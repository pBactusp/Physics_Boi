namespace Physics_Project__new_data_structure_
{
    partial class DataManager
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.parentBU = new System.Windows.Forms.Button();
            this.addVariableBU = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.variableFunctionTEBO = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.variableNameTEBO = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.constNameTEBO = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.constValueNUPDO = new System.Windows.Forms.NumericUpDown();
            this.constAddBU = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.constCOLICO = new Physics_Project__new_data_structure_.ConstantList_Control();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.constValueNUPDO)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.parentBU);
            this.groupBox1.Controls.Add(this.addVariableBU);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.variableFunctionTEBO);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.variableNameTEBO);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(240, 235);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add A Variable";
            // 
            // parentBU
            // 
            this.parentBU.Location = new System.Drawing.Point(59, 19);
            this.parentBU.Name = "parentBU";
            this.parentBU.Size = new System.Drawing.Size(75, 23);
            this.parentBU.TabIndex = 8;
            this.parentBU.Text = "parent name";
            this.parentBU.UseVisualStyleBackColor = true;
            this.parentBU.Click += new System.EventHandler(this.parentBU_Click);
            // 
            // addVariableBU
            // 
            this.addVariableBU.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.addVariableBU.Location = new System.Drawing.Point(6, 206);
            this.addVariableBU.Name = "addVariableBU";
            this.addVariableBU.Size = new System.Drawing.Size(75, 23);
            this.addVariableBU.TabIndex = 7;
            this.addVariableBU.Text = "Add";
            this.addVariableBU.UseVisualStyleBackColor = true;
            this.addVariableBU.Click += new System.EventHandler(this.addVariableBU_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Parent =";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(95, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Function";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Name";
            // 
            // variableFunctionTEBO
            // 
            this.variableFunctionTEBO.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.variableFunctionTEBO.Location = new System.Drawing.Point(98, 82);
            this.variableFunctionTEBO.Name = "variableFunctionTEBO";
            this.variableFunctionTEBO.Size = new System.Drawing.Size(133, 20);
            this.variableFunctionTEBO.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(79, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "=";
            // 
            // variableNameTEBO
            // 
            this.variableNameTEBO.Location = new System.Drawing.Point(6, 82);
            this.variableNameTEBO.Name = "variableNameTEBO";
            this.variableNameTEBO.Size = new System.Drawing.Size(67, 20);
            this.variableNameTEBO.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(17, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Y:";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.constAddBU);
            this.groupBox2.Controls.Add(this.constValueNUPDO);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.constNameTEBO);
            this.groupBox2.Location = new System.Drawing.Point(258, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(212, 102);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Add A Constant";
            // 
            // constNameTEBO
            // 
            this.constNameTEBO.Location = new System.Drawing.Point(6, 40);
            this.constNameTEBO.Name = "constNameTEBO";
            this.constNameTEBO.Size = new System.Drawing.Size(67, 20);
            this.constNameTEBO.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(79, 43);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(13, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "=";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Name";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(95, 24);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(34, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "Value";
            // 
            // constValueNUPDO
            // 
            this.constValueNUPDO.DecimalPlaces = 7;
            this.constValueNUPDO.Location = new System.Drawing.Point(98, 41);
            this.constValueNUPDO.Maximum = new decimal(new int[] {
            -559939585,
            902409669,
            54,
            0});
            this.constValueNUPDO.Minimum = new decimal(new int[] {
            -559939585,
            902409669,
            54,
            -2147483648});
            this.constValueNUPDO.Name = "constValueNUPDO";
            this.constValueNUPDO.Size = new System.Drawing.Size(108, 20);
            this.constValueNUPDO.TabIndex = 4;
            // 
            // constAddBU
            // 
            this.constAddBU.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.constAddBU.Location = new System.Drawing.Point(6, 73);
            this.constAddBU.Name = "constAddBU";
            this.constAddBU.Size = new System.Drawing.Size(75, 23);
            this.constAddBU.TabIndex = 5;
            this.constAddBU.Text = "Add";
            this.constAddBU.UseVisualStyleBackColor = true;
            this.constAddBU.Click += new System.EventHandler(this.constAddBU_Click);
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(255, 121);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 13);
            this.label9.TabIndex = 4;
            this.label9.Text = "All Constants";
            // 
            // constCOLICO
            // 
            this.constCOLICO.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.constCOLICO.Location = new System.Drawing.Point(258, 137);
            this.constCOLICO.Name = "constCOLICO";
            this.constCOLICO.Size = new System.Drawing.Size(212, 109);
            this.constCOLICO.TabIndex = 5;
            // 
            // DataManager
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(482, 264);
            this.Controls.Add(this.constCOLICO);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "DataManager";
            this.Text = "DataManager";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.constValueNUPDO)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button addVariableBU;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox variableFunctionTEBO;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox variableNameTEBO;
        private System.Windows.Forms.Button parentBU;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.NumericUpDown constValueNUPDO;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox constNameTEBO;
        private System.Windows.Forms.Button constAddBU;
        private System.Windows.Forms.Label label9;
        private ConstantList_Control constCOLICO;
    }
}