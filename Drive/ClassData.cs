using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drive
{
    public class ClassData
    {
        public static DataTable dtFile = new DataTable();
        public static DataTable dtFolder = new DataTable();
        //public static DataTable dtList = new DataTable();

        public static string pathFolder = "DriveData\\data\\Folder.txt";
        public static string pathFile = "DriveData\\data\\File.txt";
        public static string FileDownloadPath = "DriveData\\data\\Download.txt";

        public static void loaddata()
        {
            //Load files & folders
            dtFile.Columns.Add("IDfile", typeof(int));
            dtFile.Columns.Add("IDowner", typeof(int));
            dtFile.Columns.Add("type", typeof(string));
            dtFile.Columns.Add("name", typeof(string));
            //dtFile.Columns.Add("time", typeof(string));
            dtFile.Columns.Add("recent", typeof(bool));
            dtFile.Columns.Add("like", typeof(bool));
            dtFile.Columns.Add("shared", typeof(List<int>));

            try
            {
                StreamReader sr = new StreamReader(pathFile);
                string str;
                while ((str = sr.ReadLine()) != null)
                {
                    string[] st = str.Split('*');
                    if(st.Length < 7)
                    {
                        dtFile.Rows.Add(int.Parse(st[0]),
                                        int.Parse(st[1]),
                                        st[2], st[3],
                                        bool.Parse(st[4]),
                                        bool.Parse(st[5]));
                    }
                    else
                    {
                        List<int> sharedUserID = new List<int> {};
                        for (int i = 6; i < st.Length; i++)
                        {
                            sharedUserID.Add(int.Parse(st[i]));
                        }
                        dtFile.Rows.Add(int.Parse(st[0]),
                                        int.Parse(st[1]),
                                        st[2], st[3],
                                        bool.Parse(st[4]),
                                        bool.Parse(st[5]),
                                        sharedUserID);
                    }
                }
                sr.Close();
            }
            catch { }

            ////Load Playlist
            //dtPlaylist.Columns.Add("ID", typeof(int));
            //dtPlaylist.Columns.Add("name", typeof(string));
            //dtPlaylist.Columns.Add("IDSong", typeof(int));

            //try
            //{
            //    StreamReader sr = new StreamReader(pathPlaylist);
            //    string str;
            //    while ((str = sr.ReadLine()) != null)
            //    {
            //        string[] st = str.Split('*');
            //        dtPlaylist.Rows.Add(int.Parse(st[0]), st[1], int.Parse(st[2]));
            //    }
            //    sr.Close();
            //}
            //catch { }

            ////Load differentiate List
            //dtList.Columns.Add("ID", typeof(int));
            //dtList.Columns.Add("name", typeof(string));

            //List<int> id_list = new List<int>();
            //foreach (DataRow dr in ClassData.dtPlaylist.Rows)
            //{
            //    bool alreadyExist = id_list.Contains((int)dr["ID"]);
            //    if (!alreadyExist)
            //    {
            //        id_list.Add((int)dr["ID"]);
            //    }
            //}

            //for (int i = 0; i < id_list.Count; i++)
            //{
            //    foreach (DataRow dr in ClassData.dtPlaylist.Rows)
            //    {
            //        if ((int)dr["ID"] == id_list[i])
            //        {
            //            dtList.Rows.Add((int)dr["ID"], dr["Name"]);
            //            break;
            //        }
            //    }
            //}
        }
    }
}
