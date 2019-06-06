namespace Physics_Project__new_data_structure_
{
    partial class Grapher
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
            this.displayPB = new System.Windows.Forms.PictureBox();
            this.dataListsTV = new System.Windows.Forms.TreeView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.displayPB)).BeginInit();
            this.SuspendLayout();
            // 
            // displayPB
            // 
            this.displayPB.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.displayPB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.displayPB.Location = new System.Drawing.Point(3, 3);
            this.displayPB.Name = "displayPB";
            this.displayPB.Size = new System.Drawing.Size(424, 315);
            this.displayPB.TabIndex = 0;
            this.displayPB.TabStop = false;
            this.displayPB.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.displayPB_MouseDoubleClick);
            this.displayPB.MouseDown += new System.Windows.Forms.MouseEventHandler(this.displayPB_MouseDown);
            this.displayPB.MouseMove += new System.Windows.Forms.MouseEventHandler(this.displayPB_MouseMove);
            this.displayPB.MouseUp += new System.Windows.Forms.MouseEventHandler(this.displayPB_MouseUp);
            this.displayPB.Resize += new System.EventHandler(this.displayPB_Resize);
            // 
            // dataListsTV
            // 
            this.dataListsTV.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataListsTV.CheckBoxes = true;
            this.dataListsTV.Location = new System.Drawing.Point(433, 19);
            this.dataListsTV.Name = "dataListsTV";
            this.dataListsTV.Size = new System.Drawing.Size(193, 299);
            this.dataListsTV.TabIndex = 1;
            this.dataListsTV.AfterCheck += new System.Windows.Forms.TreeViewEventHandler(this.dataListsTV_AfterCheck);
            this.dataListsTV.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.dataListsTV_AfterSelect);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(430, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Data lists:";
            // 
            // Grapher
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataListsTV);
            this.Controls.Add(this.displayPB);
            this.Name = "Grapher";
            this.Size = new System.Drawing.Size(629, 321);
            ((System.ComponentModel.ISupportInitialize)(this.displayPB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox displayPB;
        private System.Windows.Forms.TreeView dataListsTV;
        private System.Windows.Forms.Label label1;
    }
}
