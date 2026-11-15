namespace JeanLuisBatistaACPrCoS1L
{
    partial class AsciiControl
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
            this.lblHeader = new System.Windows.Forms.Label();
            this.gbAsciiToChar = new System.Windows.Forms.GroupBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.lblAsciiNum = new System.Windows.Forms.Label();
            this.numAsciiInput = new System.Windows.Forms.NumericUpDown();
            this.btnToChar = new System.Windows.Forms.Button();
            this.lblCharResult = new System.Windows.Forms.Label();
            this.gbCharToAscii = new System.Windows.Forms.GroupBox();
            this.lblAsciiResult = new System.Windows.Forms.Label();
            this.btnToAscii = new System.Windows.Forms.Button();
            this.lblCharInput = new System.Windows.Forms.Label();
            this.txtCharInput = new System.Windows.Forms.TextBox();
            this.linkAsciiReference = new System.Windows.Forms.LinkLabel();
            this.gbAsciiToChar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numAsciiInput)).BeginInit();
            this.gbCharToAscii.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.lblHeader.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.lblHeader.Location = new System.Drawing.Point(25, 29);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(249, 25);
            this.lblHeader.TabIndex = 0;
            this.lblHeader.Text = "Conversor ASCII / Carácter";
            // 
            // gbAsciiToChar
            // 
            this.gbAsciiToChar.Controls.Add(this.linkAsciiReference);
            this.gbAsciiToChar.Controls.Add(this.lblCharResult);
            this.gbAsciiToChar.Controls.Add(this.btnToChar);
            this.gbAsciiToChar.Controls.Add(this.numAsciiInput);
            this.gbAsciiToChar.Controls.Add(this.lblAsciiNum);
            this.gbAsciiToChar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbAsciiToChar.Location = new System.Drawing.Point(25, 85);
            this.gbAsciiToChar.Name = "gbAsciiToChar";
            this.gbAsciiToChar.Size = new System.Drawing.Size(550, 170);
            this.gbAsciiToChar.TabIndex = 1;
            this.gbAsciiToChar.TabStop = false;
            this.gbAsciiToChar.Text = "De Número ASCII a Carácter";
            this.gbAsciiToChar.Enter += new System.EventHandler(this.gbAsciiToChar_Enter);
            // 
            // lblAsciiNum
            // 
            this.lblAsciiNum.AutoSize = true;
            this.lblAsciiNum.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAsciiNum.Location = new System.Drawing.Point(20, 46);
            this.lblAsciiNum.Name = "lblAsciiNum";
            this.lblAsciiNum.Size = new System.Drawing.Size(122, 15);
            this.lblAsciiNum.TabIndex = 0;
            this.lblAsciiNum.Text = "Código ASCII (0-255)";
            // 
            // numAsciiInput
            // 
            this.numAsciiInput.Location = new System.Drawing.Point(20, 76);
            this.numAsciiInput.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numAsciiInput.Name = "numAsciiInput";
            this.numAsciiInput.Size = new System.Drawing.Size(150, 25);
            this.numAsciiInput.TabIndex = 1;
            this.numAsciiInput.Value = new decimal(new int[] {
            65,
            0,
            0,
            0});
            this.numAsciiInput.KeyDown += new System.Windows.Forms.KeyEventHandler(this.numAsciiInput_KeyDown);
            // 
            // btnToChar
            // 
            this.btnToChar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.btnToChar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnToChar.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnToChar.Location = new System.Drawing.Point(185, 74);
            this.btnToChar.Name = "btnToChar";
            this.btnToChar.Size = new System.Drawing.Size(150, 30);
            this.btnToChar.TabIndex = 2;
            this.btnToChar.Text = "Convertir a Carácter";
            this.btnToChar.UseVisualStyleBackColor = false;
            // 
            // lblCharResult
            // 
            this.lblCharResult.AutoSize = true;
            this.lblCharResult.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCharResult.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.lblCharResult.Location = new System.Drawing.Point(350, 79);
            this.lblCharResult.Name = "lblCharResult";
            this.lblCharResult.Size = new System.Drawing.Size(98, 20);
            this.lblCharResult.TabIndex = 3;
            this.lblCharResult.Text = "Resultado: A";
            // 
            // gbCharToAscii
            // 
            this.gbCharToAscii.Controls.Add(this.txtCharInput);
            this.gbCharToAscii.Controls.Add(this.lblAsciiResult);
            this.gbCharToAscii.Controls.Add(this.btnToAscii);
            this.gbCharToAscii.Controls.Add(this.lblCharInput);
            this.gbCharToAscii.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbCharToAscii.Location = new System.Drawing.Point(25, 280);
            this.gbCharToAscii.Name = "gbCharToAscii";
            this.gbCharToAscii.Size = new System.Drawing.Size(550, 170);
            this.gbCharToAscii.TabIndex = 4;
            this.gbCharToAscii.TabStop = false;
            this.gbCharToAscii.Text = "De Carácter a Número ASCII";
            // 
            // lblAsciiResult
            // 
            this.lblAsciiResult.AutoSize = true;
            this.lblAsciiResult.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAsciiResult.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.lblAsciiResult.Location = new System.Drawing.Point(350, 78);
            this.lblAsciiResult.Name = "lblAsciiResult";
            this.lblAsciiResult.Size = new System.Drawing.Size(105, 20);
            this.lblAsciiResult.TabIndex = 3;
            this.lblAsciiResult.Text = "Resultado: 98";
            // 
            // btnToAscii
            // 
            this.btnToAscii.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnToAscii.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnToAscii.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnToAscii.Location = new System.Drawing.Point(185, 73);
            this.btnToAscii.Name = "btnToAscii";
            this.btnToAscii.Size = new System.Drawing.Size(150, 30);
            this.btnToAscii.TabIndex = 2;
            this.btnToAscii.Text = "Convertir a ASCII";
            this.btnToAscii.UseVisualStyleBackColor = false;
            // 
            // lblCharInput
            // 
            this.lblCharInput.AutoSize = true;
            this.lblCharInput.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCharInput.Location = new System.Drawing.Point(20, 45);
            this.lblCharInput.Name = "lblCharInput";
            this.lblCharInput.Size = new System.Drawing.Size(102, 15);
            this.lblCharInput.TabIndex = 0;
            this.lblCharInput.Text = "Ingrese Carácter:";
            // 
            // txtCharInput
            // 
            this.txtCharInput.Location = new System.Drawing.Point(20, 75);
            this.txtCharInput.MaxLength = 1;
            this.txtCharInput.Name = "txtCharInput";
            this.txtCharInput.Size = new System.Drawing.Size(150, 25);
            this.txtCharInput.TabIndex = 4;
            this.txtCharInput.Text = "b";
            this.txtCharInput.TextChanged += new System.EventHandler(this.txtCharInput_TextChanged);
            // 
            // linkAsciiReference
            // 
            this.linkAsciiReference.AutoSize = true;
            this.linkAsciiReference.Location = new System.Drawing.Point(20, 123);
            this.linkAsciiReference.Name = "linkAsciiReference";
            this.linkAsciiReference.Size = new System.Drawing.Size(160, 17);
            this.linkAsciiReference.TabIndex = 6;
            this.linkAsciiReference.TabStop = true;
            this.linkAsciiReference.Text = "Ver tabla ASCII completa";
            this.linkAsciiReference.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkAsciiReference_LinkClicked);
            // 
            // AsciiControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.Controls.Add(this.gbCharToAscii);
            this.Controls.Add(this.gbAsciiToChar);
            this.Controls.Add(this.lblHeader);
            this.Name = "AsciiControl";
            this.Size = new System.Drawing.Size(600, 500);
            this.Load += new System.EventHandler(this.AsciiControl_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.AsciiControl_KeyDown);
            this.gbAsciiToChar.ResumeLayout(false);
            this.gbAsciiToChar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numAsciiInput)).EndInit();
            this.gbCharToAscii.ResumeLayout(false);
            this.gbCharToAscii.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.GroupBox gbAsciiToChar;
        private System.Windows.Forms.Label lblAsciiNum;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label lblCharResult;
        private System.Windows.Forms.Button btnToChar;
        private System.Windows.Forms.NumericUpDown numAsciiInput;
        private System.Windows.Forms.GroupBox gbCharToAscii;
        private System.Windows.Forms.TextBox txtCharInput;
        private System.Windows.Forms.Label lblAsciiResult;
        private System.Windows.Forms.Button btnToAscii;
        private System.Windows.Forms.Label lblCharInput;
        private System.Windows.Forms.LinkLabel linkAsciiReference;
    }
}
