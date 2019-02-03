namespace Table
{
    partial class SetVariables
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
            this.button1 = new System.Windows.Forms.Button();
            this.DefOfNewVariable = new System.Windows.Forms.TextBox();
            this.ConstantsLB = new System.Windows.Forms.ListBox();
            this.VariablesLB = new System.Windows.Forms.ListBox();
            this.NameOfNewVariable = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.CommandsLB = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(40, 68);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(52, 27);
            this.button1.TabIndex = 2;
            this.button1.Text = "Set";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // DefOfNewVariable
            // 
            this.DefOfNewVariable.Location = new System.Drawing.Point(187, 73);
            this.DefOfNewVariable.Name = "DefOfNewVariable";
            this.DefOfNewVariable.Size = new System.Drawing.Size(180, 22);
            this.DefOfNewVariable.TabIndex = 1;
            // 
            // ConstantsLB
            // 
            this.ConstantsLB.FormattingEnabled = true;
            this.ConstantsLB.ItemHeight = 16;
            this.ConstantsLB.Location = new System.Drawing.Point(354, 135);
            this.ConstantsLB.Name = "ConstantsLB";
            this.ConstantsLB.Size = new System.Drawing.Size(122, 308);
            this.ConstantsLB.TabIndex = 100;
            // 
            // VariablesLB
            // 
            this.VariablesLB.FormattingEnabled = true;
            this.VariablesLB.ItemHeight = 16;
            this.VariablesLB.Location = new System.Drawing.Point(40, 135);
            this.VariablesLB.Name = "VariablesLB";
            this.VariablesLB.Size = new System.Drawing.Size(290, 308);
            this.VariablesLB.TabIndex = 100;
            // 
            // NameOfNewVariable
            // 
            this.NameOfNewVariable.Location = new System.Drawing.Point(112, 73);
            this.NameOfNewVariable.Name = "NameOfNewVariable";
            this.NameOfNewVariable.Size = new System.Drawing.Size(50, 22);
            this.NameOfNewVariable.TabIndex = 0;
            this.NameOfNewVariable.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.SystemColors.Control;
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Location = new System.Drawing.Point(168, 76);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(13, 15);
            this.textBox3.TabIndex = 100;
            this.textBox3.Text = "=";
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // CommandsLB
            // 
            this.CommandsLB.FormattingEnabled = true;
            this.CommandsLB.ItemHeight = 16;
            this.CommandsLB.Location = new System.Drawing.Point(505, 135);
            this.CommandsLB.Name = "CommandsLB";
            this.CommandsLB.Size = new System.Drawing.Size(122, 308);
            this.CommandsLB.TabIndex = 101;
            // 
            // SetVariables
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(682, 474);
            this.Controls.Add(this.CommandsLB);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.NameOfNewVariable);
            this.Controls.Add(this.VariablesLB);
            this.Controls.Add(this.ConstantsLB);
            this.Controls.Add(this.DefOfNewVariable);
            this.Controls.Add(this.button1);
            this.Name = "SetVariables";
            this.Text = "SetVariables";
            this.Load += new System.EventHandler(this.SetVariables_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox DefOfNewVariable;
        private System.Windows.Forms.ListBox ConstantsLB;
        private System.Windows.Forms.ListBox VariablesLB;
        private System.Windows.Forms.TextBox NameOfNewVariable;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.ListBox CommandsLB;
    }
}