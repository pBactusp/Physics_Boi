namespace Physics_Project__new_data_structure_
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.startBU = new System.Windows.Forms.Button();
            this.stopBU = new System.Windows.Forms.Button();
            this.openGrapherBU = new System.Windows.Forms.Button();
            this.openTableBU = new System.Windows.Forms.Button();
            this.openDataManagerBU = new System.Windows.Forms.Button();
            this.openSensorManager = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openProIT = new System.Windows.Forms.ToolStripMenuItem();
            this.newProIT = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.saveAsIT = new System.Windows.Forms.ToolStripMenuItem();
            this.saveIT = new System.Windows.Forms.ToolStripMenuItem();
            this.arduinoSystem_Control = new Physics_Project__new_data_structure_.ArduinoSystem_Control();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // startBU
            // 
            this.startBU.Location = new System.Drawing.Point(12, 37);
            this.startBU.Name = "startBU";
            this.startBU.Size = new System.Drawing.Size(69, 46);
            this.startBU.TabIndex = 1;
            this.startBU.Text = "Start";
            this.startBU.UseVisualStyleBackColor = true;
            this.startBU.Click += new System.EventHandler(this.startBU_Click);
            // 
            // stopBU
            // 
            this.stopBU.Enabled = false;
            this.stopBU.Location = new System.Drawing.Point(87, 37);
            this.stopBU.Name = "stopBU";
            this.stopBU.Size = new System.Drawing.Size(69, 46);
            this.stopBU.TabIndex = 2;
            this.stopBU.Text = "Stop";
            this.stopBU.UseVisualStyleBackColor = true;
            this.stopBU.Click += new System.EventHandler(this.stopBU_Click);
            // 
            // openGrapherBU
            // 
            this.openGrapherBU.Location = new System.Drawing.Point(198, 37);
            this.openGrapherBU.Name = "openGrapherBU";
            this.openGrapherBU.Size = new System.Drawing.Size(113, 46);
            this.openGrapherBU.TabIndex = 3;
            this.openGrapherBU.Text = "Open new grapher";
            this.openGrapherBU.UseVisualStyleBackColor = true;
            this.openGrapherBU.Click += new System.EventHandler(this.openGrapherBU_Click);
            // 
            // openTableBU
            // 
            this.openTableBU.Location = new System.Drawing.Point(317, 37);
            this.openTableBU.Name = "openTableBU";
            this.openTableBU.Size = new System.Drawing.Size(113, 46);
            this.openTableBU.TabIndex = 4;
            this.openTableBU.Text = "Open new table";
            this.openTableBU.UseVisualStyleBackColor = true;
            this.openTableBU.Click += new System.EventHandler(this.openTableBU_Click);
            // 
            // openDataManagerBU
            // 
            this.openDataManagerBU.Location = new System.Drawing.Point(198, 89);
            this.openDataManagerBU.Name = "openDataManagerBU";
            this.openDataManagerBU.Size = new System.Drawing.Size(113, 46);
            this.openDataManagerBU.TabIndex = 5;
            this.openDataManagerBU.Text = "Open data manager";
            this.openDataManagerBU.UseVisualStyleBackColor = true;
            this.openDataManagerBU.Click += new System.EventHandler(this.openDataManagerBU_Click);
            // 
            // openSensorManager
            // 
            this.openSensorManager.Location = new System.Drawing.Point(317, 89);
            this.openSensorManager.Name = "openSensorManager";
            this.openSensorManager.Size = new System.Drawing.Size(113, 46);
            this.openSensorManager.TabIndex = 6;
            this.openSensorManager.Text = "Open sensor manager";
            this.openSensorManager.UseVisualStyleBackColor = true;
            this.openSensorManager.Click += new System.EventHandler(this.openSensorManager_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(615, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openProIT,
            this.newProIT,
            this.toolStripSeparator1,
            this.saveAsIT,
            this.saveIT});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openProIT
            // 
            this.openProIT.Name = "openProIT";
            this.openProIT.Size = new System.Drawing.Size(180, 22);
            this.openProIT.Text = "Open project";
            this.openProIT.Click += new System.EventHandler(this.openProIT_Click);
            // 
            // newProIT
            // 
            this.newProIT.Name = "newProIT";
            this.newProIT.Size = new System.Drawing.Size(180, 22);
            this.newProIT.Text = "New project";
            this.newProIT.Click += new System.EventHandler(this.newProIT_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(140, 6);
            // 
            // saveAsIT
            // 
            this.saveAsIT.Name = "saveAsIT";
            this.saveAsIT.Size = new System.Drawing.Size(143, 22);
            this.saveAsIT.Text = "Save as";
            this.saveAsIT.Click += new System.EventHandler(this.saveAsIT_Click);
            // 
            // saveIT
            // 
            this.saveIT.Name = "saveIT";
            this.saveIT.Size = new System.Drawing.Size(143, 22);
            this.saveIT.Text = "Save";
            this.saveIT.Click += new System.EventHandler(this.saveIT_Click);
            // 
            // arduinoSystem_Control
            // 
            this.arduinoSystem_Control.AutoDetect = true;
            this.arduinoSystem_Control.Connected = false;
            this.arduinoSystem_Control.Location = new System.Drawing.Point(466, 37);
            this.arduinoSystem_Control.Name = "arduinoSystem_Control";
            this.arduinoSystem_Control.Size = new System.Drawing.Size(137, 115);
            this.arduinoSystem_Control.TabIndex = 0;
            this.arduinoSystem_Control.button_Click += new System.EventHandler(this.arduinoSystem_Control_button_Click);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(615, 164);
            this.Controls.Add(this.openSensorManager);
            this.Controls.Add(this.openDataManagerBU);
            this.Controls.Add(this.openTableBU);
            this.Controls.Add(this.openGrapherBU);
            this.Controls.Add(this.stopBU);
            this.Controls.Add(this.startBU);
            this.Controls.Add(this.arduinoSystem_Control);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ArduinoSystem_Control arduinoSystem_Control;
        private System.Windows.Forms.Button startBU;
        private System.Windows.Forms.Button stopBU;
        private System.Windows.Forms.Button openGrapherBU;
        private System.Windows.Forms.Button openTableBU;
        private System.Windows.Forms.Button openDataManagerBU;
        private System.Windows.Forms.Button openSensorManager;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openProIT;
        private System.Windows.Forms.ToolStripMenuItem newProIT;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem saveAsIT;
        private System.Windows.Forms.ToolStripMenuItem saveIT;
    }
}

