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
            this.openProBU.Click += new System.EventHandler(this.openProBU_Click);
            // 
            // cancelBU
            // 
            this.cancelBU.Location = new System.Drawing.Point(178, 113);
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
            this.ClientSize = new System.Drawing.Size(265, 150);
            this.ControlBox = false;
            this.Controls.Add(this.cancelBU);
            this.Controls.Add(this.openProBU);
            this.Controls.Add(this.newProBU);
            this.Name = "Winow_OpenProject";
            this.Text = "New project";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button newProBU;
        private System.Windows.Forms.Button openProBU;
        private System.Windows.Forms.Button cancelBU;
    }
}