namespace Drive
{
    partial class uctMyDrive
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
            this.pnGrid = new System.Windows.Forms.Panel();
            this.lblName = new System.Windows.Forms.Label();
            this.pnContentGridFile = new System.Windows.Forms.FlowLayoutPanel();
            this.pnList = new System.Windows.Forms.Panel();
            this.cbRecent = new System.Windows.Forms.ComboBox();
            this.cbType = new System.Windows.Forms.ComboBox();
            this.cbUsers = new System.Windows.Forms.ComboBox();
            this.pnFunctions = new System.Windows.Forms.Panel();
            this.lblNotice = new System.Windows.Forms.Label();
            this.pnContentGridFolder = new System.Windows.Forms.FlowLayoutPanel();
            this.lblFolder = new System.Windows.Forms.Label();
            this.lblFile = new System.Windows.Forms.Label();
            this.pnHeader = new System.Windows.Forms.Panel();
            this.lblOwner = new System.Windows.Forms.Label();
            this.lblReasonRecommend = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pnContentList = new System.Windows.Forms.FlowLayoutPanel();
            this.picMore = new System.Windows.Forms.PictureBox();
            this.picDelete = new System.Windows.Forms.PictureBox();
            this.picCopyLink = new System.Windows.Forms.PictureBox();
            this.picMove = new System.Windows.Forms.PictureBox();
            this.picDownload = new System.Windows.Forms.PictureBox();
            this.picShared = new System.Windows.Forms.PictureBox();
            this.picClose = new System.Windows.Forms.PictureBox();
            this.picGrid = new System.Windows.Forms.PictureBox();
            this.picList = new System.Windows.Forms.PictureBox();
            this.pnGrid.SuspendLayout();
            this.pnList.SuspendLayout();
            this.pnFunctions.SuspendLayout();
            this.pnHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMore)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDelete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCopyLink)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMove)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDownload)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picShared)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picList)).BeginInit();
            this.SuspendLayout();
            // 
            // pnGrid
            // 
            this.pnGrid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnGrid.Controls.Add(this.picGrid);
            this.pnGrid.Location = new System.Drawing.Point(772, 46);
            this.pnGrid.Name = "pnGrid";
            this.pnGrid.Size = new System.Drawing.Size(59, 42);
            this.pnGrid.TabIndex = 24;
            this.pnGrid.Click += new System.EventHandler(this.pnGrid_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(10, 13);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(119, 25);
            this.lblName.TabIndex = 28;
            this.lblName.Text = "Drive của tôi";
            // 
            // pnContentGridFile
            // 
            this.pnContentGridFile.AutoScroll = true;
            this.pnContentGridFile.Location = new System.Drawing.Point(3, 292);
            this.pnContentGridFile.Name = "pnContentGridFile";
            this.pnContentGridFile.Size = new System.Drawing.Size(834, 295);
            this.pnContentGridFile.TabIndex = 26;
            // 
            // pnList
            // 
            this.pnList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnList.Controls.Add(this.picList);
            this.pnList.Location = new System.Drawing.Point(713, 46);
            this.pnList.Name = "pnList";
            this.pnList.Size = new System.Drawing.Size(59, 42);
            this.pnList.TabIndex = 25;
            this.pnList.Click += new System.EventHandler(this.pnList_Click);
            // 
            // cbRecent
            // 
            this.cbRecent.BackColor = System.Drawing.Color.White;
            this.cbRecent.FormattingEnabled = true;
            this.cbRecent.Items.AddRange(new object[] {
            "Hôm nay",
            "7 ngày qua",
            "30 ngày qua",
            "Năm nay (2024)",
            "Năm ngoái (2023)"});
            this.cbRecent.Location = new System.Drawing.Point(269, 54);
            this.cbRecent.Name = "cbRecent";
            this.cbRecent.Size = new System.Drawing.Size(225, 28);
            this.cbRecent.TabIndex = 32;
            this.cbRecent.Text = " Lần sửa đổi gần đây nhất";
            // 
            // cbType
            // 
            this.cbType.BackColor = System.Drawing.Color.White;
            this.cbType.FormattingEnabled = true;
            this.cbType.Items.AddRange(new object[] {
            "Tài liệu",
            "Bảng tính",
            "Bản trình bày",
            "PDF"});
            this.cbType.Location = new System.Drawing.Point(15, 54);
            this.cbType.Name = "cbType";
            this.cbType.Size = new System.Drawing.Size(121, 28);
            this.cbType.TabIndex = 31;
            this.cbType.Text = "  Loại";
            // 
            // cbUsers
            // 
            this.cbUsers.BackColor = System.Drawing.Color.White;
            this.cbUsers.FormattingEnabled = true;
            this.cbUsers.Items.AddRange(new object[] {
            "Tài liệu",
            "Bảng tính",
            "Bản trình bày",
            "PDF"});
            this.cbUsers.Location = new System.Drawing.Point(142, 54);
            this.cbUsers.Name = "cbUsers";
            this.cbUsers.Size = new System.Drawing.Size(121, 28);
            this.cbUsers.TabIndex = 33;
            this.cbUsers.Text = "  Người";
            // 
            // pnFunctions
            // 
            this.pnFunctions.BackColor = System.Drawing.SystemColors.Control;
            this.pnFunctions.Controls.Add(this.picMore);
            this.pnFunctions.Controls.Add(this.picDelete);
            this.pnFunctions.Controls.Add(this.picCopyLink);
            this.pnFunctions.Controls.Add(this.picMove);
            this.pnFunctions.Controls.Add(this.picDownload);
            this.pnFunctions.Controls.Add(this.picShared);
            this.pnFunctions.Controls.Add(this.lblNotice);
            this.pnFunctions.Controls.Add(this.picClose);
            this.pnFunctions.Location = new System.Drawing.Point(15, 44);
            this.pnFunctions.Name = "pnFunctions";
            this.pnFunctions.Size = new System.Drawing.Size(812, 42);
            this.pnFunctions.TabIndex = 34;
            // 
            // lblNotice
            // 
            this.lblNotice.AutoSize = true;
            this.lblNotice.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNotice.Location = new System.Drawing.Point(38, 10);
            this.lblNotice.Name = "lblNotice";
            this.lblNotice.Size = new System.Drawing.Size(116, 20);
            this.lblNotice.TabIndex = 8;
            this.lblNotice.Text = "Đã chọn 1 mục";
            // 
            // pnContentGridFolder
            // 
            this.pnContentGridFolder.AutoScroll = true;
            this.pnContentGridFolder.Location = new System.Drawing.Point(3, 120);
            this.pnContentGridFolder.Name = "pnContentGridFolder";
            this.pnContentGridFolder.Size = new System.Drawing.Size(834, 130);
            this.pnContentGridFolder.TabIndex = 27;
            // 
            // lblFolder
            // 
            this.lblFolder.AutoSize = true;
            this.lblFolder.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFolder.Location = new System.Drawing.Point(3, 92);
            this.lblFolder.Name = "lblFolder";
            this.lblFolder.Size = new System.Drawing.Size(89, 25);
            this.lblFolder.TabIndex = 35;
            this.lblFolder.Text = "Thư mục";
            // 
            // lblFile
            // 
            this.lblFile.AutoSize = true;
            this.lblFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFile.Location = new System.Drawing.Point(3, 264);
            this.lblFile.Name = "lblFile";
            this.lblFile.Size = new System.Drawing.Size(47, 25);
            this.lblFile.TabIndex = 36;
            this.lblFile.Text = "Tệp";
            // 
            // pnHeader
            // 
            this.pnHeader.Controls.Add(this.lblOwner);
            this.pnHeader.Controls.Add(this.lblReasonRecommend);
            this.pnHeader.Controls.Add(this.label1);
            this.pnHeader.Location = new System.Drawing.Point(15, 100);
            this.pnHeader.Name = "pnHeader";
            this.pnHeader.Size = new System.Drawing.Size(816, 42);
            this.pnHeader.TabIndex = 38;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên";
            // 
            // pnContentList
            // 
            this.pnContentList.AutoScroll = true;
            this.pnContentList.Location = new System.Drawing.Point(15, 142);
            this.pnContentList.Name = "pnContentList";
            this.pnContentList.Size = new System.Drawing.Size(816, 475);
            this.pnContentList.TabIndex = 37;
            // 
            // picMore
            // 
            this.picMore.BackColor = System.Drawing.SystemColors.Control;
            this.picMore.Image = global::Drive.Properties.Resources.three_dots__1_;
            this.picMore.Location = new System.Drawing.Point(491, 8);
            this.picMore.Name = "picMore";
            this.picMore.Size = new System.Drawing.Size(25, 25);
            this.picMore.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picMore.TabIndex = 14;
            this.picMore.TabStop = false;
            this.picMore.Click += new System.EventHandler(this.picMore_Click);
            this.picMore.MouseEnter += new System.EventHandler(this.picMore_MouseEnter);
            this.picMore.MouseLeave += new System.EventHandler(this.picMore_MouseLeave);
            // 
            // picDelete
            // 
            this.picDelete.BackColor = System.Drawing.SystemColors.Control;
            this.picDelete.Image = global::Drive.Properties.Resources.delete__1_;
            this.picDelete.Location = new System.Drawing.Point(363, 8);
            this.picDelete.Name = "picDelete";
            this.picDelete.Size = new System.Drawing.Size(25, 25);
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
            this.picCopyLink.Location = new System.Drawing.Point(427, 8);
            this.picCopyLink.Name = "picCopyLink";
            this.picCopyLink.Size = new System.Drawing.Size(25, 25);
            this.picCopyLink.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCopyLink.TabIndex = 12;
            this.picCopyLink.TabStop = false;
            this.picCopyLink.Click += new System.EventHandler(this.picCopyLink_Click);
            this.picCopyLink.MouseEnter += new System.EventHandler(this.picCopyLink_MouseEnter);
            this.picCopyLink.MouseLeave += new System.EventHandler(this.picCopyLink_MouseLeave);
            // 
            // picMove
            // 
            this.picMove.BackColor = System.Drawing.SystemColors.Control;
            this.picMove.Image = global::Drive.Properties.Resources.move;
            this.picMove.Location = new System.Drawing.Point(299, 8);
            this.picMove.Name = "picMove";
            this.picMove.Size = new System.Drawing.Size(25, 25);
            this.picMove.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picMove.TabIndex = 11;
            this.picMove.TabStop = false;
            this.picMove.Click += new System.EventHandler(this.picMove_Click);
            this.picMove.MouseEnter += new System.EventHandler(this.picMove_MouseEnter);
            this.picMove.MouseLeave += new System.EventHandler(this.picMove_MouseLeave);
            // 
            // picDownload
            // 
            this.picDownload.BackColor = System.Drawing.SystemColors.Control;
            this.picDownload.Image = global::Drive.Properties.Resources.download;
            this.picDownload.Location = new System.Drawing.Point(235, 8);
            this.picDownload.Name = "picDownload";
            this.picDownload.Size = new System.Drawing.Size(25, 25);
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
            this.picShared.Location = new System.Drawing.Point(171, 8);
            this.picShared.Name = "picShared";
            this.picShared.Size = new System.Drawing.Size(25, 25);
            this.picShared.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picShared.TabIndex = 9;
            this.picShared.TabStop = false;
            this.picShared.Click += new System.EventHandler(this.picShared_Click);
            this.picShared.MouseEnter += new System.EventHandler(this.picShared_MouseEnter);
            this.picShared.MouseLeave += new System.EventHandler(this.picShared_MouseLeave);
            // 
            // picClose
            // 
            this.picClose.BackColor = System.Drawing.SystemColors.Control;
            this.picClose.Image = global::Drive.Properties.Resources.close;
            this.picClose.Location = new System.Drawing.Point(13, 10);
            this.picClose.Name = "picClose";
            this.picClose.Size = new System.Drawing.Size(20, 20);
            this.picClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picClose.TabIndex = 7;
            this.picClose.TabStop = false;
            this.picClose.Click += new System.EventHandler(this.picClose_Click);
            this.picClose.MouseEnter += new System.EventHandler(this.picClose_MouseEnter);
            this.picClose.MouseLeave += new System.EventHandler(this.picClose_MouseLeave);
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
            // uctMyDrive
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.pnHeader);
            this.Controls.Add(this.pnContentList);
            this.Controls.Add(this.lblFile);
            this.Controls.Add(this.lblFolder);
            this.Controls.Add(this.pnContentGridFolder);
            this.Controls.Add(this.pnFunctions);
            this.Controls.Add(this.cbUsers);
            this.Controls.Add(this.cbRecent);
            this.Controls.Add(this.cbType);
            this.Controls.Add(this.pnGrid);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.pnContentGridFile);
            this.Controls.Add(this.pnList);
            this.Name = "uctMyDrive";
            this.Size = new System.Drawing.Size(840, 620);
            this.Load += new System.EventHandler(this.uctMyDrive_Load);
            this.pnGrid.ResumeLayout(false);
            this.pnList.ResumeLayout(false);
            this.pnFunctions.ResumeLayout(false);
            this.pnFunctions.PerformLayout();
            this.pnHeader.ResumeLayout(false);
            this.pnHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMore)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDelete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCopyLink)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMove)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDownload)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picShared)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox picGrid;
        private System.Windows.Forms.Panel pnGrid;
        private System.Windows.Forms.PictureBox picList;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.FlowLayoutPanel pnContentGridFile;
        private System.Windows.Forms.Panel pnList;
        private System.Windows.Forms.ComboBox cbRecent;
        private System.Windows.Forms.ComboBox cbType;
        private System.Windows.Forms.ComboBox cbUsers;
        private System.Windows.Forms.Panel pnFunctions;
        private System.Windows.Forms.PictureBox picMore;
        private System.Windows.Forms.PictureBox picDelete;
        private System.Windows.Forms.PictureBox picCopyLink;
        private System.Windows.Forms.PictureBox picMove;
        private System.Windows.Forms.PictureBox picDownload;
        private System.Windows.Forms.PictureBox picShared;
        private System.Windows.Forms.Label lblNotice;
        private System.Windows.Forms.PictureBox picClose;
        private System.Windows.Forms.FlowLayoutPanel pnContentGridFolder;
        private System.Windows.Forms.Label lblFolder;
        private System.Windows.Forms.Label lblFile;
        private System.Windows.Forms.Panel pnHeader;
        private System.Windows.Forms.Label lblOwner;
        private System.Windows.Forms.Label lblReasonRecommend;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel pnContentList;
    }
}
