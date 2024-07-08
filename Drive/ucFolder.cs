using SautinSoft.Document;
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
    public partial class ucFolder : UserControl
    {
        int _ID = -1;
        int _IDowner = -1;
        string _type;
        string _name;
        string _time;
        int _IDfolderbelong = -1;
        bool _recent;
        bool _like;
        List<int> _shared;
        public ucFolder()
        {
            InitializeComponent();
        }
        string PathImage = "DriveData\\image\\";
        private void ucFolder_Load(object sender, EventArgs e)
        {

        }

        private void ucFolder_DoubleClick(object sender, EventArgs e)
        {
            ClassData.currentFolderID = _ID;
            ClassData.FolderName = _name;
            ClassData.FolderClicked();
        }

        public void LoadData(int id, int idowner, string type, string name, string time, int idfolderbelong, bool recent, bool like, List<int> shared)
        {
            _ID = id;
            _IDowner = idowner;
            _type = type;
            _name = name;
            _time = time;
            _IDfolderbelong = idfolderbelong;
            _recent = recent;
            _like = like;
            _shared = shared;

            lblName.Text = name;
        }

        private void ucFolder_Click(object sender, EventArgs e)
        {
            ClassData.chosenFileID = _ID;
            ClassData.chosenFildeName = _name;
            if (ClassData.chosenFileID == _ID)
                this.BackColor = System.Drawing.Color.LightSkyBlue;
            else
                this.BackColor = System.Drawing.Color.White;

            ClassData.ItemClicked();
        }

        private void ucFolder_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = System.Drawing.SystemColors.ControlDark;
        }

        private void ucFolder_MouseLeave(object sender, EventArgs e)
        {
            if (ClassData.chosenFileID == _ID)
                this.BackColor = System.Drawing.Color.LightSkyBlue;
            else
                this.BackColor = System.Drawing.Color.White;
        }
    }
}
