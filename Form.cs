using Dark.Net;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using Nameless.Utils;

namespace VolumeReducer
{
    public partial class Form : System.Windows.Forms.Form
    {
        private Settings settings;
        private VolumeManager vm;

        public Form()
        {
            InitializeComponent();
            DarkNet.Instance.SetWindowThemeForms(this, Theme.Dark);
        }

        private void Form_Load(object sender, EventArgs e)
        {
            LoadSettingsAndVolumeManager();

            trayIcon.DoubleClick += (s, e) =>
            {
                this.Visible = !this.Visible;
            };

            trayIcon.Visible = true;
            trayIcon.Text = Application.ProductName;
            var contextMenu = new ContextMenuStrip();
            contextMenu.Items.Add("Show", null, (s, e) => { this.Visible = !this.Visible; });
            contextMenu.Items.Add("Exit", null, (s, e) => { Application.Exit(); });
            trayIcon.ContextMenuStrip = contextMenu;
        }

        private void buttonReload_Click(object sender, EventArgs e)
        {
            LoadSettingsAndVolumeManager();
        }

        private void buttonMinimize_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void linkLabelSettings_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            using Process fileopener = new Process();

            fileopener.StartInfo.FileName = "explorer";
            fileopener.StartInfo.Arguments = $"\"{FileManager.filePath}\"";
            fileopener.Start();
        }

        private void LoadSettingsAndVolumeManager()
        {
            settings = Settings.LoadSettings();
            vm = new VolumeManager(settings);
        }
    }
}
