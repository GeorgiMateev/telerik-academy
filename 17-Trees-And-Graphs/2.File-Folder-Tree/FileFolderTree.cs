using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace _2.File_Folder_Tree
{
    public class File
    {
        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private long fileSize;
        public long FileSize
        {
            get { return fileSize; }
            set { fileSize = value; }
        }

        public File(string name, long size)
        {
            this.name = name;
            this.fileSize = size;
        }
    }

    public class Folder
    {
        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private File[] files;
        public File[] Files
        {
            get { return files; }
            set { files = value; }
        }

        private Folder[] childFolders;
        public Folder[] ChildFolders
        {
            get { return childFolders; }
            set { childFolders = value; }
        }

        public Folder(string name,File[] files, Folder[] childFolders)
        {
            this.name = name;
            this.files = files;
            this.childFolders = childFolders;
        }

        public Folder(string name)
        {
            this.name = name;
        }

        public void AddFiles(File[] files)
        {
            this.files = files;
        }

        public void AddChildFolders(Folder[] folders)
        {
            this.childFolders = folders;
        }
    }

    public class FileFolderTree
    {
        private Folder rootFolder;
        public Folder RootFolder
        {
            get { return rootFolder; }
            set { rootFolder = value; }
        }

        public FileFolderTree(string rootPath)
        {
            this.rootFolder = new Folder(rootPath);
            this.ConstructTreeDFS(this.rootFolder);
        }

        public void ConstructTreeDFS(Folder dir)
        {
            DirectoryInfo directory = new DirectoryInfo(dir.Name);

            List<DirectoryInfo> childDirs = new List<DirectoryInfo>();
            try
            {
                childDirs = directory.GetDirectories().ToList();
            }
            catch (UnauthorizedAccessException)
            {
                return;
            }

            Folder[] childFolders = new Folder[childDirs.Count];
            for (int i = 0; i < childDirs.Count; i++)
            {
                childFolders[i] = new Folder(childDirs[i].FullName);
            }
            dir.AddChildFolders(childFolders);

            FileInfo[] files = directory.GetFiles();
            File[] f = new File[files.Length];
            for (int i = 0; i < files.Length; i++)
            {
                f[i] = new File(files[i].FullName,files[i].Length);
            }
            dir.AddFiles(f);

            foreach (var item in childFolders)
            {
                ConstructTreeDFS(item);
            }
        }

        public long CalculateFilesSizesDFS(Folder startFolder, string searchForFolder, bool isFound)
        {
            long sizeInBytes = 0;
            if (startFolder.Name==searchForFolder)
            {
                isFound = true;
            }
            if (!isFound)
            {
                foreach (var item in startFolder.ChildFolders)
                {
                    if (item.Name==searchForFolder)
                    {
                        isFound = true;
                        sizeInBytes += CalculateFilesSizesDFS(item, searchForFolder, true);
                        break;
                    }
                }
                return sizeInBytes;
            }
            else
            {
                if (startFolder.Files != null)
                {
                    foreach (var item in startFolder.Files)
                    {
                        sizeInBytes += item.FileSize;
                    }
                }
                if (startFolder.ChildFolders != null)
                {
                    foreach (var item in startFolder.ChildFolders)
                    {
                        sizeInBytes += CalculateFilesSizesDFS(item, searchForFolder, true);
                    }
                }
                return sizeInBytes;
            }
        }
    }
}
