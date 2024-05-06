using System.Management;
using System.Runtime.Versioning;
using NAudio.CoreAudioApi;
using System.Timers;
using Timer = System.Timers.Timer;

namespace VolumeReducer
{
    internal class VolumeManager : IDisposable
    {
        private Settings _settings;
        private ManagementEventWatcher _startWatch;

        [SupportedOSPlatform("windows")]
        public VolumeManager(Settings settings)
        {
            _settings = settings;
            _startWatch = new ManagementEventWatcher(
                new WqlEventQuery("SELECT * FROM Win32_ProcessStartTrace"));
            _startWatch.EventArrived
                += new EventArrivedEventHandler(startWatch_EventArrived);
            _startWatch.Start();
        }

        ~VolumeManager()
        {
            Dispose();
        }

        void startWatch_EventArrived(object sender, EventArrivedEventArgs e)
        {
            if(_settings.Processes.Any(p => p.TargetChild == e.NewEvent.Properties["ProcessName"].Value.ToString()))
                CheckAndAdjustVolume((UInt32)e.NewEvent.Properties["ParentProcessID"].Value);
        }

        private void CheckAndAdjustVolume(UInt32 parentProcessId)
        {
            MMDeviceEnumerator enumerator = new MMDeviceEnumerator();
            var devices = enumerator.EnumerateAudioEndPoints(DataFlow.Render, DeviceState.Active);
            foreach (var device in devices)
            {
                var sessions = device.AudioSessionManager.Sessions;
                for (int i = 0; i < sessions.Count; i++)
                {
                    var session = sessions[i];
                    IEnumerable<ProcessSetting> targetSetting = _settings.Processes.Where(p => session.GetSessionIdentifier.Contains(p.TargetParent, StringComparison.OrdinalIgnoreCase));

                    foreach (var setting in targetSetting) {
                        if (setting.TargetParent != setting.TargetChild && session.GetProcessID != parentProcessId)
                            continue;

                        session.SimpleAudioVolume.Volume = setting.TargetVolume / 100f;
                    }
                }
            }
        }

        public void Dispose()
        {
            _startWatch.Stop();
        }
    }
}
