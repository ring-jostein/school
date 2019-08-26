namespace O1
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
            this.tbFarenheit = new System.Windows.Forms.TextBox();
            this.tbCelcius = new System.Windows.Forms.TextBox();
            this.labelFarenheit = new System.Windows.Forms.Label();
            this.labelCelcius = new System.Windows.Forms.Label();
            this.buttonFjerndata = new System.Windows.Forms.Button();
            this.buttonRegnom = new System.Windows.Forms.Button();
            this.buttonAvslutt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbFarenheit
            // 
            this.tbFarenheit.Location = new System.Drawing.Point(38, 63);
            this.tbFarenheit.Name = "tbFarenheit";
            this.tbFarenheit.Size = new System.Drawing.Size(100, 22);
            this.tbFarenheit.TabIndex = 0;
            // 
            // tbCelcius
            // 
            this.tbCelcius.Location = new System.Drawing.Point(283, 63);
            this.tbCelcius.Name = "tbCelcius";
            this.tbCelcius.ReadOnly = true;
            this.tbCelcius.Size = new System.Drawing.Size(100, 22);
            this.tbCelcius.TabIndex = 1;
            // 
            // labelFarenheit
            // 
            this.labelFarenheit.AutoSize = true;
            this.labelFarenheit.Location = new System.Drawing.Point(35, 42);
            this.labelFarenheit.Name = "labelFarenheit";
            this.labelFarenheit.Size = new System.Drawing.Size(68, 17);
            this.labelFarenheit.TabIndex = 2;
            this.labelFarenheit.Text = "Farenheit";
            // 
            // labelCelcius
            // 
            this.labelCelcius.AutoSize = true;
            this.labelCelcius.Location = new System.Drawing.Point(280, 42);
            this.labelCelcius.Name = "labelCelcius";
            this.labelCelcius.Size = new System.Drawing.Size(53, 17);
            this.labelCelcius.TabIndex = 3;
            this.labelCelcius.Text = "Celcius";
            // 
            // buttonFjerndata
            // 
            this.buttonFjerndata.Location = new System.Drawing.Point(38, 114);
            this.buttonFjerndata.Name = "buttonFjerndata";
            this.buttonFjerndata.Size = new System.Drawing.Size(85, 30);
            this.buttonFjerndata.TabIndex = 4;
            this.buttonFjerndata.Text = "Fjern data";
            this.buttonFjerndata.UseVisualStyleBackColor = true;
            this.buttonFjerndata.Click += new System.EventHandler(this.buttonFjerndata_Click);
            // 
            // buttonRegnom
            // 
            this.buttonRegnom.Location = new System.Drawing.Point(169, 114);
            this.buttonRegnom.Name = "buttonRegnom";
            this.buttonRegnom.Size = new System.Drawing.Size(85, 30);
            this.buttonRegnom.TabIndex = 5;
            this.buttonRegnom.Text = "Regn om";
            this.buttonRegnom.UseVisualStyleBackColor = true;
            this.buttonRegnom.Click += new System.EventHandler(this.buttonRegnom_Click);
            // 
            // buttonAvslutt
            // 
            this.buttonAvslutt.Location = new System.Drawing.Point(298, 114);
            this.buttonAvslutt.Name = "buttonAvslutt";
            this.buttonAvslutt.Size = new System.Drawing.Size(85, 30);
            this.buttonAvslutt.TabIndex = 6;
            this.buttonAvslutt.Text = "Avslutt";
            this.buttonAvslutt.UseVisualStyleBackColor = true;
            this.buttonAvslutt.Click += new System.EventHandler(this.buttonAvslutt_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 187);
            this.Controls.Add(this.buttonAvslutt);
            this.Controls.Add(this.buttonRegnom);
            this.Controls.Add(this.buttonFjerndata);
            this.Controls.Add(this.labelCelcius);
            this.Controls.Add(this.labelFarenheit);
            this.Controls.Add(this.tbCelcius);
            this.Controls.Add(this.tbFarenheit);
            this.Name = "Form1";
            this.Text = "Temperaturomregner";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbFarenheit;
        private System.Windows.Forms.TextBox tbCelcius;
        private System.Windows.Forms.Label labelFarenheit;
        private System.Windows.Forms.Label labelCelcius;
        private System.Windows.Forms.Button buttonFjerndata;
        private System.Windows.Forms.Button buttonRegnom;
        private System.Windows.Forms.Button buttonAvslutt;
    }
}

