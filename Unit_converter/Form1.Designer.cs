
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
            this.label1 = new System.Windows.Forms.Label();
            this.rtb1 = new System.Windows.Forms.TextBox();
            this.rtb2 = new System.Windows.Forms.TextBox();
            this.m = new System.Windows.Forms.Label();
            this.cm = new System.Windows.Forms.Label();
            this.clength = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.lengthConverterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tempratureToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Emoji", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(254, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(299, 47);
            this.label1.TabIndex = 0;
            this.label1.Text = "Length converter";
            // 
            // rtb1
            // 
            this.rtb1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtb1.Location = new System.Drawing.Point(78, 106);
            this.rtb1.Name = "rtb1";
            this.rtb1.Size = new System.Drawing.Size(216, 29);
            this.rtb1.TabIndex = 1;
            this.rtb1.TextChanged += new System.EventHandler(this.rtb1_TextChanged);
            // 
            // rtb2
            // 
            this.rtb2.BackColor = System.Drawing.SystemColors.Control;
            this.rtb2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtb2.Location = new System.Drawing.Point(535, 103);
            this.rtb2.Name = "rtb2";
            this.rtb2.ReadOnly = true;
            this.rtb2.Size = new System.Drawing.Size(216, 29);
            this.rtb2.TabIndex = 2;
            // 
            // m
            // 
            this.m.AutoSize = true;
            this.m.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m.Location = new System.Drawing.Point(300, 108);
            this.m.Name = "m";
            this.m.Size = new System.Drawing.Size(26, 24);
            this.m.TabIndex = 3;
            this.m.Text = "M";
            // 
            // cm
            // 
            this.cm.AutoSize = true;
            this.cm.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cm.Location = new System.Drawing.Point(757, 106);
            this.cm.Name = "cm";
            this.cm.Size = new System.Drawing.Size(39, 24);
            this.cm.TabIndex = 4;
            this.cm.Text = "CM";
            // 
            // clength
            // 
            this.clength.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clength.Location = new System.Drawing.Point(344, 287);
            this.clength.Name = "clength";
            this.clength.Size = new System.Drawing.Size(150, 54);
            this.clength.TabIndex = 5;
            this.clength.Text = "Convert";
            this.clength.UseVisualStyleBackColor = true;
            this.clength.Click += new System.EventHandler(this.clength_Click);
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
            this.listBox1.Location = new System.Drawing.Point(78, 177);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(216, 130);
            this.listBox1.TabIndex = 6;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
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
            this.listBox2.Location = new System.Drawing.Point(535, 177);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(216, 130);
            this.listBox2.TabIndex = 7;
            this.listBox2.SelectedIndexChanged += new System.EventHandler(this.listBox2_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Historic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "From:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Historic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(479, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "To:";
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
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(897, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.clength);
            this.Controls.Add(this.cm);
            this.Controls.Add(this.m);
            this.Controls.Add(this.rtb2);
            this.Controls.Add(this.rtb1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox rtb1;
        private System.Windows.Forms.TextBox rtb2;
        private System.Windows.Forms.Label cm;
        private System.Windows.Forms.Button clength;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label m;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem lengthConverterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tempratureToolStripMenuItem;
    }
}

