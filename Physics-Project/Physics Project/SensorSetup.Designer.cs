namespace Physics_Project
{
    partial class SensorSetup
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
            this.selectionPA = new System.Windows.Forms.Panel();
            this.sensorTypeLIBO = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabsTACO = new System.Windows.Forms.TabControl();
            this.SuspendLayout();
            // 
            // selectionPA
            // 
            this.selectionPA.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.selectionPA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.selectionPA.Location = new System.Drawing.Point(12, 12);
            this.selectionPA.Name = "selectionPA";
            this.selectionPA.Size = new System.Drawing.Size(776, 177);
            this.selectionPA.TabIndex = 0;
            this.selectionPA.MouseClick += new System.Windows.Forms.MouseEventHandler(this.selectionPA_MouseClick);
            // 
            // sensorTypeLIBO
            // 
            this.sensorTypeLIBO.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.sensorTypeLIBO.FormattingEnabled = true;
            this.sensorTypeLIBO.Location = new System.Drawing.Point(12, 217);
            this.sensorTypeLIBO.Name = "sensorTypeLIBO";
            this.sensorTypeLIBO.Size = new System.Drawing.Size(160, 212);
            this.sensorTypeLIBO.TabIndex = 1;
            this.sensorTypeLIBO.SelectedIndexChanged += new System.EventHandler(this.sensorTypeLIBO_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 195);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Sensor Type:";
            // 
            // tabsTACO
            // 
            this.tabsTACO.Location = new System.Drawing.Point(178, 195);
            this.tabsTACO.Name = "tabsTACO";
            this.tabsTACO.SelectedIndex = 0;
            this.tabsTACO.Size = new System.Drawing.Size(342, 234);
            this.tabsTACO.TabIndex = 3;
            // 
            // SensorSetup
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabsTACO);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sensorTypeLIBO);
            this.Controls.Add(this.selectionPA);
            this.Name = "SensorSetup";
            this.Text = "SensorSetup";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel selectionPA;
        private System.Windows.Forms.ListBox sensorTypeLIBO;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabsTACO;
    }
}