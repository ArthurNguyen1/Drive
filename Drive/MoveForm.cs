using Microsoft.Office.Interop.Word;
using System;
using System.Collections;
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
    public partial class MoveForm : Form
    {
        public MoveForm()
        {
            InitializeComponent();

            ClassData.OnItemMoved += CloseForm;
        }

        private void MoveForm_Load(object sender, EventArgs e)
        {
            Reset();
            pnContent.Visible = true;
        }
        public void AddFile_2(int id, int idowner, string type, string name, string time, int idfolderbelong, bool recent, bool like, string owner, List<int> shared)
        {
            uctMoveFolder uct = new uctMoveFolder();
            uct.LoadData_2(id, idowner, type, name, time, idfolderbelong, recent, like, shared, owner);
            pnContent.Controls.Add(uct);

        }
        public void LoadDataDown(System.Data.DataTable dt)
        {
            pnContent.Controls.Clear();
            foreach (DataRow dr in dt.Rows)
            {
                AddFile_2((int)dr["ID"], (int)dr["IDowner"], dr["type"].ToString(), dr["name"].ToString(), dr["time"].ToString(), (int)dr["IDfolderbelong"], (bool)dr["recent"], (bool)dr["like"], (string)dr["owner"], (List<int>)dr["shared"]);
            }
        }

        public void LoadDataFile()
        {
            pnContent.Controls.Clear();
            foreach (DataRow dr in ClassData.dtFile.Rows)
            {
                AddFile_2((int)dr["ID"], (int)dr["IDowner"], dr["type"].ToString(), dr["name"].ToString(), dr["time"].ToString(), (int)dr["IDfolderbelong"], (bool)dr["recent"], (bool)dr["like"], (string)dr["owner"], (List<int>)dr["shared"]);
            }
        }

        public void LoadDataFolder()
        {
            pnContent.Controls.Clear();
            foreach (DataRow dr in ClassData.dtFolder.Rows)
            {
                AddFile_2((int)dr["ID"], (int)dr["IDowner"], dr["type"].ToString(), dr["name"].ToString(), dr["time"].ToString(), (int)dr["IDfolderbelong"], (bool)dr["recent"], (bool)dr["like"], (string)dr["owner"], (List<int>)dr["shared"]);
            }
        }

        public void Reset()
        {
            pnContent.Visible = false;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();  
        }
        public void CloseForm()
        {
            this.Close();
        }
        private void btnMove_Click(object sender, EventArgs e)
        {
            
        }
    }
}
