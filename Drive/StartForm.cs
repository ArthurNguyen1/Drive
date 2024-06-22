using Drive.CustomControl;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Reflection.Emit;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Drive
{
    public partial class StartForm : Form
    {
        #region Define
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        #endregion
        public StartForm()
        {
            InitializeComponent();
            pnLogin.Visible = true;
            pnRegister.Visible = false;
            pnReset1.Visible = false;
            pnReset2.Visible = false;
        }

        private void DragWindow(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
       
        #region Sign In Button
        private void HoverSignInButton(object sender, EventArgs e)
        {
            btnSignIn.BackColor = Color.LightSkyBlue;
            btnSignIn.Cursor = Cursors.Hand;
        }

        private void LeaveSignInButton(object sender, EventArgs e)
        {
            btnSignIn.BackColor = Color.DodgerBlue;
            btnSignIn.Cursor = Cursors.Default;

        }
        #endregion

        #region Register Button
        private void HoverRegisterButton(object sender, EventArgs e)
        {
            btnRegis.BackColor = Color.LightSkyBlue;
            btnRegis.Cursor = Cursors.Hand;
        }

        private void LeaveRegisterButton(object sender, EventArgs e)
        {
            btnRegis.BackColor = Color.DodgerBlue;
            btnRegis.Cursor = Cursors.Default;
        }
        #endregion

        //#region Minimize Button
        //private void Minimize(object sender, EventArgs e)
        //{
        //    this.WindowState = FormWindowState.Minimized;
        //}

        //private void HoverMinimizeButton(object sender, EventArgs e)
        //{
        //    btnHide.Cursor = Cursors.Hand;
        //}

        //private void LeaveMinimizeButton(object sender, EventArgs e)
        //{
        //    btnHide.Cursor = Cursors.Default;
        //}
        //#endregion

        #region Change Panel Register and Login
        int OTP = 0;
        bool isAuth = false;
        private void LoadRegisterPanel(object sender, EventArgs e)
        {
            pnLogin.Visible = false;
            pnReset1.Visible = false;
            pnReset2.Visible = false;
            pnRegister.Visible = true;
        }

        private void LoadLoginPage(object sender, EventArgs e)
        {
            pnLogin.Visible = true;
            pnReset1.Visible = false;
            pnReset2.Visible = false;
            pnRegister.Visible = false;
        }
        private void LoadResetPass(object sender, EventArgs e)
        {
            pnLogin.Visible = false;
            pnReset1.Visible = true;
            pnReset2.Visible = false;
            pnRegister.Visible = false;


        }

        #endregion

        #region Function

        string currentEmail = "";
        private void SignIn(object sender, EventArgs e)
        {
            bool isExist = false;
            string[] files = Directory.GetFiles(Application.StartupPath + "//Contacts");
            for (int i = 0; i < files.Length; i++)
            {
                using (var sr = new StreamReader(files[i]))
                {
                    sr.ReadLine(); string ava = sr.ReadLine(); string on = sr.ReadLine(); string name = sr.ReadLine(); string text = sr.ReadLine(); string email = sr.ReadLine();
                    if (txbEmailLogin.Texts == email)
                    {
                        isExist = true;
                        if (txbPwLogin.Texts == sr.ReadLine())
                        {
                            MessageBox.Show("Login successfully", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Hide();

                            FormMain drive = new FormMain();
                            drive.ShowDialog();

                            this.Close();
                            break;
                        }
                        else
                        {
                            MessageBox.Show("Wrong password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            if (!isExist)
            {
                MessageBox.Show("Account does not exist", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SignUp(object sender, EventArgs e)
        {
            string[] files = Directory.GetFiles(Application.StartupPath + "//Contacts");

            StreamWriter sw = new StreamWriter(Application.StartupPath + "\\Contacts\\" + (files.Length + 1).ToString() + ".txt");
            if (txbPwRegis.Texts == txbConfirmRegis.Texts)
            {
                sw.WriteLine((files.Length + 1).ToString());

                //sw.WriteLine("C:/Users/Hoang/Downloads/default.jpg");
                //sw.WriteLine("F:\\Course in University\\C# Programing Languge\\Task\\ChatOnline\\ChatOnline\\Resources\\on.png");
                //sw.WriteLine(txbName.Texts);
                //sw.WriteLine("Newbie");
                //sw.WriteLine(txbEmailRegis.Texts);
                //sw.WriteLine(txbPassReg.Texts);
                MessageBox.Show("Register Successfully", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Confirm password and password are not match", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            sw.Close();

        }

        public void ReplaceLastLine(string filePath, string newLine)
        {
            // Đọc tất cả các dòng từ tệp
            string[] lines = System.IO.File.ReadAllLines(filePath);
            if (System.IO.File.Exists(filePath))
            {
                // Kiểm tra xem có ít nhất một dòng trong tệp không
                Array.Resize(ref lines, lines.Length - 1);

                // Thêm dòng mới vào cuối tệp
                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    foreach (string line in lines)
                    {
                        writer.WriteLine(line);
                    }

                    // Thêm dòng mới vào cuối tệp
                    writer.WriteLine(newLine);
                }
            }
        }

        private void LoadConfirmPage(object sender, EventArgs e)
        {
            currentEmail = txbEmailReset.Texts;
            MailMessage mail = new MailMessage();
            mail.From = new System.Net.Mail.MailAddress("Hoangminh1784@gmail.com");
            SmtpClient smtp = new SmtpClient();
            smtp.Port = 587;
            smtp.EnableSsl = true;
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtp.UseDefaultCredentials = false;
            smtp.Credentials = new NetworkCredential(mail.From.Address, "pjud rpxo elso bufy");
            smtp.Host = "smtp.gmail.com";

            //recipient
            Random random = new Random();
            OTP = random.Next(100000, 999999);

            mail.To.Add(new MailAddress(txbEmailReset.Texts.ToString()));
            mail.IsBodyHtml = true;
            mail.Subject = "SKYPOCK - RESET PASSWORD";
            mail.Body = OTP.ToString();



            smtp.Send(mail);
            MessageBox.Show("Email sent successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            pnLogin.Visible = false;
            a.Visible = false;
            pnReset2.Visible = true;
            pnRegister.Visible = false;

        }

        private void ConfirmOTP(object sender, EventArgs e)
        {
            if (!isAuth)
            {
                if (txbOTP.Texts == OTP.ToString())
                {
                    isAuth = true;
                    lblConfirm.Visible = lblNewPass.Visible = txbConfirmNewPass.Visible = txbNewPass.Visible = true;
                }
                else { MessageBox.Show("Wrong OTP"); }
            }
            else
            {
                if (txbNewPass.Texts == txbOTP.Texts)
                {
                    string path = "";
                    string[] files = Directory.GetFiles(Application.StartupPath + "//Contacts");
                    for (int i = 0; i < files.Length; i++)
                    {
                        using (var sr = new StreamReader(files[i]))
                        {
                            sr.ReadLine(); string ava = sr.ReadLine(); string on = sr.ReadLine(); string name = sr.ReadLine(); string text = sr.ReadLine(); string email = sr.ReadLine();
                            if (txbEmailReset.Texts == email)
                            {
                                path = files[i];
                                sr.Close();
                                break;
                            }
                        }
                    }
                    if (path != "")
                    {
                        ReplaceLastLine(path, txbOTP.Texts);
                        MessageBox.Show("Change password successfully");
                        LoadLoginPage(sender, e);
                    }
                }
                else
                {
                    MessageBox.Show("New password and confirm new password are not match");
                }
            }
        }
        #endregion
    }
}
