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
            this.tbarg1re = new System.Windows.Forms.TextBox();
            this.label1Pluss = new System.Windows.Forms.Label();
            this.tbarg1im = new System.Windows.Forms.TextBox();
            this.tbarg2re = new System.Windows.Forms.TextBox();
            this.label1i = new System.Windows.Forms.Label();
            this.label2Pluss = new System.Windows.Forms.Label();
            this.tbarg2im = new System.Windows.Forms.TextBox();
            this.label2i = new System.Windows.Forms.Label();
            this.tbresre = new System.Windows.Forms.TextBox();
            this.label3Pluss = new System.Windows.Forms.Label();
            this.tbresim = new System.Windows.Forms.TextBox();
            this.label3i = new System.Windows.Forms.Label();
            this.btnPluss = new System.Windows.Forms.Button();
            this.btnMulti = new System.Windows.Forms.Button();
            this.btnInv = new System.Windows.Forms.Button();
            this.btnMinus = new System.Windows.Forms.Button();
            this.btnDiv = new System.Windows.Forms.Button();
            this.btnAbs = new System.Windows.Forms.Button();
            this.lbLogg = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // tbarg1re
            // 
            this.tbarg1re.Location = new System.Drawing.Point(13, 13);
            this.tbarg1re.Name = "tbarg1re";
            this.tbarg1re.Size = new System.Drawing.Size(100, 20);
            this.tbarg1re.TabIndex = 0;
            this.tbarg1re.Text = "0";
            this.tbarg1re.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbarg1re.TextChanged += new System.EventHandler(this.Tbarg1re_TextChanged);
            // 
            // label1Pluss
            // 
            this.label1Pluss.AutoSize = true;
            this.label1Pluss.Location = new System.Drawing.Point(141, 16);
            this.label1Pluss.Name = "label1Pluss";
            this.label1Pluss.Size = new System.Drawing.Size(13, 13);
            this.label1Pluss.TabIndex = 1;
            this.label1Pluss.Text = "+";
            // 
            // tbarg1im
            // 
            this.tbarg1im.Location = new System.Drawing.Point(183, 13);
            this.tbarg1im.Name = "tbarg1im";
            this.tbarg1im.Size = new System.Drawing.Size(100, 20);
            this.tbarg1im.TabIndex = 2;
            this.tbarg1im.Text = "0";
            this.tbarg1im.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbarg1im.TextChanged += new System.EventHandler(this.Tbarg1im_TextChanged);
            // 
            // tbarg2re
            // 
            this.tbarg2re.Location = new System.Drawing.Point(13, 55);
            this.tbarg2re.Name = "tbarg2re";
            this.tbarg2re.Size = new System.Drawing.Size(100, 20);
            this.tbarg2re.TabIndex = 3;
            this.tbarg2re.Text = "0";
            this.tbarg2re.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbarg2re.TextChanged += new System.EventHandler(this.Tbarg2re_TextChanged);
            // 
            // label1i
            // 
            this.label1i.AutoSize = true;
            this.label1i.Location = new System.Drawing.Point(289, 16);
            this.label1i.Name = "label1i";
            this.label1i.Size = new System.Drawing.Size(9, 13);
            this.label1i.TabIndex = 4;
            this.label1i.Text = "i";
            // 
            // label2Pluss
            // 
            this.label2Pluss.AutoSize = true;
            this.label2Pluss.Location = new System.Drawing.Point(141, 58);
            this.label2Pluss.Name = "label2Pluss";
            this.label2Pluss.Size = new System.Drawing.Size(13, 13);
            this.label2Pluss.TabIndex = 5;
            this.label2Pluss.Text = "+";
            // 
            // tbarg2im
            // 
            this.tbarg2im.Location = new System.Drawing.Point(183, 55);
            this.tbarg2im.Name = "tbarg2im";
            this.tbarg2im.Size = new System.Drawing.Size(100, 20);
            this.tbarg2im.TabIndex = 6;
            this.tbarg2im.Text = "0";
            this.tbarg2im.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbarg2im.TextChanged += new System.EventHandler(this.Tbarg2im_TextChanged);
            // 
            // label2i
            // 
            this.label2i.AutoSize = true;
            this.label2i.Location = new System.Drawing.Point(289, 58);
            this.label2i.Name = "label2i";
            this.label2i.Size = new System.Drawing.Size(9, 13);
            this.label2i.TabIndex = 7;
            this.label2i.Text = "i";
            // 
            // tbresre
            // 
            this.tbresre.Location = new System.Drawing.Point(13, 102);
            this.tbresre.Name = "tbresre";
            this.tbresre.ReadOnly = true;
            this.tbresre.Size = new System.Drawing.Size(100, 20);
            this.tbresre.TabIndex = 8;
            this.tbresre.TabStop = false;
            this.tbresre.Text = "0";
            this.tbresre.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3Pluss
            // 
            this.label3Pluss.AutoSize = true;
            this.label3Pluss.Location = new System.Drawing.Point(141, 105);
            this.label3Pluss.Name = "label3Pluss";
            this.label3Pluss.Size = new System.Drawing.Size(13, 13);
            this.label3Pluss.TabIndex = 9;
            this.label3Pluss.Text = "+";
            // 
            // tbresim
            // 
            this.tbresim.Location = new System.Drawing.Point(183, 102);
            this.tbresim.Name = "tbresim";
            this.tbresim.ReadOnly = true;
            this.tbresim.Size = new System.Drawing.Size(100, 20);
            this.tbresim.TabIndex = 10;
            this.tbresim.TabStop = false;
            this.tbresim.Text = "0";
            this.tbresim.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3i
            // 
            this.label3i.AutoSize = true;
            this.label3i.Location = new System.Drawing.Point(289, 105);
            this.label3i.Name = "label3i";
            this.label3i.Size = new System.Drawing.Size(9, 13);
            this.label3i.TabIndex = 11;
            this.label3i.Text = "i";
            // 
            // btnPluss
            // 
            this.btnPluss.Location = new System.Drawing.Point(360, 11);
            this.btnPluss.Name = "btnPluss";
            this.btnPluss.Size = new System.Drawing.Size(75, 23);
            this.btnPluss.TabIndex = 12;
            this.btnPluss.Text = "+";
            this.btnPluss.UseVisualStyleBackColor = true;
            this.btnPluss.Click += new System.EventHandler(this.BtnPluss_Click);
            // 
            // btnMulti
            // 
            this.btnMulti.Location = new System.Drawing.Point(360, 53);
            this.btnMulti.Name = "btnMulti";
            this.btnMulti.Size = new System.Drawing.Size(75, 23);
            this.btnMulti.TabIndex = 14;
            this.btnMulti.Text = "*";
            this.btnMulti.UseVisualStyleBackColor = true;
            this.btnMulti.Click += new System.EventHandler(this.BtnMulti_Click);
            // 
            // btnInv
            // 
            this.btnInv.Location = new System.Drawing.Point(360, 100);
            this.btnInv.Name = "btnInv";
            this.btnInv.Size = new System.Drawing.Size(75, 23);
            this.btnInv.TabIndex = 16;
            this.btnInv.Text = "Inv";
            this.btnInv.UseVisualStyleBackColor = true;
            this.btnInv.Click += new System.EventHandler(this.BtnInv_Click);
            // 
            // btnMinus
            // 
            this.btnMinus.Location = new System.Drawing.Point(473, 11);
            this.btnMinus.Name = "btnMinus";
            this.btnMinus.Size = new System.Drawing.Size(75, 23);
            this.btnMinus.TabIndex = 13;
            this.btnMinus.Text = "-";
            this.btnMinus.UseVisualStyleBackColor = true;
            this.btnMinus.Click += new System.EventHandler(this.BtnMinus_Click);
            // 
            // btnDiv
            // 
            this.btnDiv.Location = new System.Drawing.Point(473, 53);
            this.btnDiv.Name = "btnDiv";
            this.btnDiv.Size = new System.Drawing.Size(75, 23);
            this.btnDiv.TabIndex = 15;
            this.btnDiv.Text = "/";
            this.btnDiv.UseVisualStyleBackColor = true;
            this.btnDiv.Click += new System.EventHandler(this.BtnDiv_Click);
            // 
            // btnAbs
            // 
            this.btnAbs.Location = new System.Drawing.Point(473, 100);
            this.btnAbs.Name = "btnAbs";
            this.btnAbs.Size = new System.Drawing.Size(75, 23);
            this.btnAbs.TabIndex = 17;
            this.btnAbs.Text = "Abs";
            this.btnAbs.UseVisualStyleBackColor = true;
            this.btnAbs.Click += new System.EventHandler(this.BtnAbs_Click);
            // 
            // lbLogg
            // 
            this.lbLogg.FormattingEnabled = true;
            this.lbLogg.Location = new System.Drawing.Point(13, 150);
            this.lbLogg.Name = "lbLogg";
            this.lbLogg.Size = new System.Drawing.Size(535, 290);
            this.lbLogg.TabIndex = 18;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 450);
            this.Controls.Add(this.lbLogg);
            this.Controls.Add(this.btnAbs);
            this.Controls.Add(this.btnDiv);
            this.Controls.Add(this.btnMinus);
            this.Controls.Add(this.btnInv);
            this.Controls.Add(this.btnMulti);
            this.Controls.Add(this.btnPluss);
            this.Controls.Add(this.label3i);
            this.Controls.Add(this.tbresim);
            this.Controls.Add(this.label3Pluss);
            this.Controls.Add(this.tbresre);
            this.Controls.Add(this.label2i);
            this.Controls.Add(this.tbarg2im);
            this.Controls.Add(this.label2Pluss);
            this.Controls.Add(this.label1i);
            this.Controls.Add(this.tbarg2re);
            this.Controls.Add(this.tbarg1im);
            this.Controls.Add(this.label1Pluss);
            this.Controls.Add(this.tbarg1re);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbarg1re;
        private System.Windows.Forms.Label label1Pluss;
        private System.Windows.Forms.TextBox tbarg1im;
        private System.Windows.Forms.TextBox tbarg2re;
        private System.Windows.Forms.Label label1i;
        private System.Windows.Forms.Label label2Pluss;
        private System.Windows.Forms.TextBox tbarg2im;
        private System.Windows.Forms.Label label2i;
        private System.Windows.Forms.TextBox tbresre;
        private System.Windows.Forms.Label label3Pluss;
        private System.Windows.Forms.TextBox tbresim;
        private System.Windows.Forms.Label label3i;
        private System.Windows.Forms.Button btnPluss;
        private System.Windows.Forms.Button btnMulti;
        private System.Windows.Forms.Button btnInv;
        private System.Windows.Forms.Button btnMinus;
        private System.Windows.Forms.Button btnDiv;
        private System.Windows.Forms.Button btnAbs;
        private System.Windows.Forms.ListBox lbLogg;
    }
}

