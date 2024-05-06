namespace VolumeReducer
{
    partial class Form
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form));
            trayIcon = new NotifyIcon(components);
            buttonReload = new Button();
            buttonMinimize = new Button();
            buttonExit = new Button();
            labelWelcome = new Label();
            label2 = new Label();
            linkLabelSettings = new LinkLabel();
            SuspendLayout();
            // 
            // trayIcon
            // 
            trayIcon.Icon = (Icon)resources.GetObject("trayIcon.Icon");
            trayIcon.Text = "VolumeReducer";
            trayIcon.Visible = true;
            // 
            // buttonReload
            // 
            buttonReload.Location = new Point(21, 66);
            buttonReload.Name = "buttonReload";
            buttonReload.Size = new Size(75, 25);
            buttonReload.TabIndex = 0;
            buttonReload.Text = "Reload";
            buttonReload.UseVisualStyleBackColor = true;
            buttonReload.Click += buttonReload_Click;
            // 
            // buttonMinimize
            // 
            buttonMinimize.Location = new Point(102, 66);
            buttonMinimize.Name = "buttonMinimize";
            buttonMinimize.Size = new Size(75, 25);
            buttonMinimize.TabIndex = 1;
            buttonMinimize.Text = "Minimize";
            buttonMinimize.UseVisualStyleBackColor = true;
            buttonMinimize.Click += buttonMinimize_Click;
            // 
            // buttonExit
            // 
            buttonExit.Location = new Point(183, 66);
            buttonExit.Name = "buttonExit";
            buttonExit.Size = new Size(75, 25);
            buttonExit.TabIndex = 2;
            buttonExit.Text = "Exit";
            buttonExit.UseVisualStyleBackColor = true;
            buttonExit.Click += buttonExit_Click;
            // 
            // labelWelcome
            // 
            labelWelcome.AutoSize = true;
            labelWelcome.Location = new Point(55, 16);
            labelWelcome.Name = "labelWelcome";
            labelWelcome.Size = new Size(160, 15);
            labelWelcome.TabIndex = 3;
            labelWelcome.Text = "Welcome to Volume Reducer";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(11, 38);
            label2.Name = "label2";
            label2.Size = new Size(189, 15);
            label2.TabIndex = 4;
            label2.Text = "To edit the target applications, edit";
            // 
            // linkLabelSettings
            // 
            linkLabelSettings.AutoSize = true;
            linkLabelSettings.Location = new Point(194, 38);
            linkLabelSettings.Name = "linkLabelSettings";
            linkLabelSettings.Size = new Size(73, 15);
            linkLabelSettings.TabIndex = 5;
            linkLabelSettings.TabStop = true;
            linkLabelSettings.Text = "settings.json";
            linkLabelSettings.LinkClicked += linkLabelSettings_LinkClicked;
            // 
            // Form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(278, 103);
            Controls.Add(linkLabelSettings);
            Controls.Add(label2);
            Controls.Add(labelWelcome);
            Controls.Add(buttonExit);
            Controls.Add(buttonMinimize);
            Controls.Add(buttonReload);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form";
            Text = "Volume Reducer";
            Load += Form_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private NotifyIcon trayIcon;
        private Button buttonReload;
        private Button buttonMinimize;
        private Button buttonExit;
        private Label labelWelcome;
        private Label label2;
        private LinkLabel linkLabelSettings;
    }
}
