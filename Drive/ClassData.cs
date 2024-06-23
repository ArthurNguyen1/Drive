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

        public static DataTable dtInUse = new DataTable();

        public static string pathFolder = "DriveData\\data\\Folder.txt";
        public static string pathFile = "DriveData\\data\\File.txt";
        public static string FileDownloadPath = "DriveData\\data\\Download.txt";

        public static int currentFolderID = 0; // folder root

        public static void loaddata()
        {
            //Load files & folders
            dtFile.Columns.Add("ID", typeof(int));                  // ID of file (ID > 100) or folder (ID >= 0)
            dtFile.Columns.Add("IDowner", typeof(int));             // ID of user upload (ID >= 1000)
            dtFile.Columns.Add("type", typeof(string));             // type like .docx, .pdf, ...
            dtFile.Columns.Add("name", typeof(string));             // name of the file or folder
            dtFile.Columns.Add("time", typeof(string));             // time upload or read or update that file or folder
            dtFile.Columns.Add("IDfolderbelong", typeof(int));      // ID of folder contain that file, if file in the root folder, then IDfolderbelong = 0  
            dtFile.Columns.Add("recent", typeof(bool));             // if a file is opened, then turn this bool to true
            dtFile.Columns.Add("like", typeof(bool));               // if a file is marked as a favorite file, then turn this bool to true
            dtFile.Columns.Add("shared", typeof(List<int>));        // List of others' userID can see this file/folder by sharing

            try
            {
                StreamReader sr = new StreamReader(pathFile);
                string str;
                while ((str = sr.ReadLine()) != null)
                {
                    string[] st = str.Split('*');
                    if(st.Length < 8)
                    {
                        dtFile.Rows.Add(int.Parse(st[0]),
                                        int.Parse(st[1]),
                                        st[2], st[3], st[4],
                                        int.Parse(st[5]),
                                        bool.Parse(st[6]),
                                        bool.Parse(st[7]), 
                                        null);
                    }
                    else
                    {
                        List<int> sharedUserID = new List<int> {};
                        for (int i = 8; i < st.Length; i++)
                        {
                            sharedUserID.Add(int.Parse(st[i]));
                        }
                        dtFile.Rows.Add(int.Parse(st[0]),
                                        int.Parse(st[1]),
                                        st[2], st[3], st[4],
                                        int.Parse(st[5]),
                                        bool.Parse(st[6]),
                                        bool.Parse(st[7]),
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
