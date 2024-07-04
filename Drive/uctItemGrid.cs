using SautinSoft.Document;
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
    public partial class uctItemGrid : UserControl
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
        public uctItemGrid()
        {
            InitializeComponent();
        }
        string PathImage = "DriveData\\image\\";

        private void uctItemGrid_Load(object sender, EventArgs e)
        {

        }

        private void uctItemGrid_DoubleClick(object sender, EventArgs e)
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
            lblReasonRecommend.Text = "Bạn đã mở : " + _time;
        }

        private void uctItemGrid_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = System.Drawing.SystemColors.ControlDark;
        }

        private void uctItemGrid_MouseLeave(object sender, EventArgs e)
        {
            if (ClassData.chosenFileID == _ID)
                this.BackColor = System.Drawing.Color.LightSkyBlue;
            else
                this.BackColor = System.Drawing.Color.White;
        }

        private void uctItemGrid_Click(object sender, EventArgs e)
        {
            ClassData.chosenFileID = _ID;
            ClassData.chosenFildeName = _name;
            if (ClassData.chosenFileID == _ID)
                this.BackColor = System.Drawing.Color.LightSkyBlue;
            else
                this.BackColor = System.Drawing.Color.White;

            ClassData.ItemClicked();
        }
    }
}
