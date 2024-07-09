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
    public partial class uctTrash : UserControl
    {
        public uctTrash()
        {
            InitializeComponent();

            ClassData.OnItemClicked += DisplayFunctionPanel;

            ClassData.OnPanelClosed += HideFunctionPanel;
        }

        private void picRecover_Click(object sender, EventArgs e)
        {
            try
            {
                if (ClassData.isDisplayFile == true)
                {
                    //Recover the deleted file to dtFile
                    StreamWriter sw = new StreamWriter(ClassData.pathFile, true);
                    foreach (DataRow dr in ClassData.dtDelete.Rows)
                    {
                        if ((int)dr["ID"] == ClassData.chosenFileID)
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
                            break;
                        }
                    }
                    sw.Close();

                    //Delete the chosen file in dtDelete
                    foreach (DataRow dr in ClassData.dtDelete.Rows)
                    {
                        if ((int)dr["ID"] == ClassData.chosenFileID)
                        {
                            dr.Delete();
                            break;
                        }
                    }
                    ClassData.dtDelete.AcceptChanges();

                    sw = new StreamWriter(ClassData.FileDeletePath, false);
                    foreach (DataRow dr in ClassData.dtDelete.Rows)
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
                    LoadDataDown(ClassData.dtDelete);
                }
            }
            catch { }
        }

        private void picDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (ClassData.isDisplayFile == true)
                {
                    foreach (DataRow dr in ClassData.dtDelete.Rows)
                    {
                        if ((int)dr["ID"] == ClassData.chosenFileID)
                        {
                            dr.Delete();
                            break;
                        }
                    }
                    ClassData.dtDelete.AcceptChanges();

                    StreamWriter sw = new StreamWriter(ClassData.FileDeletePath, false);
                    foreach (DataRow dr in ClassData.dtDelete.Rows)
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
                    LoadDataDown(ClassData.dtDelete);
                }
            }
            catch { }
        }

        private void uctTrash_Load(object sender, EventArgs e)
        {
            Reset();
            pnContentList.Visible = true;
            pnHeader.Visible = true;

            pnList.BackColor = Color.LightSkyBlue;
            picList.BackColor = Color.LightSkyBlue;

            HideFunctionPanel();
        }

        public void AddFile(int id, int idowner, string type, string name, string time, int idfolderbelong, bool recent, bool like, List<int> shared)
        {
            if (ClassData.isListMode) // Display List Mode
            {
                uctTrashItemList uct = new uctTrashItemList();
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

        }
        public void DisplayFunctionPanel()
        {
            pnFunctions.Visible = true;
            cbType.Visible = false;
            cbRecent.Visible = false;
            pnList.Visible = false;
            pnGrid.Visible = false;
        }
        public void HideFunctionPanel()
        {
            pnFunctions.Visible = false;
            cbType.Visible = true;
            cbRecent.Visible = true;
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

        private void picRecover_MouseEnter(object sender, EventArgs e)
        {
            picRecover.BackColor = Color.LightGray;
        }

        private void picRecover_MouseLeave(object sender, EventArgs e)
        {
            picRecover.BackColor = SystemColors.Control;
        }

        private void picDelete_MouseEnter(object sender, EventArgs e)
        {
            picDelete.BackColor = Color.LightGray;
        }

        private void picDelete_MouseLeave(object sender, EventArgs e)
        {
            picDelete.BackColor = SystemColors.Control;
        }

        private void pnList_Click(object sender, EventArgs e)
        {
            Reset();
            pnContentList.Visible = true;
            pnHeader.Visible = true;

            ClassData.isListMode = true;

            pnList.BackColor = Color.LightSkyBlue;
            picList.BackColor = Color.LightSkyBlue;

            LoadDataDown(ClassData.dtDelete);
        }

        private void pnGrid_Click(object sender, EventArgs e)
        {
            Reset();
            pnContentGrid.Visible = true;

            ClassData.isListMode = false;

            pnGrid.BackColor = Color.LightSkyBlue;
            picGrid.BackColor = Color.LightSkyBlue;

            LoadDataDown(ClassData.dtDelete);
        }
    }
}
