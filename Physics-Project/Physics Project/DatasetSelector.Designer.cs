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
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(125, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Horizontal:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Vertical:";
            // 
            // verticalBU
            // 
            this.verticalBU.Location = new System.Drawing.Point(12, 24);
            this.verticalBU.Name = "verticalBU";
            this.verticalBU.Size = new System.Drawing.Size(104, 23);
            this.verticalBU.TabIndex = 2;
            this.verticalBU.UseVisualStyleBackColor = true;
            this.verticalBU.Click += new System.EventHandler(this.verticalBU_Click);
            // 
            // horizontalBU
            // 
            this.horizontalBU.Location = new System.Drawing.Point(128, 24);
            this.horizontalBU.Name = "horizontalBU";
            this.horizontalBU.Size = new System.Drawing.Size(104, 23);
            this.horizontalBU.TabIndex = 3;
            this.horizontalBU.UseVisualStyleBackColor = true;
            this.horizontalBU.Click += new System.EventHandler(this.horizontalBU_Click);
            // 
            // selectBU
            // 
            this.selectBU.Location = new System.Drawing.Point(12, 55);
            this.selectBU.Name = "selectBU";
            this.selectBU.Size = new System.Drawing.Size(220, 23);
            this.selectBU.TabIndex = 4;
            this.selectBU.Text = "Select";
            this.selectBU.UseVisualStyleBackColor = true;
            this.selectBU.Click += new System.EventHandler(this.selectBU_Click);
            // 
            // DatasetSelector
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(244, 90);
            this.Controls.Add(this.selectBU);
            this.Controls.Add(this.horizontalBU);
            this.Controls.Add(this.verticalBU);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "DatasetSelector";
            this.Text = "DatasetSelector";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button verticalBU;
        private System.Windows.Forms.Button horizontalBU;
        private System.Windows.Forms.Button selectBU;
    }
}