namespace unisciPDF
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>pèièpiopipèip
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
            ConcatenaBnt = new Button();
            openFileDialog1 = new OpenFileDialog();
            OrderNoRdx = new RadioButton();
            OrderRdx = new RadioButton();
            ConvPNG_PDF_bnt = new Button();
            MP3 = new Button();
            InizioTaglio = new NumericUpDown();
            numericUpDown2 = new NumericUpDown();
            FineTaglio = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)InizioTaglio).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)FineTaglio).BeginInit();
            SuspendLayout();
            // 
            // ConcatenaBnt
            // 
            ConcatenaBnt.Location = new Point(51, 303);
            ConcatenaBnt.Name = "ConcatenaBnt";
            ConcatenaBnt.Size = new Size(156, 29);
            ConcatenaBnt.TabIndex = 0;
            ConcatenaBnt.Text = "ConcatenaPDF";
            ConcatenaBnt.UseVisualStyleBackColor = true;
            ConcatenaBnt.Click += ConcatenaBnt_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // OrderNoRdx
            // 
            OrderNoRdx.AutoSize = true;
            OrderNoRdx.Location = new Point(51, 388);
            OrderNoRdx.Name = "OrderNoRdx";
            OrderNoRdx.Size = new Size(174, 24);
            OrderNoRdx.TabIndex = 3;
            OrderNoRdx.TabStop = true;
            OrderNoRdx.Text = "Ordine di Inserimento";
            OrderNoRdx.UseVisualStyleBackColor = true;
            OrderNoRdx.CheckedChanged += OrderNoRdx_CheckedChanged;
            // 
            // OrderRdx
            // 
            OrderRdx.AutoSize = true;
            OrderRdx.Location = new Point(51, 358);
            OrderRdx.Name = "OrderRdx";
            OrderRdx.Size = new Size(148, 24);
            OrderRdx.TabIndex = 4;
            OrderRdx.TabStop = true;
            OrderRdx.Text = "Ordine Alfabetico";
            OrderRdx.UseVisualStyleBackColor = true;
            // 
            // ConvPNG_PDF_bnt
            // 
            ConvPNG_PDF_bnt.Location = new Point(343, 303);
            ConvPNG_PDF_bnt.Name = "ConvPNG_PDF_bnt";
            ConvPNG_PDF_bnt.Size = new Size(142, 29);
            ConvPNG_PDF_bnt.TabIndex = 5;
            ConvPNG_PDF_bnt.Text = "Da PNG a PJG";
            ConvPNG_PDF_bnt.UseVisualStyleBackColor = true;
            ConvPNG_PDF_bnt.Click += ConvPNG_PDF_bnt_Click;
            // 
            // MP3
            // 
            MP3.Location = new Point(587, 303);
            MP3.Name = "MP3";
            MP3.Size = new Size(142, 29);
            MP3.TabIndex = 6;
            MP3.Text = "Taglia MP3";
            MP3.UseVisualStyleBackColor = true;
            MP3.Click += MP3_Click;
            // 
            // InizioTaglio
            // 
            InizioTaglio.Location = new Point(590, 355);
            InizioTaglio.Name = "InizioTaglio";
            InizioTaglio.Size = new Size(150, 27);
            InizioTaglio.TabIndex = 7;
            // 
            // numericUpDown2
            // 
            numericUpDown2.Dock = DockStyle.Right;
            numericUpDown2.Location = new Point(956, 0);
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size(150, 27);
            numericUpDown2.TabIndex = 8;
            numericUpDown2.ValueChanged += numericUpDown2_ValueChanged;
            // 
            // FineTaglio
            // 
            FineTaglio.Location = new Point(590, 388);
            FineTaglio.Name = "FineTaglio";
            FineTaglio.Size = new Size(150, 27);
            FineTaglio.TabIndex = 9;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1106, 450);
            Controls.Add(FineTaglio);
            Controls.Add(numericUpDown2);
            Controls.Add(InizioTaglio);
            Controls.Add(MP3);
            Controls.Add(ConvPNG_PDF_bnt);
            Controls.Add(OrderRdx);
            Controls.Add(OrderNoRdx);
            Controls.Add(ConcatenaBnt);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)InizioTaglio).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
            ((System.ComponentModel.ISupportInitialize)FineTaglio).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button ConcatenaBnt;
        private OpenFileDialog openFileDialog1;
        private RadioButton OrderNoRdx;
        private RadioButton OrderRdx;
        private Button ConvPNG_PDF_bnt;
        private Button MP3;
        private NumericUpDown InizioTaglio;
        private NumericUpDown numericUpDown2;
        private NumericUpDown FineTaglio;
    }
}
