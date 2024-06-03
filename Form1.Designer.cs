namespace Csharp_TinhTong
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
            this.lblSo1 = new System.Windows.Forms.Label();
            this.txtSo1 = new System.Windows.Forms.TextBox();
            this.lblSo2 = new System.Windows.Forms.Label();
            this.lblKQ = new System.Windows.Forms.Label();
            this.txtSo2 = new System.Windows.Forms.TextBox();
            this.btnTinhTong = new System.Windows.Forms.Button();
            this.txtKQ = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblSo1
            // 
            this.lblSo1.AutoSize = true;
            this.lblSo1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSo1.Location = new System.Drawing.Point(67, 37);
            this.lblSo1.Name = "lblSo1";
            this.lblSo1.Size = new System.Drawing.Size(47, 23);
            this.lblSo1.TabIndex = 0;
            this.lblSo1.Text = "Số 1";
            // 
            // txtSo1
            // 
            this.txtSo1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSo1.Location = new System.Drawing.Point(162, 37);
            this.txtSo1.Name = "txtSo1";
            this.txtSo1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtSo1.Size = new System.Drawing.Size(100, 30);
            this.txtSo1.TabIndex = 1;
            this.txtSo1.Text = "4";
            this.txtSo1.TextChanged += new System.EventHandler(this.txt1_TextChanged);
            // 
            // lblSo2
            // 
            this.lblSo2.AutoSize = true;
            this.lblSo2.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSo2.Location = new System.Drawing.Point(67, 89);
            this.lblSo2.Name = "lblSo2";
            this.lblSo2.Size = new System.Drawing.Size(47, 23);
            this.lblSo2.TabIndex = 2;
            this.lblSo2.Text = "Số 2";
            // 
            // lblKQ
            // 
            this.lblKQ.AutoSize = true;
            this.lblKQ.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKQ.Location = new System.Drawing.Point(67, 125);
            this.lblKQ.Name = "lblKQ";
            this.lblKQ.Size = new System.Drawing.Size(75, 23);
            this.lblKQ.TabIndex = 3;
            this.lblKQ.Text = "Kết quả";
            // 
            // txtSo2
            // 
            this.txtSo2.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSo2.Location = new System.Drawing.Point(162, 82);
            this.txtSo2.Name = "txtSo2";
            this.txtSo2.Size = new System.Drawing.Size(100, 30);
            this.txtSo2.TabIndex = 4;
            this.txtSo2.Text = "9";
            this.txtSo2.TextChanged += new System.EventHandler(this.txt2_TextChanged);
            // 
            // btnTinhTong
            // 
            this.btnTinhTong.BackColor = System.Drawing.Color.White;
            this.btnTinhTong.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTinhTong.Location = new System.Drawing.Point(80, 174);
            this.btnTinhTong.Name = "btnTinhTong";
            this.btnTinhTong.Size = new System.Drawing.Size(299, 108);
            this.btnTinhTong.TabIndex = 6;
            this.btnTinhTong.Text = "Tính tổng";
            this.btnTinhTong.UseVisualStyleBackColor = false;
            this.btnTinhTong.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtKQ
            // 
            this.txtKQ.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKQ.Location = new System.Drawing.Point(162, 125);
            this.txtKQ.Name = "txtKQ";
            this.txtKQ.Size = new System.Drawing.Size(100, 30);
            this.txtKQ.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtKQ);
            this.Controls.Add(this.btnTinhTong);
            this.Controls.Add(this.txtSo2);
            this.Controls.Add(this.lblKQ);
            this.Controls.Add(this.lblSo2);
            this.Controls.Add(this.txtSo1);
            this.Controls.Add(this.lblSo1);
            this.Name = "Form1";
            this.Text = "CHƯƠNG TRÌNH TÍNH TỔNG";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSo1;
        private System.Windows.Forms.TextBox txtSo1;
        private System.Windows.Forms.Label lblSo2;
        private System.Windows.Forms.Label lblKQ;
        private System.Windows.Forms.TextBox txtSo2;
        private System.Windows.Forms.Button btnTinhTong;
        private System.Windows.Forms.TextBox txtKQ;
    }
}

