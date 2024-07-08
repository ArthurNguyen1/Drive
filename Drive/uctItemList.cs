using Drive.CustomControl;
using SautinSoft.Document;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Drive
{
    public partial class uctItemList : UserControl
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
        public static TransparentTxb currentFileName;
        public static int currentFileID;
        public static string currentFileType;

        public uctItemList()
        {
            InitializeComponent();
            //lblName.BackColor = Color.
        }
        string PathImage = "DriveData\\image\\";
        private void uctItemList_Load(object sender, EventArgs e)
        {

        }

        public void WriteToFileStack(string filePath, string lineToAdd)
        {
            try
            {
                List<string> lines = new List<string>();

                // Đọc nội dung hiện tại của file nếu có
                if (File.Exists(filePath))
                {
                    lines = File.ReadAllLines(filePath).ToList();
                }

                // Thêm dòng mới vào đầu danh sách (định dạng stack)
                lines.Insert(0, lineToAdd);

                // Nếu số dòng vượt quá 10, xóa các dòng cũ nhất
                if (lines.Count > 10)
                {
                    lines = lines.Take(10).ToList(); // Lấy ra chỉ 10 dòng mới nhất
                }

                // Ghi lại toàn bộ nội dung mới vào file
                File.WriteAllLines(filePath, lines);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Lỗi: {ex.Message}");
            }
        }
        private void uctItemList_DoubleClick(object sender, EventArgs e)
        {
            if(_type != "folder")
            {
                string pathDataFile = "UserData\\file_recent\\" + StartForm.userID.ToString() + "_filerecent.txt";
                WriteToFileStack(pathDataFile, ClassData.chosenFileID + "*" +
                         "1000" + "*" +
                         uctItemList.currentFileType + "*" +
                         ClassData.chosenFildeName + "*" +
                         DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss tt") + "*" +
                         ClassData.currentFolderID.ToString() + "*" +
                         "False" + "*" +
                         "False" + "*" + StartForm.userName);


                string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "DriveData\\file\\" + lblName.Text + ".docx");
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
            lblOwner.Text = "Chủ sở hữu";
            lblReasonRecommend.Text = "Bạn đã mở : " + _time;
        }

        public void LoadData_2(int id, int idowner, string type, string name, string time, int idfolderbelong, bool recent, bool like, List<int> shared, string owner)
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
            lblOwner.Text = owner;
            lblReasonRecommend.Text = "Bạn đã mở : " + _time;
        }

        private void uctItemList_MouseEnter(object sender, EventArgs e)
        {
            lblName.BackColor = System.Drawing.SystemColors.ControlDark;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
        }

        private void uctItemList_MouseLeave(object sender, EventArgs e)
        {
            if(ClassData.chosenFileID == _ID)
            {
                this.BackColor = System.Drawing.Color.LightSkyBlue;
                lblName.BackColor = System.Drawing.Color.LightSkyBlue;

            }
            else
            {
                this.BackColor = System.Drawing.Color.White;
                lblName.BackColor = System.Drawing.Color.White;
            }
        }

        private void uctItemList_Click(object sender, EventArgs e)
        {
            currentFileName = this.lblName;
            currentFileID = ClassData.chosenFileID;
            currentFileType = _type;
            ClassData.chosenFileID = _ID;
            ClassData.chosenFildeName = _name;
            if (ClassData.chosenFileID == _ID)
                this.BackColor = System.Drawing.Color.LightSkyBlue;
            else
                this.BackColor = System.Drawing.Color.White;

            ClassData.ItemClicked();
        }

        private void Rename(object sender, EventArgs e)
        {
            //string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "DriveData\\file\\" + lblName.Text + ".docx");
            //// The file format is detected automatically from the file extension: ".docx".
            //DocumentCore dc = DocumentCore.Load(filePath);

            //if (dc != null)
            //{
            //    object readOnly = false;
            //    object visible = true;
            //    object save = false;
            //    object fileName = filePath;
            //    object newTemplate = false;
            //    object docType = 0;
            //    object missing = Type.Missing;
            //    Microsoft.Office.Interop.Word.Document document;
            //    Microsoft.Office.Interop.Word.Application application = new Microsoft.Office.Interop.Word.Application() { Visible = true };
            //    document = application.Documents.Open(ref fileName, ref missing, ref readOnly, ref missing, ref missing, ref missing, ref missing,
            //            ref missing, ref missing, ref missing, ref missing, ref visible, ref missing, ref missing, ref missing, ref missing);
            //    document.ActiveWindow.Selection.WholeStory();
            //}
        }

    }
}
