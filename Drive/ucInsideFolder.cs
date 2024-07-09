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

namespace Drive
{
    public partial class ucInsideFolder : UserControl
    {
        public ucInsideFolder()
        {
            InitializeComponent();

            ClassData.OnItemClicked += DisplayFunctionPanel;

            ClassData.OnPanelClosed += HideFunctionPanel;
        }
        public void SetName(string name)
        {
            lblName.Text = name;
        }
        private void ucInsideFolder_Load(object sender, EventArgs e)
        {
            Reset();
            pnContentGridFile.Visible = true;
            pnContentGridFolder.Visible = true;

            pnGrid.BackColor = Color.LightSkyBlue;
            picGrid.BackColor = Color.LightSkyBlue;
            ClassData.isListMode = false;

            lblFile.Visible = true;
            lblFolder.Visible = true;
            HideFunctionPanel();
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
                if (type == "folder")
                {
                    ucFolder uct = new ucFolder();
                    uct.LoadData(id, idowner, type, name, time, idfolderbelong, recent, like, shared);
                    pnContentGridFolder.Controls.Add(uct);
                }
                else
                {
                    uctItemGrid uct = new uctItemGrid();
                    uct.LoadData(id, idowner, type, name, time, idfolderbelong, recent, like, shared);
                    pnContentGridFile.Controls.Add(uct);
                }

            }
        }

        public void LoadDataDown(DataTable dt, string Name)
        {
            pnContentList.Controls.Clear();
            pnContentGridFile.Controls.Clear();
            pnContentGridFolder.Controls.Clear();
            foreach (DataRow dr in dt.Rows)
            {
                if((int)dr["ID"] != -1)
                    AddFile((int)dr["ID"], (int)dr["IDowner"], dr["type"].ToString(), dr["name"].ToString(), dr["time"].ToString(), (int)dr["IDfolderbelong"], (bool)dr["recent"], (bool)dr["like"], (List<int>)dr["shared"]);
            }
            lblName.Text = Name;
        }

        public void LoadDataFile()
        {
            pnContentList.Controls.Clear();
            pnContentGridFile.Controls.Clear();
            pnContentGridFolder.Controls.Clear();
            foreach (DataRow dr in ClassData.dtFile.Rows)
            {
                AddFile((int)dr["ID"], (int)dr["IDowner"], dr["type"].ToString(), dr["name"].ToString(), dr["time"].ToString(), (int)dr["IDfolderbelong"], (bool)dr["recent"], (bool)dr["like"], (List<int>)dr["shared"]);
            }
        }

        public void LoadDataFolder()
        {
            pnContentList.Controls.Clear();
            pnContentGridFile.Controls.Clear();
            pnContentGridFolder.Controls.Clear();

            //Merge 2 tables
            DataTable dt1 = ClassData.dtFolder.Copy();
            DataTable dt2 = ClassData.dtFile.Copy();

            DataTable dtAll = dt1.Copy();
            dtAll.Merge(dt2);

            if (dtAll.AsEnumerable().Where(dr => dr.Field<int>("IDfolderbelong") == ClassData.currentFolderID).Count() == 0)
            {
                dtAll.Rows.Clear();
                dtAll.Rows.Add();
                dtAll.Rows[0]["ID"] = -1;
            }
            else
                dtAll = dtAll.AsEnumerable().Where(dr => dr.Field<int>("IDfolderbelong") == ClassData.currentFolderID).CopyToDataTable();

            foreach (DataRow dr in dtAll.Rows)
            {
                AddFile((int)dr["ID"], (int)dr["IDowner"], dr["type"].ToString(), dr["name"].ToString(), dr["time"].ToString(), (int)dr["IDfolderbelong"], (bool)dr["recent"], (bool)dr["like"], (List<int>)dr["shared"]);
            }
        }

        public void Reset()
        {
            pnContentGridFile.Visible = false;
            pnContentGridFolder.Visible = false;
            pnContentList.Visible = false;
            pnHeader.Visible = false;

            pnList.BackColor = Color.White;
            pnGrid.BackColor = Color.White;
            picList.BackColor = Color.White;
            picGrid.BackColor = Color.White;

            lblFile.Visible = false;
            lblFolder.Visible = false;
        }

        public void FolderAdd()
        {
            Reset();
            pnContentGridFile.Visible = true;
            pnContentGridFolder.Visible = true;
            lblFile.Visible = true;
            lblFolder.Visible = true;

            pnList.BackColor = Color.LightSkyBlue;
            picList.BackColor = Color.LightSkyBlue;
        }

        public void DisplayFunctionPanel()
        {
            pnFunctions.Visible = true;
            cbRecent.Visible = false;
            cbType.Visible = false;
            cbUsers.Visible = false;
            pnList.Visible = false;
            pnGrid.Visible = false;
        }

        public void HideFunctionPanel()
        {
            pnFunctions.Visible = false;
            cbRecent.Visible = true;
            cbType.Visible = true;
            cbUsers.Visible = true;
            pnList.Visible = true;
            pnGrid.Visible = true;
        }

        private void picClose_Click(object sender, EventArgs e)
        {
            ClassData.PanelClosed();
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
                string filePath = "DriveData\\file\\" + ClassData.chosenFildeName + ".docx";
                string absolutePath = Path.GetFullPath(filePath);
                System.IO.File.Copy(absolutePath, saveFileDialog.FileName);

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
                if (ClassData.isDisplayFile == true)
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
                                        dr["like"].ToString() + "*" +
                                        dr["owner"]);
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
                                        dr["like"].ToString() + "*" +
                                        dr["owner"]);
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
                        if ((List<int>)dr["shared"] == null)
                        {
                            sw.WriteLine(dr["ID"].ToString() + "*" +
                                    dr["IDowner"].ToString() + "*" +
                                    dr["type"] + "*" +
                                    dr["name"] + "*" +
                                    dr["time"] + "*" +
                                    dr["IDfolderbelong"].ToString() + "*" +
                                    dr["recent"].ToString() + "*" +
                                    dr["like"].ToString() + "*" +
                                    dr["owner"]);
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
                                    dr["like"].ToString() + "*" +
                                    dr["owner"]);
                            foreach (int temp in (List<int>)dr["shared"])
                            {
                                sw.Write("*" + temp.ToString());
                            }
                            sw.WriteLine();
                        }
                    }
                    sw.Close();

                    ClassData.reloaddata();
                    LoadDataDown(ClassData.dtFile, lblName.Text);
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

            //Merge 2 tables
            DataTable dt1 = ClassData.dtFolder.Copy();
            DataTable dt2 = ClassData.dtFile.Copy();

            DataTable dtAll = dt1.Copy();
            dtAll.Merge(dt2);

            LoadDataDown(dtAll.AsEnumerable().Where(dr => dr.Field<int>("IDfolderbelong") == ClassData.currentFolderID).CopyToDataTable(), lblName.Text);
        }

        private void pnGrid_Click(object sender, EventArgs e)
        {
            Reset();
            pnContentGridFile.Visible = true;
            pnContentGridFolder.Visible = true;
            lblFile.Visible = true;
            lblFolder.Visible = true;

            ClassData.isListMode = false;

            pnGrid.BackColor = Color.LightSkyBlue;
            picGrid.BackColor = Color.LightSkyBlue;

            //Merge 2 tables
            DataTable dt1 = ClassData.dtFolder.Copy();
            DataTable dt2 = ClassData.dtFile.Copy();

            DataTable dtAll = dt1.Copy();
            dtAll.Merge(dt2);

            LoadDataDown(dtAll.AsEnumerable().Where(dr => dr.Field<int>("IDfolderbelong") == ClassData.currentFolderID).CopyToDataTable(), lblName.Text);
        }

        private void picBack_Click(object sender, EventArgs e)
        {
            ClassData.FolderBacked();
        }

        private void picMove_Click(object sender, EventArgs e)
        {
            MoveForm moveForm = new MoveForm();
            moveForm.LoadDataDown(ClassData.dtFolder);
            moveForm.ShowDialog();
        }
    }
}
