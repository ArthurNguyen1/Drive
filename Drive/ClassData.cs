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
        public static DataTable dtDownload = new DataTable();
        public static DataTable dtDelete = new DataTable();

        //public static DataTable dtList = new DataTable();

        //public static DataTable dtInUse = new DataTable();

        public static string pathFolder = "DriveData\\data\\Folder.txt";
        public static string pathFile = "DriveData\\data\\File.txt";
        public static string FileDownloadPath = "DriveData\\data\\Download.txt";
        public static string FileDeletePath = "DriveData\\data\\Delete.txt";

        public static int currentFolderID = 0; // folder root
        public static int chosenFileID = -1;
        public static string chosenFildeName = "";

        public static int nextFileID = 101;
        public static int nextFolderID = 1;

        public static bool isDisplayFile = true; // true: File display, false: Folder display

        public delegate void ClickEventHandler();
        public static event ClickEventHandler OnItemClicked;
        public static event ClickEventHandler OnPanelClosed;

        public static void ItemClicked()
        {
            if (OnItemClicked != null)
                OnItemClicked();
        }

        public static void PanelClosed()
        {
            if (OnPanelClosed != null)
                OnPanelClosed();
        }

        public static void loaddata()
        {
            //Load files
            dtFile.Columns.Add("ID", typeof(int));                  // ID of file (ID > 100)
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
                    nextFileID++;
                }
                sr.Close();
            }
            catch { }

            //Load folders
            dtFolder.Columns.Add("ID", typeof(int));                  // ID of folder (ID <= 100)
            dtFolder.Columns.Add("IDowner", typeof(int));             // ID of user upload (ID >= 1000)
            dtFolder.Columns.Add("type", typeof(string));             // type like .docx, .pdf, ...
            dtFolder.Columns.Add("name", typeof(string));             // name of the file or folder
            dtFolder.Columns.Add("time", typeof(string));             // time upload or read or update that file or folder
            dtFolder.Columns.Add("IDfolderbelong", typeof(int));      // ID of folder contain that file, if file in the root folder, then IDfolderbelong = 0  
            dtFolder.Columns.Add("recent", typeof(bool));             // if a file is opened, then turn this bool to true
            dtFolder.Columns.Add("like", typeof(bool));               // if a file is marked as a favorite file, then turn this bool to true
            dtFolder.Columns.Add("shared", typeof(List<int>));        // List of others' userID can see this file/folder by sharing

            try
            {
                StreamReader sr = new StreamReader(pathFolder);
                string str;
                while ((str = sr.ReadLine()) != null)
                {
                    string[] st = str.Split('*');
                    if (st.Length < 8)
                    {
                        dtFolder.Rows.Add(int.Parse(st[0]),
                                        int.Parse(st[1]),
                                        st[2], st[3], st[4],
                                        int.Parse(st[5]),
                                        bool.Parse(st[6]),
                                        bool.Parse(st[7]),
                                        null);
                    }
                    else
                    {
                        List<int> sharedUserID = new List<int> { };
                        for (int i = 8; i < st.Length; i++)
                        {
                            sharedUserID.Add(int.Parse(st[i]));
                        }
                        dtFolder.Rows.Add(int.Parse(st[0]),
                                        int.Parse(st[1]),
                                        st[2], st[3], st[4],
                                        int.Parse(st[5]),
                                        bool.Parse(st[6]),
                                        bool.Parse(st[7]),
                                        sharedUserID);
                    }
                    nextFolderID++;
                }
                sr.Close();
            }
            catch { }

            //Load download
            dtDownload.Columns.Add("ID", typeof(int));                  // ID of folder (ID <= 100)
            dtDownload.Columns.Add("IDowner", typeof(int));             // ID of user upload (ID >= 1000)
            dtDownload.Columns.Add("type", typeof(string));             // type like .docx, .pdf, ...
            dtDownload.Columns.Add("name", typeof(string));             // name of the file or folder
            dtDownload.Columns.Add("time", typeof(string));             // time upload or read or update that file or folder
            
            try
            {
                StreamReader sr = new StreamReader(FileDownloadPath);
                string str;
                while ((str = sr.ReadLine()) != null)
                {
                    string[] st = str.Split('|');
                    dtDownload.Rows.Add(int.Parse(st[0]),
                                        int.Parse(st[1]),
                                        st[2], st[3], st[4]);
                }
                sr.Close();
            }
            catch { }

            //Load delete files
            dtDelete.Columns.Add("ID", typeof(int));                  // ID of file (ID > 100)
            dtDelete.Columns.Add("IDowner", typeof(int));             // ID of user upload (ID >= 1000)
            dtDelete.Columns.Add("type", typeof(string));             // type like .docx, .pdf, ...
            dtDelete.Columns.Add("name", typeof(string));             // name of the file or folder
            dtDelete.Columns.Add("time", typeof(string));             // time upload or read or update that file or folder
            dtDelete.Columns.Add("IDfolderbelong", typeof(int));      // ID of folder contain that file, if file in the root folder, then IDfolderbelong = 0  
            dtDelete.Columns.Add("recent", typeof(bool));             // if a file is opened, then turn this bool to true
            dtDelete.Columns.Add("like", typeof(bool));               // if a file is marked as a favorite file, then turn this bool to true
            dtDelete.Columns.Add("shared", typeof(List<int>));        // List of others' userID can see this file/folder by sharing

            try
            {
                StreamReader sr = new StreamReader(FileDeletePath);
                string str;
                while ((str = sr.ReadLine()) != null)
                {
                    string[] st = str.Split('*');
                    if (st.Length < 8)
                    {
                        dtDelete.Rows.Add(int.Parse(st[0]),
                                        int.Parse(st[1]),
                                        st[2], st[3], st[4],
                                        int.Parse(st[5]),
                                        bool.Parse(st[6]),
                                        bool.Parse(st[7]),
                                        null);
                    }
                    else
                    {
                        List<int> sharedUserID = new List<int> { };
                        for (int i = 8; i < st.Length; i++)
                        {
                            sharedUserID.Add(int.Parse(st[i]));
                        }
                        dtDelete.Rows.Add(int.Parse(st[0]),
                                        int.Parse(st[1]),
                                        st[2], st[3], st[4],
                                        int.Parse(st[5]),
                                        bool.Parse(st[6]),
                                        bool.Parse(st[7]),
                                        sharedUserID);
                    }
                    nextFileID++;
                }
                sr.Close();
            }
            catch { }
        }

        public static void reloaddata()
        {
            nextFileID = 101;
            nextFolderID = 1;

            dtFile.Clear();
            dtFolder.Clear();
            dtDelete.Clear();

            //Load file again
            try
            {
                StreamReader sr = new StreamReader(pathFile);
                string str;
                while ((str = sr.ReadLine()) != null)
                {
                    string[] st = str.Split('*');
                    if (st.Length < 8)
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
                        List<int> sharedUserID = new List<int> { };
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
                    nextFileID++;
                }
                sr.Close();
            }
            catch { }

            //Load folder again
            try
            {
                StreamReader sr = new StreamReader(pathFolder);
                string str;
                while ((str = sr.ReadLine()) != null)
                {
                    string[] st = str.Split('*');
                    if (st.Length < 8)
                    {
                        dtFolder.Rows.Add(int.Parse(st[0]),
                                        int.Parse(st[1]),
                                        st[2], st[3], st[4],
                                        int.Parse(st[5]),
                                        bool.Parse(st[6]),
                                        bool.Parse(st[7]),
                                        null);
                    }
                    else
                    {
                        List<int> sharedUserID = new List<int> { };
                        for (int i = 8; i < st.Length; i++)
                        {
                            sharedUserID.Add(int.Parse(st[i]));
                        }
                        dtFolder.Rows.Add(int.Parse(st[0]),
                                        int.Parse(st[1]),
                                        st[2], st[3], st[4],
                                        int.Parse(st[5]),
                                        bool.Parse(st[6]),
                                        bool.Parse(st[7]),
                                        sharedUserID);
                    }
                    nextFolderID++;
                }
                sr.Close();
            }
            catch { }

            //Load deleted file again
            try
            {
                StreamReader sr = new StreamReader(FileDeletePath, false);
                string str;
                while ((str = sr.ReadLine()) != null)
                {
                    string[] st = str.Split('*');
                    if (st.Length < 8)
                    {
                        dtDelete.Rows.Add(int.Parse(st[0]),
                                        int.Parse(st[1]),
                                        st[2], st[3], st[4],
                                        int.Parse(st[5]),
                                        bool.Parse(st[6]),
                                        bool.Parse(st[7]),
                                        null);
                    }
                    else
                    {
                        List<int> sharedUserID = new List<int> { };
                        for (int i = 8; i < st.Length; i++)
                        {
                            sharedUserID.Add(int.Parse(st[i]));
                        }
                        dtDelete.Rows.Add(int.Parse(st[0]),
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
        }
    }
}
