namespace Drive
{
    partial class ucFolder
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
            this.lblName = new System.Windows.Forms.Label();
            this.picOption = new System.Windows.Forms.PictureBox();
            this.picType = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picOption)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picType)).BeginInit();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(40, 20);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(36, 20);
            this.lblName.TabIndex = 7;
            this.lblName.Text = "Tên";
            // 
            // picOption
            // 
            this.picOption.Image = global::Drive.Properties.Resources.three_dots__1_;
            this.picOption.Location = new System.Drawing.Point(231, 15);
            this.picOption.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picOption.Name = "picOption";
            this.picOption.Size = new System.Drawing.Size(25, 25);
            this.picOption.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picOption.TabIndex = 9;
            this.picOption.TabStop = false;
            // 
            // picType
            // 
            this.picType.Image = global::Drive.Properties.Resources.folder__1_;
            this.picType.Location = new System.Drawing.Point(9, 16);
            this.picType.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picType.Name = "picType";
            this.picType.Size = new System.Drawing.Size(25, 25);
            this.picType.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picType.TabIndex = 8;
            this.picType.TabStop = false;
            // 
            // ucFolder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.picOption);
            this.Controls.Add(this.picType);
            this.Controls.Add(this.lblName);
            this.Name = "ucFolder";
            this.Size = new System.Drawing.Size(270, 60);
            this.Load += new System.EventHandler(this.ucFolder_Load);
            this.Click += new System.EventHandler(this.ucFolder_Click);
            this.DoubleClick += new System.EventHandler(this.ucFolder_DoubleClick);
            this.MouseEnter += new System.EventHandler(this.ucFolder_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.ucFolder_MouseLeave);
            ((System.ComponentModel.ISupportInitialize)(this.picOption)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picType)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picType;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.PictureBox picOption;
    }
}
