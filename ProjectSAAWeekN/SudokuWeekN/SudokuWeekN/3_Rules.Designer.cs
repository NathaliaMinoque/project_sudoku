
namespace SudokuWeekN
{
    partial class FormRules
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
            this.pictureBoxClose1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClose1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxClose1
            // 
            this.pictureBoxClose1.Image = global::SudokuWeekN.Properties.Resources._20210111_100002;
            this.pictureBoxClose1.Location = new System.Drawing.Point(688, 388);
            this.pictureBoxClose1.Name = "pictureBoxClose1";
            this.pictureBoxClose1.Size = new System.Drawing.Size(100, 50);
            this.pictureBoxClose1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxClose1.TabIndex = 0;
            this.pictureBoxClose1.TabStop = false;
            this.pictureBoxClose1.Click += new System.EventHandler(this.pictureBoxClose1_Click);
            // 
            // FormRules
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SudokuWeekN.Properties.Resources._20210112_123949_0000;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBoxClose1);
            this.DoubleBuffered = true;
            this.Name = "FormRules";
            this.Text = "Sudoku Week-N";
            this.Load += new System.EventHandler(this.FormRules_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClose1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxClose1;
    }
}