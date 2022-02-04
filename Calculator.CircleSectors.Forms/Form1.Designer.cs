namespace Calculator.CircleSectors.Forms
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.nudAngle = new System.Windows.Forms.NumericUpDown();
            this.nudRadius = new System.Windows.Forms.NumericUpDown();
            this.nudChord = new System.Windows.Forms.NumericUpDown();
            this.nudArcLength = new System.Windows.Forms.NumericUpDown();
            this.nudSurfaceArea = new System.Windows.Forms.NumericUpDown();
            this.pnlGraphic = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblMessage = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudAngle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRadius)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudChord)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudArcLength)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSurfaceArea)).BeginInit();
            this.SuspendLayout();
            // 
            // nudAngle
            // 
            this.nudAngle.DecimalPlaces = 2;
            this.nudAngle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.nudAngle.Location = new System.Drawing.Point(122, 30);
            this.nudAngle.Maximum = new decimal(new int[] {
            1569325055,
            23283064,
            0,
            0});
            this.nudAngle.Name = "nudAngle";
            this.nudAngle.Size = new System.Drawing.Size(196, 21);
            this.nudAngle.TabIndex = 0;
            this.nudAngle.Leave += new System.EventHandler(this.nud_Leave);
            // 
            // nudRadius
            // 
            this.nudRadius.DecimalPlaces = 2;
            this.nudRadius.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.nudRadius.Location = new System.Drawing.Point(122, 65);
            this.nudRadius.Maximum = new decimal(new int[] {
            1569325055,
            23283064,
            0,
            0});
            this.nudRadius.Name = "nudRadius";
            this.nudRadius.Size = new System.Drawing.Size(196, 21);
            this.nudRadius.TabIndex = 1;
            this.nudRadius.Leave += new System.EventHandler(this.nud_Leave);
            // 
            // nudChord
            // 
            this.nudChord.DecimalPlaces = 2;
            this.nudChord.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.nudChord.Location = new System.Drawing.Point(122, 100);
            this.nudChord.Maximum = new decimal(new int[] {
            1569325055,
            23283064,
            0,
            0});
            this.nudChord.Name = "nudChord";
            this.nudChord.Size = new System.Drawing.Size(196, 21);
            this.nudChord.TabIndex = 2;
            this.nudChord.Leave += new System.EventHandler(this.nud_Leave);
            // 
            // nudArcLength
            // 
            this.nudArcLength.DecimalPlaces = 2;
            this.nudArcLength.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.nudArcLength.Location = new System.Drawing.Point(122, 135);
            this.nudArcLength.Maximum = new decimal(new int[] {
            1569325055,
            23283064,
            0,
            0});
            this.nudArcLength.Name = "nudArcLength";
            this.nudArcLength.Size = new System.Drawing.Size(196, 21);
            this.nudArcLength.TabIndex = 3;
            this.nudArcLength.Leave += new System.EventHandler(this.nud_Leave);
            // 
            // nudSurfaceArea
            // 
            this.nudSurfaceArea.DecimalPlaces = 2;
            this.nudSurfaceArea.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.nudSurfaceArea.Location = new System.Drawing.Point(122, 170);
            this.nudSurfaceArea.Maximum = new decimal(new int[] {
            1569325055,
            23283064,
            0,
            0});
            this.nudSurfaceArea.Name = "nudSurfaceArea";
            this.nudSurfaceArea.Size = new System.Drawing.Size(196, 21);
            this.nudSurfaceArea.TabIndex = 4;
            this.nudSurfaceArea.Leave += new System.EventHandler(this.nud_Leave);
            // 
            // pnlGraphic
            // 
            this.pnlGraphic.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pnlGraphic.Location = new System.Drawing.Point(12, 237);
            this.pnlGraphic.Name = "pnlGraphic";
            this.pnlGraphic.Size = new System.Drawing.Size(375, 375);
            this.pnlGraphic.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.label1.Location = new System.Drawing.Point(74, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Angle";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.label2.Location = new System.Drawing.Point(66, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Radius";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.label3.Location = new System.Drawing.Point(73, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Chord";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.label4.Location = new System.Drawing.Point(46, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "Arc Length";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.label5.Location = new System.Drawing.Point(31, 172);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Surface Area";
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMessage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblMessage.Location = new System.Drawing.Point(12, 206);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(0, 15);
            this.lblMessage.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 622);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pnlGraphic);
            this.Controls.Add(this.nudSurfaceArea);
            this.Controls.Add(this.nudArcLength);
            this.Controls.Add(this.nudChord);
            this.Controls.Add(this.nudRadius);
            this.Controls.Add(this.nudAngle);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Trigonometry";
            ((System.ComponentModel.ISupportInitialize)(this.nudAngle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRadius)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudChord)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudArcLength)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSurfaceArea)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown nudAngle;
        private System.Windows.Forms.NumericUpDown nudRadius;
        private System.Windows.Forms.NumericUpDown nudChord;
        private System.Windows.Forms.NumericUpDown nudArcLength;
        private System.Windows.Forms.NumericUpDown nudSurfaceArea;
        private System.Windows.Forms.Panel pnlGraphic;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblMessage;
    }
}

