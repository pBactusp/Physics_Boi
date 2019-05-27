namespace Physics_Project__new_data_structure_
{
    partial class ConstantList_Control
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
            this.components = new System.ComponentModel.Container();
            this.mainLIBO = new System.Windows.Forms.ListBox();
            this.toolsCOMEST = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.removeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsCOMEST.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainLIBO
            // 
            this.mainLIBO.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mainLIBO.ContextMenuStrip = this.toolsCOMEST;
            this.mainLIBO.FormattingEnabled = true;
            this.mainLIBO.Location = new System.Drawing.Point(3, 3);
            this.mainLIBO.Name = "mainLIBO";
            this.mainLIBO.Size = new System.Drawing.Size(172, 147);
            this.mainLIBO.TabIndex = 0;
            // 
            // toolsCOMEST
            // 
            this.toolsCOMEST.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.removeToolStripMenuItem});
            this.toolsCOMEST.Name = "toolsCOMEST";
            this.toolsCOMEST.Size = new System.Drawing.Size(181, 48);
            // 
            // removeToolStripMenuItem
            // 
            this.removeToolStripMenuItem.Name = "removeToolStripMenuItem";
            this.removeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.removeToolStripMenuItem.Text = "Remove";
            this.removeToolStripMenuItem.Click += new System.EventHandler(this.removeToolStripMenuItem_Click);
            // 
            // ConstantList_Control
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.mainLIBO);
            this.Name = "ConstantList_Control";
            this.Size = new System.Drawing.Size(178, 155);
            this.toolsCOMEST.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox mainLIBO;
        private System.Windows.Forms.ContextMenuStrip toolsCOMEST;
        private System.Windows.Forms.ToolStripMenuItem removeToolStripMenuItem;
    }
}
