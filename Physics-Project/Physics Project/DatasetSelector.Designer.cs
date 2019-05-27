namespace Physics_Project
{
    partial class DatasetSelector
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.verticalBU = new System.Windows.Forms.Button();
            this.horizontalBU = new System.Windows.Forms.Button();
            this.selectBU = new System.Windows.Forms.Button();
            this.beforeNUPDO = new System.Windows.Forms.NumericUpDown();
            this.afterNUPDO = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.nameTEBO = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.beforeNUPDO)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.afterNUPDO)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(128, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Horizontal:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Vertical:";
            // 
            // verticalBU
            // 
            this.verticalBU.Location = new System.Drawing.Point(15, 61);
            this.verticalBU.Name = "verticalBU";
            this.verticalBU.Size = new System.Drawing.Size(104, 23);
            this.verticalBU.TabIndex = 2;
            this.verticalBU.UseVisualStyleBackColor = true;
            this.verticalBU.Click += new System.EventHandler(this.verticalBU_Click);
            // 
            // horizontalBU
            // 
            this.horizontalBU.Location = new System.Drawing.Point(131, 61);
            this.horizontalBU.Name = "horizontalBU";
            this.horizontalBU.Size = new System.Drawing.Size(104, 23);
            this.horizontalBU.TabIndex = 3;
            this.horizontalBU.UseVisualStyleBackColor = true;
            this.horizontalBU.Click += new System.EventHandler(this.horizontalBU_Click);
            // 
            // selectBU
            // 
            this.selectBU.Location = new System.Drawing.Point(15, 137);
            this.selectBU.Name = "selectBU";
            this.selectBU.Size = new System.Drawing.Size(220, 23);
            this.selectBU.TabIndex = 4;
            this.selectBU.Text = "Select";
            this.selectBU.UseVisualStyleBackColor = true;
            this.selectBU.Click += new System.EventHandler(this.selectBU_Click);
            // 
            // beforeNUPDO
            // 
            this.beforeNUPDO.Location = new System.Drawing.Point(89, 111);
            this.beforeNUPDO.Name = "beforeNUPDO";
            this.beforeNUPDO.Size = new System.Drawing.Size(30, 20);
            this.beforeNUPDO.TabIndex = 5;
            // 
            // afterNUPDO
            // 
            this.afterNUPDO.Location = new System.Drawing.Point(131, 111);
            this.afterNUPDO.Name = "afterNUPDO";
            this.afterNUPDO.Size = new System.Drawing.Size(30, 20);
            this.afterNUPDO.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Name:";
            // 
            // nameTEBO
            // 
            this.nameTEBO.Location = new System.Drawing.Point(56, 6);
            this.nameTEBO.Name = "nameTEBO";
            this.nameTEBO.Size = new System.Drawing.Size(176, 20);
            this.nameTEBO.TabIndex = 8;
            // 
            // DatasetSelector
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(244, 170);
            this.Controls.Add(this.nameTEBO);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.afterNUPDO);
            this.Controls.Add(this.beforeNUPDO);
            this.Controls.Add(this.selectBU);
            this.Controls.Add(this.horizontalBU);
            this.Controls.Add(this.verticalBU);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "DatasetSelector";
            this.Text = "DatasetSelector";
            ((System.ComponentModel.ISupportInitialize)(this.beforeNUPDO)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.afterNUPDO)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button verticalBU;
        private System.Windows.Forms.Button horizontalBU;
        private System.Windows.Forms.Button selectBU;
        private System.Windows.Forms.NumericUpDown beforeNUPDO;
        private System.Windows.Forms.NumericUpDown afterNUPDO;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox nameTEBO;
    }
}