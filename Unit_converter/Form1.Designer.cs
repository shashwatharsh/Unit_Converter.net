
namespace Unit_converter
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.lengthConverterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tempratureToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lengthp = new System.Windows.Forms.Panel();
            this.tempraturet = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.clength = new System.Windows.Forms.Button();
            this.cm = new System.Windows.Forms.Label();
            this.m = new System.Windows.Forms.Label();
            this.rtb2 = new System.Windows.Forms.TextBox();
            this.rtb1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.listBox2tmp = new System.Windows.Forms.ListBox();
            this.listBox1tmp = new System.Windows.Forms.ListBox();
            this.ctmp = new System.Windows.Forms.Label();
            this.ftmp = new System.Windows.Forms.Label();
            this.txttmp2 = new System.Windows.Forms.TextBox();
            this.txttmp1 = new System.Windows.Forms.TextBox();
            this.labeltemp = new System.Windows.Forms.Label();
            this.tmpmain = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.lengthp.SuspendLayout();
            this.tempraturet.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lengthConverterToolStripMenuItem,
            this.tempratureToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(897, 24);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menu Script";
            // 
            // lengthConverterToolStripMenuItem
            // 
            this.lengthConverterToolStripMenuItem.Name = "lengthConverterToolStripMenuItem";
            this.lengthConverterToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.lengthConverterToolStripMenuItem.Text = "Length ";
            this.lengthConverterToolStripMenuItem.Click += new System.EventHandler(this.lengthConverterToolStripMenuItem_Click);
            // 
            // tempratureToolStripMenuItem
            // 
            this.tempratureToolStripMenuItem.Name = "tempratureToolStripMenuItem";
            this.tempratureToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.tempratureToolStripMenuItem.Text = "Temprature";
            this.tempratureToolStripMenuItem.Click += new System.EventHandler(this.tempratureToolStripMenuItem_Click);
            // 
            // lengthp
            // 
            this.lengthp.Controls.Add(this.tempraturet);
            this.lengthp.Controls.Add(this.label3);
            this.lengthp.Controls.Add(this.label2);
            this.lengthp.Controls.Add(this.listBox2);
            this.lengthp.Controls.Add(this.listBox1);
            this.lengthp.Controls.Add(this.clength);
            this.lengthp.Controls.Add(this.cm);
            this.lengthp.Controls.Add(this.m);
            this.lengthp.Controls.Add(this.rtb2);
            this.lengthp.Controls.Add(this.rtb1);
            this.lengthp.Controls.Add(this.label1);
            this.lengthp.Location = new System.Drawing.Point(0, 24);
            this.lengthp.Name = "lengthp";
            this.lengthp.Size = new System.Drawing.Size(897, 426);
            this.lengthp.TabIndex = 11;
            // 
            // tempraturet
            // 
            this.tempraturet.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.tempraturet.Controls.Add(this.tmpmain);
            this.tempraturet.Controls.Add(this.labeltemp);
            this.tempraturet.Controls.Add(this.label4);
            this.tempraturet.Controls.Add(this.label5);
            this.tempraturet.Controls.Add(this.listBox2tmp);
            this.tempraturet.Controls.Add(this.listBox1tmp);
            this.tempraturet.Controls.Add(this.ctmp);
            this.tempraturet.Controls.Add(this.ftmp);
            this.tempraturet.Controls.Add(this.txttmp2);
            this.tempraturet.Controls.Add(this.txttmp1);
            this.tempraturet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tempraturet.Location = new System.Drawing.Point(0, 0);
            this.tempraturet.Name = "tempraturet";
            this.tempraturet.Size = new System.Drawing.Size(897, 426);
            this.tempraturet.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Historic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(519, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 20);
            this.label3.TabIndex = 19;
            this.label3.Text = "To:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Historic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(61, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 18;
            this.label2.Text = "From:";
            // 
            // listBox2
            // 
            this.listBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 18;
            this.listBox2.Items.AddRange(new object[] {
            "Meter",
            "Kilometer",
            "Centimeter",
            "Mile",
            "Yard",
            "Foot",
            "Inch"});
            this.listBox2.Location = new System.Drawing.Point(575, 203);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(216, 130);
            this.listBox2.TabIndex = 17;
            this.listBox2.Click += new System.EventHandler(this.listBox2_SelectedIndexChanged);
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 18;
            this.listBox1.Items.AddRange(new object[] {
            "Meter",
            "Kilometer",
            "Centimeter",
            "Mile",
            "Yard",
            "Foot",
            "Inch"});
            this.listBox1.Location = new System.Drawing.Point(118, 203);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(216, 130);
            this.listBox1.TabIndex = 16;
            this.listBox1.Click += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // clength
            // 
            this.clength.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clength.Location = new System.Drawing.Point(384, 313);
            this.clength.Name = "clength";
            this.clength.Size = new System.Drawing.Size(150, 54);
            this.clength.TabIndex = 15;
            this.clength.Text = "Convert";
            this.clength.UseVisualStyleBackColor = true;
            this.clength.Click += new System.EventHandler(this.clength_Click);
            // 
            // cm
            // 
            this.cm.AutoSize = true;
            this.cm.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cm.Location = new System.Drawing.Point(797, 132);
            this.cm.Name = "cm";
            this.cm.Size = new System.Drawing.Size(39, 24);
            this.cm.TabIndex = 14;
            this.cm.Text = "CM";
            // 
            // m
            // 
            this.m.AutoSize = true;
            this.m.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m.Location = new System.Drawing.Point(340, 134);
            this.m.Name = "m";
            this.m.Size = new System.Drawing.Size(26, 24);
            this.m.TabIndex = 13;
            this.m.Text = "M";
            // 
            // rtb2
            // 
            this.rtb2.BackColor = System.Drawing.SystemColors.Control;
            this.rtb2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtb2.Location = new System.Drawing.Point(575, 129);
            this.rtb2.Name = "rtb2";
            this.rtb2.ReadOnly = true;
            this.rtb2.Size = new System.Drawing.Size(216, 29);
            this.rtb2.TabIndex = 12;
            // 
            // rtb1
            // 
            this.rtb1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtb1.Location = new System.Drawing.Point(118, 129);
            this.rtb1.Name = "rtb1";
            this.rtb1.Size = new System.Drawing.Size(216, 29);
            this.rtb1.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Emoji", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(294, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(299, 47);
            this.label1.TabIndex = 10;
            this.label1.Text = "Length converter";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Historic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(549, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 20);
            this.label4.TabIndex = 29;
            this.label4.Text = "To:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Historic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(91, 102);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 20);
            this.label5.TabIndex = 28;
            this.label5.Text = "From:";
            // 
            // listBox2tmp
            // 
            this.listBox2tmp.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox2tmp.FormattingEnabled = true;
            this.listBox2tmp.ItemHeight = 18;
            this.listBox2tmp.Items.AddRange(new object[] {
            "Celsius",
            "Kelvin",
            "Fahrenheit"});
            this.listBox2tmp.Location = new System.Drawing.Point(605, 173);
            this.listBox2tmp.Name = "listBox2tmp";
            this.listBox2tmp.Size = new System.Drawing.Size(216, 130);
            this.listBox2tmp.TabIndex = 27;
            this.listBox2tmp.SelectedIndexChanged += new System.EventHandler(this.listBox2tmp_SelectedIndexChanged);
            // 
            // listBox1tmp
            // 
            this.listBox1tmp.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1tmp.FormattingEnabled = true;
            this.listBox1tmp.ItemHeight = 18;
            this.listBox1tmp.Items.AddRange(new object[] {
            "Celsius",
            "Kelvin",
            "Fahrenheit"});
            this.listBox1tmp.Location = new System.Drawing.Point(148, 173);
            this.listBox1tmp.Name = "listBox1tmp";
            this.listBox1tmp.Size = new System.Drawing.Size(216, 130);
            this.listBox1tmp.TabIndex = 26;
            this.listBox1tmp.SelectedIndexChanged += new System.EventHandler(this.listBox1tmp_SelectedIndexChanged);
            // 
            // ctmp
            // 
            this.ctmp.AutoSize = true;
            this.ctmp.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctmp.Location = new System.Drawing.Point(827, 102);
            this.ctmp.Name = "ctmp";
            this.ctmp.Size = new System.Drawing.Size(39, 24);
            this.ctmp.TabIndex = 25;
            this.ctmp.Text = "CM";
            // 
            // ftmp
            // 
            this.ftmp.AutoSize = true;
            this.ftmp.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ftmp.Location = new System.Drawing.Point(370, 104);
            this.ftmp.Name = "ftmp";
            this.ftmp.Size = new System.Drawing.Size(26, 24);
            this.ftmp.TabIndex = 24;
            this.ftmp.Text = "M";
            // 
            // txttmp2
            // 
            this.txttmp2.BackColor = System.Drawing.SystemColors.Control;
            this.txttmp2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttmp2.Location = new System.Drawing.Point(605, 99);
            this.txttmp2.Name = "txttmp2";
            this.txttmp2.ReadOnly = true;
            this.txttmp2.Size = new System.Drawing.Size(216, 29);
            this.txttmp2.TabIndex = 23;
            // 
            // txttmp1
            // 
            this.txttmp1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttmp1.Location = new System.Drawing.Point(148, 99);
            this.txttmp1.Name = "txttmp1";
            this.txttmp1.Size = new System.Drawing.Size(216, 29);
            this.txttmp1.TabIndex = 22;
            // 
            // labeltemp
            // 
            this.labeltemp.AutoSize = true;
            this.labeltemp.Font = new System.Drawing.Font("Segoe UI Emoji", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeltemp.Location = new System.Drawing.Point(324, 30);
            this.labeltemp.Name = "labeltemp";
            this.labeltemp.Size = new System.Drawing.Size(375, 47);
            this.labeltemp.TabIndex = 21;
            this.labeltemp.Text = "Temprature converter";
            // 
            // tmpmain
            // 
            this.tmpmain.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tmpmain.Location = new System.Drawing.Point(401, 313);
            this.tmpmain.Name = "tmpmain";
            this.tmpmain.Size = new System.Drawing.Size(150, 54);
            this.tmpmain.TabIndex = 30;
            this.tmpmain.Text = "Convert";
            this.tmpmain.UseVisualStyleBackColor = true;
            this.tmpmain.Click += new System.EventHandler(this.tmpmain_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(897, 450);
            this.Controls.Add(this.lengthp);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.lengthp.ResumeLayout(false);
            this.lengthp.PerformLayout();
            this.tempraturet.ResumeLayout(false);
            this.tempraturet.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem lengthConverterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tempratureToolStripMenuItem;
        private System.Windows.Forms.Panel lengthp;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button clength;
        private System.Windows.Forms.Label cm;
        private System.Windows.Forms.Label m;
        private System.Windows.Forms.TextBox rtb2;
        private System.Windows.Forms.TextBox rtb1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel tempraturet;
        private System.Windows.Forms.Label labeltemp;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox listBox2tmp;
        private System.Windows.Forms.ListBox listBox1tmp;
        private System.Windows.Forms.Label ctmp;
        private System.Windows.Forms.Label ftmp;
        private System.Windows.Forms.TextBox txttmp2;
        private System.Windows.Forms.TextBox txttmp1;
        private System.Windows.Forms.Button tmpmain;
    }
}

