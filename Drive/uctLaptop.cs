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
    public partial class uctLaptop : UserControl
    {
        public uctLaptop()
        {
            InitializeComponent();
        }

        private void uctLaptop_Load(object sender, EventArgs e)
        {
            Reset();
            pnContentList.Visible = true;
            pnHeader.Visible = true;

            pnList.BackColor = Color.LightSkyBlue;
            picList.BackColor = Color.LightSkyBlue;
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
                AddFile((int)dr["ID"], (int)dr["IDowner"], dr["type"].ToString(), dr["name"].ToString(), dr["time"].ToString(), -1, false, false, null);
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
    }
}
