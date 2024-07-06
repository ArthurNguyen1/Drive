namespace Drive
{
    partial class uctHome
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
            this.pnContentGrid = new System.Windows.Forms.FlowLayoutPanel();
            this.pnList = new System.Windows.Forms.Panel();
            this.pnGrid = new System.Windows.Forms.Panel();
            this.pnFolder = new System.Windows.Forms.Panel();
            this.lblFolder = new System.Windows.Forms.Label();
            this.pnFile = new System.Windows.Forms.Panel();
            this.lblFile = new System.Windows.Forms.Label();
            this.lblRecommend = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pnContentList = new System.Windows.Forms.FlowLayoutPanel();
            this.pnHeader = new System.Windows.Forms.Panel();
            this.lblOwner = new System.Windows.Forms.Label();
            this.lblReasonRecommend = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.pnFunctions = new System.Windows.Forms.Panel();
            this.lblNotice = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.picMore = new System.Windows.Forms.PictureBox();
            this.picDelete = new System.Windows.Forms.PictureBox();
            this.picCopyLink = new System.Windows.Forms.PictureBox();
            this.picMove = new System.Windows.Forms.PictureBox();
            this.picDownload = new System.Windows.Forms.PictureBox();
            this.picShared = new System.Windows.Forms.PictureBox();
            this.picClose = new System.Windows.Forms.PictureBox();
            this.picList = new System.Windows.Forms.PictureBox();
            this.picGrid = new System.Windows.Forms.PictureBox();
            this.picFolder = new System.Windows.Forms.PictureBox();
            this.picFile = new System.Windows.Forms.PictureBox();
            this.pnList.SuspendLayout();
            this.pnGrid.SuspendLayout();
            this.pnFolder.SuspendLayout();
            this.pnFile.SuspendLayout();
            this.pnHeader.SuspendLayout();
            this.pnFunctions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMore)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDelete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCopyLink)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMove)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDownload)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picShared)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFolder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFile)).BeginInit();
            this.SuspendLayout();
            // 
            // pnContentGrid
            // 
            this.pnContentGrid.AutoScroll = true;
            this.pnContentGrid.Location = new System.Drawing.Point(3, 75);
            this.pnContentGrid.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnContentGrid.Name = "pnContentGrid";
            this.pnContentGrid.Size = new System.Drawing.Size(741, 394);
            this.pnContentGrid.TabIndex = 17;
            // 
            // pnList
            // 
            this.pnList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnList.Controls.Add(this.picList);
            this.pnList.Location = new System.Drawing.Point(634, 37);
            this.pnList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnList.Name = "pnList";
            this.pnList.Size = new System.Drawing.Size(53, 34);
            this.pnList.TabIndex = 16;
            this.pnList.Click += new System.EventHandler(this.pnList_Click);
            // 
            // pnGrid
            // 
            this.pnGrid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnGrid.Controls.Add(this.picGrid);
            this.pnGrid.Location = new System.Drawing.Point(686, 37);
            this.pnGrid.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnGrid.Name = "pnGrid";
            this.pnGrid.Size = new System.Drawing.Size(53, 34);
            this.pnGrid.TabIndex = 15;
            this.pnGrid.Click += new System.EventHandler(this.pnGrid_Click);
            // 
            // pnFolder
            // 
            this.pnFolder.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnFolder.Controls.Add(this.lblFolder);
            this.pnFolder.Controls.Add(this.picFolder);
            this.pnFolder.Location = new System.Drawing.Point(244, 37);
            this.pnFolder.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnFolder.Name = "pnFolder";
            this.pnFolder.Size = new System.Drawing.Size(126, 34);
            this.pnFolder.TabIndex = 14;
            this.pnFolder.Click += new System.EventHandler(this.pnFolder_Click);
            // 
            // lblFolder
            // 
            this.lblFolder.AutoSize = true;
            this.lblFolder.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFolder.Location = new System.Drawing.Point(41, 9);
            this.lblFolder.Name = "lblFolder";
            this.lblFolder.Size = new System.Drawing.Size(70, 17);
            this.lblFolder.TabIndex = 6;
            this.lblFolder.Text = "Thư mục";
            // 
            // pnFile
            // 
            this.pnFile.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnFile.Controls.Add(this.lblFile);
            this.pnFile.Controls.Add(this.picFile);
            this.pnFile.Location = new System.Drawing.Point(118, 37);
            this.pnFile.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnFile.Name = "pnFile";
            this.pnFile.Size = new System.Drawing.Size(126, 34);
            this.pnFile.TabIndex = 12;
            this.pnFile.Click += new System.EventHandler(this.pnFile_Click);
            // 
            // lblFile
            // 
            this.lblFile.AutoSize = true;
            this.lblFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFile.Location = new System.Drawing.Point(57, 9);
            this.lblFile.Name = "lblFile";
            this.lblFile.Size = new System.Drawing.Size(36, 17);
            this.lblFile.TabIndex = 6;
            this.lblFile.Text = "Tệp";
            // 
            // lblRecommend
            // 
            this.lblRecommend.AutoSize = true;
            this.lblRecommend.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecommend.Location = new System.Drawing.Point(10, 44);
            this.lblRecommend.Name = "lblRecommend";
            this.lblRecommend.Size = new System.Drawing.Size(95, 18);
            this.lblRecommend.TabIndex = 13;
            this.lblRecommend.Text = "Được đề xuất";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 20);
            this.label1.TabIndex = 18;
            this.label1.Text = "Chào mừng bạn đến với Drive";
            // 
            // pnContentList
            // 
            this.pnContentList.AutoScroll = true;
            this.pnContentList.Location = new System.Drawing.Point(13, 114);
            this.pnContentList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnContentList.Name = "pnContentList";
            this.pnContentList.Size = new System.Drawing.Size(725, 380);
            this.pnContentList.TabIndex = 18;
            // 
            // pnHeader
            // 
            this.pnHeader.Controls.Add(this.lblOwner);
            this.pnHeader.Controls.Add(this.lblReasonRecommend);
            this.pnHeader.Controls.Add(this.lblName);
            this.pnHeader.Location = new System.Drawing.Point(13, 80);
            this.pnHeader.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnHeader.Name = "pnHeader";
            this.pnHeader.Size = new System.Drawing.Size(725, 34);
            this.pnHeader.TabIndex = 19;
            // 
            // lblOwner
            // 
            this.lblOwner.AutoSize = true;
            this.lblOwner.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOwner.Location = new System.Drawing.Point(558, 8);
            this.lblOwner.Name = "lblOwner";
            this.lblOwner.Size = new System.Drawing.Size(90, 17);
            this.lblOwner.TabIndex = 2;
            this.lblOwner.Text = "Chủ sở hữu";
            // 
            // lblReasonRecommend
            // 
            this.lblReasonRecommend.AutoSize = true;
            this.lblReasonRecommend.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReasonRecommend.Location = new System.Drawing.Point(285, 8);
            this.lblReasonRecommend.Name = "lblReasonRecommend";
            this.lblReasonRecommend.Size = new System.Drawing.Size(200, 17);
            this.lblReasonRecommend.TabIndex = 1;
            this.lblReasonRecommend.Text = "Lý do tài liệu được đề xuất";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(3, 8);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(36, 17);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Tên";
            // 
            // pnFunctions
            // 
            this.pnFunctions.BackColor = System.Drawing.SystemColors.Control;
            this.pnFunctions.Controls.Add(this.pictureBox1);
            this.pnFunctions.Controls.Add(this.picMore);
            this.pnFunctions.Controls.Add(this.picDelete);
            this.pnFunctions.Controls.Add(this.picCopyLink);
            this.pnFunctions.Controls.Add(this.picMove);
            this.pnFunctions.Controls.Add(this.picDownload);
            this.pnFunctions.Controls.Add(this.picShared);
            this.pnFunctions.Controls.Add(this.lblNotice);
            this.pnFunctions.Controls.Add(this.picClose);
            this.pnFunctions.Location = new System.Drawing.Point(13, 35);
            this.pnFunctions.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnFunctions.Name = "pnFunctions";
            this.pnFunctions.Size = new System.Drawing.Size(722, 34);
            this.pnFunctions.TabIndex = 20;
            // 
            // lblNotice
            // 
            this.lblNotice.AutoSize = true;
            this.lblNotice.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNotice.Location = new System.Drawing.Point(34, 8);
            this.lblNotice.Name = "lblNotice";
            this.lblNotice.Size = new System.Drawing.Size(103, 17);
            this.lblNotice.TabIndex = 8;
            this.lblNotice.Text = "Đã chọn 1 mục";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox1.Image = global::Drive.Properties.Resources.edit;
            this.pictureBox1.Location = new System.Drawing.Point(428, 6);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(22, 20);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.Edit);
            // 
            // picMore
            // 
            this.picMore.BackColor = System.Drawing.SystemColors.Control;
            this.picMore.Image = global::Drive.Properties.Resources.three_dots__1_;
            this.picMore.Location = new System.Drawing.Point(483, 6);
            this.picMore.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picMore.Name = "picMore";
            this.picMore.Size = new System.Drawing.Size(22, 20);
            this.picMore.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picMore.TabIndex = 14;
            this.picMore.TabStop = false;
            this.picMore.MouseEnter += new System.EventHandler(this.picMore_MouseEnter);
            this.picMore.MouseLeave += new System.EventHandler(this.picMore_MouseLeave);
            // 
            // picDelete
            // 
            this.picDelete.BackColor = System.Drawing.SystemColors.Control;
            this.picDelete.Image = global::Drive.Properties.Resources.delete__1_;
            this.picDelete.Location = new System.Drawing.Point(323, 6);
            this.picDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picDelete.Name = "picDelete";
            this.picDelete.Size = new System.Drawing.Size(22, 20);
            this.picDelete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picDelete.TabIndex = 13;
            this.picDelete.TabStop = false;
            this.picDelete.Click += new System.EventHandler(this.picDelete_Click);
            this.picDelete.MouseEnter += new System.EventHandler(this.picDelete_MouseEnter);
            this.picDelete.MouseLeave += new System.EventHandler(this.picDelete_MouseLeave);
            // 
            // picCopyLink
            // 
            this.picCopyLink.BackColor = System.Drawing.SystemColors.Control;
            this.picCopyLink.Image = global::Drive.Properties.Resources.link;
            this.picCopyLink.Location = new System.Drawing.Point(380, 6);
            this.picCopyLink.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picCopyLink.Name = "picCopyLink";
            this.picCopyLink.Size = new System.Drawing.Size(22, 20);
            this.picCopyLink.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCopyLink.TabIndex = 12;
            this.picCopyLink.TabStop = false;
            this.picCopyLink.MouseEnter += new System.EventHandler(this.picCopyLink_MouseEnter);
            this.picCopyLink.MouseLeave += new System.EventHandler(this.picCopyLink_MouseLeave);
            // 
            // picMove
            // 
            this.picMove.BackColor = System.Drawing.SystemColors.Control;
            this.picMove.Image = global::Drive.Properties.Resources.move;
            this.picMove.Location = new System.Drawing.Point(266, 6);
            this.picMove.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picMove.Name = "picMove";
            this.picMove.Size = new System.Drawing.Size(22, 20);
            this.picMove.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picMove.TabIndex = 11;
            this.picMove.TabStop = false;
            this.picMove.MouseEnter += new System.EventHandler(this.picMove_MouseEnter);
            this.picMove.MouseLeave += new System.EventHandler(this.picMove_MouseLeave);
            // 
            // picDownload
            // 
            this.picDownload.BackColor = System.Drawing.SystemColors.Control;
            this.picDownload.Image = global::Drive.Properties.Resources.download;
            this.picDownload.Location = new System.Drawing.Point(209, 6);
            this.picDownload.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picDownload.Name = "picDownload";
            this.picDownload.Size = new System.Drawing.Size(22, 20);
            this.picDownload.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picDownload.TabIndex = 10;
            this.picDownload.TabStop = false;
            this.picDownload.Click += new System.EventHandler(this.picDownload_Click);
            this.picDownload.MouseEnter += new System.EventHandler(this.picDownload_MouseEnter);
            this.picDownload.MouseLeave += new System.EventHandler(this.picDownload_MouseLeave);
            // 
            // picShared
            // 
            this.picShared.BackColor = System.Drawing.SystemColors.Control;
            this.picShared.Image = global::Drive.Properties.Resources.add;
            this.picShared.Location = new System.Drawing.Point(152, 6);
            this.picShared.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picShared.Name = "picShared";
            this.picShared.Size = new System.Drawing.Size(22, 20);
            this.picShared.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picShared.TabIndex = 9;
            this.picShared.TabStop = false;
            this.picShared.MouseEnter += new System.EventHandler(this.picShared_MouseEnter);
            this.picShared.MouseLeave += new System.EventHandler(this.picShared_MouseLeave);
            // 
            // picClose
            // 
            this.picClose.BackColor = System.Drawing.SystemColors.Control;
            this.picClose.Image = global::Drive.Properties.Resources.close;
            this.picClose.Location = new System.Drawing.Point(12, 8);
            this.picClose.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picClose.Name = "picClose";
            this.picClose.Size = new System.Drawing.Size(18, 16);
            this.picClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picClose.TabIndex = 7;
            this.picClose.TabStop = false;
            this.picClose.Click += new System.EventHandler(this.picClose_Click);
            this.picClose.MouseEnter += new System.EventHandler(this.picClose_MouseEnter);
            this.picClose.MouseLeave += new System.EventHandler(this.picClose_MouseLeave);
            // 
            // picList
            // 
            this.picList.BackColor = System.Drawing.Color.White;
            this.picList.Image = global::Drive.Properties.Resources.menu;
            this.picList.Location = new System.Drawing.Point(15, 6);
            this.picList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picList.Name = "picList";
            this.picList.Size = new System.Drawing.Size(22, 20);
            this.picList.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picList.TabIndex = 5;
            this.picList.TabStop = false;
            // 
            // picGrid
            // 
            this.picGrid.BackColor = System.Drawing.Color.White;
            this.picGrid.Image = global::Drive.Properties.Resources.tiles;
            this.picGrid.Location = new System.Drawing.Point(15, 6);
            this.picGrid.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picGrid.Name = "picGrid";
            this.picGrid.Size = new System.Drawing.Size(22, 20);
            this.picGrid.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picGrid.TabIndex = 5;
            this.picGrid.TabStop = false;
            // 
            // picFolder
            // 
            this.picFolder.BackColor = System.Drawing.Color.White;
            this.picFolder.Image = global::Drive.Properties.Resources.folder;
            this.picFolder.Location = new System.Drawing.Point(16, 6);
            this.picFolder.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picFolder.Name = "picFolder";
            this.picFolder.Size = new System.Drawing.Size(22, 20);
            this.picFolder.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picFolder.TabIndex = 5;
            this.picFolder.TabStop = false;
            // 
            // picFile
            // 
            this.picFile.BackColor = System.Drawing.Color.White;
            this.picFile.Image = global::Drive.Properties.Resources.tick;
            this.picFile.Location = new System.Drawing.Point(31, 6);
            this.picFile.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picFile.Name = "picFile";
            this.picFile.Size = new System.Drawing.Size(22, 20);
            this.picFile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picFile.TabIndex = 5;
            this.picFile.TabStop = false;
            // 
            // uctHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.pnFunctions);
            this.Controls.Add(this.pnHeader);
            this.Controls.Add(this.pnContentList);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pnContentGrid);
            this.Controls.Add(this.pnList);
            this.Controls.Add(this.pnGrid);
            this.Controls.Add(this.pnFolder);
            this.Controls.Add(this.pnFile);
            this.Controls.Add(this.lblRecommend);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "uctHome";
            this.Size = new System.Drawing.Size(747, 496);
            this.Load += new System.EventHandler(this.uctHome_Load);
            this.pnList.ResumeLayout(false);
            this.pnGrid.ResumeLayout(false);
            this.pnFolder.ResumeLayout(false);
            this.pnFolder.PerformLayout();
            this.pnFile.ResumeLayout(false);
            this.pnFile.PerformLayout();
            this.pnHeader.ResumeLayout(false);
            this.pnHeader.PerformLayout();
            this.pnFunctions.ResumeLayout(false);
            this.pnFunctions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMore)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDelete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCopyLink)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMove)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDownload)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picShared)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFolder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFile)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel pnContentGrid;
        private System.Windows.Forms.Panel pnList;
        private System.Windows.Forms.PictureBox picList;
        private System.Windows.Forms.Panel pnGrid;
        private System.Windows.Forms.PictureBox picGrid;
        private System.Windows.Forms.Panel pnFolder;
        private System.Windows.Forms.Label lblFolder;
        private System.Windows.Forms.PictureBox picFolder;
        private System.Windows.Forms.Panel pnFile;
        private System.Windows.Forms.Label lblFile;
        private System.Windows.Forms.PictureBox picFile;
        private System.Windows.Forms.Label lblRecommend;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel pnContentList;
        private System.Windows.Forms.Panel pnHeader;
        private System.Windows.Forms.Label lblReasonRecommend;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblOwner;
        private System.Windows.Forms.Panel pnFunctions;
        private System.Windows.Forms.Label lblNotice;
        private System.Windows.Forms.PictureBox picClose;
        private System.Windows.Forms.PictureBox picMore;
        private System.Windows.Forms.PictureBox picDelete;
        private System.Windows.Forms.PictureBox picCopyLink;
        private System.Windows.Forms.PictureBox picMove;
        private System.Windows.Forms.PictureBox picDownload;
        private System.Windows.Forms.PictureBox picShared;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
