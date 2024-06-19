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
        public static DataTable dtSong = new DataTable();
        public static DataTable dtPlaylist = new DataTable();
        public static DataTable dtList = new DataTable();

        public static string pathPlaylist = "Music\\data\\Playlist.txt";
        public static string pathSong = "Music\\data\\Song.txt";
        public static string FileDownloadPath = "Music\\data\\Download.txt";
        public static string commentsPath = "Music\\data\\Comments.txt";

        public static void loaddata()
        {
            //Load songs
            dtSong.Columns.Add("ID", typeof(int));
            dtSong.Columns.Add("song", typeof(Image));
            dtSong.Columns.Add("video", typeof(string));
            dtSong.Columns.Add("name", typeof(string));
            dtSong.Columns.Add("singer", typeof(string));
            dtSong.Columns.Add("love", typeof(bool));
            dtSong.Columns.Add("play", typeof(bool));
            dtSong.Columns.Add("type", typeof(int));

            try
            {
                StreamReader sr = new StreamReader(pathSong);
                string str;
                while ((str = sr.ReadLine()) != null)
                {
                    string[] st = str.Split('*');
                    dtSong.Rows.Add(int.Parse(st[0]), Image.FromFile(st[1]), st[2], st[3], st[4], bool.Parse(st[5]), bool.Parse(st[6]), int.Parse(st[7]));
                }
                sr.Close();
            }
            catch { }

            //Load Playlist
            dtPlaylist.Columns.Add("ID", typeof(int));
            dtPlaylist.Columns.Add("name", typeof(string));
            dtPlaylist.Columns.Add("IDSong", typeof(int));

            try
            {
                StreamReader sr = new StreamReader(pathPlaylist);
                string str;
                while ((str = sr.ReadLine()) != null)
                {
                    string[] st = str.Split('*');
                    dtPlaylist.Rows.Add(int.Parse(st[0]), st[1], int.Parse(st[2]));
                }
                sr.Close();
            }
            catch { }

            //Load differentiate List
            dtList.Columns.Add("ID", typeof(int));
            dtList.Columns.Add("name", typeof(string));

            List<int> id_list = new List<int>();
            foreach (DataRow dr in ClassData.dtPlaylist.Rows)
            {
                bool alreadyExist = id_list.Contains((int)dr["ID"]);
                if (!alreadyExist)
                {
                    id_list.Add((int)dr["ID"]);
                }
            }

            for (int i = 0; i < id_list.Count; i++)
            {
                foreach (DataRow dr in ClassData.dtPlaylist.Rows)
                {
                    if ((int)dr["ID"] == id_list[i])
                    {
                        dtList.Rows.Add((int)dr["ID"], dr["Name"]);
                        break;
                    }
                }
            }
        }
    }
}
