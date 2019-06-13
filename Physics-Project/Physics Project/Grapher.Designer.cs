namespace Physics_Project
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.fitLinB = new System.Windows.Forms.Button();
            this.powerValueNUD = new System.Windows.Forms.NumericUpDown();
            this.polyResNUD = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dataSetsTV = new System.Windows.Forms.TreeView();
            this.zoomModeCB = new System.Windows.Forms.ComboBox();
            this.treeViewMEST = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.changeColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyNameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fourierBU = new System.Windows.Forms.Button();
            this.adDatasetBU = new System.Windows.Forms.Button();
            this.displayPB = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.powerValueNUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.polyResNUD)).BeginInit();
            this.treeViewMEST.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.displayPB)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.Location = new System.Drawing.Point(544, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Selected dataset:";
            // 
            // fitLinB
            // 
            this.fitLinB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fitLinB.Location = new System.Drawing.Point(642, 349);
            this.fitLinB.Name = "fitLinB";
            this.fitLinB.Size = new System.Drawing.Size(71, 25);
            this.fitLinB.TabIndex = 3;
            this.fitLinB.Text = "Fit polynom";
            this.fitLinB.UseVisualStyleBackColor = true;
            this.fitLinB.Click += new System.EventHandler(this.fitPolinom_Click);
            // 
            // powerValueNUD
            // 
            this.powerValueNUD.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.powerValueNUD.Location = new System.Drawing.Point(719, 353);
            this.powerValueNUD.Name = "powerValueNUD";
            this.powerValueNUD.Size = new System.Drawing.Size(69, 20);
            this.powerValueNUD.TabIndex = 4;
            this.powerValueNUD.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // polyResNUD
            // 
            this.polyResNUD.Location = new System.Drawing.Point(731, 389);
            this.polyResNUD.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.polyResNUD.Minimum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.polyResNUD.Name = "polyResNUD";
            this.polyResNUD.Size = new System.Drawing.Size(60, 20);
            this.polyResNUD.TabIndex = 6;
            this.polyResNUD.Value = new decimal(new int[] {
            500,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label2.Location = new System.Drawing.Point(627, 391);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Polynom resolution:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Zoom mode:";
            // 
            // dataSetsTV
            // 
            this.dataSetsTV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataSetsTV.CheckBoxes = true;
            this.dataSetsTV.Location = new System.Drawing.Point(547, 140);
            this.dataSetsTV.Name = "dataSetsTV";
            this.dataSetsTV.Size = new System.Drawing.Size(241, 203);
            this.dataSetsTV.TabIndex = 16;
            this.dataSetsTV.AfterCheck += new System.Windows.Forms.TreeViewEventHandler(this.dataSetsTV_AfterCheck);
            this.dataSetsTV.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.dataSetsTV_AfterSelect);
            this.dataSetsTV.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.dataSetsTV_NodeMouseClick);
            // 
            // zoomModeCB
            // 
            this.zoomModeCB.FormattingEnabled = true;
            this.zoomModeCB.Items.AddRange(new object[] {
            "To Mouse",
            "To Center"});
            this.zoomModeCB.Location = new System.Drawing.Point(12, 25);
            this.zoomModeCB.Name = "zoomModeCB";
            this.zoomModeCB.Size = new System.Drawing.Size(94, 21);
            this.zoomModeCB.TabIndex = 8;
            this.zoomModeCB.Text = "To Center";
            // 
            // treeViewMEST
            // 
            this.treeViewMEST.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.changeColorToolStripMenuItem,
            this.deleteToolStripMenuItem,
            this.copyNameToolStripMenuItem});
            this.treeViewMEST.Name = "treeViewMEST";
            this.treeViewMEST.Size = new System.Drawing.Size(148, 70);
            // 
            // changeColorToolStripMenuItem
            // 
            this.changeColorToolStripMenuItem.Name = "changeColorToolStripMenuItem";
            this.changeColorToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.changeColorToolStripMenuItem.Text = "Change Color";
            this.changeColorToolStripMenuItem.Click += new System.EventHandler(this.changeColorToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // copyNameToolStripMenuItem
            // 
            this.copyNameToolStripMenuItem.Name = "copyNameToolStripMenuItem";
            this.copyNameToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.copyNameToolStripMenuItem.Text = "Copy Name";
            this.copyNameToolStripMenuItem.Click += new System.EventHandler(this.copyNameToolStripMenuItem_Click);
            // 
            // fourierBU
            // 
            this.fourierBU.Location = new System.Drawing.Point(547, 349);
            this.fourierBU.Name = "fourierBU";
            this.fourierBU.Size = new System.Drawing.Size(87, 25);
            this.fourierBU.TabIndex = 19;
            this.fourierBU.Text = "Fit fourier";
            this.fourierBU.UseVisualStyleBackColor = true;
            this.fourierBU.Click += new System.EventHandler(this.fourierBU_Click);
            // 
            // adDatasetBU
            // 
            this.adDatasetBU.Location = new System.Drawing.Point(689, 9);
            this.adDatasetBU.Name = "adDatasetBU";
            this.adDatasetBU.Size = new System.Drawing.Size(99, 48);
            this.adDatasetBU.TabIndex = 20;
            this.adDatasetBU.Text = "Add a dataset";
            this.adDatasetBU.UseVisualStyleBackColor = true;
            this.adDatasetBU.Click += new System.EventHandler(this.adDatasetBU_Click_1);
            // 
            // displayPB
            // 
            this.displayPB.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.displayPB.Location = new System.Drawing.Point(12, 52);
            this.displayPB.Name = "displayPB";
            this.displayPB.Size = new System.Drawing.Size(480, 386);
            this.displayPB.TabIndex = 21;
            this.displayPB.TabStop = false;
            this.displayPB.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.displayPB_MouseDoubleClick);
            this.displayPB.MouseDown += new System.Windows.Forms.MouseEventHandler(this.displayPB_MouseDown);
            this.displayPB.MouseMove += new System.Windows.Forms.MouseEventHandler(this.displayPB_MouseMove);
            this.displayPB.MouseUp += new System.Windows.Forms.MouseEventHandler(this.displayPB_MouseUp);
            this.displayPB.Resize += new System.EventHandler(this.displayPB_Resize);
            // 
            // Grapher
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.displayPB);
            this.Controls.Add(this.adDatasetBU);
            this.Controls.Add(this.polyResNUD);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.powerValueNUD);
            this.Controls.Add(this.fitLinB);
            this.Controls.Add(this.dataSetsTV);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.zoomModeCB);
            this.Controls.Add(this.fourierBU);
            this.DoubleBuffered = true;
            this.Name = "Grapher";
            this.Text = "Grapher";
            ((System.ComponentModel.ISupportInitialize)(this.powerValueNUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.polyResNUD)).EndInit();
            this.treeViewMEST.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.displayPB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button fitLinB;
        private System.Windows.Forms.NumericUpDown powerValueNUD;
        private System.Windows.Forms.NumericUpDown polyResNUD;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TreeView dataSetsTV;
        private System.Windows.Forms.ComboBox zoomModeCB;
        private System.Windows.Forms.ContextMenuStrip treeViewMEST;
        private System.Windows.Forms.ToolStripMenuItem changeColorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyNameToolStripMenuItem;
        private System.Windows.Forms.Button fourierBU;
        private System.Windows.Forms.Button adDatasetBU;
        private System.Windows.Forms.PictureBox displayPB;
    }
}