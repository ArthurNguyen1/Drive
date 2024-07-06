using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Drive.CustomControl
{
    public partial class UserSelectionForm : Form
    {
        public string selectedUser { get; private set; }

        public UserSelectionForm()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            bool isExist = false;
            string[] userFiles = Directory.GetFiles(System.Windows.Forms.Application.StartupPath + "//Users");
            for (int i = 0; i < userFiles.Length; i++)
            {
                using (var sr = new StreamReader(userFiles[i]))
                {
                    string id = sr.ReadLine(); string email = sr.ReadLine(); string name = sr.ReadLine();
                    if(textBoxCustom1.Texts == email)
                    {
                        if(id == StartForm.userID.ToString())
                        {
                            MessageBox.Show("KHông thể chia sẻ cho chính mình!");
                            return;
                        }
                        else
                        {
                            isExist = true;
                            uctHome.userSharedEmail = email;
                            MessageBox.Show("Đã chia sẻ!");

                            this.Close();
                        }
                    }
                }
            }
            //label2.Visible = true;
            if (!isExist)
            {
                MessageBox.Show("Người dùng không tồn tại!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
