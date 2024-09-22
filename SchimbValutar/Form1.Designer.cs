namespace SchimbValutar
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnSchimba = new Button();
            boxDin = new ComboBox();
            boxIn = new ComboBox();
            lblSVT = new Label();
            lblDin = new Label();
            lblIn = new Label();
            txtSuma = new TextBox();
            lblSuma = new Label();
            lblCurs = new Label();
            lblSumaSchimbata = new Label();
            SuspendLayout();
            // 
            // btnSchimba
            // 
            btnSchimba.Font = new Font("Perpetua", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSchimba.ForeColor = Color.LightSeaGreen;
            btnSchimba.Location = new Point(300, 348);
            btnSchimba.Name = "btnSchimba";
            btnSchimba.Size = new Size(195, 37);
            btnSchimba.TabIndex = 0;
            btnSchimba.Text = "Schimbă";
            btnSchimba.UseVisualStyleBackColor = true;
            btnSchimba.Click += button1_Click;
            // 
            // boxDin
            // 
            boxDin.FormattingEnabled = true;
            boxDin.Items.AddRange(new object[] { "RON", "EUR", "USD", "GBP" });
            boxDin.Location = new Point(324, 256);
            boxDin.Name = "boxDin";
            boxDin.Size = new Size(152, 23);
            boxDin.TabIndex = 2;
            // 
            // boxIn
            // 
            boxIn.FormattingEnabled = true;
            boxIn.Items.AddRange(new object[] { "RON", "EUR", "USD", "GBP" });
            boxIn.Location = new Point(324, 302);
            boxIn.Name = "boxIn";
            boxIn.Size = new Size(152, 23);
            boxIn.TabIndex = 3;
            // 
            // lblSVT
            // 
            lblSVT.AutoSize = true;
            lblSVT.Font = new Font("Papyrus", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSVT.Location = new Point(247, 41);
            lblSVT.Name = "lblSVT";
            lblSVT.Size = new Size(260, 38);
            lblSVT.TabIndex = 4;
            lblSVT.Text = "#   Schimb Valutar   #";
            lblSVT.Click += lblSVT_Click;
            // 
            // lblDin
            // 
            lblDin.AutoSize = true;
            lblDin.Font = new Font("Tw Cen MT", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 238);
            lblDin.ForeColor = Color.FromArgb(0, 192, 192);
            lblDin.Location = new Point(357, 236);
            lblDin.Name = "lblDin";
            lblDin.Size = new Size(93, 17);
            lblDin.TabIndex = 5;
            lblDin.Text = "Din moneda :";
            lblDin.Click += label1_Click;
            // 
            // lblIn
            // 
            lblIn.AutoSize = true;
            lblIn.Font = new Font("Tw Cen MT", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 238);
            lblIn.ForeColor = Color.FromArgb(0, 192, 192);
            lblIn.Location = new Point(357, 282);
            lblIn.Name = "lblIn";
            lblIn.Size = new Size(83, 17);
            lblIn.TabIndex = 6;
            lblIn.Text = "În moneda :";
            // 
            // txtSuma
            // 
            txtSuma.Location = new Point(324, 210);
            txtSuma.Name = "txtSuma";
            txtSuma.Size = new Size(152, 23);
            txtSuma.TabIndex = 7;
            // 
            // lblSuma
            // 
            lblSuma.AutoSize = true;
            lblSuma.Font = new Font("Tw Cen MT", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 238);
            lblSuma.ForeColor = Color.LightSeaGreen;
            lblSuma.Location = new Point(284, 190);
            lblSuma.Name = "lblSuma";
            lblSuma.Size = new Size(223, 17);
            lblSuma.TabIndex = 8;
            lblSuma.Text = "Suma pe care doriți să o schimbați";
            // 
            // lblCurs
            // 
            lblCurs.AutoSize = true;
            lblCurs.Font = new Font("Tw Cen MT Condensed", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 238);
            lblCurs.ForeColor = Color.Gray;
            lblCurs.Location = new Point(307, 111);
            lblCurs.Name = "lblCurs";
            lblCurs.Size = new Size(193, 20);
            lblCurs.TabIndex = 9;
            lblCurs.Text = "Curs valutar : 1 RON = _____";
            // 
            // lblSumaSchimbata
            // 
            lblSumaSchimbata.AutoSize = true;
            lblSumaSchimbata.Font = new Font("Tw Cen MT Condensed", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 238);
            lblSumaSchimbata.ForeColor = Color.Gray;
            lblSumaSchimbata.Location = new Point(324, 131);
            lblSumaSchimbata.Name = "lblSumaSchimbata";
            lblSumaSchimbata.Size = new Size(161, 20);
            lblSumaSchimbata.TabIndex = 10;
            lblSumaSchimbata.Text = "Suma schimbată : _____";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblSumaSchimbata);
            Controls.Add(lblCurs);
            Controls.Add(lblSuma);
            Controls.Add(txtSuma);
            Controls.Add(lblIn);
            Controls.Add(lblDin);
            Controls.Add(lblSVT);
            Controls.Add(boxIn);
            Controls.Add(boxDin);
            Controls.Add(btnSchimba);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSchimba;
        private ComboBox boxDin;
        private ComboBox boxIn;
        private Label lblSVT;
        private Label lblDin;
        private Label lblIn;
        private TextBox txtSuma;
        private Label lblSuma;
        private Label lblCurs;
        private Label lblSumaSchimbata;
    }
}
