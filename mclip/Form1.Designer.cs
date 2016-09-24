namespace mclip
{
    partial class Form1
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
            this.labelcsv = new System.Windows.Forms.Label();
            this.labelhtml = new System.Windows.Forms.Label();
            this.labelrtf = new System.Windows.Forms.Label();
            this.labeltext = new System.Windows.Forms.Label();
            this.labelunicode = new System.Windows.Forms.Label();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.restoreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stripTextToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.clipboardMonitor1 = new mclip.ClipboardMonitor();
            this.contextMenuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelcsv
            // 
            this.labelcsv.AutoSize = true;
            this.labelcsv.Location = new System.Drawing.Point(57, 16);
            this.labelcsv.Name = "labelcsv";
            this.labelcsv.Size = new System.Drawing.Size(29, 13);
            this.labelcsv.TabIndex = 1;
            this.labelcsv.Text = "True";
            // 
            // labelhtml
            // 
            this.labelhtml.AutoSize = true;
            this.labelhtml.Location = new System.Drawing.Point(57, 29);
            this.labelhtml.Name = "labelhtml";
            this.labelhtml.Size = new System.Drawing.Size(32, 13);
            this.labelhtml.TabIndex = 2;
            this.labelhtml.Text = "False";
            // 
            // labelrtf
            // 
            this.labelrtf.AutoSize = true;
            this.labelrtf.Location = new System.Drawing.Point(57, 42);
            this.labelrtf.Name = "labelrtf";
            this.labelrtf.Size = new System.Drawing.Size(38, 13);
            this.labelrtf.TabIndex = 3;
            this.labelrtf.Text = "labelrtf";
            // 
            // labeltext
            // 
            this.labeltext.AutoSize = true;
            this.labeltext.Location = new System.Drawing.Point(57, 55);
            this.labeltext.Name = "labeltext";
            this.labeltext.Size = new System.Drawing.Size(46, 13);
            this.labeltext.TabIndex = 4;
            this.labeltext.Text = "labeltext";
            // 
            // labelunicode
            // 
            this.labelunicode.AutoSize = true;
            this.labelunicode.Location = new System.Drawing.Point(57, 68);
            this.labelunicode.Name = "labelunicode";
            this.labelunicode.Size = new System.Drawing.Size(67, 13);
            this.labelunicode.TabIndex = 5;
            this.labelunicode.Text = "labelunicode";
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Text = "mclip";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.DoubleClick += new System.EventHandler(this.notifyIcon1_DoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.restoreToolStripMenuItem,
            this.stripTextToolStripMenuItem,
            this.toolStripMenuItem1,
            this.exitToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(153, 98);
            // 
            // restoreToolStripMenuItem
            // 
            this.restoreToolStripMenuItem.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.restoreToolStripMenuItem.Name = "restoreToolStripMenuItem";
            this.restoreToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.restoreToolStripMenuItem.Text = "&Open mclip";
            this.restoreToolStripMenuItem.Click += new System.EventHandler(this.restoreToolStripMenuItem_Click);
            // 
            // stripTextToolStripMenuItem
            // 
            this.stripTextToolStripMenuItem.Checked = true;
            this.stripTextToolStripMenuItem.CheckOnClick = true;
            this.stripTextToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.stripTextToolStripMenuItem.Name = "stripTextToolStripMenuItem";
            this.stripTextToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.stripTextToolStripMenuItem.Text = "S&trip Text";
            this.stripTextToolStripMenuItem.CheckedChanged += new System.EventHandler(this.stripTextToolStripMenuItem_CheckedChanged);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(149, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "csv";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "html";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(16, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "rtf";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "text";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "unicode";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.labelrtf);
            this.groupBox1.Controls.Add(this.labelunicode);
            this.groupBox1.Controls.Add(this.labelcsv);
            this.groupBox1.Controls.Add(this.labeltext);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.labelhtml);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(5, 44);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(113, 88);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "state";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Location = new System.Drawing.Point(6, 16);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(71, 17);
            this.checkBox1.TabIndex = 12;
            this.checkBox1.Text = "S&trip Text";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.checkBox1);
            this.groupBox2.Location = new System.Drawing.Point(5, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(113, 39);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "config";
            // 
            // clipboardMonitor1
            // 
            this.clipboardMonitor1.BackColor = System.Drawing.Color.Red;
            this.clipboardMonitor1.Location = new System.Drawing.Point(5, 28);
            this.clipboardMonitor1.Name = "clipboardMonitor1";
            this.clipboardMonitor1.Size = new System.Drawing.Size(12, 13);
            this.clipboardMonitor1.TabIndex = 0;
            this.clipboardMonitor1.Text = "clipboardMonitor1";
            this.clipboardMonitor1.Visible = false;
            this.clipboardMonitor1.ClipboardChanged += new System.EventHandler<mclip.ClipboardChangedEventArgs>(this.clipboardMonitor1_ClipboardChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(120, 133);
            this.Controls.Add(this.clipboardMonitor1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "Form1";
            this.Text = "mclip";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.contextMenuStrip1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ClipboardMonitor clipboardMonitor1;
        private System.Windows.Forms.Label labelcsv;
        private System.Windows.Forms.Label labelhtml;
        private System.Windows.Forms.Label labelrtf;
        private System.Windows.Forms.Label labeltext;
        private System.Windows.Forms.Label labelunicode;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stripTextToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ToolStripMenuItem restoreToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
    }
}

