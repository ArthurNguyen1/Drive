namespace Drive
{
    partial class uctItemList
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
            this.lblOwner = new System.Windows.Forms.Label();
            this.lblReasonRecommend = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.picOption = new System.Windows.Forms.PictureBox();
            this.picOwner = new System.Windows.Forms.PictureBox();
            this.picType = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picOption)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picOwner)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picType)).BeginInit();
            this.SuspendLayout();
            // 
            // lblOwner
            // 
            this.lblOwner.AutoSize = true;
            this.lblOwner.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOwner.Location = new System.Drawing.Point(589, 8);
            this.lblOwner.Name = "lblOwner";
            this.lblOwner.Size = new System.Drawing.Size(80, 17);
            this.lblOwner.TabIndex = 5;
            this.lblOwner.Text = "Chủ sở hữu";
            // 
            // lblReasonRecommend
            // 
            this.lblReasonRecommend.AutoSize = true;
            this.lblReasonRecommend.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReasonRecommend.Location = new System.Drawing.Point(285, 8);
            this.lblReasonRecommend.Name = "lblReasonRecommend";
            this.lblReasonRecommend.Size = new System.Drawing.Size(173, 17);
            this.lblReasonRecommend.TabIndex = 4;
            this.lblReasonRecommend.Text = "Lý do tài liệu được đề xuất";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(30, 8);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(33, 17);
            this.lblName.TabIndex = 3;
            this.lblName.Text = "Tên";
            // 
            // picOption
            // 
            this.picOption.Image = global::Drive.Properties.Resources.three_dots__1_;
            this.picOption.Location = new System.Drawing.Point(700, 8);
            this.picOption.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picOption.Name = "picOption";
            this.picOption.Size = new System.Drawing.Size(22, 20);
            this.picOption.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picOption.TabIndex = 8;
            this.picOption.TabStop = false;
            this.picOption.Click += new System.EventHandler(this.Rename);
            // 
            // picOwner
            // 
            this.picOwner.Location = new System.Drawing.Point(562, 8);
            this.picOwner.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picOwner.Name = "picOwner";
            this.picOwner.Size = new System.Drawing.Size(22, 20);
            this.picOwner.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picOwner.TabIndex = 7;
            this.picOwner.TabStop = false;
            // 
            // picType
            // 
            this.picType.Location = new System.Drawing.Point(3, 5);
            this.picType.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picType.Name = "picType";
            this.picType.Size = new System.Drawing.Size(22, 20);
            this.picType.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picType.TabIndex = 6;
            this.picType.TabStop = false;
            // 
            // uctItemList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.picOption);
            this.Controls.Add(this.picOwner);
            this.Controls.Add(this.picType);
            this.Controls.Add(this.lblOwner);
            this.Controls.Add(this.lblReasonRecommend);
            this.Controls.Add(this.lblName);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "uctItemList";
            this.Size = new System.Drawing.Size(725, 34);
            this.Load += new System.EventHandler(this.uctItemList_Load);
            this.Click += new System.EventHandler(this.uctItemList_Click);
            this.DoubleClick += new System.EventHandler(this.uctItemList_DoubleClick);
            this.MouseEnter += new System.EventHandler(this.uctItemList_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.uctItemList_MouseLeave);
            ((System.ComponentModel.ISupportInitialize)(this.picOption)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picOwner)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picType)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblOwner;
        private System.Windows.Forms.Label lblReasonRecommend;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.PictureBox picType;
        private System.Windows.Forms.PictureBox picOwner;
        private System.Windows.Forms.PictureBox picOption;
    }
}
