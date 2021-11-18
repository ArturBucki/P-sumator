
namespace Półsumator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.bitA = new System.Windows.Forms.CheckBox();
            this.bitB = new System.Windows.Forms.CheckBox();
            this.bitS = new System.Windows.Forms.CheckBox();
            this.bitC = new System.Windows.Forms.CheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // bitA
            // 
            this.bitA.AccessibleDescription = "";
            this.bitA.AutoSize = true;
            this.bitA.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bitA.Location = new System.Drawing.Point(207, 155);
            this.bitA.Name = "bitA";
            this.bitA.Size = new System.Drawing.Size(33, 17);
            this.bitA.TabIndex = 5;
            this.bitA.Text = "A";
            this.bitA.UseVisualStyleBackColor = true;
            this.bitA.CheckedChanged += new System.EventHandler(this.bitA_CheckedChanged_1);
            // 
            // bitB
            // 
            this.bitB.AutoSize = true;
            this.bitB.Location = new System.Drawing.Point(207, 209);
            this.bitB.Name = "bitB";
            this.bitB.Size = new System.Drawing.Size(33, 17);
            this.bitB.TabIndex = 6;
            this.bitB.Text = "B";
            this.bitB.UseVisualStyleBackColor = true;
            this.bitB.CheckedChanged += new System.EventHandler(this.bitB_CheckedChanged);
            // 
            // bitS
            // 
            this.bitS.AutoSize = true;
            this.bitS.Location = new System.Drawing.Point(717, 182);
            this.bitS.Name = "bitS";
            this.bitS.Size = new System.Drawing.Size(33, 17);
            this.bitS.TabIndex = 7;
            this.bitS.Text = "S";
            this.bitS.UseVisualStyleBackColor = true;
            this.bitS.CheckedChanged += new System.EventHandler(this.bitS_CheckedChanged);
            // 
            // bitC
            // 
            this.bitC.AutoSize = true;
            this.bitC.Location = new System.Drawing.Point(717, 331);
            this.bitC.Name = "bitC";
            this.bitC.Size = new System.Drawing.Size(33, 17);
            this.bitC.TabIndex = 8;
            this.bitC.Text = "C";
            this.bitC.UseVisualStyleBackColor = true;
            this.bitC.CheckedChanged += new System.EventHandler(this.bitC_CheckedChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(333, 109);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(267, 160);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(385, 286);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(204, 106);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1157, 644);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.bitC);
            this.Controls.Add(this.bitS);
            this.Controls.Add(this.bitB);
            this.Controls.Add(this.bitA);
            this.Name = "Form1";
            this.Text = "Półsumator 1-bitowy ";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.CheckBox bitA;
        private System.Windows.Forms.CheckBox bitB;
        private System.Windows.Forms.CheckBox bitS;
        private System.Windows.Forms.CheckBox bitC;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

