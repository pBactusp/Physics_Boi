namespace Physics_Project__new_data_structure_
{
    partial class Winow_OpenProject
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
            this.newProBU = new System.Windows.Forms.Button();
            this.openProBU = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.cancelBU = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // newProBU
            // 
            this.newProBU.Location = new System.Drawing.Point(12, 12);
            this.newProBU.Name = "newProBU";
            this.newProBU.Size = new System.Drawing.Size(117, 75);
            this.newProBU.TabIndex = 0;
            this.newProBU.Text = "New project";
            this.newProBU.UseVisualStyleBackColor = true;
            this.newProBU.Click += new System.EventHandler(this.newProBU_Click);
            // 
            // openProBU
            // 
            this.openProBU.Location = new System.Drawing.Point(136, 12);
            this.openProBU.Name = "openProBU";
            this.openProBU.Size = new System.Drawing.Size(117, 75);
            this.openProBU.TabIndex = 1;
            this.openProBU.Text = "Open project";
            this.openProBU.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(12, 116);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(241, 97);
            this.listView1.TabIndex = 2;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Recent projects:";
            // 
            // cancelBU
            // 
            this.cancelBU.Location = new System.Drawing.Point(178, 219);
            this.cancelBU.Name = "cancelBU";
            this.cancelBU.Size = new System.Drawing.Size(75, 25);
            this.cancelBU.TabIndex = 4;
            this.cancelBU.Text = "Cancel";
            this.cancelBU.UseVisualStyleBackColor = true;
            this.cancelBU.Click += new System.EventHandler(this.cancelBU_Click);
            // 
            // Winow_OpenProject
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(265, 256);
            this.ControlBox = false;
            this.Controls.Add(this.cancelBU);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.openProBU);
            this.Controls.Add(this.newProBU);
            this.Name = "Winow_OpenProject";
            this.Text = "New project";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button newProBU;
        private System.Windows.Forms.Button openProBU;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cancelBU;
    }
}