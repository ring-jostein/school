namespace O3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnregn = new System.Windows.Forms.Button();
            this.btnavslutt = new System.Windows.Forms.Button();
            this.tba = new System.Windows.Forms.TextBox();
            this.tbb = new System.Windows.Forms.TextBox();
            this.tbc = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbsvar = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(174, 82);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(351, 64);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(195, 155);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "a =";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(287, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "b =";
            // 
            // btnregn
            // 
            this.btnregn.Location = new System.Drawing.Point(206, 259);
            this.btnregn.Name = "btnregn";
            this.btnregn.Size = new System.Drawing.Size(75, 23);
            this.btnregn.TabIndex = 3;
            this.btnregn.Text = "Regn Ut";
            this.btnregn.UseVisualStyleBackColor = true;
            this.btnregn.Click += new System.EventHandler(this.btnregn_Click);
            // 
            // btnavslutt
            // 
            this.btnavslutt.Location = new System.Drawing.Point(409, 259);
            this.btnavslutt.Name = "btnavslutt";
            this.btnavslutt.Size = new System.Drawing.Size(75, 23);
            this.btnavslutt.TabIndex = 4;
            this.btnavslutt.Text = "Avslutt";
            this.btnavslutt.UseVisualStyleBackColor = true;
            this.btnavslutt.Click += new System.EventHandler(this.btnavslutt_Click);
            // 
            // tba
            // 
            this.tba.Location = new System.Drawing.Point(221, 152);
            this.tba.Name = "tba";
            this.tba.Size = new System.Drawing.Size(60, 20);
            this.tba.TabIndex = 5;
            this.tba.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tbb
            // 
            this.tbb.Location = new System.Drawing.Point(315, 152);
            this.tbb.Name = "tbb";
            this.tbb.Size = new System.Drawing.Size(60, 20);
            this.tbb.TabIndex = 6;
            this.tbb.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tbc
            // 
            this.tbc.Location = new System.Drawing.Point(409, 152);
            this.tbc.Name = "tbc";
            this.tbc.Size = new System.Drawing.Size(60, 20);
            this.tbc.TabIndex = 7;
            this.tbc.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(381, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(22, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "c =";
            // 
            // tbsvar
            // 
            this.tbsvar.Location = new System.Drawing.Point(174, 221);
            this.tbsvar.Name = "tbsvar";
            this.tbsvar.ReadOnly = true;
            this.tbsvar.Size = new System.Drawing.Size(351, 20);
            this.tbsvar.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(312, 189);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Løsning(er):";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(691, 396);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbsvar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbc);
            this.Controls.Add(this.tbb);
            this.Controls.Add(this.tba);
            this.Controls.Add(this.btnavslutt);
            this.Controls.Add(this.btnregn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Likningskalkulator";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnregn;
        private System.Windows.Forms.Button btnavslutt;
        private System.Windows.Forms.TextBox tba;
        private System.Windows.Forms.TextBox tbb;
        private System.Windows.Forms.TextBox tbc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbsvar;
        private System.Windows.Forms.Label label4;
    }
}

