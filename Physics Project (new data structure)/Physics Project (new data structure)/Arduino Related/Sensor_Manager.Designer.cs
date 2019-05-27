namespace Physics_Project__new_data_structure_
{
    partial class Sensor_Manager
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
            this.sensorProperties_Control = new Physics_Project__new_data_structure_.SensorProperties_Control();
            this.applyBU = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // selectionPA
            // 
            this.selectionPA.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.selectionPA.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.selectionPA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.selectionPA.Location = new System.Drawing.Point(12, 12);
            this.selectionPA.Name = "selectionPA";
            this.selectionPA.Size = new System.Drawing.Size(573, 160);
            this.selectionPA.TabIndex = 0;
            this.selectionPA.MouseClick += new System.Windows.Forms.MouseEventHandler(this.selectionPA_MouseClick);
            // 
            // sensorTypeLIBO
            // 
            this.sensorTypeLIBO.FormattingEnabled = true;
            this.sensorTypeLIBO.Location = new System.Drawing.Point(12, 178);
            this.sensorTypeLIBO.Name = "sensorTypeLIBO";
            this.sensorTypeLIBO.Size = new System.Drawing.Size(120, 160);
            this.sensorTypeLIBO.TabIndex = 1;
            this.sensorTypeLIBO.SelectedIndexChanged += new System.EventHandler(this.sensorTypeLIBO_SelectedIndexChanged);
            // 
            // sensorProperties_Control
            // 
            this.sensorProperties_Control.Location = new System.Drawing.Point(139, 179);
            this.sensorProperties_Control.Name = "sensorProperties_Control";
            this.sensorProperties_Control.Size = new System.Drawing.Size(186, 159);
            this.sensorProperties_Control.TabIndex = 2;
            this.sensorProperties_Control.Unit_Changed += new System.EventHandler(this.sensorProperties_Control_Unit_Changed);
            this.sensorProperties_Control.Frequency_Changed += new System.EventHandler(this.sensorProperties_Control_Frequency_Changed);
            // 
            // applyBU
            // 
            this.applyBU.Location = new System.Drawing.Point(510, 317);
            this.applyBU.Name = "applyBU";
            this.applyBU.Size = new System.Drawing.Size(75, 23);
            this.applyBU.TabIndex = 3;
            this.applyBU.Text = "Apply";
            this.applyBU.UseVisualStyleBackColor = true;
            this.applyBU.Click += new System.EventHandler(this.applyBU_Click);
            // 
            // Sensor_Manager
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(597, 352);
            this.Controls.Add(this.applyBU);
            this.Controls.Add(this.sensorProperties_Control);
            this.Controls.Add(this.sensorTypeLIBO);
            this.Controls.Add(this.selectionPA);
            this.Name = "Sensor_Manager";
            this.Text = "Sensor_Manager";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel selectionPA;
        private System.Windows.Forms.ListBox sensorTypeLIBO;
        private SensorProperties_Control sensorProperties_Control;
        private System.Windows.Forms.Button applyBU;
    }
}