﻿using System;
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

            ClassData.OnClicked += DisplayFunctionPanel;
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
            uctItemList uct = new uctItemList();
            uct.LoadData(id, idowner, type, name, time, idfolderbelong, recent, like, shared);
            pnContentList.Controls.Add(uct);
        }

        public void LoadDataDown(DataTable dt)
        {
            pnContentList.Controls.Clear();
            foreach (DataRow dr in dt.Rows)
            {
                AddFile((int)dr["ID"], (int)dr["IDowner"], dr["type"].ToString(), dr["name"].ToString(), dr["time"].ToString(), (int)dr["IDfolderbelong"], (bool)dr["recent"], (bool)dr["like"], (List<int>)dr["shared"]);
            }
        }

        public void LoadDataFile()
        {
            pnContentList.Controls.Clear();
            foreach (DataRow dr in ClassData.dtFile.Rows)
            {
                AddFile((int)dr["ID"], (int)dr["IDowner"], dr["type"].ToString(), dr["name"].ToString(), dr["time"].ToString(), (int)dr["IDfolderbelong"], (bool)dr["recent"], (bool)dr["like"], (List<int>)dr["shared"]);
            }
        }

        public void LoadDataFolder()
        {
            pnContentList.Controls.Clear();
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
            pnContentList.Visible = true;
            pnHeader.Visible = true;

            pnList.BackColor = Color.LightSkyBlue;
            picList.BackColor = Color.LightSkyBlue;

            //ClassData.dtInUse = ClassData.dtFile.AsEnumerable().Where(dr => dr.Field<string>("type") != "folder").CopyToDataTable();
            LoadDataDown(ClassData.dtFile);
            ClassData.isDisplayFile = true;

            pnFile.BackColor = Color.LightSkyBlue;
            picFile.BackColor = Color.LightSkyBlue;
        }

        private void pnFolder_Click(object sender, EventArgs e)
        {
            Reset();
            pnContentList.Visible = true;
            pnHeader.Visible = true;

            pnList.BackColor = Color.LightSkyBlue;
            picList.BackColor = Color.LightSkyBlue;

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
            HideFunctionPanel();
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
                    foreach (DataRow dr in ClassData.dtFile.Rows)
                    {
                        if ((int)dr["ID"] == ClassData.chosenFileID)
                        {
                            dr.Delete();
                            break;
                        }
                    }
                    ClassData.dtFile.AcceptChanges();

                    StreamWriter sw = new StreamWriter(ClassData.pathFile, false);
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
    }
}
