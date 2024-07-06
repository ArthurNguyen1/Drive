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
            this.picOption = new System.Windows.Forms.PictureBox();
            this.picOwner = new System.Windows.Forms.PictureBox();
            this.picType = new System.Windows.Forms.PictureBox();
            this.lblName = new Drive.CustomControl.TransparentTxb();
            ((System.ComponentModel.ISupportInitialize)(this.picOption)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picOwner)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picType)).BeginInit();
            this.SuspendLayout();
            // 
            // lblOwner
            // 
            this.lblOwner.AutoSize = true;
            this.lblOwner.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOwner.Location = new System.Drawing.Point(590, 10);
            this.lblOwner.Name = "lblOwner";
            this.lblOwner.Size = new System.Drawing.Size(91, 17);
            this.lblOwner.TabIndex = 5;
            this.lblOwner.Text = "Nguyễn Minh";
            this.lblOwner.Click += new System.EventHandler(this.uctItemList_Click);
            this.lblOwner.DoubleClick += new System.EventHandler(this.uctItemList_DoubleClick);
            this.lblOwner.MouseEnter += new System.EventHandler(this.uctItemList_MouseEnter);
            this.lblOwner.MouseLeave += new System.EventHandler(this.uctItemList_MouseLeave);
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
            this.lblReasonRecommend.Click += new System.EventHandler(this.uctItemList_Click);
            this.lblReasonRecommend.DoubleClick += new System.EventHandler(this.uctItemList_DoubleClick);
            this.lblReasonRecommend.MouseEnter += new System.EventHandler(this.uctItemList_MouseEnter);
            this.lblReasonRecommend.MouseLeave += new System.EventHandler(this.uctItemList_MouseLeave);
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
            this.picOwner.Click += new System.EventHandler(this.uctItemList_Click);
            this.picOwner.DoubleClick += new System.EventHandler(this.uctItemList_DoubleClick);
            this.picOwner.MouseEnter += new System.EventHandler(this.uctItemList_MouseEnter);
            this.picOwner.MouseLeave += new System.EventHandler(this.uctItemList_MouseLeave);
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
            this.picType.Click += new System.EventHandler(this.uctItemList_Click);
            this.picType.DoubleClick += new System.EventHandler(this.uctItemList_DoubleClick);
            this.picType.MouseEnter += new System.EventHandler(this.uctItemList_MouseEnter);
            this.picType.MouseLeave += new System.EventHandler(this.uctItemList_MouseLeave);
            // 
            // lblName
            // 
            this.lblName.BackColor = System.Drawing.Color.Transparent;
            this.lblName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblName.CausesValidation = false;
            this.lblName.ForeColor = System.Drawing.SystemColors.MenuText;
            this.lblName.Location = new System.Drawing.Point(31, 9);
            this.lblName.Name = "lblName";
            this.lblName.ReadOnly = true;
            this.lblName.Size = new System.Drawing.Size(168, 15);
            this.lblName.TabIndex = 9;
            this.lblName.Text = "Tên";
            this.lblName.WordWrap = false;
            this.lblName.Click += new System.EventHandler(this.uctItemList_Click);
            this.lblName.DoubleClick += new System.EventHandler(this.uctItemList_DoubleClick);
            this.lblName.MouseEnter += new System.EventHandler(this.uctItemList_MouseEnter);
            this.lblName.MouseLeave += new System.EventHandler(this.uctItemList_MouseLeave);
            // 
            // uctItemList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.picOption);
            this.Controls.Add(this.picOwner);
            this.Controls.Add(this.picType);
            this.Controls.Add(this.lblOwner);
            this.Controls.Add(this.lblReasonRecommend);
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
        private System.Windows.Forms.PictureBox picType;
        private System.Windows.Forms.PictureBox picOwner;
        private System.Windows.Forms.PictureBox picOption;
        public CustomControl.TransparentTxb lblName;
    }
}
