namespace Physics_Project
{
    partial class AllRunsTreeView
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
            this.tv = new System.Windows.Forms.TreeView();
            this.selectBU = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tv
            // 
            this.tv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tv.BackColor = System.Drawing.SystemColors.Control;
            this.tv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tv.Location = new System.Drawing.Point(12, 12);
            this.tv.Name = "tv";
            this.tv.Size = new System.Drawing.Size(232, 462);
            this.tv.TabIndex = 0;
            this.tv.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.tv_NodeMouseDoubleClick);
            // 
            // selectBU
            // 
            this.selectBU.Location = new System.Drawing.Point(12, 480);
            this.selectBU.Name = "selectBU";
            this.selectBU.Size = new System.Drawing.Size(232, 23);
            this.selectBU.TabIndex = 1;
            this.selectBU.Text = "Select";
            this.selectBU.UseVisualStyleBackColor = true;
            this.selectBU.Click += new System.EventHandler(this.selectBU_Click);
            // 
            // AllRunsTreeView
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(256, 515);
            this.Controls.Add(this.selectBU);
            this.Controls.Add(this.tv);
            this.Name = "AllRunsTreeView";
            this.Text = "AllRunsTreeView";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView tv;
        private System.Windows.Forms.Button selectBU;
    }
}