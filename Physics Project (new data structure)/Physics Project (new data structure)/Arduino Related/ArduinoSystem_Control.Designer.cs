namespace Physics_Project__new_data_structure_
{
    partial class ArduinoSystem_Control
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
            this.detectSystemBU = new System.Windows.Forms.Button();
            this.autoDetectSystemCHBO = new System.Windows.Forms.CheckBox();
            this.systemConnectedCHBO = new System.Windows.Forms.CheckBox();
            this.mainGRBO.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainGRBO
            // 
            this.mainGRBO.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mainGRBO.Controls.Add(this.systemConnectedCHBO);
            this.mainGRBO.Controls.Add(this.autoDetectSystemCHBO);
            this.mainGRBO.Controls.Add(this.detectSystemBU);
            this.mainGRBO.Location = new System.Drawing.Point(3, 3);
            this.mainGRBO.Name = "mainGRBO";
            this.mainGRBO.Size = new System.Drawing.Size(152, 141);
            this.mainGRBO.TabIndex = 0;
            this.mainGRBO.TabStop = false;
            this.mainGRBO.Text = "Arduin System";
            // 
            // detectSystemBU
            // 
            this.detectSystemBU.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.detectSystemBU.Location = new System.Drawing.Point(6, 19);
            this.detectSystemBU.Name = "detectSystemBU";
            this.detectSystemBU.Size = new System.Drawing.Size(140, 70);
            this.detectSystemBU.TabIndex = 0;
            this.detectSystemBU.Text = "Detect system";
            this.detectSystemBU.UseVisualStyleBackColor = true;
            this.detectSystemBU.Click += new System.EventHandler(this.detectSystemBU_Click);
            // 
            // autoDetectSystemCHBO
            // 
            this.autoDetectSystemCHBO.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.autoDetectSystemCHBO.AutoSize = true;
            this.autoDetectSystemCHBO.Checked = true;
            this.autoDetectSystemCHBO.CheckState = System.Windows.Forms.CheckState.Checked;
            this.autoDetectSystemCHBO.Location = new System.Drawing.Point(6, 95);
            this.autoDetectSystemCHBO.Name = "autoDetectSystemCHBO";
            this.autoDetectSystemCHBO.Size = new System.Drawing.Size(116, 17);
            this.autoDetectSystemCHBO.TabIndex = 1;
            this.autoDetectSystemCHBO.Text = "Auto-detect system";
            this.autoDetectSystemCHBO.UseVisualStyleBackColor = true;
            // 
            // systemConnectedCHBO
            // 
            this.systemConnectedCHBO.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.systemConnectedCHBO.AutoSize = true;
            this.systemConnectedCHBO.Enabled = false;
            this.systemConnectedCHBO.Location = new System.Drawing.Point(6, 118);
            this.systemConnectedCHBO.Name = "systemConnectedCHBO";
            this.systemConnectedCHBO.Size = new System.Drawing.Size(78, 17);
            this.systemConnectedCHBO.TabIndex = 2;
            this.systemConnectedCHBO.Text = "Connected";
            this.systemConnectedCHBO.UseVisualStyleBackColor = true;
            // 
            // ArduinoSystem_Control
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.mainGRBO);
            this.Name = "ArduinoSystem_Control";
            this.Size = new System.Drawing.Size(158, 147);
            this.mainGRBO.ResumeLayout(false);
            this.mainGRBO.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox mainGRBO;
        private System.Windows.Forms.CheckBox systemConnectedCHBO;
        private System.Windows.Forms.CheckBox autoDetectSystemCHBO;
        private System.Windows.Forms.Button detectSystemBU;
    }
}
