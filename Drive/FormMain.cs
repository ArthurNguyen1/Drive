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
using System.Windows.Forms.VisualStyles;

namespace Drive
{
    public partial class FormMain : Form
    {
        DataTable dtFiles = null;

        uctHome Home = new uctHome();

        public FormMain()
        {
            InitializeComponent();
            dtFiles = new DataTable();

            this.Controls.Add(Home);
            Home.Location = new Point(187, 65);
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            ClassData.loaddata();
            Reset();
            pnNew.Visible = false;

            Home.Visible = true;

            dtFiles = ClassData.dtFile.Copy();
            Home.LoadDataDown(dtFiles);

            pnHome.BackColor = Color.LightSkyBlue;
            picHome.BackColor = Color.LightSkyBlue;
        }

        void Reset()
        {
            pnHome.BackColor = Color.WhiteSmoke;
            picHome.BackColor = Color.WhiteSmoke;


            Home.Visible = false;

            //dtLoves = ClassData.dtSong.Select("love=true").CopyToDataTable();
            //dtRecents = ClassData.dtSong.Select("play=true").CopyToDataTable();
            //dtMusics = ClassData.dtSong.Copy();
        }

        private void pnHome_Click(object sender, EventArgs e)
        {
            Reset();
            Home.Visible = true;
            //if (ClassData.dtSong.Select("play=true").Length > 0)
            //{
            //    dtRecents = ClassData.dtSong.Select("play=true").CopyToDataTable();
            //}
            //Recents.LoadDataDown(dtRecents);
            pnHome.BackColor = Color.LightSkyBlue;
            picHome.BackColor = Color.LightSkyBlue;
        }

        private void lblHome_Click(object sender, EventArgs e)
        {
            Reset();
            Home.Visible = true;
            pnHome.BackColor = Color.LightSkyBlue;
            picHome.BackColor = Color.LightSkyBlue;
        }

        private void picHome_Click(object sender, EventArgs e)
        {
            Reset();
            Home.Visible = true;
            pnHome.BackColor = Color.LightSkyBlue;
            picHome.BackColor = Color.LightSkyBlue;
        }

        
        private void btnNew_Click(object sender, EventArgs e)
        {
            pnNew.Visible = true;
        }

        private void pnFunction_Click(object sender, EventArgs e)
        {
            pnNew.Visible = false;
        }

        private void pnUploadFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog f = new OpenFileDialog();
            f.Multiselect = true;
            if (f.ShowDialog() == DialogResult.OK)
            {
                string[] st = f.FileNames;
                if (st.Length % 2 == 0)
                {
                    for (int i = 0; i < st.Length; i++)
                    {
                        //UCpic ucpic = new UCpic();
                        //ucpic.LoadDataPicOnly(st[i], 0);
                        //ucpic.Location = new System.Drawing.Point(0, y_Chat);
                        //ucpic.Size = new System.Drawing.Size(200, 180);
                        //pnChat.Controls.Add(ucpic);
                        ////x_Vid += 300;

                        //FileInfo fi = new FileInfo(st[i]);
                        //string s = "Chat\\photo\\" + Path.GetFileName(st[i]);
                        //FileInfo fii = new FileInfo(s);
                        //if (!fii.Exists)
                        //{
                        //    fi.CopyTo(s);
                        //}
                        //StreamWriter sw = new StreamWriter(pathDataChat, true);
                        //sw.Write("*" + "Chat\\photo\\" + Path.GetFileName(st[i]) + "*" +
                        //         ucpic.Location.X.ToString() + "*" +
                        //         ucpic.Location.Y.ToString() + "*" +
                        //         ucpic.Size.Width.ToString() + "*" +
                        //         ucpic.Size.Height.ToString());
                        //sw.Close();
                    }
                }
                else
                {
                    for (int i = 0; i < st.Length; i++)
                    {
                        //UCpic ucpic = new UCpic();
                        //ucpic.LoadDataPicOnly(st[i], 0);
                        //ucpic.Location = new System.Drawing.Point(0, y_Chat);
                        //ucpic.Size = new System.Drawing.Size(200, 180);
                        //pnChat.Controls.Add(ucpic);
                        ////x_Vid += 300;

                        //FileInfo fi = new FileInfo(st[i]);
                        //string s = "Chat\\photo\\" + Path.GetFileName(st[i]);
                        //FileInfo fii = new FileInfo(s);
                        //if (!fii.Exists)
                        //{
                        //    fi.CopyTo(s);
                        //}
                        //StreamWriter sw = new StreamWriter(pathDataChat, true);
                        //sw.Write("*" + "Chat\\photo\\" + Path.GetFileName(st[i]) + "*" +
                        //         ucpic.Location.X.ToString() + "*" +
                        //         ucpic.Location.Y.ToString() + "*" +
                        //         ucpic.Size.Width.ToString() + "*" +
                        //         ucpic.Size.Height.ToString());
                        //sw.Close();
                    }
                }
            }
        }
    }
}
