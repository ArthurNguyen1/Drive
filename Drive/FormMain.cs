using Microsoft.Office.Interop.Word;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;
using Syncfusion.DocIO.DLS;

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
        uctLaptop Laptop = new uctLaptop();
        uctTrash Trash = new uctTrash();
        uctMyDrive MyDrive = new uctMyDrive();

        public FormMain()
        {
            InitializeComponent();
            ClassData.OnFolderClicked += AddInsideFolderUI;
            ClassData.OnFolderBacked += RemoveInsideFolderUI;

            this.Controls.Add(Home);
            Home.Location = new System.Drawing.Point(187, 65);

            this.Controls.Add(Laptop);
            Laptop.Location = new System.Drawing.Point(187, 65);

            this.Controls.Add(Trash);
            Trash.Location = new System.Drawing.Point(187, 65);

            this.Controls.Add(MyDrive);
            MyDrive.Location = new System.Drawing.Point(187, 65);
        }

        private Stack<ucInsideFolder> history = new Stack<ucInsideFolder>();

        public void Save(ucInsideFolder memento)
        {
            history.Push(memento);
        }

        public ucInsideFolder Undo()
        {
            if (history.Count > 0)
            {
                return history.Pop();
            }

            return null;
        }

        public void AddInsideFolderUI()
        {
            ucInsideFolder insideFolder = new ucInsideFolder();
            this.Controls.Add(insideFolder);
            insideFolder.Location = new System.Drawing.Point(187, 65);
            insideFolder.BringToFront();
            //insideFolder.SetName(ClassData.FolderName);
            
            //Merge 2 tables
            System.Data.DataTable dt1 = ClassData.dtFolder.Copy();
            System.Data.DataTable dt2 = ClassData.dtFile.Copy();

            System.Data.DataTable dtAll = dt1.Copy();
            dtAll.Merge(dt2);

            if (dtAll.AsEnumerable().Where(dr => dr.Field<int>("IDfolderbelong") == ClassData.currentFolderID).Count() == 0)
            {
                dtAll.Rows.Clear();
                dtAll.Rows.Add();
                dtAll.Rows[0]["ID"] = -1;
            }
            else
                dtAll = dtAll.AsEnumerable().Where(dr => dr.Field<int>("IDfolderbelong") == ClassData.currentFolderID).CopyToDataTable();
            
            insideFolder.LoadDataDown(dtAll, ClassData.FolderName);

            Save(insideFolder);
        }

        public void RemoveInsideFolderUI()
        {
            ucInsideFolder insideFolder = Undo();
            this.Controls.Remove(insideFolder);
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            ClassData.loaddata();
            Reset();
            pnNew.Visible = false;
            Laptop.Visible = false;
            Trash.Visible = false;
            MyDrive.Visible = false;

            Home.Visible = true;
            //ClassData.dtInUse = ClassData.dtFile.AsEnumerable().Where(dr => dr.Field<string>("type") != "folder").CopyToDataTable();
            Home.LoadDataDown(ClassData.dtFile/*.AsEnumerable().Where(dr => dr.Field<int>("IDfolderbelong") == ClassData.currentFolderID).CopyToDataTable()*/);

            pnHome.BackColor = Color.LightSkyBlue;
            picHome.BackColor = Color.LightSkyBlue;
        }

        void Reset()
        {
            pnHome.BackColor = Color.WhiteSmoke;
            picHome.BackColor = Color.WhiteSmoke;

            pnMyDrive.BackColor = Color.WhiteSmoke;
            picMyDrive.BackColor = Color.WhiteSmoke;

            pnLaptop.BackColor = Color.WhiteSmoke;
            picLaptop.BackColor = Color.WhiteSmoke;

            pnTrash.BackColor = Color.WhiteSmoke;
            picTrash.BackColor = Color.WhiteSmoke;

            pnShared.BackColor = Color.WhiteSmoke;
            picShared.BackColor = Color.WhiteSmoke;

            pnRecent.BackColor = Color.WhiteSmoke;
            picRecent.BackColor = Color.WhiteSmoke;

            Home.Visible = false;
            Laptop.Visible = false;
            Trash.Visible = false;
            MyDrive.Visible = false;
            //dtLoves = ClassData.dtSong.Select("love=true").CopyToDataTable();
            //dtRecents = ClassData.dtSong.Select("play=true").CopyToDataTable();
            //dtMusics = ClassData.dtSong.Copy();
            
            while(history.Count > 0)
            {
                ucInsideFolder insideFolder = Undo();
                this.Controls.Remove(insideFolder);
            }

            ClassData.isListMode = true;
            ClassData.isDisplayFile = true;
            ClassData.currentFolderID = 0;

            ClassData.PanelClosed();
        }

        private void pnHome_Click(object sender, EventArgs e)
        {
            Reset();
            Home.Visible = true;
            //if (ClassData.dtSong.Select("play=true").Length > 0)
            //{
            //    dtRecents = ClassData.dtSong.Select("play=true").CopyToDataTable();
            //}
            Home.LoadDataDown(ClassData.dtFile/*.AsEnumerable().Where(dr => dr.Field<int>("IDfolderbelong") == ClassData.currentFolderID).CopyToDataTable()*/);
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

                    string pathDataFile = "UserData\\file\\" + StartForm.userID.ToString() + "_file.txt";
                    string fileName = Path.GetFileNameWithoutExtension(st[i]);
                    StreamWriter sw = new StreamWriter(pathDataFile, true);
                    sw.WriteLine(ClassData.nextFileID.ToString() + "*" +
                             "1000" + "*" +
                             fii.Extension + "*" +
                             fileName + "*" +
                             DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss tt") + "*" +
                             ClassData.currentFolderID.ToString() + "*" +
                             "False" + "*" +
                             "False" + "*" + StartForm.userName);
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
            pnUploadFolder.BackColor = Color.LightSkyBlue; 
            picUploadFolder.BackColor = Color.LightSkyBlue; 
        }

        private void pnUploadFolder_MouseLeave(object sender, EventArgs e)
        {
            pnUploadFolder.BackColor = Color.White;
            picUploadFolder.BackColor = Color.White;
        }

        private void pnNewFolder_Click(object sender, EventArgs e)
        {
            string pathDataFolder = ClassData.pathFolder;
            StreamWriter sw = new StreamWriter(pathDataFolder, true);
            sw.WriteLine(ClassData.nextFolderID.ToString() + "*" +
                     "1000" + "*" +
                     "folder" + "*" +
                     "New Folder" + "*" +
                     DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss tt") + "*" +
                     ClassData.currentFolderID.ToString() + "*" +
                     "False" + "*" +
                     "False" + "*" +
                     StartForm.userName);
            sw.Close();

            ClassData.nextFolderID++;

            ClassData.reloaddata();
            Home.FolderAdd();
            Home.LoadDataFolder();

            MyDrive.FolderAdd();
            MyDrive.LoadDataFolder();

            history.Peek().FolderAdd();
            history.Peek().LoadDataFolder();

            pnNew.Visible = false;
        }

        private void pnNewDoc_MouseEnter(object sender, EventArgs e)
        {
            pnNewDoc.BackColor = Color.LightSkyBlue;
            picNewDoc.BackColor = Color.LightSkyBlue;
        }

        private void pnNewDoc_MouseLeave(object sender, EventArgs e)
        {
            pnNewDoc.BackColor = Color.White;
            picNewDoc.BackColor = Color.White;
        }

        private void pnNewDoc_Click(object sender, EventArgs e)
        {
            // Đường dẫn đến thư mục chứa file "New Document" trong thư mục Debug của ứng dụng
            string initialFilePath = Path.Combine(System.Windows.Forms.Application.StartupPath, "DriveData", "file", "New Document.docx");

            // Create a new Word document instance
            WordDocument document = new WordDocument();

            // Adding a section to the document
            IWSection section = document.AddSection();

            // Adding a paragraph to the section
            IWParagraph paragraph = section.AddParagraph();

            // Adding text to the paragraph
            paragraph.AppendText("Hello, this is a simple Word document created using Syncfusion DocIO!");

            // Save the document to the initialFilePath
            try
            {
                document.Save(initialFilePath);

                Console.WriteLine($"Document saved successfully at: {initialFilePath}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error saving document: {ex.Message}");
                // Handle the exception as needed
            }
            finally
            {
                // Close the document instance
                document.Close();
            }

            FileInfo fi = new FileInfo(initialFilePath);
            string s = "DriveData\\file\\" + Path.GetFileName("New Document.docx");
            FileInfo fii = new FileInfo(s);
            if (!fii.Exists)
            {
                fi.CopyTo(s);
            }

            string userDataFilePath = Path.Combine(System.Windows.Forms.Application.StartupPath, "UserData", "file", StartForm.userID + "_file.txt");
            StreamWriter sw = new StreamWriter(userDataFilePath, true);
            sw.WriteLine(ClassData.nextFileID.ToString() + "*" +
                     "1000" + "*" +
                     fii.Extension + "*" +
                     "New Document" + "*" +
                     DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss tt") + "*" +
                     ClassData.currentFolderID.ToString() + "*" +
                     "False" + "*" +
                     "False" + "*" + StartForm.userName);
            sw.Close();

            ClassData.nextFileID++;

            ClassData.reloaddata();
            Home.LoadDataFile();
            pnNew.Visible = false;
        }

        private void pnHome_MouseEnter(object sender, EventArgs e)
        {
            //pnHome.BackColor = Color.LightGray;
            //picHome.BackColor = Color.LightGray;
        }

        private void pnHome_MouseLeave(object sender, EventArgs e)
        {
            //pnHome.BackColor = Color.WhiteSmoke;
            //picHome.BackColor = Color.WhiteSmoke;
        }

        private void pnMyDrive_Click(object sender, EventArgs e)
        {
            Reset();
            MyDrive.Visible = true;

            //Merge 2 tables
            System.Data.DataTable dt1 = ClassData.dtFolder.Copy();
            System.Data.DataTable dt2 = ClassData.dtFile.Copy();

            System.Data.DataTable dtAll = dt1.Copy();
            dtAll.Merge(dt2);

            MyDrive.LoadDataDown(dtAll.AsEnumerable().Where(dr => dr.Field<int>("IDfolderbelong") == ClassData.currentFolderID).CopyToDataTable());
            pnMyDrive.BackColor = Color.LightSkyBlue;
            picMyDrive.BackColor = Color.LightSkyBlue;
        }

        private void pnMyDrive_MouseEnter(object sender, EventArgs e)
        {
            //pnMyDrive.BackColor = Color.LightGray;
            //picMyDrive.BackColor = Color.LightGray;
        }

        private void pnMyDrive_MouseLeave(object sender, EventArgs e)
        {
            //pnMyDrive.BackColor = Color.WhiteSmoke;
            //picMyDrive.BackColor = Color.WhiteSmoke;
        }

        private void pnLaptop_Click(object sender, EventArgs e)
        {
            Reset();
            Laptop.Visible = true;

            Laptop.LoadDataDown(ClassData.dtDownload);
            pnLaptop.BackColor = Color.LightSkyBlue;
            picLaptop.BackColor = Color.LightSkyBlue;
        }

        private void pnLaptop_MouseEnter(object sender, EventArgs e)
        {
            //pnLaptop.BackColor = Color.LightGray;
            //picLaptop.BackColor = Color.WhiteSmoke;
        }

        private void pnLaptop_MouseLeave(object sender, EventArgs e)
        {
            //pnLaptop.BackColor = Color.WhiteSmoke;
            //picLaptop.BackColor = Color.WhiteSmoke;
        }

        private void txtSearching_KeyDown(object sender, KeyEventArgs e)
        {   
            if (e.KeyValue == 13)
            {
                if(txtSearching.Text == "")
                {
                    Home.LoadDataDown(ClassData.dtFile.AsEnumerable().Where(dr => dr.Field<int>("IDfolderbelong") == ClassData.currentFolderID).CopyToDataTable());
                }
                else
                {
                    if(ClassData.isDisplayFile == true)
                    {
                        DataRow[] dt_file = ClassData.dtFile.Select("name LIKE '%" + txtSearching.Text + "%'");
                        if (dt_file.Length > 0)
                        {
                            Home.LoadDataDown(dt_file.CopyToDataTable());
                        }
                    }
                    else
                    {
                        DataRow[] dt_folder = ClassData.dtFolder.Select("name LIKE '%" + txtSearching.Text + "%'");
                        if (dt_folder.Length > 0)
                        {
                            Home.LoadDataDown(dt_folder.CopyToDataTable());
                        }
                    }

                    txtSearching.Text = "";
                }
                
            }
        }

        private void txtSearching_Click(object sender, EventArgs e)
        {
            if(txtSearching.Text == "Tìm trong Drive")
            {
                txtSearching.Text = "";
            }
        }

        private void pnTrash_Click(object sender, EventArgs e)
        {
            Reset();
            Trash.Visible = true;

            Trash.LoadDataDown(ClassData.dtDelete);
            pnTrash.BackColor = Color.LightSkyBlue;
            picTrash.BackColor = Color.LightSkyBlue;
        }

        private void SharedWithMe(object sender, EventArgs e)
        {
            ClassData.reloaddata();

            Reset();
            Home.Visible = true;
            foreach (uctItemList item in Home.Controls.OfType<UserControl>())
            {
                // Kiểm tra kiểu của control và xác định liệu nó có phải là loại A hay không
                if (item.GetType() == typeof(uctItemList))
                {
                    Home.Controls.Remove(item);
                    item.Dispose(); // Giải phóng tài nguyên của control nếu cần thiết
                }
            }
            Home.LoadDataDown(ClassData.dtFileShared);
            pnShared.BackColor = Color.LightSkyBlue;
            picShared.BackColor = Color.LightSkyBlue;
        }

        private void OpenRecentFile(object sender, EventArgs e)
        {
            ClassData.reloaddata();
            Reset();
            Home.Visible = true;
            foreach (uctItemList item in Home.Controls.OfType<UserControl>())
            {
                // Kiểm tra kiểu của control và xác định liệu nó có phải là loại A hay không
                if (item.GetType() == typeof(uctItemList))
                {
                    Home.Controls.Remove(item);
                    item.Dispose(); // Giải phóng tài nguyên của control nếu cần thiết
                }
            }
            Home.LoadDataDown(ClassData.dtFileRecent);
            pnRecent.BackColor = Color.LightSkyBlue;
            picRecent.BackColor = Color.LightSkyBlue;
        }

        private void Logout(object sender, EventArgs e)
        {
            this.Close();

            StartForm startForm = new StartForm();
            startForm.ShowDialog();
        }
    }
}
