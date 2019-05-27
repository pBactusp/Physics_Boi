namespace Physics_Project__new_data_structure_
{
    partial class AllRuns_Control
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
            this.mainTV = new System.Windows.Forms.TreeView();
            this.SuspendLayout();
            // 
            // mainTV
            // 
            this.mainTV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mainTV.Location = new System.Drawing.Point(3, 3);
            this.mainTV.Name = "mainTV";
            this.mainTV.Size = new System.Drawing.Size(252, 302);
            this.mainTV.TabIndex = 0;
            this.mainTV.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.mainTV_NodeMouseClick);
            this.mainTV.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.mainTV_NodeMouseDoubleClick);
            // 
            // AllRuns_Control
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.mainTV);
            this.Name = "AllRuns_Control";
            this.Size = new System.Drawing.Size(258, 308);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView mainTV;
    }
}
