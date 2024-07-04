namespace Drive
{
    partial class uctTrashItemList
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
            this.lblSize = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblOwner = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picType)).BeginInit();
            this.SuspendLayout();
            // 
            // picType
            // 
            this.picType.Location = new System.Drawing.Point(3, 6);
            this.picType.Name = "picType";
            this.picType.Size = new System.Drawing.Size(25, 25);
            this.picType.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picType.TabIndex = 12;
            this.picType.TabStop = false;
            // 
            // lblSize
            // 
            this.lblSize.AutoSize = true;
            this.lblSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSize.Location = new System.Drawing.Point(678, 11);
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(87, 20);
            this.lblSize.TabIndex = 11;
            this.lblSize.Text = "Kích cỡ tệp";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(506, 11);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(45, 20);
            this.lblDate.TabIndex = 10;
            this.lblDate.Text = "Ngày";
            // 
            // lblOwner
            // 
            this.lblOwner.AutoSize = true;
            this.lblOwner.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOwner.Location = new System.Drawing.Point(328, 11);
            this.lblOwner.Name = "lblOwner";
            this.lblOwner.Size = new System.Drawing.Size(90, 20);
            this.lblOwner.TabIndex = 9;
            this.lblOwner.Text = "Chủ sở hữu";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(34, 11);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(36, 20);
            this.lblName.TabIndex = 8;
            this.lblName.Text = "Tên";
            // 
            // uctTrashItemList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.picType);
            this.Controls.Add(this.lblSize);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblOwner);
            this.Controls.Add(this.lblName);
            this.Name = "uctTrashItemList";
            this.Size = new System.Drawing.Size(816, 42);
            this.Load += new System.EventHandler(this.uctITrashtemList_Load);
            this.Click += new System.EventHandler(this.uctITrashtemList_Click);
            this.DoubleClick += new System.EventHandler(this.uctITrashtemList_DoubleClick);
            this.MouseEnter += new System.EventHandler(this.uctITrashtemList_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.uctITrashtemList_MouseLeave);
            ((System.ComponentModel.ISupportInitialize)(this.picType)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picType;
        private System.Windows.Forms.Label lblSize;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblOwner;
        private System.Windows.Forms.Label lblName;
    }
}
