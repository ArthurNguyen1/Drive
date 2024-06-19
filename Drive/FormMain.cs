using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Drive
{
    public partial class FormMain : Form
    {
        DataTable dtRecents = null;

        uctHome Home = new uctHome();        

        public FormMain()
        {
            InitializeComponent();
            dtRecents = new DataTable();

            this.Controls.Add(Home);
            Home.Location = new Point(187, 65);
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            ClassData.loaddata();
            Reset();

            //Home.Visible = true;
            //if (ClassData.dtSong.Select("play=true").Length > 0)
            //{
            //    dtRecents = ClassData.dtSong.Select("play=true").CopyToDataTable();
            //}
            //Recents.LoadDataDown(dtRecents);
            
            //pnHome.BackColor = Color.LightSkyBlue;
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

        //Created combobox with picture
        public sealed class FileCreator : ComboBox
        {
            public FileCreator()
            {
                DrawMode = DrawMode.OwnerDrawFixed;
                DropDownStyle = ComboBoxStyle.DropDownList;
            }

            // Draws the items into the FileCreator object
            protected override void OnDrawItem(DrawItemEventArgs e)
            {
                e.DrawBackground();
                e.DrawFocusRectangle();

                if (e.Index >= 0 && e.Index < Items.Count)
                {
                    DropDownItem item = (DropDownItem)Items[e.Index];

                    e.Graphics.DrawImage(item.Image, e.Bounds.Left, e.Bounds.Top);

                    e.Graphics.DrawString(item.Value, e.Font, new SolidBrush(e.ForeColor), e.Bounds.Left + item.Image.Width, e.Bounds.Top + 2);
                }

                base.OnDrawItem(e);
            }
        }

        public sealed class DropDownItem
        {
            public string Value { get; set; }

            public Image Image { get; set; }

            public DropDownItem()
                : this("")
            { }

            public DropDownItem(string val)
            {
                Value = val;
                Image = new Bitmap(16, 16);
                using (Graphics g = Graphics.FromImage(Image))
                {
                    using (Brush b = new SolidBrush(Color.FromName(val)))
                    {
                        g.DrawRectangle(Pens.White, 0, 0, Image.Width, Image.Height);
                        g.FillRectangle(b, 1, 1, Image.Width - 1, Image.Height - 1);
                    }
                }
            }

            public override string ToString()
            {
                return Value;
            }
        }
        private void btnNew_Click(object sender, EventArgs e)
        {
            FileCreator fileCreator = new FileCreator();

            pnFunction.Controls.Add(fileCreator);
            fileCreator.BringToFront();
            fileCreator.Location = new Point(10, 60);
        }
    }
}
