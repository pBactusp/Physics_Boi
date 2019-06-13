namespace Physics_Project__new_data_structure_
{
    partial class DataList_Selecter
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
            this.selectBU = new System.Windows.Forms.Button();
            this.cancelBU = new System.Windows.Forms.Button();
            this.showNamedListCHEBO = new System.Windows.Forms.CheckBox();
            this.allRuns_Control = new Physics_Project__new_data_structure_.AllRuns_Control();
            this.SuspendLayout();
            // 
            // selectBU
            // 
            this.selectBU.Location = new System.Drawing.Point(12, 269);
            this.selectBU.Name = "selectBU";
            this.selectBU.Size = new System.Drawing.Size(64, 40);
            this.selectBU.TabIndex = 1;
            this.selectBU.Text = "Select";
            this.selectBU.UseVisualStyleBackColor = true;
            this.selectBU.Click += new System.EventHandler(this.selectBU_Click);
            // 
            // cancelBU
            // 
            this.cancelBU.Location = new System.Drawing.Point(148, 269);
            this.cancelBU.Name = "cancelBU";
            this.cancelBU.Size = new System.Drawing.Size(64, 40);
            this.cancelBU.TabIndex = 2;
            this.cancelBU.Text = "Cancel";
            this.cancelBU.UseVisualStyleBackColor = true;
            this.cancelBU.Click += new System.EventHandler(this.cancelBU_Click);
            // 
            // showNamedListCHEBO
            // 
            this.showNamedListCHEBO.AutoSize = true;
            this.showNamedListCHEBO.Checked = true;
            this.showNamedListCHEBO.CheckState = System.Windows.Forms.CheckState.Checked;
            this.showNamedListCHEBO.Location = new System.Drawing.Point(12, 246);
            this.showNamedListCHEBO.Name = "showNamedListCHEBO";
            this.showNamedListCHEBO.Size = new System.Drawing.Size(127, 17);
            this.showNamedListCHEBO.TabIndex = 3;
            this.showNamedListCHEBO.Text = "Show single data-lists";
            this.showNamedListCHEBO.UseVisualStyleBackColor = true;
            this.showNamedListCHEBO.CheckedChanged += new System.EventHandler(this.showNamedListCHEBO_CheckedChanged);
            // 
            // allRuns_Control
            // 
            this.allRuns_Control.Location = new System.Drawing.Point(12, 12);
            this.allRuns_Control.Name = "allRuns_Control";
            this.allRuns_Control.Size = new System.Drawing.Size(200, 228);
            this.allRuns_Control.TabIndex = 0;
            // 
            // DataList_Selecter
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(224, 321);
            this.ControlBox = false;
            this.Controls.Add(this.showNamedListCHEBO);
            this.Controls.Add(this.cancelBU);
            this.Controls.Add(this.selectBU);
            this.Controls.Add(this.allRuns_Control);
            this.Name = "DataList_Selecter";
            this.Text = "Select data";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AllRuns_Control allRuns_Control;
        private System.Windows.Forms.Button selectBU;
        private System.Windows.Forms.Button cancelBU;
        private System.Windows.Forms.CheckBox showNamedListCHEBO;
    }
}