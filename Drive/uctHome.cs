using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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

            //ClassData.dtInUse = ClassData.dtFile.AsEnumerable().Where(dr => dr.Field<string>("type") != "folder").CopyToDataTable();
            LoadDataDown(ClassData.dtFile);

            pnFile.BackColor = Color.LightSkyBlue;
            picFile.BackColor = Color.LightSkyBlue;
        }

        private void pnFolder_Click(object sender, EventArgs e)
        {
            Reset();
            pnContentList.Visible = true;
            pnHeader.Visible = true;

            //ClassData.dtInUse = ClassData.dtFile.AsEnumerable().Where(dr => dr.Field<string>("type") == "folder").CopyToDataTable();
            LoadDataDown(ClassData.dtFolder);

            pnFolder.BackColor = Color.LightSkyBlue;
            picFolder.BackColor = Color.LightSkyBlue;
        }

        public void FolderAdd()
        {
            Reset();
            pnContentList.Visible = true;
            pnHeader.Visible = true;

            pnFolder.BackColor = Color.LightSkyBlue;
            picFolder.BackColor = Color.LightSkyBlue;
        }
    }
}
