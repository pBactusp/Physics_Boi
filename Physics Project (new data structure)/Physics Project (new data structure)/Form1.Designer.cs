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
            this.arduinoSystem_Control = new Physics_Project__new_data_structure_.ArduinoSystem_Control();
            this.openDataManagerBU = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // startBU
            // 
            this.startBU.Location = new System.Drawing.Point(13, 12);
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
            this.stopBU.Location = new System.Drawing.Point(88, 12);
            this.stopBU.Name = "stopBU";
            this.stopBU.Size = new System.Drawing.Size(69, 46);
            this.stopBU.TabIndex = 2;
            this.stopBU.Text = "Stop";
            this.stopBU.UseVisualStyleBackColor = true;
            // 
            // openGrapherBU
            // 
            this.openGrapherBU.Location = new System.Drawing.Point(285, 12);
            this.openGrapherBU.Name = "openGrapherBU";
            this.openGrapherBU.Size = new System.Drawing.Size(113, 46);
            this.openGrapherBU.TabIndex = 3;
            this.openGrapherBU.Text = "Open new grapher";
            this.openGrapherBU.UseVisualStyleBackColor = true;
            this.openGrapherBU.Click += new System.EventHandler(this.openGrapherBU_Click);
            // 
            // openTableBU
            // 
            this.openTableBU.Location = new System.Drawing.Point(404, 12);
            this.openTableBU.Name = "openTableBU";
            this.openTableBU.Size = new System.Drawing.Size(113, 46);
            this.openTableBU.TabIndex = 4;
            this.openTableBU.Text = "Open new table";
            this.openTableBU.UseVisualStyleBackColor = true;
            this.openTableBU.Click += new System.EventHandler(this.openTableBU_Click);
            // 
            // arduinoSystem_Control
            // 
            this.arduinoSystem_Control.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.arduinoSystem_Control.AutoDetect = true;
            this.arduinoSystem_Control.Connected = false;
            this.arduinoSystem_Control.Location = new System.Drawing.Point(730, 13);
            this.arduinoSystem_Control.Name = "arduinoSystem_Control";
            this.arduinoSystem_Control.Size = new System.Drawing.Size(137, 132);
            this.arduinoSystem_Control.TabIndex = 0;
            this.arduinoSystem_Control.button_Click += new System.EventHandler(this.arduinoSystem_Control_button_Click);
            // 
            // openDataManagerBU
            // 
            this.openDataManagerBU.Location = new System.Drawing.Point(285, 64);
            this.openDataManagerBU.Name = "openDataManagerBU";
            this.openDataManagerBU.Size = new System.Drawing.Size(113, 46);
            this.openDataManagerBU.TabIndex = 5;
            this.openDataManagerBU.Text = "Open data manager";
            this.openDataManagerBU.UseVisualStyleBackColor = true;
            this.openDataManagerBU.Click += new System.EventHandler(this.openDataManagerBU_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(404, 64);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 46);
            this.button1.TabIndex = 6;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(879, 154);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.openDataManagerBU);
            this.Controls.Add(this.openTableBU);
            this.Controls.Add(this.openGrapherBU);
            this.Controls.Add(this.stopBU);
            this.Controls.Add(this.startBU);
            this.Controls.Add(this.arduinoSystem_Control);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private ArduinoSystem_Control arduinoSystem_Control;
        private System.Windows.Forms.Button startBU;
        private System.Windows.Forms.Button stopBU;
        private System.Windows.Forms.Button openGrapherBU;
        private System.Windows.Forms.Button openTableBU;
        private System.Windows.Forms.Button openDataManagerBU;
        private System.Windows.Forms.Button button1;
    }
}

