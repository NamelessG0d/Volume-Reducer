using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.XPath;
using Nameless.Utils;

namespace VolumeReducer
{
    public class ProcessSetting
    {
        public string TargetChild { get; set; } = "CptHost.exe";
        public string TargetParent { get; set; } = "Zoom.exe";
        public int TargetVolume { get; set; } = 10;
    }

    public class Settings : IDisposable
    {
        public int Version { get; set; } = 1;
        public List<ProcessSetting> Processes { get; set; } = [new()];

        public Settings() { }
        ~Settings()
        {
            this.Dispose();
        }

        public static Settings LoadSettings()
        {
            var result = FileManager.Load<Settings>();
            if(result == null)
                FileManager.Save(result ??= new Settings());
            
            return result;
        }

        public void SaveSettings() => FileManager.Save(this);

        public void Dispose()
        {
            SaveSettings();
        }
    }
}
