namespace Physics_Project__new_data_structure_
{
    partial class Table
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
            this.displayGRVE = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.displayGRVE)).BeginInit();
            this.SuspendLayout();
            // 
            // displayGRVE
            // 
            this.displayGRVE.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.displayGRVE.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.displayGRVE.Location = new System.Drawing.Point(3, 3);
            this.displayGRVE.Name = "displayGRVE";
            this.displayGRVE.Size = new System.Drawing.Size(597, 339);
            this.displayGRVE.TabIndex = 0;
            // 
            // Table
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.displayGRVE);
            this.Name = "Table";
            this.Size = new System.Drawing.Size(603, 345);
            ((System.ComponentModel.ISupportInitialize)(this.displayGRVE)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView displayGRVE;
    }
}
