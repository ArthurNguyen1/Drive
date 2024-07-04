using Microsoft.Office.Interop.Word;
using SautinSoft.Document;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Drive
{
    public partial class uctTrashItemList : UserControl
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
        public uctTrashItemList()
        {
            InitializeComponent();
        }
        string PathImage = "DriveData\\image\\";

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

            picType.Image = Image.FromFile(PathImage + type + ".png");
            lblName.Text = name;
            lblDate.Text = _time;

            FileInfo fInf = new FileInfo(ClassData.pathFile);
            string sLen = fInf.Length.ToString();
            if (fInf.Length >= (1 << 30))
                sLen = string.Format("{0}Gb", fInf.Length >> 30);
            else if (fInf.Length >= (1 << 20))
                sLen = string.Format("{0}Mb", fInf.Length >> 20);
            else if (fInf.Length >= (1 << 10))
                sLen = string.Format("{0}Kb", fInf.Length >> 10);
            else
                sLen = string.Format("{0}B", fInf.Length);

            lblSize.Text = sLen;
        }

        private void uctITrashtemList_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = System.Drawing.SystemColors.ControlDark;
        }

        private void uctITrashtemList_MouseLeave(object sender, EventArgs e)
        {
            if (ClassData.chosenFileID == _ID)
                this.BackColor = System.Drawing.Color.LightSkyBlue;
            else
                this.BackColor = System.Drawing.Color.White;
        }

        private void uctITrashtemList_Click(object sender, EventArgs e)
        {
            ClassData.chosenFileID = _ID;
            ClassData.chosenFildeName = _name;
            if (ClassData.chosenFileID == _ID)
                this.BackColor = System.Drawing.Color.LightSkyBlue;
            else
                this.BackColor = System.Drawing.Color.White;

            ClassData.ItemClicked();
        }

        private void uctITrashtemList_DoubleClick(object sender, EventArgs e)
        {
            string filePath = "D:\\Drive\\Drive\\bin\\Debug\\DriveData\\file\\" + lblName.Text + ".docx";
            // The file format is detected automatically from the file extension: ".docx".
            DocumentCore dc = DocumentCore.Load(filePath);

            if (dc != null)
            {
                object readOnly = false;
                object visible = true;
                object save = false;
                object fileName = filePath;
                object newTemplate = false;
                object docType = 0;
                object missing = Type.Missing;
                Microsoft.Office.Interop.Word.Document document;
                Microsoft.Office.Interop.Word.Application application = new Microsoft.Office.Interop.Word.Application() { Visible = true };
                document = application.Documents.Open(ref fileName, ref missing, ref readOnly, ref missing, ref missing, ref missing, ref missing,
                        ref missing, ref missing, ref missing, ref missing, ref visible, ref missing, ref missing, ref missing, ref missing);
                document.ActiveWindow.Selection.WholeStory();
            }
        }

        private void uctITrashtemList_Load(object sender, EventArgs e)
        {

        }
    }
}
