using SautinSoft.Document;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Drive
{
    public partial class uctItemList : UserControl
    {
        int IDfile, IDowner = 0;
        string type;
        public uctItemList()
        {
            InitializeComponent();
        }
        string PathImage = "DriveData\\image\\";
        private void uctItemList_Load(object sender, EventArgs e)
        {

        }

        private void uctItemList_DoubleClick(object sender, EventArgs e)
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

            //using (OpenFileDialog ofd = new OpenFileDialog() { ValidateNames = true, Multiselect = false, Filter = "Word 97-2003|*.doc|Word Document|*.docx" })
            //{
            //    if (ofd.ShowDialog() == DialogResult.OK)
            //    {
            //        object readOnly = false;
            //        object visible = true;
            //        object save = false;
            //        object fileName = ofd.FileName;
            //        object newTemplate = false;
            //        object docType = 0;
            //        object missing = Type.Missing;
            //        Microsoft.Office.Interop.Word.Document document;
            //        Microsoft.Office.Interop.Word.Application application = new Microsoft.Office.Interop.Word.Application() { Visible = true };
            //        document = application.Documents.Open(ref fileName, ref missing, ref readOnly, ref missing, ref missing, ref missing, ref missing,
            //                ref missing, ref missing, ref missing, ref missing, ref visible, ref missing, ref missing, ref missing, ref missing);
            //        document.ActiveWindow.Selection.WholeStory();
            //        //document.ActiveWindow.Selection.Copy();
            //        //IDataObject dataObject = Clipboard.GetDataObject();
            //        //rtfData.Rtf = dataObject.GetData(DataFormats.Rtf).ToString();
            //        //application.Quit(ref missing, ref missing, ref missing);
            //    }
            //}
        }

        public void LoadData(int idfile, int idowner, string type, string name)
        {
            IDfile = idfile;
            lblName.Text = name;
            //lblReasonRecommend.Text = suggest;
            IDowner = idowner;
            picType.Image = Image.FromFile(PathImage + type + ".png");
            this.type = type;
        }
    }
}
