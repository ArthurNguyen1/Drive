namespace Drive
{
    partial class uctLaptop
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
            this.pnHeader = new System.Windows.Forms.Panel();
            this.pnContentList = new System.Windows.Forms.FlowLayoutPanel();
            this.picGrid = new System.Windows.Forms.PictureBox();
            this.pnGrid = new System.Windows.Forms.Panel();
            this.picList = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pnContentGrid = new System.Windows.Forms.FlowLayoutPanel();
            this.pnList = new System.Windows.Forms.Panel();
            this.pnHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picGrid)).BeginInit();
            this.pnGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picList)).BeginInit();
            this.pnList.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblOwner
            // 
            this.lblOwner.AutoSize = true;
            this.lblOwner.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOwner.Location = new System.Drawing.Point(628, 10);
            this.lblOwner.Name = "lblOwner";
            this.lblOwner.Size = new System.Drawing.Size(100, 20);
            this.lblOwner.TabIndex = 2;
            this.lblOwner.Text = "Chủ sở hữu";
            // 
            // lblReasonRecommend
            // 
            this.lblReasonRecommend.AutoSize = true;
            this.lblReasonRecommend.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReasonRecommend.Location = new System.Drawing.Point(321, 10);
            this.lblReasonRecommend.Name = "lblReasonRecommend";
            this.lblReasonRecommend.Size = new System.Drawing.Size(218, 20);
            this.lblReasonRecommend.TabIndex = 1;
            this.lblReasonRecommend.Text = "Lý do tài liệu được đề xuất";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(3, 10);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(39, 20);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Tên";
            // 
            // pnHeader
            // 
            this.pnHeader.Controls.Add(this.lblOwner);
            this.pnHeader.Controls.Add(this.lblReasonRecommend);
            this.pnHeader.Controls.Add(this.lblName);
            this.pnHeader.Location = new System.Drawing.Point(15, 95);
            this.pnHeader.Name = "pnHeader";
            this.pnHeader.Size = new System.Drawing.Size(816, 42);
            this.pnHeader.TabIndex = 29;
            // 
            // pnContentList
            // 
            this.pnContentList.AutoScroll = true;
            this.pnContentList.Location = new System.Drawing.Point(15, 137);
            this.pnContentList.Name = "pnContentList";
            this.pnContentList.Size = new System.Drawing.Size(816, 475);
            this.pnContentList.TabIndex = 27;
            // 
            // picGrid
            // 
            this.picGrid.BackColor = System.Drawing.Color.White;
            this.picGrid.Image = global::Drive.Properties.Resources.tiles;
            this.picGrid.Location = new System.Drawing.Point(17, 7);
            this.picGrid.Name = "picGrid";
            this.picGrid.Size = new System.Drawing.Size(25, 25);
            this.picGrid.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picGrid.TabIndex = 5;
            this.picGrid.TabStop = false;
            // 
            // pnGrid
            // 
            this.pnGrid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnGrid.Controls.Add(this.picGrid);
            this.pnGrid.Location = new System.Drawing.Point(772, 41);
            this.pnGrid.Name = "pnGrid";
            this.pnGrid.Size = new System.Drawing.Size(59, 42);
            this.pnGrid.TabIndex = 24;
            // 
            // picList
            // 
            this.picList.BackColor = System.Drawing.Color.White;
            this.picList.Image = global::Drive.Properties.Resources.menu;
            this.picList.Location = new System.Drawing.Point(17, 7);
            this.picList.Name = "picList";
            this.picList.Size = new System.Drawing.Size(25, 25);
            this.picList.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picList.TabIndex = 5;
            this.picList.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 25);
            this.label1.TabIndex = 28;
            this.label1.Text = "Máy tính";
            // 
            // pnContentGrid
            // 
            this.pnContentGrid.AutoScroll = true;
            this.pnContentGrid.Location = new System.Drawing.Point(28, 89);
            this.pnContentGrid.Name = "pnContentGrid";
            this.pnContentGrid.Size = new System.Drawing.Size(787, 493);
            this.pnContentGrid.TabIndex = 26;
            // 
            // pnList
            // 
            this.pnList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnList.Controls.Add(this.picList);
            this.pnList.Location = new System.Drawing.Point(713, 41);
            this.pnList.Name = "pnList";
            this.pnList.Size = new System.Drawing.Size(59, 42);
            this.pnList.TabIndex = 25;
            // 
            // uctLaptop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnHeader);
            this.Controls.Add(this.pnContentList);
            this.Controls.Add(this.pnGrid);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pnContentGrid);
            this.Controls.Add(this.pnList);
            this.Name = "uctLaptop";
            this.Size = new System.Drawing.Size(840, 620);
            this.Load += new System.EventHandler(this.uctLaptop_Load);
            this.pnHeader.ResumeLayout(false);
            this.pnHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picGrid)).EndInit();
            this.pnGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picList)).EndInit();
            this.pnList.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblOwner;
        private System.Windows.Forms.Label lblReasonRecommend;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Panel pnHeader;
        private System.Windows.Forms.FlowLayoutPanel pnContentList;
        private System.Windows.Forms.PictureBox picGrid;
        private System.Windows.Forms.Panel pnGrid;
        private System.Windows.Forms.PictureBox picList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel pnContentGrid;
        private System.Windows.Forms.Panel pnList;
    }
}
