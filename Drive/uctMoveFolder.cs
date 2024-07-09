using Drive.CustomControl;
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
    public partial class uctMoveFolder : UserControl
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
        public uctMoveFolder()
        {
            InitializeComponent();
        }

        private void uctMoveFolder_Load(object sender, EventArgs e)
        {
            lblMove.Visible = false;
            picOption.Visible = false;
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
            lblName.Text = name;           
        }

        private void uctMoveFolder_Click(object sender, EventArgs e)
        {
            if (ClassData.chosenFileID == _ID)
                this.BackColor = System.Drawing.Color.LightSkyBlue;
            else
                this.BackColor = System.Drawing.Color.White;

            lblMove.Visible = true;
            picOption.Visible = true;
        }

        private void lblMove_Click(object sender, EventArgs e)
        {
            bool isFoundTheTarget = false;

            string currentTime = DateTime.Now.ToString("hh:mm tt, dd/MM/yyyy");

            foreach (DataRow dr in ClassData.dtFile.Rows)
            {
                if ((int)dr["ID"] == ClassData.chosenFileID)
                {
                    isFoundTheTarget = true;
                    dr["IDfolderbelong"] = _ID;

                    break;
                }
            }
            ClassData.dtFile.AcceptChanges();

            StreamWriter sw = new StreamWriter(ClassData.pathFile, false);
            foreach (DataRow dr in ClassData.dtFile.Rows)
            {
                if ((List<int>)dr["shared"] == null)
                {
                    sw.WriteLine(dr["ID"].ToString() + "*" +
                            dr["IDowner"].ToString() + "*" +
                            dr["type"] + "*" +
                            dr["name"] + "*" +
                            dr["time"] + "*" +
                            dr["IDfolderbelong"].ToString() + "*" +
                            dr["recent"].ToString() + "*" +
                            dr["like"].ToString() + "*" + dr["owner"]);
                }
                else
                {
                    sw.Write(dr["ID"].ToString() + "*" +
                            dr["IDowner"].ToString() + "*" +
                            dr["type"] + "*" +
                            dr["name"] + "*" +
                            dr["time"] + "*" +
                            dr["IDfolderbelong"].ToString() + "*" +
                            dr["recent"].ToString() + "*" +
                            dr["like"].ToString() + "*" + dr["owner"]);
                    foreach (int temp in (List<int>)dr["shared"])
                    {
                        sw.Write("*" + temp.ToString());
                    }
                    sw.WriteLine();
                }
            }
            sw.Close();

            if(isFoundTheTarget == false)
            {
                foreach (DataRow dr in ClassData.dtFolder.Rows)
                {
                    if ((int)dr["ID"] == ClassData.chosenFileID)
                    {
                        dr["IDfolderbelong"] = _ID;

                        break;
                    }
                }
                ClassData.dtFolder.AcceptChanges();

                sw = new StreamWriter(ClassData.pathFolder, false);
                foreach (DataRow dr in ClassData.dtFolder.Rows)
                {
                    if ((List<int>)dr["shared"] == null)
                    {
                        sw.WriteLine(dr["ID"].ToString() + "*" +
                                dr["IDowner"].ToString() + "*" +
                                dr["type"] + "*" +
                                dr["name"] + "*" +
                                dr["time"] + "*" +
                                dr["IDfolderbelong"].ToString() + "*" +
                                dr["recent"].ToString() + "*" +
                                dr["like"].ToString() + "*" + dr["owner"]);
                    }
                    else
                    {
                        sw.Write(dr["ID"].ToString() + "*" +
                                dr["IDowner"].ToString() + "*" +
                                dr["type"] + "*" +
                                dr["name"] + "*" +
                                dr["time"] + "*" +
                                dr["IDfolderbelong"].ToString() + "*" +
                                dr["recent"].ToString() + "*" +
                                dr["like"].ToString() + "*" + dr["owner"]);
                        foreach (int temp in (List<int>)dr["shared"])
                        {
                            sw.Write("*" + temp.ToString());
                        }
                        sw.WriteLine();
                    }
                }
                sw.Close();
            }

            MessageBox.Show("Move successful");

            ClassData.reloaddata();
            ClassData.ItemMoved();
        }
    }
}
