namespace Drive
{
    partial class uctMoveFolder
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
            this.lblName = new Drive.CustomControl.TransparentTxb();
            this.picType = new System.Windows.Forms.PictureBox();
            this.picOption = new System.Windows.Forms.PictureBox();
            this.lblMove = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picOption)).BeginInit();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.BackColor = System.Drawing.Color.Transparent;
            this.lblName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblName.CausesValidation = false;
            this.lblName.ForeColor = System.Drawing.SystemColors.MenuText;
            this.lblName.Location = new System.Drawing.Point(35, 12);
            this.lblName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lblName.Name = "lblName";
            this.lblName.ReadOnly = true;
            this.lblName.Size = new System.Drawing.Size(189, 19);
            this.lblName.TabIndex = 11;
            this.lblName.Text = "Tên";
            this.lblName.WordWrap = false;
            // 
            // picType
            // 
            this.picType.Image = global::Drive.Properties.Resources.folder__1_;
            this.picType.Location = new System.Drawing.Point(3, 7);
            this.picType.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picType.Name = "picType";
            this.picType.Size = new System.Drawing.Size(25, 25);
            this.picType.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picType.TabIndex = 10;
            this.picType.TabStop = false;
            // 
            // picOption
            // 
            this.picOption.Image = global::Drive.Properties.Resources.three_dots__1_;
            this.picOption.Location = new System.Drawing.Point(688, 7);
            this.picOption.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picOption.Name = "picOption";
            this.picOption.Size = new System.Drawing.Size(25, 25);
            this.picOption.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picOption.TabIndex = 12;
            this.picOption.TabStop = false;
            // 
            // lblMove
            // 
            this.lblMove.AutoSize = true;
            this.lblMove.Location = new System.Drawing.Point(581, 11);
            this.lblMove.Name = "lblMove";
            this.lblMove.Size = new System.Drawing.Size(79, 20);
            this.lblMove.TabIndex = 13;
            this.lblMove.Text = "Di chuyển";
            this.lblMove.Click += new System.EventHandler(this.lblMove_Click);
            // 
            // uctMoveFolder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.lblMove);
            this.Controls.Add(this.picOption);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.picType);
            this.Name = "uctMoveFolder";
            this.Size = new System.Drawing.Size(750, 42);
            this.Load += new System.EventHandler(this.uctMoveFolder_Load);
            this.Click += new System.EventHandler(this.uctMoveFolder_Click);
            ((System.ComponentModel.ISupportInitialize)(this.picType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picOption)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public CustomControl.TransparentTxb lblName;
        private System.Windows.Forms.PictureBox picType;
        private System.Windows.Forms.PictureBox picOption;
        private System.Windows.Forms.Label lblMove;
    }
}
