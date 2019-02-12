namespace O4
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
            this.btnconvert = new System.Windows.Forms.Button();
            this.tbresult = new System.Windows.Forms.TextBox();
            this.cb16 = new System.Windows.Forms.CheckBox();
            this.cb8 = new System.Windows.Forms.CheckBox();
            this.cb4 = new System.Windows.Forms.CheckBox();
            this.cb2 = new System.Windows.Forms.CheckBox();
            this.cb1 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // btnconvert
            // 
            this.btnconvert.Location = new System.Drawing.Point(95, 65);
            this.btnconvert.Name = "btnconvert";
            this.btnconvert.Size = new System.Drawing.Size(86, 23);
            this.btnconvert.TabIndex = 0;
            this.btnconvert.Text = "Konverter";
            this.btnconvert.UseVisualStyleBackColor = true;
            this.btnconvert.Click += new System.EventHandler(this.btnconvert_Click);
            // 
            // tbresult
            // 
            this.tbresult.Location = new System.Drawing.Point(73, 104);
            this.tbresult.Name = "tbresult";
            this.tbresult.ReadOnly = true;
            this.tbresult.Size = new System.Drawing.Size(126, 22);
            this.tbresult.TabIndex = 1;
            this.tbresult.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // cb16
            // 
            this.cb16.AutoSize = true;
            this.cb16.Location = new System.Drawing.Point(31, 27);
            this.cb16.Name = "cb16";
            this.cb16.Size = new System.Drawing.Size(46, 21);
            this.cb16.TabIndex = 2;
            this.cb16.Text = "16";
            this.cb16.UseVisualStyleBackColor = true;
            // 
            // cb8
            // 
            this.cb8.AutoSize = true;
            this.cb8.Location = new System.Drawing.Point(83, 27);
            this.cb8.Name = "cb8";
            this.cb8.Size = new System.Drawing.Size(38, 21);
            this.cb8.TabIndex = 3;
            this.cb8.Text = "8";
            this.cb8.UseVisualStyleBackColor = true;
            // 
            // cb4
            // 
            this.cb4.AutoSize = true;
            this.cb4.Location = new System.Drawing.Point(127, 27);
            this.cb4.Name = "cb4";
            this.cb4.Size = new System.Drawing.Size(38, 21);
            this.cb4.TabIndex = 4;
            this.cb4.Text = "4";
            this.cb4.UseVisualStyleBackColor = true;
            // 
            // cb2
            // 
            this.cb2.AutoSize = true;
            this.cb2.Location = new System.Drawing.Point(171, 27);
            this.cb2.Name = "cb2";
            this.cb2.Size = new System.Drawing.Size(38, 21);
            this.cb2.TabIndex = 5;
            this.cb2.Text = "2";
            this.cb2.UseVisualStyleBackColor = true;
            // 
            // cb1
            // 
            this.cb1.AutoSize = true;
            this.cb1.Location = new System.Drawing.Point(215, 27);
            this.cb1.Name = "cb1";
            this.cb1.Size = new System.Drawing.Size(38, 21);
            this.cb1.TabIndex = 6;
            this.cb1.Text = "1";
            this.cb1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(274, 170);
            this.Controls.Add(this.cb1);
            this.Controls.Add(this.cb2);
            this.Controls.Add(this.cb4);
            this.Controls.Add(this.cb8);
            this.Controls.Add(this.cb16);
            this.Controls.Add(this.tbresult);
            this.Controls.Add(this.btnconvert);
            this.Name = "Form1";
            this.Text = "Binær konverter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnconvert;
        private System.Windows.Forms.TextBox tbresult;
        private System.Windows.Forms.CheckBox cb16;
        private System.Windows.Forms.CheckBox cb8;
        private System.Windows.Forms.CheckBox cb4;
        private System.Windows.Forms.CheckBox cb2;
        private System.Windows.Forms.CheckBox cb1;
    }
}

