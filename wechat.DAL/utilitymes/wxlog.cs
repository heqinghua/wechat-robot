namespace wechat.DAL.utilitymes
{
    using System;
    using System.IO;

    public class wxlog
    {
        private string logFile;
        private StreamWriter writer;
        private FileStream fileStream = null;

        public wxlog(string fileName)
        {
            this.logFile = fileName;
            this.CreateDirectory(this.logFile);
        }

        public void CreateDirectory(string infoPath)
        {
            DirectoryInfo parent = Directory.GetParent(infoPath);
            if (!parent.Exists)
            {
                parent.Create();
            }
        }

        public void log(string info)
        {
            try
            {
                FileInfo info2 = new FileInfo(this.logFile);
                if (!info2.Exists)
                {
                    this.fileStream = info2.Create();
                    this.writer = new StreamWriter(this.fileStream);
                }
                else
                {
                    this.fileStream = info2.Open(FileMode.Append, FileAccess.Write);
                    this.writer = new StreamWriter(this.fileStream);
                }
                this.writer.WriteLine(DateTime.Now + ": " + info);
            }
            finally
            {
                if (this.writer != null)
                {
                    this.writer.Close();
                    this.writer.Dispose();
                    this.fileStream.Close();
                    this.fileStream.Dispose();
                }
            }
        }
    }
}

