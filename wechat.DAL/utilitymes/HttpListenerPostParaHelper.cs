namespace wechat.DAL.utilitymes
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Net;
    using System.Text;

    public class HttpListenerPostParaHelper
    {
        private HttpListenerContext request;

        public HttpListenerPostParaHelper(HttpListenerContext request)
        {
            this.request = request;
        }

        private bool CompareBytes(byte[] source, byte[] comparison)
        {
            bool flag2;
            try
            {
                int length = source.Length;
                if (source.Length != comparison.Length)
                {
                    flag2 = false;
                }
                else
                {
                    int index = 0;
                    while (true)
                    {
                        if (index >= length)
                        {
                            flag2 = true;
                        }
                        else
                        {
                            if (source[index] == comparison[index])
                            {
                                index++;
                                continue;
                            }
                            flag2 = false;
                        }
                        break;
                    }
                }
            }
            catch
            {
                flag2 = false;
            }
            return flag2;
        }

        public List<HttpListenerPostValue> GetHttpListenerPostValue()
        {
            try
            {
                List<HttpListenerPostValue> list = new List<HttpListenerPostValue>();
                if ((this.request.Request.ContentType.Length > 20) && (string.Compare(this.request.Request.ContentType.Substring(0, 20), "multipart/form-data;", true) == 0))
                {
                    char[] separator = new char[] { ';' };
                    string[] strArray = this.request.Request.ContentType.Split(separator).Skip<string>(1).ToArray<string>();
                    string str = string.Join(";", strArray).Replace("boundary=", "").Trim();
                    byte[] bytes = Encoding.UTF8.GetBytes("--" + str + "\r\n");
                    byte[] source = Encoding.UTF8.GetBytes("--" + str + "--\r\n");
                    Stream inputStream = this.request.Request.InputStream;
                    MemoryStream stream2 = new MemoryStream();
                    bool flag2 = true;
                    HttpListenerPostValue value2 = null;
                    while (true)
                    {
                        if (!flag2)
                        {
                            break;
                        }
                        byte[] buffer3 = this.ReadLineAsBytes(inputStream);
                        if (!Encoding.UTF8.GetString(buffer3).Equals("\r\n"))
                        {
                            stream2.Write(buffer3, 0, buffer3.Length);
                        }
                        if (this.CompareBytes(bytes, buffer3))
                        {
                            byte[] buffer = new byte[stream2.Length - bytes.Length];
                            stream2.Position = 0L;
                            stream2.Read(buffer, 0, buffer.Length);
                            flag2 = true;
                            if (buffer.Length != 0)
                            {
                                value2.datas = buffer;
                            }
                            list.Add(new HttpListenerPostValue());
                            stream2.Dispose();
                            stream2 = new MemoryStream();
                        }
                        else if (Encoding.UTF8.GetString(buffer3).Contains("Content-Disposition"))
                        {
                            byte[] buffer = new byte[stream2.Length - 2L];
                            stream2.Position = 0L;
                            stream2.Read(buffer, 0, buffer.Length);
                            flag2 = true;
                            char[] chArray2 = new char[] { ';' };
                            value2.name = Encoding.UTF8.GetString(buffer).Replace("Content-Disposition: form-data; name=\"", "").Replace("\"", "").Split(chArray2)[0];
                            stream2.Dispose();
                            stream2 = new MemoryStream();
                        }
                        else if (Encoding.UTF8.GetString(buffer3).Contains("Content-Type"))
                        {
                            flag2 = true;
                            value2.type = 1;
                            stream2.Dispose();
                            stream2 = new MemoryStream();
                        }
                        else if (this.CompareBytes(source, buffer3))
                        {
                            byte[] buffer = new byte[(stream2.Length - source.Length) - 2L];
                            stream2.Position = 0L;
                            stream2.Read(buffer, 0, buffer.Length);
                            value2.datas = buffer;
                            stream2.Dispose();
                            flag2 = false;
                        }
                    }
                }
                return list;
            }
            catch (Exception)
            {
                return null;
            }
        }

        private byte[] ReadLineAsBytes(Stream SourceStream)
        {
            MemoryStream stream = new MemoryStream();
            while (true)
            {
                int num = SourceStream.ReadByte();
                stream.WriteByte((byte) num);
                if (num == 10)
                {
                    stream.Position = 0L;
                    byte[] buffer = new byte[stream.Length];
                    stream.Read(buffer, 0, buffer.Length);
                    return buffer;
                }
            }
        }
    }
}

