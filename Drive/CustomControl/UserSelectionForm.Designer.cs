namespace Drive.CustomControl
{
    partial class UserSelectionForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textBoxCustom1 = new Drive.CustomControl.TextBoxCustom();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(153, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "User Email";
            // 
            // btnOK
            // 
            this.btnOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOK.Location = new System.Drawing.Point(345, 180);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 41);
            this.btnOK.TabIndex = 3;
            this.btnOK.Text = "Share";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(264, 180);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 41);
            this.button2.TabIndex = 4;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBoxCustom1
            // 
            this.textBoxCustom1.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxCustom1.BorderColor = System.Drawing.Color.Black;
            this.textBoxCustom1.BorderFocusColor = System.Drawing.Color.Silver;
            this.textBoxCustom1.BorderRadius = 0;
            this.textBoxCustom1.BorderSize = 2;
            this.textBoxCustom1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCustom1.ForeColor = System.Drawing.Color.DimGray;
            this.textBoxCustom1.Location = new System.Drawing.Point(34, 80);
            this.textBoxCustom1.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxCustom1.Multiline = true;
            this.textBoxCustom1.Name = "textBoxCustom1";
            this.textBoxCustom1.Padding = new System.Windows.Forms.Padding(7);
            this.textBoxCustom1.PasswordChar = false;
            this.textBoxCustom1.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.textBoxCustom1.PlaceholderText = "";
            this.textBoxCustom1.ReadOnly = false;
            this.textBoxCustom1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            this.textBoxCustom1.SelectionColor = System.Drawing.Color.Yellow;
            this.textBoxCustom1.Size = new System.Drawing.Size(386, 47);
            this.textBoxCustom1.TabIndex = 2;
            this.textBoxCustom1.Texts = "";
            this.textBoxCustom1.UnderlinedStyle = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Firebrick;
            this.label2.Location = new System.Drawing.Point(266, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Người dùng không tồn tại";
            this.label2.Visible = false;
            // 
            // UserSelectionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 278);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.textBoxCustom1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UserSelectionForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UserSelectionForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private TextBoxCustom textBoxCustom1;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
    }
}