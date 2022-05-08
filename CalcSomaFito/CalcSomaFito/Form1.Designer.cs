namespace CalcSomaFito
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.N1 = new System.Windows.Forms.TextBox();
            this.N2 = new System.Windows.Forms.TextBox();
            this.r = new System.Windows.Forms.TextBox();
            this.somaButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Unispace", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(102, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "NÚMERO 1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Unispace", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(271, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 44);
            this.label2.TabIndex = 1;
            this.label2.Text = "+";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Unispace", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(343, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 33);
            this.label3.TabIndex = 2;
            this.label3.Text = "NÚMERO 2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Unispace", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(581, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(159, 33);
            this.label4.TabIndex = 3;
            this.label4.Text = "RESULTADO";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // N1
            // 
            this.N1.AccessibleName = "N1";
            this.N1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.N1.Location = new System.Drawing.Point(104, 169);
            this.N1.Name = "N1";
            this.N1.Size = new System.Drawing.Size(141, 33);
            this.N1.TabIndex = 4;
            // 
            // N2
            // 
            this.N2.AccessibleName = "N2";
            this.N2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.N2.Location = new System.Drawing.Point(345, 169);
            this.N2.Name = "N2";
            this.N2.Size = new System.Drawing.Size(141, 33);
            this.N2.TabIndex = 5;
            // 
            // r
            // 
            this.r.AccessibleName = "N2";
            this.r.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.r.Location = new System.Drawing.Point(581, 169);
            this.r.Name = "r";
            this.r.Size = new System.Drawing.Size(141, 33);
            this.r.TabIndex = 7;
            // 
            // somaButton
            // 
            this.somaButton.Location = new System.Drawing.Point(517, 176);
            this.somaButton.Name = "somaButton";
            this.somaButton.Size = new System.Drawing.Size(33, 23);
            this.somaButton.TabIndex = 8;
            this.somaButton.Text = "=";
            this.somaButton.UseVisualStyleBackColor = true;
            this.somaButton.Click += new System.EventHandler(this.somaButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(1089, 588);
            this.Controls.Add(this.somaButton);
            this.Controls.Add(this.r);
            this.Controls.Add(this.N2);
            this.Controls.Add(this.N1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "CalcSomaFito";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox N1;
        private TextBox N2;
        private TextBox r;
        private Button somaButton;
    }
}