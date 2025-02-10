namespace Bai5_GiaiPTBac2
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtA = new System.Windows.Forms.TextBox();
            this.txtB = new System.Windows.Forms.TextBox();
            this.txtC = new System.Windows.Forms.TextBox();
            this.btnGiaiPT = new System.Windows.Forms.Button();
            this.lblKQ = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbA = new System.Windows.Forms.TrackBar();
            this.tbB = new System.Windows.Forms.TrackBar();
            this.tbC = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.tbA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbC)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(49, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Giải Phương Trình Bậc 2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "nhập a";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "nhập b";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "nhập c";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtA
            // 
            this.txtA.Location = new System.Drawing.Point(86, 53);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(114, 20);
            this.txtA.TabIndex = 1;
            this.txtA.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtB
            // 
            this.txtB.Location = new System.Drawing.Point(86, 93);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(114, 20);
            this.txtB.TabIndex = 1;
            this.txtB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtC
            // 
            this.txtC.Location = new System.Drawing.Point(86, 134);
            this.txtC.Name = "txtC";
            this.txtC.Size = new System.Drawing.Size(114, 20);
            this.txtC.TabIndex = 1;
            this.txtC.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnGiaiPT
            // 
            this.btnGiaiPT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGiaiPT.Location = new System.Drawing.Point(97, 174);
            this.btnGiaiPT.Name = "btnGiaiPT";
            this.btnGiaiPT.Size = new System.Drawing.Size(89, 26);
            this.btnGiaiPT.TabIndex = 2;
            this.btnGiaiPT.Text = "Giải PT";
            this.btnGiaiPT.UseVisualStyleBackColor = true;
            this.btnGiaiPT.Click += new System.EventHandler(this.lblKQ_Click);
            // 
            // lblKQ
            // 
            this.lblKQ.AutoSize = true;
            this.lblKQ.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKQ.Location = new System.Drawing.Point(12, 229);
            this.lblKQ.Name = "lblKQ";
            this.lblKQ.Size = new System.Drawing.Size(74, 20);
            this.lblKQ.TabIndex = 3;
            this.lblKQ.Text = "Kết Quả";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(93, 229);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 20);
            this.label5.TabIndex = 4;
            // 
            // tbA
            // 
            this.tbA.LargeChange = 2;
            this.tbA.Location = new System.Drawing.Point(245, 43);
            this.tbA.Maximum = 100;
            this.tbA.Minimum = -100;
            this.tbA.Name = "tbA";
            this.tbA.Size = new System.Drawing.Size(454, 45);
            this.tbA.TabIndex = 5;
            this.tbA.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // tbB
            // 
            this.tbB.LargeChange = 2;
            this.tbB.Location = new System.Drawing.Point(245, 93);
            this.tbB.Maximum = 100;
            this.tbB.Minimum = -100;
            this.tbB.Name = "tbB";
            this.tbB.Size = new System.Drawing.Size(454, 45);
            this.tbB.TabIndex = 5;
            this.tbB.Scroll += new System.EventHandler(this.tbB_Scroll);
            // 
            // tbC
            // 
            this.tbC.LargeChange = 2;
            this.tbC.Location = new System.Drawing.Point(245, 134);
            this.tbC.Maximum = 100;
            this.tbC.Minimum = -100;
            this.tbC.Name = "tbC";
            this.tbC.Size = new System.Drawing.Size(454, 45);
            this.tbC.TabIndex = 5;
            this.tbC.Scroll += new System.EventHandler(this.tbC_Scroll);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbC);
            this.Controls.Add(this.tbB);
            this.Controls.Add(this.tbA);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblKQ);
            this.Controls.Add(this.btnGiaiPT);
            this.Controls.Add(this.txtC);
            this.Controls.Add(this.txtB);
            this.Controls.Add(this.txtA);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.tbA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbC)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.TextBox txtC;
        private System.Windows.Forms.Button btnGiaiPT;
        private System.Windows.Forms.Label lblKQ;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TrackBar tbA;
        private System.Windows.Forms.TrackBar tbB;
        private System.Windows.Forms.TrackBar tbC;
    }
}

