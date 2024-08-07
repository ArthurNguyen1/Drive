﻿using System;
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
        public static DataTable dtFileShared = new DataTable();
        public static DataTable dtFileRecent = new DataTable();

        //public static DataTable dtList = new DataTable();

        //public static DataTable dtInUse = new DataTable();

        public static string pathFolder = $"UserData\\folder\\{StartForm.userID}_folder.txt";
        public static string pathFile = $"UserData\\file\\{StartForm.userID}_file.txt";
        public static string FileDownloadPath = $"UserData\\download\\{StartForm.userID}_download.txt";
        public static string FileDeletePath = $"UserData\\delete\\{StartForm.userID}_delete.txt";
        public static string FileShared = $"UserData\\file_shared\\{StartForm.userID}_fileshared.txt";
        public static string FileRecent = $"UserData\\file_recent\\{StartForm.userID}_filerecent.txt";

        public static int currentFolderID = 0; // folder root
        public static int chosenFileID = -1;
        public static string chosenFildeName = "";
        public static string chosenFileType = "";

        public static int nextFileID = 101;
        public static int nextFolderID = 1;

        public static bool isDisplayFile = true; // true: File display, false: Folder display
        public static bool isListMode = true; // true: Display in List mode, false: Display in Grid mode

        public static string FolderName;

        public delegate void ClickEventHandler();
        public static event ClickEventHandler OnItemClicked;
        public static event ClickEventHandler OnPanelClosed;
        public static event ClickEventHandler OnFolderClicked;
        public static event ClickEventHandler OnFolderBacked;
        public static event ClickEventHandler OnItemMoved;


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
        public static void FolderClicked()
        {
            if (OnFolderClicked != null)
                OnFolderClicked();
        }
        public static void FolderBacked()
        {
            if (OnFolderBacked != null)
                OnFolderBacked();
        }
        public static void ItemMoved()
        {
            if (OnItemMoved != null)
                OnItemMoved();
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
            dtFile.Columns.Add("owner", typeof(string));            // owner
            dtFile.Columns.Add("shared", typeof(List<int>));        // List of others' userID can see this file/folder by sharing

            try
            {
                StreamReader sr = new StreamReader(pathFile);
                string str;
                while ((str = sr.ReadLine()) != null)
                {
                    string[] st = str.Split('*');
                    if (st.Length < 9)
                    {
                        dtFile.Rows.Add(int.Parse(st[0]),
                                        int.Parse(st[1]),
                                        st[2], st[3], st[4],
                                        int.Parse(st[5]),
                                        bool.Parse(st[6]),
                                        bool.Parse(st[7]),
                                        st[8],
                                        null);
                    }
                    else
                    {
                        List<int> sharedUserID = new List<int> { };
                        for (int i = 9; i < st.Length; i++)
                        {
                            sharedUserID.Add(int.Parse(st[i]));
                        }
                        dtFile.Rows.Add(int.Parse(st[0]),
                                        int.Parse(st[1]),
                                        st[2], st[3], st[4],
                                        int.Parse(st[5]),
                                        bool.Parse(st[6]),
                                        bool.Parse(st[7]),
                                        st[8],
                                        sharedUserID);
                    }
                    nextFileID++;
                }
                sr.Close();
            }
            catch { }

            //Load files shared with me
            dtFileShared.Columns.Add("ID", typeof(int));                  // ID of file (ID > 100)
            dtFileShared.Columns.Add("IDowner", typeof(int));             // ID of user upload (ID >= 1000)
            dtFileShared.Columns.Add("type", typeof(string));             // type like .docx, .pdf, ...
            dtFileShared.Columns.Add("name", typeof(string));             // name of the file or folder
            dtFileShared.Columns.Add("time", typeof(string));             // time upload or read or update that file or folder
            dtFileShared.Columns.Add("IDfolderbelong", typeof(int));      // ID of folder contain that file, if file in the root folder, then IDfolderbelong = 0  
            dtFileShared.Columns.Add("recent", typeof(bool));             // if a file is opened, then turn this bool to true
            dtFileShared.Columns.Add("like", typeof(bool));               // if a file is marked as a favorite file, then turn this bool to true
            dtFileShared.Columns.Add("owner", typeof(string));        // owner
            dtFileShared.Columns.Add("shared", typeof(List<int>));        // List of others' userID can see this file/folder by sharing

            try
            {
                StreamReader sr = new StreamReader(FileShared);
                string str;
                while ((str = sr.ReadLine()) != null)
                {
                    string[] st = str.Split('*');
                    if (st.Length < 9)
                    {
                        dtFileShared.Rows.Add(int.Parse(st[0]),
                                        int.Parse(st[1]),
                                        st[2], st[3], st[4],
                                        int.Parse(st[5]),
                                        bool.Parse(st[6]),
                                        bool.Parse(st[7]),
                                        st[8],
                                        null);
                    }
                    else
                    {
                        List<int> sharedUserID = new List<int> { };
                        for (int i = 9; i < st.Length; i++)
                        {
                            sharedUserID.Add(int.Parse(st[i]));
                        }
                        dtFileShared.Rows.Add(int.Parse(st[0]),
                                        int.Parse(st[1]),
                                        st[2], st[3], st[4],
                                        int.Parse(st[5]),
                                        bool.Parse(st[6]),
                                        bool.Parse(st[7]),
                                        st[8],
                                        sharedUserID);
                    }
                }
                sr.Close();
            }
            catch { }

            //Load files open recent
            dtFileRecent.Columns.Add("ID", typeof(int));                  // ID of file (ID > 100)
            dtFileRecent.Columns.Add("IDowner", typeof(int));             // ID of user upload (ID >= 1000)
            dtFileRecent.Columns.Add("type", typeof(string));             // type like .docx, .pdf, ...
            dtFileRecent.Columns.Add("name", typeof(string));             // name of the file or folder
            dtFileRecent.Columns.Add("time", typeof(string));             // time upload or read or update that file or folder
            dtFileRecent.Columns.Add("IDfolderbelong", typeof(int));      // ID of folder contain that file, if file in the root folder, then IDfolderbelong = 0  
            dtFileRecent.Columns.Add("recent", typeof(bool));             // if a file is opened, then turn this bool to true
            dtFileRecent.Columns.Add("like", typeof(bool));               // if a file is marked as a favorite file, then turn this bool to true
            dtFileRecent.Columns.Add("owner", typeof(string));            // owner
            dtFileRecent.Columns.Add("shared", typeof(List<int>));        // List of others' userID can see this file/folder by sharing

            try
            {
                StreamReader sr = new StreamReader(FileRecent);
                string str;
                while ((str = sr.ReadLine()) != null)
                {
                    string[] st = str.Split('*');
                    if (st.Length < 9)
                    {
                        dtFileRecent.Rows.Add(int.Parse(st[0]),
                                        int.Parse(st[1]),
                                        st[2], st[3], st[4],
                                        int.Parse(st[5]),
                                        bool.Parse(st[6]),
                                        bool.Parse(st[7]),
                                        st[8],
                                        null);
                    }
                    else
                    {
                        List<int> sharedUserID = new List<int> { };
                        for (int i = 9; i < st.Length; i++)
                        {
                            sharedUserID.Add(int.Parse(st[i]));
                        }
                        dtFileRecent.Rows.Add(int.Parse(st[0]),
                                        int.Parse(st[1]),
                                        st[2], st[3], st[4],
                                        int.Parse(st[5]),
                                        bool.Parse(st[6]),
                                        bool.Parse(st[7]),
                                        st[8],
                                        sharedUserID);
                    }
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
            dtFolder.Columns.Add("owner", typeof(string));
            dtFolder.Columns.Add("shared", typeof(List<int>));        // List of others' userID can see this file/folder by sharing

            try
            {
                StreamReader sr = new StreamReader(pathFolder);
                string str;
                while ((str = sr.ReadLine()) != null)
                {
                    string[] st = str.Split('*');
                    if (st.Length < 9)
                    {
                        dtFolder.Rows.Add(int.Parse(st[0]),
                                        int.Parse(st[1]),
                                        st[2], st[3], st[4],
                                        int.Parse(st[5]),
                                        bool.Parse(st[6]),
                                        bool.Parse(st[7]),
                                        st[8],
                                        null);
                    }
                    else
                    {
                        List<int> sharedUserID = new List<int> { };
                        for (int i = 9; i < st.Length; i++)
                        {
                            sharedUserID.Add(int.Parse(st[i]));
                        }
                        dtFolder.Rows.Add(int.Parse(st[0]),
                                        int.Parse(st[1]),
                                        st[2], st[3], st[4],
                                        int.Parse(st[5]),
                                        bool.Parse(st[6]),
                                        bool.Parse(st[7]),
                                        st[8],
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
            dtDelete.Columns.Add("owner", typeof(string));
            dtDelete.Columns.Add("shared", typeof(List<int>));        // List of others' userID can see this file/folder by sharing

            try
            {
                StreamReader sr = new StreamReader(FileDeletePath);
                string str;
                while ((str = sr.ReadLine()) != null)
                {
                    string[] st = str.Split('*');
                    if (st.Length < 9)
                    {
                        dtDelete.Rows.Add(int.Parse(st[0]),
                                        int.Parse(st[1]),
                                        st[2], st[3], st[4],
                                        int.Parse(st[5]),
                                        bool.Parse(st[6]),
                                        bool.Parse(st[7]),
                                        st[8],
                                        null);
                    }
                    else
                    {
                        List<int> sharedUserID = new List<int> { };
                        for (int i = 9; i < st.Length; i++)
                        {
                            sharedUserID.Add(int.Parse(st[i]));
                        }
                        dtDelete.Rows.Add(int.Parse(st[0]),
                                        int.Parse(st[1]),
                                        st[2], st[3], st[4],
                                        int.Parse(st[5]),
                                        bool.Parse(st[6]),
                                        bool.Parse(st[7]),
                                        st[8],
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
            dtFileRecent.Clear();
            dtFileShared.Clear();

            //Load file again
            try
            {
                StreamReader sr = new StreamReader(pathFile);
                string str;
                while ((str = sr.ReadLine()) != null)
                {
                    string[] st = str.Split('*');
                    if (st.Length < 9)
                    {
                        dtFile.Rows.Add(int.Parse(st[0]),
                                        int.Parse(st[1]),
                                        st[2], st[3], st[4],
                                        int.Parse(st[5]),
                                        bool.Parse(st[6]),
                                        bool.Parse(st[7]),
                                        st[8],
                                        null);
                    }
                    else
                    {
                        List<int> sharedUserID = new List<int> { };
                        for (int i = 9; i < st.Length; i++)
                        {
                            sharedUserID.Add(int.Parse(st[i]));
                        }
                        dtFile.Rows.Add(int.Parse(st[0]),
                                        int.Parse(st[1]),
                                        st[2], st[3], st[4],
                                        int.Parse(st[5]),
                                        bool.Parse(st[6]),
                                        bool.Parse(st[7]),
                                        st[8],
                                        sharedUserID);
                    }
                    nextFileID++;
                }
                sr.Close();
            }
            catch { }


            //Load file shared again
            try
            {
                StreamReader sr = new StreamReader(FileShared);
                string str;
                while ((str = sr.ReadLine()) != null)
                {
                    string[] st = str.Split('*');
                    if (st.Length < 9)
                    {
                        dtFileShared.Rows.Add(int.Parse(st[0]),
                                        int.Parse(st[1]),
                                        st[2], st[3], st[4],
                                        int.Parse(st[5]),
                                        bool.Parse(st[6]),
                                        bool.Parse(st[7]),
                                        st[8],
                                        null);
                    }
                    else
                    {
                        List<int> sharedUserID = new List<int> { };
                        for (int i = 9; i < st.Length; i++)
                        {
                            sharedUserID.Add(int.Parse(st[i]));
                        }
                        dtFileShared.Rows.Add(int.Parse(st[0]),
                                        int.Parse(st[1]),
                                        st[2], st[3], st[4],
                                        int.Parse(st[5]),
                                        bool.Parse(st[6]),
                                        bool.Parse(st[7]),
                                        st[8],
                                        sharedUserID);
                    }
                }
                sr.Close();
            }

            catch { }

            //Load file recent again
            try
            {
                StreamReader sr = new StreamReader(FileRecent);
                string str;
                while ((str = sr.ReadLine()) != null)
                {
                    string[] st = str.Split('*');
                    if (st.Length < 9)
                    {
                        dtFileRecent.Rows.Add(int.Parse(st[0]),
                                        int.Parse(st[1]),
                                        st[2], st[3], st[4],
                                        int.Parse(st[5]),
                                        bool.Parse(st[6]),
                                        bool.Parse(st[7]),
                                        st[8],
                                        null);
                    }
                    else
                    {
                        List<int> sharedUserID = new List<int> { };
                        for (int i = 9; i < st.Length; i++)
                        {
                            sharedUserID.Add(int.Parse(st[i]));
                        }
                        dtFileRecent.Rows.Add(int.Parse(st[0]),
                                        int.Parse(st[1]),
                                        st[2], st[3], st[4],
                                        int.Parse(st[5]),
                                        bool.Parse(st[6]),
                                        bool.Parse(st[7]),
                                        st[8],
                                        sharedUserID);
                    }
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
                    if (st.Length < 9)
                    {
                        dtFolder.Rows.Add(int.Parse(st[0]),
                                        int.Parse(st[1]),
                                        st[2], st[3], st[4],
                                        int.Parse(st[5]),
                                        bool.Parse(st[6]),
                                        bool.Parse(st[7]),
                                        st[8],
                                        null);
                    }
                    else
                    {
                        List<int> sharedUserID = new List<int> { };
                        for (int i = 9; i < st.Length; i++)
                        {
                            sharedUserID.Add(int.Parse(st[i]));
                        }
                        dtFolder.Rows.Add(int.Parse(st[0]),
                                        int.Parse(st[1]),
                                        st[2], st[3], st[4],
                                        int.Parse(st[5]),
                                        bool.Parse(st[6]),
                                        bool.Parse(st[7]),
                                        st[8],
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
                    if (st.Length < 9)
                    {
                        dtDelete.Rows.Add(int.Parse(st[0]),
                                        int.Parse(st[1]),
                                        st[2], st[3], st[4],
                                        int.Parse(st[5]),
                                        bool.Parse(st[6]),
                                        bool.Parse(st[7]),
                                        st[8],
                                        null);
                    }
                    else
                    {
                        List<int> sharedUserID = new List<int> { };
                        for (int i = 9; i < st.Length; i++)
                        {
                            sharedUserID.Add(int.Parse(st[i]));
                        }
                        dtDelete.Rows.Add(int.Parse(st[0]),
                                        int.Parse(st[1]),
                                        st[2], st[3], st[4],
                                        int.Parse(st[5]),
                                        bool.Parse(st[6]),
                                        bool.Parse(st[7]),
                                        st[8],
                                        sharedUserID);
                    }
                }
                sr.Close();
            }
            catch { }
        }
    }
}
