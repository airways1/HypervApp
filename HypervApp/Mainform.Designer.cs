namespace HypervApp
{
    partial class Mainform
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Mainform));
            this.txtScript = new System.Windows.Forms.TextBox();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripSplitButton1 = new System.Windows.Forms.ToolStripSeparator();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btnRun = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.btnLoadRoutine = new System.Windows.Forms.ToolStripMenuItem();
            this.btnGetVm = new System.Windows.Forms.ToolStripButton();
            this.btnGetDisk = new System.Windows.Forms.ToolStripButton();
            this.btnDiskTree = new System.Windows.Forms.ToolStripButton();
            this.btnMergeDisk = new System.Windows.Forms.ToolStripButton();
            this.btnSetting = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtScript
            // 
            this.txtScript.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtScript.Font = new System.Drawing.Font("Lucida Console", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtScript.Location = new System.Drawing.Point(0, 0);
            this.txtScript.Margin = new System.Windows.Forms.Padding(4);
            this.txtScript.Multiline = true;
            this.txtScript.Name = "txtScript";
            this.txtScript.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtScript.Size = new System.Drawing.Size(220, 254);
            this.txtScript.TabIndex = 0;
            this.txtScript.Text = "Get-Process";
            // 
            // txtResult
            // 
            this.txtResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtResult.Font = new System.Drawing.Font("Lucida Console", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResult.Location = new System.Drawing.Point(0, 258);
            this.txtResult.Margin = new System.Windows.Forms.Padding(4);
            this.txtResult.Multiline = true;
            this.txtResult.Name = "txtResult";
            this.txtResult.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtResult.Size = new System.Drawing.Size(220, 252);
            this.txtResult.TabIndex = 1;
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnRun,
            this.toolStripButton1,
            this.toolStripSplitButton1,
            this.btnGetVm,
            this.btnGetDisk,
            this.btnDiskTree,
            this.btnMergeDisk,
            this.toolStripSeparator1,
            this.btnSetting});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(661, 52);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripSplitButton1
            // 
            this.toolStripSplitButton1.AutoSize = false;
            this.toolStripSplitButton1.Name = "toolStripSplitButton1";
            this.toolStripSplitButton1.Size = new System.Drawing.Size(16, 52);
            // 
            // splitter1
            // 
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitter1.Location = new System.Drawing.Point(0, 254);
            this.splitter1.Margin = new System.Windows.Forms.Padding(4);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(220, 4);
            this.splitter1.TabIndex = 1;
            this.splitter1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtResult);
            this.panel1.Controls.Add(this.splitter1);
            this.panel1.Controls.Add(this.txtScript);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(220, 510);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(437, 510);
            this.panel2.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(437, 510);
            this.dataGridView1.TabIndex = 0;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 52);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.panel1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.panel2);
            this.splitContainer1.Size = new System.Drawing.Size(661, 510);
            this.splitContainer1.SplitterDistance = 220;
            this.splitContainer1.TabIndex = 1;
            // 
            // btnRun
            // 
            this.btnRun.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnRun.Image = global::HypervApp.Properties.Resources.script;
            this.btnRun.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(44, 49);
            this.btnRun.Text = "toolStripButton1";
            this.btnRun.ToolTipText = "執行";
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnLoadRoutine});
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(34, 49);
            this.toolStripButton1.Text = "^";
            // 
            // btnLoadRoutine
            // 
            this.btnLoadRoutine.Name = "btnLoadRoutine";
            this.btnLoadRoutine.Size = new System.Drawing.Size(159, 26);
            this.btnLoadRoutine.Text = "載入副程式";
            this.btnLoadRoutine.Click += new System.EventHandler(this.btnLoadRoutine_Click);
            // 
            // btnGetVm
            // 
            this.btnGetVm.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnGetVm.Image = global::HypervApp.Properties.Resources.vm;
            this.btnGetVm.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnGetVm.Name = "btnGetVm";
            this.btnGetVm.Size = new System.Drawing.Size(44, 49);
            this.btnGetVm.Text = "toolStripButton1";
            this.btnGetVm.ToolTipText = "列出虛擬機";
            this.btnGetVm.Click += new System.EventHandler(this.btnGetVm_Click);
            // 
            // btnGetDisk
            // 
            this.btnGetDisk.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnGetDisk.Image = global::HypervApp.Properties.Resources.hd;
            this.btnGetDisk.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnGetDisk.Name = "btnGetDisk";
            this.btnGetDisk.Size = new System.Drawing.Size(44, 49);
            this.btnGetDisk.Text = "toolStripButton3";
            this.btnGetDisk.ToolTipText = "列出硬碟";
            this.btnGetDisk.Click += new System.EventHandler(this.btnGetDisk_Click);
            // 
            // btnDiskTree
            // 
            this.btnDiskTree.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnDiskTree.Image = global::HypervApp.Properties.Resources.tree;
            this.btnDiskTree.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDiskTree.Name = "btnDiskTree";
            this.btnDiskTree.Size = new System.Drawing.Size(44, 49);
            this.btnDiskTree.Text = "toolStripButton2";
            this.btnDiskTree.ToolTipText = "硬碟樹結構";
            this.btnDiskTree.Click += new System.EventHandler(this.btnDiskTree_Click);
            // 
            // btnMergeDisk
            // 
            this.btnMergeDisk.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnMergeDisk.Image = global::HypervApp.Properties.Resources.merge;
            this.btnMergeDisk.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnMergeDisk.Name = "btnMergeDisk";
            this.btnMergeDisk.Size = new System.Drawing.Size(44, 49);
            this.btnMergeDisk.Text = "toolStripButton1";
            this.btnMergeDisk.ToolTipText = "合併硬碟";
            this.btnMergeDisk.Click += new System.EventHandler(this.btnMergeDisk_Click);
            // 
            // btnSetting
            // 
            this.btnSetting.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnSetting.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnSetting.Image = global::HypervApp.Properties.Resources.setting;
            this.btnSetting.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSetting.Name = "btnSetting";
            this.btnSetting.Size = new System.Drawing.Size(44, 49);
            this.btnSetting.Text = "toolStripButton2";
            this.btnSetting.Click += new System.EventHandler(this.btnSetting_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 52);
            // 
            // Mainform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(661, 562);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.toolStrip1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Mainform";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txtScript;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.ToolStripButton btnGetVm;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ToolStripButton btnDiskTree;
        private System.Windows.Forms.ToolStripButton btnGetDisk;
        private System.Windows.Forms.ToolStripButton btnMergeDisk;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ToolStripSeparator toolStripSplitButton1;
        private System.Windows.Forms.ToolStripButton btnRun;
        private System.Windows.Forms.ToolStripDropDownButton toolStripButton1;
        private System.Windows.Forms.ToolStripMenuItem btnLoadRoutine;
        private System.Windows.Forms.ToolStripButton btnSetting;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    }
}

