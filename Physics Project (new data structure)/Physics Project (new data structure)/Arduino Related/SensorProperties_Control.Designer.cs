namespace Physics_Project__new_data_structure_
{
    partial class SensorProperties_Control
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.mainGRBO = new System.Windows.Forms.GroupBox();
            this.dataNameLA = new System.Windows.Forms.Label();
            this.unitCOBO = new System.Windows.Forms.ComboBox();
            this.frequencyNUPDO = new System.Windows.Forms.NumericUpDown();
            this.frequencyLA = new System.Windows.Forms.Label();
            this.mainGRBO.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.frequencyNUPDO)).BeginInit();
            this.SuspendLayout();
            // 
            // mainGRBO
            // 
            this.mainGRBO.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mainGRBO.Controls.Add(this.frequencyLA);
            this.mainGRBO.Controls.Add(this.frequencyNUPDO);
            this.mainGRBO.Controls.Add(this.unitCOBO);
            this.mainGRBO.Controls.Add(this.dataNameLA);
            this.mainGRBO.Location = new System.Drawing.Point(3, 3);
            this.mainGRBO.Name = "mainGRBO";
            this.mainGRBO.Size = new System.Drawing.Size(165, 203);
            this.mainGRBO.TabIndex = 0;
            this.mainGRBO.TabStop = false;
            this.mainGRBO.Text = "Sensor Properties";
            // 
            // dataNameLA
            // 
            this.dataNameLA.AutoSize = true;
            this.dataNameLA.Location = new System.Drawing.Point(6, 31);
            this.dataNameLA.Name = "dataNameLA";
            this.dataNameLA.Size = new System.Drawing.Size(81, 13);
            this.dataNameLA.TabIndex = 0;
            this.dataNameLA.Text = "Measuring Unit:";
            // 
            // unitCOBO
            // 
            this.unitCOBO.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.unitCOBO.FormattingEnabled = true;
            this.unitCOBO.Location = new System.Drawing.Point(93, 28);
            this.unitCOBO.Name = "unitCOBO";
            this.unitCOBO.Size = new System.Drawing.Size(66, 21);
            this.unitCOBO.TabIndex = 1;
            this.unitCOBO.SelectedIndexChanged += new System.EventHandler(this.unitCOBO_SelectedIndexChanged);
            // 
            // frequencyNUPDO
            // 
            this.frequencyNUPDO.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.frequencyNUPDO.DecimalPlaces = 3;
            this.frequencyNUPDO.Location = new System.Drawing.Point(93, 55);
            this.frequencyNUPDO.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.frequencyNUPDO.Name = "frequencyNUPDO";
            this.frequencyNUPDO.Size = new System.Drawing.Size(66, 20);
            this.frequencyNUPDO.TabIndex = 2;
            this.frequencyNUPDO.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.frequencyNUPDO.ValueChanged += new System.EventHandler(this.frequencyNUPDO_ValueChanged);
            // 
            // frequencyLA
            // 
            this.frequencyLA.AutoSize = true;
            this.frequencyLA.Location = new System.Drawing.Point(6, 57);
            this.frequencyLA.Name = "frequencyLA";
            this.frequencyLA.Size = new System.Drawing.Size(60, 13);
            this.frequencyLA.TabIndex = 3;
            this.frequencyLA.Text = "Frequency:";
            // 
            // SensorProperties_Control
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.mainGRBO);
            this.Name = "SensorProperties_Control";
            this.Size = new System.Drawing.Size(171, 209);
            this.mainGRBO.ResumeLayout(false);
            this.mainGRBO.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.frequencyNUPDO)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox mainGRBO;
        private System.Windows.Forms.Label dataNameLA;
        private System.Windows.Forms.NumericUpDown frequencyNUPDO;
        private System.Windows.Forms.ComboBox unitCOBO;
        private System.Windows.Forms.Label frequencyLA;
    }
}
