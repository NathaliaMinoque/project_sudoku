
namespace SudokuWeekN
{
    partial class FormLevel
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
            this.pictureBoxHard = new System.Windows.Forms.PictureBox();
            this.pictureBoxEasy = new System.Windows.Forms.PictureBox();
            this.pictureBoxMedium = new System.Windows.Forms.PictureBox();
            this.pictureBoxLevel = new System.Windows.Forms.PictureBox();
            this.pictureBoxRules = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEasy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMedium)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLevel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRules)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxHard
            // 
            this.pictureBoxHard.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.pictureBoxHard.Image = global::SudokuWeekN.Properties.Resources.PicsArt_01_07_03_03_43;
            this.pictureBoxHard.Location = new System.Drawing.Point(510, 178);
            this.pictureBoxHard.Name = "pictureBoxHard";
            this.pictureBoxHard.Size = new System.Drawing.Size(174, 162);
            this.pictureBoxHard.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxHard.TabIndex = 3;
            this.pictureBoxHard.TabStop = false;
            this.pictureBoxHard.Click += new System.EventHandler(this.pictureBoxHard_Click);
            // 
            // pictureBoxEasy
            // 
            this.pictureBoxEasy.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pictureBoxEasy.Image = global::SudokuWeekN.Properties.Resources.PicsArt_01_07_03_02_35;
            this.pictureBoxEasy.Location = new System.Drawing.Point(114, 178);
            this.pictureBoxEasy.Name = "pictureBoxEasy";
            this.pictureBoxEasy.Size = new System.Drawing.Size(174, 161);
            this.pictureBoxEasy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxEasy.TabIndex = 2;
            this.pictureBoxEasy.TabStop = false;
            this.pictureBoxEasy.Click += new System.EventHandler(this.pictureBoxEasy_Click);
            // 
            // pictureBoxMedium
            // 
            this.pictureBoxMedium.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBoxMedium.Image = global::SudokuWeekN.Properties.Resources.PicsArt_01_07_03_03_15;
            this.pictureBoxMedium.Location = new System.Drawing.Point(314, 179);
            this.pictureBoxMedium.Name = "pictureBoxMedium";
            this.pictureBoxMedium.Size = new System.Drawing.Size(174, 161);
            this.pictureBoxMedium.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxMedium.TabIndex = 1;
            this.pictureBoxMedium.TabStop = false;
            this.pictureBoxMedium.Click += new System.EventHandler(this.pictureBoxMedium_Click);
            // 
            // pictureBoxLevel
            // 
            this.pictureBoxLevel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxLevel.Image = global::SudokuWeekN.Properties.Resources._20210107_143905_0001;
            this.pictureBoxLevel.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxLevel.Name = "pictureBoxLevel";
            this.pictureBoxLevel.Size = new System.Drawing.Size(800, 450);
            this.pictureBoxLevel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxLevel.TabIndex = 0;
            this.pictureBoxLevel.TabStop = false;
            this.pictureBoxLevel.Click += new System.EventHandler(this.pictureBoxLevel_Click);
            // 
            // pictureBoxRules
            // 
            this.pictureBoxRules.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxRules.Image = global::SudokuWeekN.Properties.Resources._20210111_095938;
            this.pictureBoxRules.Location = new System.Drawing.Point(688, 388);
            this.pictureBoxRules.Name = "pictureBoxRules";
            this.pictureBoxRules.Size = new System.Drawing.Size(100, 50);
            this.pictureBoxRules.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxRules.TabIndex = 4;
            this.pictureBoxRules.TabStop = false;
            this.pictureBoxRules.Click += new System.EventHandler(this.pictureBoxRules_Click);
            // 
            // FormLevel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBoxRules);
            this.Controls.Add(this.pictureBoxHard);
            this.Controls.Add(this.pictureBoxEasy);
            this.Controls.Add(this.pictureBoxMedium);
            this.Controls.Add(this.pictureBoxLevel);
            this.Name = "FormLevel";
            this.Text = "Sudoku Week-N";
            this.Load += new System.EventHandler(this.FormLevel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHard)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEasy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMedium)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLevel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRules)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxLevel;
        private System.Windows.Forms.PictureBox pictureBoxMedium;
        private System.Windows.Forms.PictureBox pictureBoxEasy;
        private System.Windows.Forms.PictureBox pictureBoxHard;
        private System.Windows.Forms.PictureBox pictureBoxRules;
    }
}