namespace Part_4_RNG
{
    partial class RandomNumbers
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
            System.Windows.Forms.Label lblNumber;
            this.btnInt = new System.Windows.Forms.Button();
            this.btnDbl = new System.Windows.Forms.Button();
            this.lblMin = new System.Windows.Forms.Label();
            this.lblMax = new System.Windows.Forms.Label();
            this.txtMin = new System.Windows.Forms.TextBox();
            this.txtMax = new System.Windows.Forms.TextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblNmbr = new System.Windows.Forms.Label();
            lblNumber = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblNumber
            // 
            lblNumber.AutoSize = true;
            lblNumber.Location = new System.Drawing.Point(403, 111);
            lblNumber.Name = "lblNumber";
            lblNumber.Size = new System.Drawing.Size(0, 13);
            lblNumber.TabIndex = 1;
            lblNumber.Click += new System.EventHandler(this.lblNumber_Click);
            // 
            // btnInt
            // 
            this.btnInt.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnInt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInt.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnInt.Location = new System.Drawing.Point(201, 130);
            this.btnInt.Name = "btnInt";
            this.btnInt.Size = new System.Drawing.Size(117, 40);
            this.btnInt.TabIndex = 0;
            this.btnInt.Text = "Get Integer";
            this.btnInt.UseVisualStyleBackColor = false;
            this.btnInt.Click += new System.EventHandler(this.btnClick_Click);
            // 
            // btnDbl
            // 
            this.btnDbl.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnDbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDbl.ForeColor = System.Drawing.Color.Red;
            this.btnDbl.Location = new System.Drawing.Point(321, 130);
            this.btnDbl.Name = "btnDbl";
            this.btnDbl.Size = new System.Drawing.Size(117, 40);
            this.btnDbl.TabIndex = 2;
            this.btnDbl.Text = "Get Double";
            this.btnDbl.UseVisualStyleBackColor = false;
            this.btnDbl.Click += new System.EventHandler(this.btnDbl_Click);
            // 
            // lblMin
            // 
            this.lblMin.AutoSize = true;
            this.lblMin.Font = new System.Drawing.Font("Perpetua Titling MT", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMin.Location = new System.Drawing.Point(206, 57);
            this.lblMin.Name = "lblMin";
            this.lblMin.Size = new System.Drawing.Size(97, 20);
            this.lblMin.TabIndex = 3;
            this.lblMin.Text = "Minimum";
            // 
            // lblMax
            // 
            this.lblMax.AutoSize = true;
            this.lblMax.Font = new System.Drawing.Font("Perpetua Titling MT", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMax.Location = new System.Drawing.Point(206, 91);
            this.lblMax.Name = "lblMax";
            this.lblMax.Size = new System.Drawing.Size(103, 20);
            this.lblMax.TabIndex = 4;
            this.lblMax.Text = "Maximum";
            // 
            // txtMin
            // 
            this.txtMin.BackColor = System.Drawing.SystemColors.Info;
            this.txtMin.ForeColor = System.Drawing.Color.Brown;
            this.txtMin.Location = new System.Drawing.Point(338, 57);
            this.txtMin.Name = "txtMin";
            this.txtMin.Size = new System.Drawing.Size(100, 20);
            this.txtMin.TabIndex = 5;
            this.txtMin.TextChanged += new System.EventHandler(this.txtMin_TextChanged);
            // 
            // txtMax
            // 
            this.txtMax.BackColor = System.Drawing.SystemColors.Info;
            this.txtMax.ForeColor = System.Drawing.Color.Brown;
            this.txtMax.Location = new System.Drawing.Point(338, 91);
            this.txtMax.Name = "txtMax";
            this.txtMax.Size = new System.Drawing.Size(100, 20);
            this.txtMax.TabIndex = 6;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Bernard MT Condensed", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(196, 19);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(276, 25);
            this.lblTitle.TabIndex = 7;
            this.lblTitle.Text = "Enter a Minimum and a Maximum";
            // 
            // lblNmbr
            // 
            this.lblNmbr.AutoSize = true;
            this.lblNmbr.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblNmbr.Font = new System.Drawing.Font("Revit_HEB_SHX", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.lblNmbr.ForeColor = System.Drawing.Color.DarkViolet;
            this.lblNmbr.Location = new System.Drawing.Point(146, 206);
            this.lblNmbr.Name = "lblNmbr";
            this.lblNmbr.Size = new System.Drawing.Size(347, 60);
            this.lblNmbr.TabIndex = 8;
            this.lblNmbr.Text = "Big Numba";
            this.lblNmbr.Click += new System.EventHandler(this.lblNmbr_Click);
            // 
            // RandomNumbers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(695, 450);
            this.Controls.Add(this.lblNmbr);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.txtMax);
            this.Controls.Add(this.txtMin);
            this.Controls.Add(this.lblMax);
            this.Controls.Add(this.lblMin);
            this.Controls.Add(this.btnDbl);
            this.Controls.Add(lblNumber);
            this.Controls.Add(this.btnInt);
            this.Name = "RandomNumbers";
            this.Text = "Part4RNG";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnInt;
        private System.Windows.Forms.Button btnDbl;
        private System.Windows.Forms.Label lblMin;
        private System.Windows.Forms.Label lblMax;
        private System.Windows.Forms.TextBox txtMin;
        private System.Windows.Forms.TextBox txtMax;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblNmbr;
    }
}

