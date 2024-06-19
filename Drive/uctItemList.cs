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
    public partial class uctItemList : UserControl
    {
        int IDfile, IDowner = 0;
        public uctItemList()
        {
            InitializeComponent();
        }
        string PathImage = "DriveData\\image\\";
        private void uctItemList_Load(object sender, EventArgs e)
        {

        }

        public void LoadData(int idfile, int idowner, string type, string name)
        {
            IDfile = idfile;
            lblName.Text = name;
            //lblReasonRecommend.Text = suggest;
            IDowner = idowner;
            picType.Image = Image.FromFile(PathImage + type + ".png");
        }
    }
}
