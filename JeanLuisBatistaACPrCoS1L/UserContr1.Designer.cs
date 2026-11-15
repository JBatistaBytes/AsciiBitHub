namespace JeanLuisBatistaACPrCoS1L
{
    partial class baseControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gbBinToDec = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblDecResult = new System.Windows.Forms.Label();
            this.btnToDecimal = new System.Windows.Forms.Button();
            this.lblBinInput = new System.Windows.Forms.Label();
            this.lblHeader = new System.Windows.Forms.Label();
            this.gbDecToBin = new System.Windows.Forms.GroupBox();
            this.numDecInput = new System.Windows.Forms.NumericUpDown();
            this.lblBinResult = new System.Windows.Forms.Label();
            this.btnToBinary = new System.Windows.Forms.Button();
            this.lblDecInput = new System.Windows.Forms.Label();
            this.gbBinToDec.SuspendLayout();
            this.gbDecToBin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDecInput)).BeginInit();
            this.SuspendLayout();
            // 
            // gbBinToDec
            // 
            this.gbBinToDec.Controls.Add(this.textBox1);
            this.gbBinToDec.Controls.Add(this.lblDecResult);
            this.gbBinToDec.Controls.Add(this.btnToDecimal);
            this.gbBinToDec.Controls.Add(this.lblBinInput);
            this.gbBinToDec.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbBinToDec.Location = new System.Drawing.Point(25, 85);
            this.gbBinToDec.Name = "gbBinToDec";
            this.gbBinToDec.Size = new System.Drawing.Size(550, 170);
            this.gbBinToDec.TabIndex = 2;
            this.gbBinToDec.TabStop = false;
            this.gbBinToDec.Text = "De Binario (Base 2) a Decimal (Base 10)";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(20, 82);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(150, 25);
            this.textBox1.TabIndex = 4;
            this.textBox1.Text = "01000001";
            // 
            // lblDecResult
            // 
            this.lblDecResult.AutoSize = true;
            this.lblDecResult.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDecResult.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.lblDecResult.Location = new System.Drawing.Point(350, 85);
            this.lblDecResult.Name = "lblDecResult";
            this.lblDecResult.Size = new System.Drawing.Size(105, 20);
            this.lblDecResult.TabIndex = 3;
            this.lblDecResult.Text = "Resultado: 65";
            // 
            // btnToDecimal
            // 
            this.btnToDecimal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(68)))), ((int)(((byte)(173)))));
            this.btnToDecimal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnToDecimal.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnToDecimal.Location = new System.Drawing.Point(185, 80);
            this.btnToDecimal.Name = "btnToDecimal";
            this.btnToDecimal.Size = new System.Drawing.Size(150, 30);
            this.btnToDecimal.TabIndex = 2;
            this.btnToDecimal.Text = "Convertir a Decimal";
            this.btnToDecimal.UseVisualStyleBackColor = false;
            // 
            // lblBinInput
            // 
            this.lblBinInput.AutoSize = true;
            this.lblBinInput.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBinInput.Location = new System.Drawing.Point(20, 55);
            this.lblBinInput.Name = "lblBinInput";
            this.lblBinInput.Size = new System.Drawing.Size(98, 15);
            this.lblBinInput.TabIndex = 0;
            this.lblBinInput.Text = "Número Binario:";
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.lblHeader.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.lblHeader.Location = new System.Drawing.Point(25, 29);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(418, 23);
            this.lblHeader.TabIndex = 3;
            this.lblHeader.Text = "Conversor de Base Numérica (Binario <-> Decimal)";
            // 
            // gbDecToBin
            // 
            this.gbDecToBin.Controls.Add(this.numDecInput);
            this.gbDecToBin.Controls.Add(this.lblBinResult);
            this.gbDecToBin.Controls.Add(this.btnToBinary);
            this.gbDecToBin.Controls.Add(this.lblDecInput);
            this.gbDecToBin.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDecToBin.Location = new System.Drawing.Point(25, 274);
            this.gbDecToBin.Name = "gbDecToBin";
            this.gbDecToBin.Size = new System.Drawing.Size(550, 170);
            this.gbDecToBin.TabIndex = 5;
            this.gbDecToBin.TabStop = false;
            this.gbDecToBin.Text = "De Decimal (Base 10) a Binario (Base 2)";
            // 
            // numDecInput
            // 
            this.numDecInput.Location = new System.Drawing.Point(20, 86);
            this.numDecInput.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.numDecInput.Name = "numDecInput";
            this.numDecInput.Size = new System.Drawing.Size(150, 25);
            this.numDecInput.TabIndex = 4;
            this.numDecInput.Value = new decimal(new int[] {
            65,
            0,
            0,
            0});
            // 
            // lblBinResult
            // 
            this.lblBinResult.AutoSize = true;
            this.lblBinResult.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBinResult.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.lblBinResult.Location = new System.Drawing.Point(350, 89);
            this.lblBinResult.Name = "lblBinResult";
            this.lblBinResult.Size = new System.Drawing.Size(159, 20);
            this.lblBinResult.TabIndex = 3;
            this.lblBinResult.Text = "Resultado: 01000001";
            // 
            // btnToBinary
            // 
            this.btnToBinary.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(84)))), ((int)(((byte)(0)))));
            this.btnToBinary.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnToBinary.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnToBinary.Location = new System.Drawing.Point(185, 84);
            this.btnToBinary.Name = "btnToBinary";
            this.btnToBinary.Size = new System.Drawing.Size(150, 30);
            this.btnToBinary.TabIndex = 2;
            this.btnToBinary.Text = "Convertir a Binario";
            this.btnToBinary.UseVisualStyleBackColor = false;
            // 
            // lblDecInput
            // 
            this.lblDecInput.AutoSize = true;
            this.lblDecInput.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDecInput.Location = new System.Drawing.Point(20, 53);
            this.lblDecInput.Name = "lblDecInput";
            this.lblDecInput.Size = new System.Drawing.Size(104, 15);
            this.lblDecInput.TabIndex = 0;
            this.lblDecInput.Text = "Número Decimal:";
            // 
            // baseControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.Controls.Add(this.gbDecToBin);
            this.Controls.Add(this.lblHeader);
            this.Controls.Add(this.gbBinToDec);
            this.Name = "baseControl";
            this.Size = new System.Drawing.Size(600, 500);
            this.Load += new System.EventHandler(this.baseControl_Load);
            this.gbBinToDec.ResumeLayout(false);
            this.gbBinToDec.PerformLayout();
            this.gbDecToBin.ResumeLayout(false);
            this.gbDecToBin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDecInput)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbBinToDec;
        private System.Windows.Forms.Label lblDecResult;
        private System.Windows.Forms.Button btnToDecimal;
        private System.Windows.Forms.Label lblBinInput;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox gbDecToBin;
        private System.Windows.Forms.Label lblBinResult;
        private System.Windows.Forms.Button btnToBinary;
        private System.Windows.Forms.Label lblDecInput;
        private System.Windows.Forms.NumericUpDown numDecInput;
    }
}
