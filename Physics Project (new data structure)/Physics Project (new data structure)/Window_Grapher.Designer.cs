namespace Physics_Project__new_data_structure_
{
    partial class Window_Grapher
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
            this.grapher = new Physics_Project__new_data_structure_.Grapher();
            this.addBU = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // grapher
            // 
            this.grapher.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grapher.Location = new System.Drawing.Point(131, 12);
            this.grapher.Name = "grapher";
            this.grapher.Size = new System.Drawing.Size(543, 295);
            this.grapher.TabIndex = 0;
            // 
            // addBU
            // 
            this.addBU.Location = new System.Drawing.Point(12, 12);
            this.addBU.Name = "addBU";
            this.addBU.Size = new System.Drawing.Size(113, 41);
            this.addBU.TabIndex = 1;
            this.addBU.Text = "Add data";
            this.addBU.UseVisualStyleBackColor = true;
            this.addBU.Click += new System.EventHandler(this.addBU_Click);
            // 
            // Window_Grapher
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(686, 319);
            this.Controls.Add(this.addBU);
            this.Controls.Add(this.grapher);
            this.Name = "Window_Grapher";
            this.Text = "Window_Grapher";
            this.ResumeLayout(false);

        }

        #endregion

        private Grapher grapher;
        private System.Windows.Forms.Button addBU;
    }
}