namespace Drive
{
    partial class uctTrash
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
            this.lblName = new System.Windows.Forms.Label();
            this.pnHeader = new System.Windows.Forms.Panel();
            this.lblSize = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.pnContentList = new System.Windows.Forms.FlowLayoutPanel();
            this.pnGrid = new System.Windows.Forms.Panel();
            this.picGrid = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pnContentGrid = new System.Windows.Forms.FlowLayoutPanel();
            this.pnList = new System.Windows.Forms.Panel();
            this.picList = new System.Windows.Forms.PictureBox();
            this.cbType = new System.Windows.Forms.ComboBox();
            this.cbRecent = new System.Windows.Forms.ComboBox();
            this.pnFunctions = new System.Windows.Forms.Panel();
            this.picDelete = new System.Windows.Forms.PictureBox();
            this.picRecover = new System.Windows.Forms.PictureBox();
            this.lblNotice = new System.Windows.Forms.Label();
            this.picClose = new System.Windows.Forms.PictureBox();
            this.pnHeader.SuspendLayout();
            this.pnGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picGrid)).BeginInit();
            this.pnList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picList)).BeginInit();
            this.pnFunctions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picDelete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRecover)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picClose)).BeginInit();
            this.SuspendLayout();
            // 
            // lblOwner
            // 
            this.lblOwner.AutoSize = true;
            this.lblOwner.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOwner.Location = new System.Drawing.Point(328, 10);
            this.lblOwner.Name = "lblOwner";
            this.lblOwner.Size = new System.Drawing.Size(100, 20);
            this.lblOwner.TabIndex = 2;
            this.lblOwner.Text = "Chủ sở hữu";
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
            this.pnHeader.Controls.Add(this.lblSize);
            this.pnHeader.Controls.Add(this.lblDate);
            this.pnHeader.Controls.Add(this.lblOwner);
            this.pnHeader.Controls.Add(this.lblName);
            this.pnHeader.Location = new System.Drawing.Point(15, 100);
            this.pnHeader.Name = "pnHeader";
            this.pnHeader.Size = new System.Drawing.Size(816, 42);
            this.pnHeader.TabIndex = 29;
            // 
            // lblSize
            // 
            this.lblSize.AutoSize = true;
            this.lblSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSize.Location = new System.Drawing.Point(678, 10);
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(98, 20);
            this.lblSize.TabIndex = 4;
            this.lblSize.Text = "Kích cỡ tệp";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(506, 10);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(49, 20);
            this.lblDate.TabIndex = 3;
            this.lblDate.Text = "Ngày";
            // 
            // pnContentList
            // 
            this.pnContentList.AutoScroll = true;
            this.pnContentList.Location = new System.Drawing.Point(15, 142);
            this.pnContentList.Name = "pnContentList";
            this.pnContentList.Size = new System.Drawing.Size(816, 475);
            this.pnContentList.TabIndex = 27;
            // 
            // pnGrid
            // 
            this.pnGrid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnGrid.Controls.Add(this.picGrid);
            this.pnGrid.Location = new System.Drawing.Point(772, 46);
            this.pnGrid.Name = "pnGrid";
            this.pnGrid.Size = new System.Drawing.Size(59, 42);
            this.pnGrid.TabIndex = 24;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 25);
            this.label1.TabIndex = 28;
            this.label1.Text = "Thùng rác";
            // 
            // pnContentGrid
            // 
            this.pnContentGrid.AutoScroll = true;
            this.pnContentGrid.Location = new System.Drawing.Point(28, 94);
            this.pnContentGrid.Name = "pnContentGrid";
            this.pnContentGrid.Size = new System.Drawing.Size(787, 493);
            this.pnContentGrid.TabIndex = 26;
            // 
            // pnList
            // 
            this.pnList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnList.Controls.Add(this.picList);
            this.pnList.Location = new System.Drawing.Point(713, 46);
            this.pnList.Name = "pnList";
            this.pnList.Size = new System.Drawing.Size(59, 42);
            this.pnList.TabIndex = 25;
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
            // cbType
            // 
            this.cbType.BackColor = System.Drawing.Color.White;
            this.cbType.FormattingEnabled = true;
            this.cbType.Items.AddRange(new object[] {
            "Tài liệu",
            "Bảng tính",
            "Bản trình bày",
            "PDF"});
            this.cbType.Location = new System.Drawing.Point(15, 51);
            this.cbType.Name = "cbType";
            this.cbType.Size = new System.Drawing.Size(121, 28);
            this.cbType.TabIndex = 0;
            this.cbType.Text = "  Loại";
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
            this.cbRecent.Location = new System.Drawing.Point(142, 51);
            this.cbRecent.Name = "cbRecent";
            this.cbRecent.Size = new System.Drawing.Size(225, 28);
            this.cbRecent.TabIndex = 30;
            this.cbRecent.Text = " Lần sửa đổi gần đây nhất";
            // 
            // pnFunctions
            // 
            this.pnFunctions.BackColor = System.Drawing.SystemColors.Control;
            this.pnFunctions.Controls.Add(this.picDelete);
            this.pnFunctions.Controls.Add(this.picRecover);
            this.pnFunctions.Controls.Add(this.lblNotice);
            this.pnFunctions.Controls.Add(this.picClose);
            this.pnFunctions.Location = new System.Drawing.Point(15, 46);
            this.pnFunctions.Name = "pnFunctions";
            this.pnFunctions.Size = new System.Drawing.Size(812, 42);
            this.pnFunctions.TabIndex = 31;
            // 
            // picDelete
            // 
            this.picDelete.BackColor = System.Drawing.SystemColors.Control;
            this.picDelete.Image = global::Drive.Properties.Resources.trash;
            this.picDelete.Location = new System.Drawing.Point(235, 8);
            this.picDelete.Name = "picDelete";
            this.picDelete.Size = new System.Drawing.Size(25, 25);
            this.picDelete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picDelete.TabIndex = 10;
            this.picDelete.TabStop = false;
            this.picDelete.Click += new System.EventHandler(this.picDelete_Click);
            this.picDelete.MouseEnter += new System.EventHandler(this.picDelete_MouseEnter);
            this.picDelete.MouseLeave += new System.EventHandler(this.picDelete_MouseLeave);
            // 
            // picRecover
            // 
            this.picRecover.BackColor = System.Drawing.SystemColors.Control;
            this.picRecover.Image = global::Drive.Properties.Resources.recent;
            this.picRecover.Location = new System.Drawing.Point(171, 8);
            this.picRecover.Name = "picRecover";
            this.picRecover.Size = new System.Drawing.Size(25, 25);
            this.picRecover.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picRecover.TabIndex = 9;
            this.picRecover.TabStop = false;
            this.picRecover.Click += new System.EventHandler(this.picRecover_Click);
            this.picRecover.MouseEnter += new System.EventHandler(this.picRecover_MouseEnter);
            this.picRecover.MouseLeave += new System.EventHandler(this.picRecover_MouseLeave);
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
            // uctTrash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.pnFunctions);
            this.Controls.Add(this.cbRecent);
            this.Controls.Add(this.cbType);
            this.Controls.Add(this.pnHeader);
            this.Controls.Add(this.pnContentList);
            this.Controls.Add(this.pnGrid);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pnContentGrid);
            this.Controls.Add(this.pnList);
            this.Name = "uctTrash";
            this.Size = new System.Drawing.Size(840, 620);
            this.Load += new System.EventHandler(this.uctTrash_Load);
            this.pnHeader.ResumeLayout(false);
            this.pnHeader.PerformLayout();
            this.pnGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picGrid)).EndInit();
            this.pnList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picList)).EndInit();
            this.pnFunctions.ResumeLayout(false);
            this.pnFunctions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picDelete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRecover)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picClose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblOwner;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Panel pnHeader;
        private System.Windows.Forms.FlowLayoutPanel pnContentList;
        private System.Windows.Forms.PictureBox picGrid;
        private System.Windows.Forms.Panel pnGrid;
        private System.Windows.Forms.PictureBox picList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel pnContentGrid;
        private System.Windows.Forms.Panel pnList;
        private System.Windows.Forms.Label lblSize;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.ComboBox cbType;
        private System.Windows.Forms.ComboBox cbRecent;
        private System.Windows.Forms.Panel pnFunctions;
        private System.Windows.Forms.PictureBox picDelete;
        private System.Windows.Forms.PictureBox picRecover;
        private System.Windows.Forms.Label lblNotice;
        private System.Windows.Forms.PictureBox picClose;
    }
}
