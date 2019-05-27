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
            this.grapher1 = new Physics_Project__new_data_structure_.Grapher();
            this.arduinoSystem_Control = new Physics_Project__new_data_structure_.ArduinoSystem_Control();
            this.tempTable = new Physics_Project__new_data_structure_.Table();
            this.SuspendLayout();
            // 
            // startBU
            // 
            this.startBU.Location = new System.Drawing.Point(13, 13);
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
            this.stopBU.Location = new System.Drawing.Point(88, 13);
            this.stopBU.Name = "stopBU";
            this.stopBU.Size = new System.Drawing.Size(69, 46);
            this.stopBU.TabIndex = 2;
            this.stopBU.Text = "Stop";
            this.stopBU.UseVisualStyleBackColor = true;
            // 
            // grapher1
            // 
            this.grapher1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grapher1.Location = new System.Drawing.Point(13, 65);
            this.grapher1.Name = "grapher1";
            this.grapher1.Size = new System.Drawing.Size(506, 215);
            this.grapher1.TabIndex = 3;
            // 
            // arduinoSystem_Control
            // 
            this.arduinoSystem_Control.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.arduinoSystem_Control.AutoDetect = true;
            this.arduinoSystem_Control.Connected = false;
            this.arduinoSystem_Control.Location = new System.Drawing.Point(616, 13);
            this.arduinoSystem_Control.Name = "arduinoSystem_Control";
            this.arduinoSystem_Control.Size = new System.Drawing.Size(137, 132);
            this.arduinoSystem_Control.TabIndex = 0;
            this.arduinoSystem_Control.button_Click += new System.EventHandler(this.arduinoSystem_Control_button_Click);
            // 
            // tempTable
            // 
            this.tempTable.Location = new System.Drawing.Point(13, 286);
            this.tempTable.Name = "tempTable";
            this.tempTable.Size = new System.Drawing.Size(506, 276);
            this.tempTable.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(765, 574);
            this.Controls.Add(this.tempTable);
            this.Controls.Add(this.grapher1);
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
        private Grapher grapher1;
        private Table tempTable;
    }
}

