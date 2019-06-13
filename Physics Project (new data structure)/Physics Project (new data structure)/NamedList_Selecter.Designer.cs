namespace Physics_Project__new_data_structure_
{
    partial class NamedList_Selecter
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
            this.yBU = new System.Windows.Forms.Button();
            this.xBU = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.selectBU = new System.Windows.Forms.Button();
            this.cancelBU = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // yBU
            // 
            this.yBU.Location = new System.Drawing.Point(12, 25);
            this.yBU.Name = "yBU";
            this.yBU.Size = new System.Drawing.Size(75, 23);
            this.yBU.TabIndex = 0;
            this.yBU.Text = "empty";
            this.yBU.UseVisualStyleBackColor = true;
            this.yBU.Click += new System.EventHandler(this.yBU_Click);
            // 
            // xBU
            // 
            this.xBU.Location = new System.Drawing.Point(96, 25);
            this.xBU.Name = "xBU";
            this.xBU.Size = new System.Drawing.Size(75, 23);
            this.xBU.TabIndex = 1;
            this.xBU.Text = "empty";
            this.xBU.UseVisualStyleBackColor = true;
            this.xBU.Click += new System.EventHandler(this.xBU_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Y:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(93, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "X:";
            // 
            // selectBU
            // 
            this.selectBU.Location = new System.Drawing.Point(12, 78);
            this.selectBU.Name = "selectBU";
            this.selectBU.Size = new System.Drawing.Size(75, 23);
            this.selectBU.TabIndex = 4;
            this.selectBU.Text = "Select";
            this.selectBU.UseVisualStyleBackColor = true;
            this.selectBU.Click += new System.EventHandler(this.selectBU_Click);
            // 
            // cancelBU
            // 
            this.cancelBU.Location = new System.Drawing.Point(96, 78);
            this.cancelBU.Name = "cancelBU";
            this.cancelBU.Size = new System.Drawing.Size(75, 23);
            this.cancelBU.TabIndex = 5;
            this.cancelBU.Text = "Cancel";
            this.cancelBU.UseVisualStyleBackColor = true;
            this.cancelBU.Click += new System.EventHandler(this.cancelBU_Click);
            // 
            // NamedList_Selecter
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(182, 114);
            this.Controls.Add(this.cancelBU);
            this.Controls.Add(this.selectBU);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.xBU);
            this.Controls.Add(this.yBU);
            this.Name = "NamedList_Selecter";
            this.Text = "NamedList_Selecter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button yBU;
        private System.Windows.Forms.Button xBU;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button selectBU;
        private System.Windows.Forms.Button cancelBU;
    }
}