using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Drive
{
    public partial class uctHome : UserControl
    {
        public uctHome()
        {
            InitializeComponent();

            ClassData.OnItemClicked += DisplayFunctionPanel;

            ClassData.OnPanelClosed += HideFunctionPanel;
        }

        private void uctHome_Load(object sender, EventArgs e)
        {
            Reset();
            pnContentList.Visible = true;
            pnHeader.Visible = true;

            pnList.BackColor = Color.LightSkyBlue;
            picList.BackColor = Color.LightSkyBlue;

            pnFile.BackColor = Color.LightSkyBlue;
            picFile.BackColor = Color.LightSkyBlue;

            HideFunctionPanel();
        }

        public void LoadForm()
        {

        }

        public void AddFile(int id, int idowner, string type, string name, string time, int idfolderbelong, bool recent, bool like, List<int> shared)
        {
            if (ClassData.isListMode) // Display List Mode
            {
                uctItemList uct = new uctItemList();
                uct.LoadData(id, idowner, type, name, time, idfolderbelong, recent, like, shared);
                pnContentList.Controls.Add(uct);
            }
            else // Display Grid Mode
            {
                uctItemGrid uct = new uctItemGrid();
                uct.LoadData(id, idowner, type, name, time, idfolderbelong, recent, like, shared);
                pnContentGrid.Controls.Add(uct);
            }
        }

        public void LoadDataDown(DataTable dt)
        {
            pnContentList.Controls.Clear();
            pnContentGrid.Controls.Clear();
            foreach (DataRow dr in dt.Rows)
            {
                AddFile((int)dr["ID"], (int)dr["IDowner"], dr["type"].ToString(), dr["name"].ToString(), dr["time"].ToString(), (int)dr["IDfolderbelong"], (bool)dr["recent"], (bool)dr["like"], (List<int>)dr["shared"]);
            }
        }

        public void LoadDataFile()
        {
            pnContentList.Controls.Clear();
            pnContentGrid.Controls.Clear();
            foreach (DataRow dr in ClassData.dtFile.Rows)
            {
                AddFile((int)dr["ID"], (int)dr["IDowner"], dr["type"].ToString(), dr["name"].ToString(), dr["time"].ToString(), (int)dr["IDfolderbelong"], (bool)dr["recent"], (bool)dr["like"], (List<int>)dr["shared"]);
            }
        }

        public void LoadDataFolder()
        {
            pnContentList.Controls.Clear();
            pnContentGrid.Controls.Clear();
            foreach (DataRow dr in ClassData.dtFolder.Rows)
            {
                AddFile((int)dr["ID"], (int)dr["IDowner"], dr["type"].ToString(), dr["name"].ToString(), dr["time"].ToString(), (int)dr["IDfolderbelong"], (bool)dr["recent"], (bool)dr["like"], (List<int>)dr["shared"]);
            }
        }

        public void Reset()
        {
            pnContentGrid.Visible = false;
            pnContentList.Visible = false;
            pnHeader.Visible = false;

            pnList.BackColor = Color.White;
            pnGrid.BackColor = Color.White;
            picList.BackColor = Color.White;
            picGrid.BackColor = Color.White;

            pnFolder.BackColor = Color.White;
            pnFile.BackColor = Color.White;
            picFolder.BackColor = Color.White;
            picFile.BackColor = Color.White;
        }

        private void pnFile_Click(object sender, EventArgs e)
        {
            Reset();
            if(ClassData.isListMode)
            {
                pnContentList.Visible = true;
                pnHeader.Visible = true;

                pnList.BackColor = Color.LightSkyBlue;
                picList.BackColor = Color.LightSkyBlue;
            }
            else
            {
                pnContentGrid.Visible = true;

                pnGrid.BackColor = Color.LightSkyBlue;
                picGrid.BackColor = Color.LightSkyBlue;
            }

            //ClassData.dtInUse = ClassData.dtFile.AsEnumerable().Where(dr => dr.Field<string>("type") != "folder").CopyToDataTable();
            LoadDataDown(ClassData.dtFile);
            ClassData.isDisplayFile = true;

            pnFile.BackColor = Color.LightSkyBlue;
            picFile.BackColor = Color.LightSkyBlue;
        }

        private void pnFolder_Click(object sender, EventArgs e)
        {
            Reset();
            if (ClassData.isListMode)
            {
                pnContentList.Visible = true;
                pnHeader.Visible = true;

                pnList.BackColor = Color.LightSkyBlue;
                picList.BackColor = Color.LightSkyBlue;
            }
            else
            {
                pnContentGrid.Visible = true;

                pnGrid.BackColor = Color.LightSkyBlue;
                picGrid.BackColor = Color.LightSkyBlue;
            }

            //ClassData.dtInUse = ClassData.dtFile.AsEnumerable().Where(dr => dr.Field<string>("type") == "folder").CopyToDataTable();
            LoadDataDown(ClassData.dtFolder);
            ClassData.isDisplayFile = false;

            pnFolder.BackColor = Color.LightSkyBlue;
            picFolder.BackColor = Color.LightSkyBlue;
        }

        public void FolderAdd()
        {
            Reset();
            pnContentList.Visible = true;
            pnHeader.Visible = true;

            pnList.BackColor = Color.LightSkyBlue;
            picList.BackColor = Color.LightSkyBlue;

            pnFolder.BackColor = Color.LightSkyBlue;
            picFolder.BackColor = Color.LightSkyBlue;
        }

        public void DisplayFunctionPanel()
        {
            pnFunctions.Visible = true;
            lblRecommend.Visible = false;
            pnFile.Visible = false;
            pnFolder.Visible = false;
            pnList.Visible = false;
            pnGrid.Visible = false;
        }

        public void HideFunctionPanel()
        {
            pnFunctions.Visible = false;
            lblRecommend.Visible = true;
            pnFile.Visible = true;
            pnFolder.Visible = true;
            pnList.Visible = true;
            pnGrid.Visible = true;
        }

        private void picClose_Click(object sender, EventArgs e)
        {
            ClassData.PanelClosed();
        }

        private void picClose_MouseEnter(object sender, EventArgs e)
        {
            picClose.BackColor = Color.LightGray;
        }

        private void picClose_MouseLeave(object sender, EventArgs e)
        {
            picClose.BackColor = SystemColors.Control;
        }

        private void picShared_MouseEnter(object sender, EventArgs e)
        {
            picShared.BackColor = Color.LightGray;
        }

        private void picShared_MouseLeave(object sender, EventArgs e)
        {
            picShared.BackColor = SystemColors.Control;
        }

        private void picDownload_MouseEnter(object sender, EventArgs e)
        {
            picDownload.BackColor = Color.LightGray;
        }

        private void picDownload_MouseLeave(object sender, EventArgs e)
        {
            picDownload.BackColor = SystemColors.Control;
        }

        private void picMove_MouseEnter(object sender, EventArgs e)
        {
            picMove.BackColor = Color.LightGray;
        }

        private void picMove_MouseLeave(object sender, EventArgs e)
        {
            picMove.BackColor = SystemColors.Control;
        }

        private void picDelete_MouseEnter(object sender, EventArgs e)
        {
            picDelete.BackColor = Color.LightGray;
        }

        private void picDelete_MouseLeave(object sender, EventArgs e)
        {
            picDelete.BackColor = SystemColors.Control;
        }

        private void picCopyLink_MouseEnter(object sender, EventArgs e)
        {
            picCopyLink.BackColor = Color.LightGray;
        }

        private void picCopyLink_MouseLeave(object sender, EventArgs e)
        {
            picCopyLink.BackColor = SystemColors.Control;
        }

        private void picMore_MouseEnter(object sender, EventArgs e)
        {
            picMore.BackColor = Color.LightGray;
        }

        private void picMore_MouseLeave(object sender, EventArgs e)
        {
            picMore.BackColor = SystemColors.Control;
        }

        private void picDownload_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Word 97-2003|*.doc|Word Document|*.docx"; 
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            saveFileDialog.FileName = ClassData.chosenFildeName + ".docx";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string currentTime = DateTime.Now.ToString("hh:mm tt, dd/MM/yyyy");
                string filePath =  "DriveData\\file\\" + ClassData.chosenFildeName + ".docx";
                string absolutePath = Path.GetFullPath(filePath);
                File.Copy(absolutePath, saveFileDialog.FileName);

                // Save download info to file
                string data = $"{ClassData.chosenFileID}|{ClassData.chosenFildeName}|1000|.docx|{currentTime}";

                bool isAlready = false;

                try
                {
                    StreamReader sr = new StreamReader(ClassData.FileDownloadPath);
                    string str;
                    while ((str = sr.ReadLine()) != null)
                    {
                        string[] st = str.Split('|');
                        if (int.Parse(st[0]) == ClassData.chosenFileID)
                        {
                            isAlready = true;
                            break;
                        }
                    }
                    sr.Close();
                }
                catch { }

                if (!isAlready)
                {
                    using (StreamWriter sw = new StreamWriter(ClassData.FileDownloadPath, true))
                    {
                        sw.WriteLine(data);
                    }
                }
                MessageBox.Show("Download successfully!");
            }
        }

        private void picDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if(ClassData.isDisplayFile == true)
                {
                    string currentTime = DateTime.Now.ToString("hh:mm tt, dd/MM/yyyy");

                    //Add the deleted file to dtDelete
                    StreamWriter sw = new StreamWriter(ClassData.FileDeletePath, true);
                    foreach (DataRow dr in ClassData.dtFile.Rows)
                    {
                        if ((int)dr["ID"] == ClassData.chosenFileID)
                        {
                            if ((List<int>)dr["shared"] == null)
                            {
                                sw.WriteLine(dr["ID"].ToString() + "*" +
                                        dr["IDowner"].ToString() + "*" +
                                        dr["type"] + "*" +
                                        dr["name"] + "*" +
                                        currentTime + "*" +
                                        dr["IDfolderbelong"].ToString() + "*" +
                                        dr["recent"].ToString() + "*" +
                                        dr["like"].ToString());
                            }
                            else
                            {
                                sw.Write(dr["ID"].ToString() + "*" +
                                        dr["IDowner"].ToString() + "*" +
                                        dr["type"] + "*" +
                                        dr["name"] + "*" +
                                        currentTime + "*" +
                                        dr["IDfolderbelong"].ToString() + "*" +
                                        dr["recent"].ToString() + "*" +
                                        dr["like"].ToString());
                                foreach (int temp in (List<int>)dr["shared"])
                                {
                                    sw.Write("*" + temp.ToString());
                                }
                                sw.WriteLine();
                            }
                            break;
                        }
                    }
                    sw.Close();

                    //Delete the chosen file in dtFile
                    foreach (DataRow dr in ClassData.dtFile.Rows)
                    {
                        if ((int)dr["ID"] == ClassData.chosenFileID)
                        {
                            dr.Delete();
                            break;
                        }
                    }
                    ClassData.dtFile.AcceptChanges();

                    sw = new StreamWriter(ClassData.pathFile, false);
                    foreach (DataRow dr in ClassData.dtFile.Rows)
                    {
                        if((List<int>)dr["shared"] == null)
                        {
                            sw.WriteLine(dr["ID"].ToString() + "*" +
                                    dr["IDowner"].ToString() + "*" +
                                    dr["type"] + "*" +
                                    dr["name"] + "*" +
                                    dr["time"] + "*" +
                                    dr["IDfolderbelong"].ToString() + "*" +
                                    dr["recent"].ToString() + "*" +
                                    dr["like"].ToString());
                        }
                        else
                        {
                            sw.Write(dr["ID"].ToString() + "*" +
                                    dr["IDowner"].ToString() + "*" +
                                    dr["type"] + "*" +
                                    dr["name"] + "*" +
                                    dr["time"] + "*" +
                                    dr["IDfolderbelong"].ToString() + "*" +
                                    dr["recent"].ToString() + "*" +
                                    dr["like"].ToString());
                            foreach(int temp in (List<int>)dr["shared"])
                            {
                                sw.Write("*" + temp.ToString());
                            }
                            sw.WriteLine();
                        }                        
                    }
                    sw.Close();

                    ClassData.reloaddata();
                    LoadDataDown(ClassData.dtFile);
                }    
            }
            catch { }
        }

        private void pnList_Click(object sender, EventArgs e)
        {
            Reset();
            pnContentList.Visible = true;
            pnHeader.Visible = true;

            ClassData.isListMode = true;

            pnList.BackColor = Color.LightSkyBlue;
            picList.BackColor = Color.LightSkyBlue;

            if (ClassData.isDisplayFile)
            {
                LoadDataDown(ClassData.dtFile);

                pnFile.BackColor = Color.LightSkyBlue;
                picFile.BackColor = Color.LightSkyBlue;
            }
            else
            {
                LoadDataDown(ClassData.dtFolder);

                pnFolder.BackColor = Color.LightSkyBlue;
                picFolder.BackColor = Color.LightSkyBlue;
            }
        }

        private void pnGrid_Click(object sender, EventArgs e)
        {
            Reset();
            pnContentGrid.Visible = true;

            ClassData.isListMode = false;

            pnGrid.BackColor = Color.LightSkyBlue;
            picGrid.BackColor = Color.LightSkyBlue;

            if (ClassData.isDisplayFile)
            {
                LoadDataDown(ClassData.dtFile);

                pnFile.BackColor = Color.LightSkyBlue;
                picFile.BackColor = Color.LightSkyBlue;
            }
            else
            {
                LoadDataDown(ClassData.dtFolder);

                pnFolder.BackColor = Color.LightSkyBlue;
                picFolder.BackColor = Color.LightSkyBlue;
            }
        }

        private bool isEdited = false;
        private void Edit(object sender, EventArgs e)
        {
            if(isEdited){

                uctItemList.currentFileName.ReadOnly = true;
                string nameFile = ClassData.chosenFildeName;
                string newNameFile = uctItemList.currentFileName.Text;
                string sourceFile = $"DriveData\\file\\{nameFile}" + uctItemList.currentFileType;
                string destinationFile = $"DriveData\\file\\{newNameFile}" + uctItemList.currentFileType;

                CopyAndRenameFile(sourceFile, destinationFile);
                ReplaceFile(ClassData.chosenFileID, newNameFile);
    }
            else{
                uctItemList.currentFileName.ReadOnly = false;
            }
            isEdited = !isEdited;

        }

        public void ReplaceFile(int fileID, string fileName)
        {
            string filePath = $"UserData\\file\\{StartForm.userID}_file.txt";
            string tempFilePath = $"{filePath}.tmp"; // Tạo một tệp tạm để lưu nội dung mới

            try
            {
                // Mở tệp nguồn để đọc
                using (StreamReader sr = new StreamReader(filePath))
                {
                    // Tạo một StringBuilder để xây dựng nội dung mới
                    StringBuilder sb = new StringBuilder();
                    string line;

                    // Đọc từng dòng từ tệp nguồn
                    while ((line = sr.ReadLine()) != null)
                    {
                        string[] contents = line.Split('*');

                        // Kiểm tra nếu dòng hiện tại chứa fileID cần thay đổi
                        if (contents.Length > 3 && contents[0] == fileID.ToString())
                        {
                            // Thực hiện thay đổi nội dung chỉ một lần
                            contents[3] = fileName;
                            line = string.Join("*", contents); // Tạo lại dòng với nội dung đã thay đổi
                        }

                        // Thêm dòng đã xử lý vào StringBuilder
                        sb.AppendLine(line);
                    }

                    // Ghi nội dung mới vào tệp tạm
                    File.WriteAllText(tempFilePath, sb.ToString());
                }

                // Xóa tệp nguồn và đổi tên tệp tạm thành tên tệp nguồn
                File.Delete(filePath);
                File.Move(tempFilePath, filePath);

                Console.WriteLine("Thay thế nội dung thành công.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Lỗi: {ex.Message}");
            }
        }

        public void CopyAndRenameFile(string sourceFileName, string destinationFileName)
        {
            MessageBox.Show(sourceFileName);
            try
            {
                // Kiểm tra xem tệp nguồn có tồn tại không
                if (File.Exists(sourceFileName))
                {
                    // Kiểm tra xem tệp đích đã tồn tại chưa, nếu có thì xóa đi
                    if (File.Exists(destinationFileName))
                    {
                        File.Delete(destinationFileName);
                    }

                    // Sao chép tệp nguồn vào đích và đổi tên
                    File.Copy(sourceFileName, destinationFileName);
                }
                else
                {
                    Console.WriteLine("Không tìm thấy tệp nguồn.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Lỗi: {ex.Message}");

            }
        }
    }
}
