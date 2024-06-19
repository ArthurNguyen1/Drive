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

        //
        public void AddFile(int idfile, int idowner, string type, string name)
        {
            uctItemList uct = new uctItemList();
            uct.LoadData(idfile, idowner, type, name);
            pnContentList.Controls.Add(uct);
        }

        public void LoadDataDown(DataTable dt)
        {
            pnContentList.Controls.Clear();
            foreach (DataRow dr in dt.Rows)
            {
                AddFile((int)dr["IDfile"], (int)dr["IDowner"], dr["type"].ToString(), dr["name"].ToString());
            }
        }
        //

        void Reset()
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
    }
}
