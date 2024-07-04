namespace Drive
{
    partial class uctItemGrid
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
            this.picType = new System.Windows.Forms.PictureBox();
            this.lblName = new System.Windows.Forms.Label();
            this.picOwner = new System.Windows.Forms.PictureBox();
            this.lblReasonRecommend = new System.Windows.Forms.Label();
            this.picOption = new System.Windows.Forms.PictureBox();
            this.picImg = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picOwner)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picOption)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picImg)).BeginInit();
            this.SuspendLayout();
            // 
            // picType
            // 
            this.picType.Location = new System.Drawing.Point(10, 8);
            this.picType.Name = "picType";
            this.picType.Size = new System.Drawing.Size(25, 25);
            this.picType.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picType.TabIndex = 8;
            this.picType.TabStop = false;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(41, 12);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(36, 20);
            this.lblName.TabIndex = 7;
            this.lblName.Text = "Tên";
            // 
            // picOwner
            // 
            this.picOwner.Location = new System.Drawing.Point(10, 149);
            this.picOwner.Name = "picOwner";
            this.picOwner.Size = new System.Drawing.Size(25, 25);
            this.picOwner.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picOwner.TabIndex = 10;
            this.picOwner.TabStop = false;
            // 
            // lblReasonRecommend
            // 
            this.lblReasonRecommend.AutoSize = true;
            this.lblReasonRecommend.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReasonRecommend.Location = new System.Drawing.Point(41, 154);
            this.lblReasonRecommend.Name = "lblReasonRecommend";
            this.lblReasonRecommend.Size = new System.Drawing.Size(191, 20);
            this.lblReasonRecommend.TabIndex = 9;
            this.lblReasonRecommend.Text = "Lý do tài liệu được đề xuất";
            // 
            // picOption
            // 
            this.picOption.Image = global::Drive.Properties.Resources.three_dots__1_;
            this.picOption.Location = new System.Drawing.Point(242, 7);
            this.picOption.Name = "picOption";
            this.picOption.Size = new System.Drawing.Size(25, 25);
            this.picOption.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picOption.TabIndex = 11;
            this.picOption.TabStop = false;
            // 
            // picImg
            // 
            this.picImg.Image = global::Drive.Properties.Resources.imgdocx;
            this.picImg.Location = new System.Drawing.Point(10, 39);
            this.picImg.Name = "picImg";
            this.picImg.Size = new System.Drawing.Size(257, 104);
            this.picImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picImg.TabIndex = 12;
            this.picImg.TabStop = false;
            // 
            // uctItemGrid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.picImg);
            this.Controls.Add(this.picOption);
            this.Controls.Add(this.picOwner);
            this.Controls.Add(this.lblReasonRecommend);
            this.Controls.Add(this.picType);
            this.Controls.Add(this.lblName);
            this.Name = "uctItemGrid";
            this.Size = new System.Drawing.Size(270, 190);
            this.Load += new System.EventHandler(this.uctItemGrid_Load);
            this.Click += new System.EventHandler(this.uctItemGrid_Click);
            this.DoubleClick += new System.EventHandler(this.uctItemGrid_DoubleClick);
            this.MouseEnter += new System.EventHandler(this.uctItemGrid_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.uctItemGrid_MouseLeave);
            ((System.ComponentModel.ISupportInitialize)(this.picType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picOwner)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picOption)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picImg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picType;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.PictureBox picOwner;
        private System.Windows.Forms.Label lblReasonRecommend;
        private System.Windows.Forms.PictureBox picOption;
        private System.Windows.Forms.PictureBox picImg;
    }
}
