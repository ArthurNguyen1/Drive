using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using static System.Net.Mime.MediaTypeNames;

namespace Drive
{
    public partial class FormMain : Form
    {
        #region Define
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        #endregion

        //DataTable dtFiles = null;

        uctHome Home = new uctHome();

        public FormMain()
        {
            InitializeComponent();
            //dtFiles = new DataTable();

            this.Controls.Add(Home);
            Home.Location = new Point(187, 65);
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            ClassData.loaddata();
            Reset();
            pnNew.Visible = false;

            Home.Visible = true;
            //ClassData.dtInUse = ClassData.dtFile.AsEnumerable().Where(dr => dr.Field<string>("type") != "folder").CopyToDataTable();
            Home.LoadDataDown(ClassData.dtFile);

            pnHome.BackColor = Color.LightSkyBlue;
            picHome.BackColor = Color.LightSkyBlue;
        }

        void Reset()
        {
            pnHome.BackColor = Color.WhiteSmoke;
            picHome.BackColor = Color.WhiteSmoke;


            Home.Visible = false;

            //dtLoves = ClassData.dtSong.Select("love=true").CopyToDataTable();
            //dtRecents = ClassData.dtSong.Select("play=true").CopyToDataTable();
            //dtMusics = ClassData.dtSong.Copy();
        }

        private void pnHome_Click(object sender, EventArgs e)
        {
            Reset();
            Home.Visible = true;
            //if (ClassData.dtSong.Select("play=true").Length > 0)
            //{
            //    dtRecents = ClassData.dtSong.Select("play=true").CopyToDataTable();
            //}
            //Recents.LoadDataDown(dtRecents);
            pnHome.BackColor = Color.LightSkyBlue;
            picHome.BackColor = Color.LightSkyBlue;
        }

        private void lblHome_Click(object sender, EventArgs e)
        {
            Reset();
            Home.Visible = true;
            pnHome.BackColor = Color.LightSkyBlue;
            picHome.BackColor = Color.LightSkyBlue;
        }

        private void picHome_Click(object sender, EventArgs e)
        {
            Reset();
            Home.Visible = true;
            pnHome.BackColor = Color.LightSkyBlue;
            picHome.BackColor = Color.LightSkyBlue;
        }

        
        private void btnNew_Click(object sender, EventArgs e)
        {
            pnNew.Visible = true;
        }

        private void pnFunction_Click(object sender, EventArgs e)
        {
            pnNew.Visible = false;
        }

        private void pnUploadFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog f = new OpenFileDialog();
            f.Multiselect = true;
            if (f.ShowDialog() == DialogResult.OK)
            {
                string[] st = f.FileNames;
                for (int i = 0; i < st.Length; i++)
                {
                    FileInfo fi = new FileInfo(st[i]);
                    string s = "DriveData\\file\\" + Path.GetFileName(st[i]);
                    FileInfo fii = new FileInfo(s);
                    if (!fii.Exists)
                    {
                        fi.CopyTo(s);
                    }

                    string pathDataFile = "DriveData\\data\\File.txt";
                    string fileName = fii.Name.Substring(0, fii.Name.Length - 5);
                    StreamWriter sw = new StreamWriter(pathDataFile, true);
                    sw.WriteLine(ClassData.nextFileID.ToString() + "*" +
                             "1000" + "*" +
                             fii.Extension + "*" +
                             fileName + "*" +
                             DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss tt") + "*" +
                             ClassData.currentFolderID.ToString() + "*" +
                             "False" + "*" +
                             "False");
                    sw.Close();

                    ClassData.nextFileID++;
                }
            }

            ClassData.reloaddata();
            Home.LoadDataFile();
            pnNew.Visible = false;
        }

        private void DragWindow(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void pnUploadFile_MouseEnter(object sender, EventArgs e)
        {
            pnUploadFile.BackColor = Color.LightSkyBlue;
            picUploadFile.BackColor = Color.LightSkyBlue;
        }

        private void pnUploadFile_MouseLeave(object sender, EventArgs e)
        {
            pnUploadFile.BackColor = Color.White;
            picUploadFile.BackColor = Color.White;
        }

        private void pnNewFolder_MouseEnter(object sender, EventArgs e)
        {
            pnNewFolder.BackColor = Color.LightSkyBlue;
            picNewFolder.BackColor = Color.LightSkyBlue;
        }

        private void pnNewFolder_MouseLeave(object sender, EventArgs e)
        {
            pnNewFolder.BackColor = Color.White;
            picNewFolder.BackColor = Color.White;
        }

        private void pnUploadFolder_MouseEnter(object sender, EventArgs e)
        {
            pnUploadFolder.BackColor = Color.LightSkyBlue; ;
            picUploadFolder.BackColor = Color.LightSkyBlue; ;
        }

        private void pnUploadFolder_MouseLeave(object sender, EventArgs e)
        {
            pnUploadFolder.BackColor = Color.White;
            picUploadFolder.BackColor = Color.White;
        }

        private void pnNewFolder_Click(object sender, EventArgs e)
        {
            string pathDataFolder = "DriveData\\data\\Folder.txt";
            StreamWriter sw = new StreamWriter(pathDataFolder, true);
            sw.WriteLine(ClassData.nextFolderID.ToString() + "*" +
                     "1000" + "*" +
                     "folder" + "*" +
                     "New Folder" + "*" +
                     DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss tt") + "*" +
                     ClassData.currentFolderID.ToString() + "*" +
                     "False" + "*" +
                     "False");
            sw.Close();

            ClassData.nextFolderID++;

            ClassData.reloaddata();
            Home.FolderAdd();
            Home.LoadDataFolder();

            pnNew.Visible = false;
        }
    }
}
