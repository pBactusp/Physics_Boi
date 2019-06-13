namespace Physics_Project__new_data_structure_
{
    partial class Window_Table
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
            this.table = new Physics_Project__new_data_structure_.Table();
            this.addBU = new System.Windows.Forms.Button();
            this.removeBU = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // table
            // 
            this.table.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.table.Location = new System.Drawing.Point(132, 68);
            this.table.Name = "table";
            this.table.Size = new System.Drawing.Size(454, 320);
            this.table.TabIndex = 0;
            // 
            // addBU
            // 
            this.addBU.Location = new System.Drawing.Point(12, 12);
            this.addBU.Name = "addBU";
            this.addBU.Size = new System.Drawing.Size(114, 50);
            this.addBU.TabIndex = 1;
            this.addBU.Text = "Add data";
            this.addBU.UseVisualStyleBackColor = true;
            this.addBU.Click += new System.EventHandler(this.addBU_Click);
            // 
            // removeBU
            // 
            this.removeBU.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.removeBU.Location = new System.Drawing.Point(12, 338);
            this.removeBU.Name = "removeBU";
            this.removeBU.Size = new System.Drawing.Size(114, 50);
            this.removeBU.TabIndex = 2;
            this.removeBU.Text = "Remove data";
            this.removeBU.UseVisualStyleBackColor = true;
            // 
            // Window_Table
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(598, 400);
            this.Controls.Add(this.removeBU);
            this.Controls.Add(this.addBU);
            this.Controls.Add(this.table);
            this.Name = "Window_Table";
            this.Text = "Window_Table";
            this.ResumeLayout(false);

        }

        #endregion

        private Table table;
        private System.Windows.Forms.Button addBU;
        private System.Windows.Forms.Button removeBU;
    }
}