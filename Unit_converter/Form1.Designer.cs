
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
            this.M = new System.Windows.Forms.Label();
            this.cm = new System.Windows.Forms.Label();
            this.clength = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(246, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(293, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Length converter";
            // 
            // rtb1
            // 
            this.rtb1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtb1.Location = new System.Drawing.Point(183, 157);
            this.rtb1.Name = "rtb1";
            this.rtb1.Size = new System.Drawing.Size(100, 29);
            this.rtb1.TabIndex = 1;
            this.rtb1.TextChanged += new System.EventHandler(this.rtb1_TextChanged);
            // 
            // rtb2
            // 
            this.rtb2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtb2.Location = new System.Drawing.Point(489, 158);
            this.rtb2.Name = "rtb2";
            this.rtb2.ReadOnly = true;
            this.rtb2.Size = new System.Drawing.Size(100, 29);
            this.rtb2.TabIndex = 2;
            // 
            // M
            // 
            this.M.AutoSize = true;
            this.M.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.M.Location = new System.Drawing.Point(290, 161);
            this.M.Name = "M";
            this.M.Size = new System.Drawing.Size(26, 24);
            this.M.TabIndex = 3;
            this.M.Text = "M";
            // 
            // cm
            // 
            this.cm.AutoSize = true;
            this.cm.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cm.Location = new System.Drawing.Point(595, 161);
            this.cm.Name = "cm";
            this.cm.Size = new System.Drawing.Size(39, 24);
            this.cm.TabIndex = 4;
            this.cm.Text = "CM";
            // 
            // clength
            // 
            this.clength.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clength.Location = new System.Drawing.Point(316, 235);
            this.clength.Name = "clength";
            this.clength.Size = new System.Drawing.Size(150, 54);
            this.clength.TabIndex = 5;
            this.clength.Text = "Convert";
            this.clength.UseVisualStyleBackColor = true;
            this.clength.Click += new System.EventHandler(this.clength_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(183, 204);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.clength);
            this.Controls.Add(this.cm);
            this.Controls.Add(this.M);
            this.Controls.Add(this.rtb2);
            this.Controls.Add(this.rtb1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox rtb1;
        private System.Windows.Forms.TextBox rtb2;
        private System.Windows.Forms.Label M;
        private System.Windows.Forms.Label cm;
        private System.Windows.Forms.Button clength;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}

