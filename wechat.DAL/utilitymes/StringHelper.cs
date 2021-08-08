namespace wechat.DAL.utilitymes
{
    using Newtonsoft.Json.Linq;
    using Newtonsoft.Json;
    using System;
    using System.Drawing;
    using System.Drawing.Drawing2D;
    using System.Drawing.Imaging;
    using System.IO;
    using System.Runtime.Serialization.Json;
    using System.Security.Cryptography;
    using System.Text;
    using System.Text.RegularExpressions;
    using System.Web;
    using System.Windows.Forms;

    public class StringHelper
    {
        public static string ArrayToString(string[] StrArr, string Delimiter)
        {
            string str2;
            if (StrArr.Length == 0)
            {
                str2 = "";
            }
            else
            {
                string str = "";
                string[] strArray = StrArr;
                int index = 0;
                while (true)
                {
                    if (index >= strArray.Length)
                    {
                        if (str.Length > 0)
                        {
                            str = str.Substring(Delimiter.Length, str.Length - Delimiter.Length);
                        }
                        str2 = str;
                        break;
                    }
                    string str3 = strArray[index];
                    if (str3.Trim() != "")
                    {
                        str = (str + Delimiter) + "'" + str3 + "'";
                    }
                    index++;
                }
            }
            return str2;
        }

        public static string ChineseCaps(string ChineseStr)
        {
            string str = "";
            byte[] bytes = new byte[2];
            string str3 = "";
            int startIndex = 0;
            while (true)
            {
                if (startIndex <= (ChineseStr.Length - 1))
                {
                    string s = ChineseStr.Substring(startIndex, 1).ToString();
                    bytes = Encoding.Default.GetBytes(s);
                    if (bytes.Length == 2)
                    {
                        int num4 = bytes[1];
                        long num = (bytes[0] * 0x100) + num4;
                        if ((num >= 0xb0a1L) && (num <= 0xb0c4L))
                        {
                            str3 = "A";
                        }
                        else if ((num >= 0xb0c5L) && (num <= 0xb2c0L))
                        {
                            str3 = "B";
                        }
                        else if ((num >= 0xb2c1L) && (num <= 0xb4edL))
                        {
                            str3 = "C";
                        }
                        else if ((num >= 0xb4eeL) && (num <= 0xb6e9L))
                        {
                            str3 = "D";
                        }
                        else if ((num >= 0xb6eaL) && (num <= 0xb7a1L))
                        {
                            str3 = "E";
                        }
                        else if ((num >= 0xb7a2L) && (num <= 0xb8c0L))
                        {
                            str3 = "F";
                        }
                        else if ((num >= 0xb8c1L) && (num <= 0xb9fdL))
                        {
                            str3 = "G";
                        }
                        else if ((num >= 0xb9feL) && (num <= 0xbbf6L))
                        {
                            str3 = "H";
                        }
                        else if ((num >= 0xbbf7L) && (num <= 0xbfa5L))
                        {
                            str3 = "J";
                        }
                        else if ((num >= 0xbfa6L) && (num <= 0xc0abL))
                        {
                            str3 = "K";
                        }
                        else if ((num >= 0xc0acL) && (num <= 0xc2e7L))
                        {
                            str3 = "L";
                        }
                        else if ((num >= 0xc2e8L) && (num <= 0xc4c2L))
                        {
                            str3 = "M";
                        }
                        else if ((num >= 0xc4c3L) && (num <= 0xc5b5L))
                        {
                            str3 = "N";
                        }
                        else if ((num >= 0xc5b6L) && (num <= 0xc5bdL))
                        {
                            str3 = "O";
                        }
                        else if ((num >= 0xc5beL) && (num <= 0xc6d9L))
                        {
                            str3 = "P";
                        }
                        else if ((num >= 0xc6daL) && (num <= 0xc8baL))
                        {
                            str3 = "Q";
                        }
                        else if ((num >= 0xc8bbL) && (num <= 0xc8f5L))
                        {
                            str3 = "R";
                        }
                        else if ((num >= 0xc8f6L) && (num <= 0xcbf9L))
                        {
                            str3 = "S";
                        }
                        else if ((num >= 0xcbfaL) && (num <= 0xcdd9L))
                        {
                            str3 = "T";
                        }
                        else if ((num >= 0xcddaL) && (num <= 0xcef3L))
                        {
                            str3 = "W";
                        }
                        else if ((num >= 0xcef4L) && (num <= 0xd188L))
                        {
                            str3 = "X";
                        }
                        else if ((num >= 0xd1b9L) && (num <= 0xd4d0L))
                        {
                            str3 = "Y";
                        }
                        else if ((num >= 0xd4d1L) && (num <= 0xd7f9L))
                        {
                            str3 = "Z";
                        }
                        str = str + str3;
                        startIndex++;
                        continue;
                    }
                    str = ChineseStr;
                }
                return str;
            }
        }

        public static string ConventDateFormat(DateTime? mydate) => 
            (mydate != null) ? mydate.Value.ToString("yyyy年MM月dd日") : "  年  月  日 ";

        public static string ConverRandom(int iseed) => 
            new Random(0).Next(iseed).ToString();

        private static string ConvertDateStringToJsonDate(Match m)
        {
            TimeSpan span = (TimeSpan) (DateTime.Parse(m.Groups[0].Value).ToUniversalTime() - DateTime.Parse("1970-01-01"));
            return @"\/Date({span.TotalMilliseconds}+0800)\/";
        }

        public static int ConvertISFFInt(string flag) => 
            (flag != "已签收") ? 0 : 1;

        public static string ConvertISFFStr(int flag) => 
            (flag != 0) ? "已签收" : "已发放";

        private static string ConvertJsonDateToDateString(Match m)
        {
            DateTime time = new DateTime(0x7b2, 1, 1);
            return time.AddMilliseconds((double) long.Parse(m.Groups[1].Value)).ToLocalTime().ToString("yyyy-MM-dd HH:mm:ss");
        }

        public static string ConvertToEn(string text)
        {
            char[] chArray = text.ToCharArray();
            for (int i = 0; i < chArray.Length; i++)
            {
                int index = "。；，？！、“”‘’：".IndexOf(chArray[i]);
                if (index != -1)
                {
                    chArray[i] = ".;,?!\\\"\"'':"[index];
                }
            }
            return new string(chArray);
        }

        public static string ConvertZhuangT(string flag)
        {
            string str = "";
            if (flag == "0")
            {
                str = "未开发票";
            }
            else if (flag == "1")
            {
                str = "已开发票";
            }
            return str;
        }

        public static string CountRate(int a, int b) => 
            (b != 0) ? ((Math.Round((double) (((float) a) / ((float) b)), 4) * 100.0).ToString() + "%") : "0%";

        public static void CreateDirectory(string infoPath)
        {
            DirectoryInfo parent = Directory.GetParent(infoPath);
            if (!parent.Exists)
            {
                parent.Create();
            }
        }

        public static string CreateRandomCode(int codeCount)
        {
            string str3;
            char[] separator = new char[] { ',' };
            string[] strArray = "0,1,2,3,4,5,6,7,8,9,A,B,C,D,E,a,b,c,d,e,f,g,h,i,g,k,l,m,n,o,p,q,r,F,G,H,I,G,K,L,M,N,O,P,Q,R,S,T,U,V,W,X,Y,Z,s,t,u,v,w,x,y,z".Split(separator);
            string str2 = "";
            int num = -1;
            Random random = new Random();
            int num2 = 0;
            while (true)
            {
                if (num2 >= codeCount)
                {
                    str3 = str2;
                    break;
                }
                if (num != -1)
                {
                    random = new Random((num2 * num) * ((int) DateTime.Now.Ticks));
                }
                int index = random.Next(0x23);
                if (num == index)
                {
                    str3 = CreateRandomCode(codeCount);
                    break;
                }
                num = index;
                str2 = str2 + strArray[index];
                num2++;
            }
            return str3;
        }

        public static byte[] CreateValidateGraphic(string validateCode, double width, int height, int fontsize)
        {
            byte[] buffer;
            Bitmap image = new Bitmap((int) Math.Ceiling((double) (validateCode.Length * width)), height);
            Graphics graphics = Graphics.FromImage(image);
            try
            {
                Random random = new Random();
                graphics.Clear(Color.White);
                int num = 0;
                while (true)
                {
                    if (num >= 0x19)
                    {
                        Font font = new Font("Arial", (float) fontsize, FontStyle.Bold);
                        graphics.DrawString(validateCode, font, new LinearGradientBrush(new Rectangle(0, 0, image.Width, image.Height), Color.Blue, Color.DarkRed, 1.2f, true), (float) 3f, (float) 2f);
                        int num6 = 0;
                        while (true)
                        {
                            if (num6 >= 100)
                            {
                                graphics.DrawRectangle(new Pen(Color.Silver), 0, 0, image.Width - 1, image.Height - 1);
                                MemoryStream stream = new MemoryStream();
                                image.Save(stream, ImageFormat.Jpeg);
                                buffer = stream.ToArray();
                                break;
                            }
                            int x = random.Next(image.Width);
                            int y = random.Next(image.Height);
                            image.SetPixel(x, y, Color.FromArgb(random.Next()));
                            num6++;
                        }
                        break;
                    }
                    int num2 = random.Next(image.Width);
                    int num3 = random.Next(image.Width);
                    int num4 = random.Next(image.Height);
                    int num5 = random.Next(image.Height);
                    graphics.DrawLine(new Pen(Color.Silver), num2, num3, num4, num5);
                    num++;
                }
            }
            finally
            {
                graphics.Dispose();
                image.Dispose();
            }
            return buffer;
        }

        public static string cutStr(string str, int lenth)
        {
            if (!string.IsNullOrEmpty(str))
            {
                str = (str.Length > lenth) ? (str.Substring(0, lenth) + "...") : str;
            }
            return str;
        }

        public static string DecodeBase64(string result) => 
            DecodeBase64(Encoding.UTF8, result);

        public static string DecodeBase64(Encoding encode, string result)
        {
            byte[] bytes = Convert.FromBase64String(result);
            try
            {
                return encode.GetString(bytes);
            }
            catch
            {
                return result;
            }
        }

        public static JObject DeserializeStringToJObject(string jsonStr) => 
            (JObject) JsonConvert.DeserializeObject(jsonStr);

        public static string GenerateMD5(string txt)
        {
            string str;
            using (MD5 md = MD5.Create())
            {
                byte[] buffer2 = md.ComputeHash(Encoding.Default.GetBytes(txt));
                StringBuilder builder = new StringBuilder();
                int index = 0;
                while (true)
                {
                    if (index >= buffer2.Length)
                    {
                        str = builder.ToString();
                        break;
                    }
                    builder.Append(buffer2[index].ToString("x2"));
                    index++;
                }
            }
            return str;
        }

        public static string GenerateRandomCode(int length)
        {
            StringBuilder builder = new StringBuilder();
            for (int i = 0; i < length; i++)
            {
                Guid guid = Guid.NewGuid();
                Random random = new Random(guid.GetHashCode());
                builder.Append(random.Next(0, 10));
            }
            return builder.ToString();
        }

        public static string getDateTimeShort(string ShortTime) => 
            (ShortTime == "") ? "" : ShortTime.Substring(0, ShortTime.IndexOf(' '));

        public static string getExtName(string FileName)
        {
            int startIndex = FileName.LastIndexOf(".");
            return ((startIndex <= -1) ? "" : FileName.Substring(startIndex, FileName.Length - startIndex));
        }

        public static string getguidid() => 
            Guid.NewGuid().ToString().Replace("-", "");

        public static string GetIPAddress()
        {
            string strIp = string.Empty;
            strIp = HttpContext.Current.Request.ServerVariables["HTTP_X_FORWARDED_FOR"];
            if ((strIp != null) && (strIp != string.Empty))
            {
                if (strIp.IndexOf(".") != -1)
                {
                    if (strIp.IndexOf(".") == -1)
                    {
                        if (!IsIPAddress(strIp))
                        {
                            strIp = null;
                        }
                        else
                        {
                            return strIp;
                        }
                    }
                    else
                    {
                        string[] strArray = strIp.Replace(" ", "").Replace("'", "").Split(",;".ToCharArray());
                        int index = 0;
                        while (true)
                        {
                            if (index >= strArray.Length)
                            {
                                break;
                            }
                            if ((!IsIPAddress(strArray[index]) || ((strArray[index].Substring(0, 3) == "10.") || (strArray[index].Substring(0, 7) == "192.168"))) || (strArray[index].Substring(0, 7) == "172.16."))
                            {
                                index++;
                                continue;
                            }
                            return strArray[index];
                        }
                    }
                }
                else
                {
                    strIp = null;
                }
            }
            string str2 = ((HttpContext.Current.Request.ServerVariables["HTTP_X_FORWARDED_FOR"] == null) || (HttpContext.Current.Request.ServerVariables["HTTP_X_FORWARDED_FOR"] == string.Empty)) ? HttpContext.Current.Request.ServerVariables["REMOTE_ADDR"] : HttpContext.Current.Request.ServerVariables["HTTP_X_FORWARDED_FOR"];
            if ((strIp == null) || (strIp == string.Empty))
            {
                strIp = HttpContext.Current.Request.ServerVariables["REMOTE_ADDR"];
            }
            if ((strIp == null) || (strIp == string.Empty))
            {
                strIp = HttpContext.Current.Request.UserHostAddress;
            }
            return strIp;
        }

        public static string GetMD5HashFromFile(string fileName)
        {
            string str = "";
            try
            {
                FileStream inputStream = new FileStream(fileName, FileMode.Open);
                byte[] buffer = new MD5CryptoServiceProvider().ComputeHash(inputStream);
                inputStream.Close();
                StringBuilder builder = new StringBuilder();
                int index = 0;
                while (true)
                {
                    if (index >= buffer.Length)
                    {
                        str = builder.ToString();
                        break;
                    }
                    builder.Append(buffer[index].ToString("x2"));
                    index++;
                }
            }
            catch (Exception)
            {
            }
            return str;
        }

        public static double GetNextDouble(Random random, double miniDouble, double maxiDouble) => 
            (random == null) ? 0.0 : ((random.NextDouble() * (maxiDouble - miniDouble)) + miniDouble);

        public static string GetPostData(Stream InputStream) => 
            new StreamReader(InputStream).ReadToEnd();

        public static string getTimestamp() => 
            Convert.ToInt64((DateTime.UtcNow - new DateTime(0x7b2, 1, 1, 0, 0, 0, 0)).TotalSeconds).ToString();

        public static int getusertype(string wxid)
        {
            int num = 1;
            bool flag = true;
            if ((wxid.Length > 9) && (wxid.Substring(wxid.Length - 9, 9) == "@chatroom"))
            {
                num = 2;
                flag = false;
            }
            if (flag && (wxid.Substring(0, 3) == "gh_"))
            {
                num = 3;
                flag = false;
            }
            if (flag && (wxid == "wxid_pzhf43hmwizd11"))
            {
                num = 3;
                flag = false;
            }
            if (flag)
            {
                num = 1;
            }
            return num;
        }

        //public static string getwebsiteurl() => HttpContent.Current.Request.Url.AbsoluteUri.Replace(HttpContext.Current.Request.RawUrl, "");

        public static string getWeekNumber(string weekName)
        {
            string str2 = "";
            string s = weekName.ToLower();
            uint num = PrivateImplementationDetails.ComputeStringHash(s);
            if (num <= 0x26285d10)
            {
                if (num == 0x121cf816)
                {
                    if (s == "saturday")
                    {
                        str2 = "6";
                    }
                }
                else if (num != 0x121ee9b7)
                {
                    if ((num == 0x26285d10) && (s == "tuesday"))
                    {
                        str2 = "2";
                    }
                }
                else if (s == "thursday")
                {
                    str2 = "4";
                }
            }
            else if (num <= 0x4cfa1739)
            {
                if (num != 0x49b74432)
                {
                    if ((num == 0x4cfa1739) && (s == "monday"))
                    {
                        str2 = "1";
                    }
                }
                else if (s == "friday")
                {
                    str2 = "5";
                }
            }
            else if (num != 0xa429a0d9)
            {
                if ((num == 0xc39645d7) && (s == "wednesday"))
                {
                    str2 = "3";
                }
            }
            else if (s == "sunday")
            {
                str2 = "7";
            }
            return str2;
        }

        public static string GuidTo16String()
        {
            long num = 1L;
            foreach (byte num3 in Guid.NewGuid().ToByteArray())
            {
                num *= num3 + 1;
            }
            return $"{(num - DateTime.Now.Ticks):x}";
        }

        public static bool iscontainletter(string str) => 
            Regex.Matches(str, "[a-zA-Z]").Count > 0;

        public static bool iscontainnum(string str) => 
            Regex.Matches(str, "[0-9]").Count > 0;

        public static bool IsConvertToDateTime(string Value)
        {
            DateTime time;
            return (!string.IsNullOrWhiteSpace(Value) ? DateTime.TryParse(Value, out time) : false);
        }

        public static bool IsConvertToFloat(string Value)
        {
            float num;
            return float.TryParse(Value, out num);
        }

        public static bool IsConvertToInt(string Value)
        {
            int num;
            return int.TryParse(Value, out num);
        }

        public static bool IsInDate(DateTime dt, DateTime dt1, DateTime dt2) => 
            (dt.CompareTo(dt1) >= 0) && (dt.CompareTo(dt2) <= 0);

        public static bool IsInt(string inString) => 
            new Regex("^[0-9]*[1-9][0-9]*$").IsMatch(inString.Trim());

        private static bool IsIPAddress(string strIp) => 
            (((strIp != null) && ((strIp != string.Empty) && (strIp.Length >= 7))) && (strIp.Length <= 15)) ? new Regex("^d{1,3}[.]d{1,3}[.]d{1,3}[.]d{1,3}___FCKpd___0quot", RegexOptions.IgnoreCase).IsMatch(strIp) : false;

        private static void IsNullThrow(string Value, string Describe)
        {
            if (string.IsNullOrEmpty(Value))
            {
                throw new Exception(Describe + "不能为空！");
            }
        }

        public static T JsonDeserialize<T>(string jsonString)
        {
            MatchEvaluator evaluator = new MatchEvaluator(StringHelper.ConvertDateStringToJsonDate);
            jsonString = new Regex(@"\d{4}-\d{2}-\d{2}\s\d{2}:\d{2}:\d{2}").Replace(jsonString, evaluator);
            DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(T));
            using (MemoryStream stream = new MemoryStream(Encoding.UTF8.GetBytes(jsonString)))
            {
                return (T) serializer.ReadObject(stream);
            }
        }

        public static string JsonSerializer<T>(T t)
        {
            DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(T));
            using (MemoryStream stream = new MemoryStream())
            {
                serializer.WriteObject(stream, t);
                stream.Close();
                return new Regex(@"\\/Date\((\d+)\+\d+\)\\/").Replace(Encoding.UTF8.GetString(stream.ToArray()), new MatchEvaluator(StringHelper.ConvertJsonDateToDateString));
            }
        }

        public static string LimitStr(string str, int n, string Tailer)
        {
            string str3;
            string str2 = string.Empty;
            if (Encoding.Default.GetByteCount(str) <= n)
            {
                str3 = str;
            }
            else
            {
                int num = 0;
                char[] chArray = str.ToCharArray();
                int index = 0;
                while (true)
                {
                    if ((index >= chArray.Length) || (num >= n))
                    {
                        break;
                    }
                    if ((chArray[index] < '一') || (chArray[index] > 0x9fa5))
                    {
                        str2 = str2 + chArray[index].ToString();
                        num++;
                    }
                    else
                    {
                        if ((num + 2) > n)
                        {
                            break;
                        }
                        str2 = str2 + chArray[index].ToString();
                        num += 2;
                    }
                    index++;
                }
                str3 = str2 + Tailer;
            }
            return str3;
        }

        public static string LimitString(string Str, int length, string Tailer) => 
            (Str.Length <= length) ? Str : (Str.Substring(0, length) + Tailer);

        public static string MD5Encrypt(string password, int bit)
        {
            StringBuilder builder = new StringBuilder();
            foreach (byte num2 in new MD5CryptoServiceProvider().ComputeHash(Encoding.GetEncoding("gb2312").GetBytes(password)))
            {
                builder.Append(num2.ToString("x2"));
            }
            return ((bit != 0x10) ? ((bit != 0x20) ? string.Empty : builder.ToString()) : builder.ToString().Substring(8, 0x10));
        }

        public static string[] StringSplit(string mystring, char mychar)
        {
            char[] separator = new char[] { mychar };
            return mystring.Split(separator);
        }

        public static string StringToJson(string JsonString)
        {
            StringBuilder builder = new StringBuilder();
            int index = 0;
            goto TR_0014;
        TR_0001:
            index++;
        TR_0014:
            while (true)
            {
                if (index >= JsonString.Length)
                {
                    return builder.ToString();
                }
                char ch = JsonString.ToCharArray()[index];
                char ch2 = ch;
                if (ch2 > '"')
                {
                    if (ch2 == '/')
                    {
                        builder.Append(@"\/");
                        break;
                    }
                    if (ch2 == '\\')
                    {
                        builder.Append(@"\\");
                        break;
                    }
                }
                else
                {
                    switch (ch2)
                    {
                        case '\b':
                            builder.Append(@"\b");
                            goto TR_0001;

                        case '\t':
                            builder.Append(@"\t");
                            goto TR_0001;

                        case '\n':
                            builder.Append(@"\n");
                            goto TR_0001;

                        case '\v':
                            break;

                        case '\f':
                            builder.Append(@"\f");
                            goto TR_0001;

                        case '\r':
                            builder.Append(@"\r");
                            goto TR_0001;

                        default:
                            if (ch2 != '"')
                            {
                                break;
                            }
                            builder.Append("\\\"");
                            goto TR_0001;
                    }
                }
                if (!(((ch < '\0') || (ch > '\x001f')) ? (ch == '\x007f') : true))
                {
                    builder.Append(ch);
                }
                break;
            }
            goto TR_0001;
        }

        public static string[] ToChinaDate(DateTime mydate)
        {
            string str = mydate.Year.ToString();
            string str2 = mydate.Month.ToString();
            string str3 = mydate.Day.ToString();
            string str4 = "";
            string str5 = "";
            string str6 = "";
            int startIndex = 0;
            while (true)
            {
                uint num3;
                if (startIndex >= str.Length)
                {
                    if (str2.Length > 1)
                    {
                        string str8 = str2.Substring(0, 1);
                        if (str8 == "1")
                        {
                            str5 = str5 + "十";
                        }
                        else if (str8 == "2")
                        {
                            str5 = str5 + "二十";
                        }
                        else if (str8 == "3")
                        {
                            str5 = str5 + "三十";
                        }
                    }
                    string str9 = str2.Substring(str2.Length - 1, 1);
                    num3 = PrivateImplementationDetails.ComputeStringHash(str9);
                    if (num3 <= 0x330ca589)
                    {
                        if (num3 <= 0x310ca263)
                        {
                            if (num3 != 0x300ca0d0)
                            {
                                if ((num3 == 0x310ca263) && (str9 == "4"))
                                {
                                    str5 = str5 + "四";
                                }
                            }
                            else if (str9 == "5")
                            {
                                str5 = str5 + "五";
                            }
                        }
                        else if (num3 != 0x320ca3f6)
                        {
                            if ((num3 == 0x330ca589) && (str9 == "6"))
                            {
                                str5 = str5 + "六";
                            }
                        }
                        else if (str9 == "7")
                        {
                            str5 = str5 + "七";
                        }
                    }
                    else if (num3 <= 0x360caa42)
                    {
                        if (num3 != 0x340ca71c)
                        {
                            if ((num3 == 0x360caa42) && (str9 == "3"))
                            {
                                str5 = str5 + "三";
                            }
                        }
                        else if (str9 == "1")
                        {
                            str5 = str5 + "一";
                        }
                    }
                    else if (num3 == 0x370cabd5)
                    {
                        if (str9 == "2")
                        {
                            str5 = str5 + "二";
                        }
                    }
                    else if (num3 != 0x3c0cb3b4)
                    {
                        if ((num3 == 0x3d0cb547) && (str9 == "8"))
                        {
                            str5 = str5 + "八";
                        }
                    }
                    else if (str9 == "9")
                    {
                        str5 = str5 + "九";
                    }
                    if (str3.Length > 1)
                    {
                        string str10 = str3.Substring(0, 1);
                        if (str10 == "1")
                        {
                            str6 = str6 + "十";
                        }
                        else if (str10 == "2")
                        {
                            str6 = str6 + "二十";
                        }
                        else if (str10 == "3")
                        {
                            str6 = str6 + "三十";
                        }
                    }
                    string str11 = str3.Substring(str3.Length - 1, 1);
                    num3 = PrivateImplementationDetails.ComputeStringHash(str11);
                    if (num3 <= 0x330ca589)
                    {
                        if (num3 <= 0x310ca263)
                        {
                            if (num3 != 0x300ca0d0)
                            {
                                if ((num3 == 0x310ca263) && (str11 == "4"))
                                {
                                    str6 = str6 + "四";
                                }
                            }
                            else if (str11 == "5")
                            {
                                str6 = str6 + "五";
                            }
                        }
                        else if (num3 != 0x320ca3f6)
                        {
                            if ((num3 == 0x330ca589) && (str11 == "6"))
                            {
                                str6 = str6 + "六";
                            }
                        }
                        else if (str11 == "7")
                        {
                            str6 = str6 + "七";
                        }
                    }
                    else if (num3 <= 0x360caa42)
                    {
                        if (num3 != 0x340ca71c)
                        {
                            if ((num3 == 0x360caa42) && (str11 == "3"))
                            {
                                str6 = str6 + "三";
                            }
                        }
                        else if (str11 == "1")
                        {
                            str6 = str6 + "一";
                        }
                    }
                    else if (num3 == 0x370cabd5)
                    {
                        if (str11 == "2")
                        {
                            str6 = str6 + "二";
                        }
                    }
                    else if (num3 != 0x3c0cb3b4)
                    {
                        if ((num3 == 0x3d0cb547) && (str11 == "8"))
                        {
                            str6 = str6 + "八";
                        }
                    }
                    else if (str11 == "9")
                    {
                        str6 = str6 + "九";
                    }
                    return new string[] { str4, str5, str6 };
                }
                string s = str.Substring(startIndex, 1);
                num3 = PrivateImplementationDetails.ComputeStringHash(s);
                if (num3 <= 0x340ca71c)
                {
                    if (num3 <= 0x310ca263)
                    {
                        if (num3 != 0x300ca0d0)
                        {
                            if ((num3 == 0x310ca263) && (s == "4"))
                            {
                                str4 = str4 + "四";
                            }
                        }
                        else if (s == "5")
                        {
                            str4 = str4 + "五";
                        }
                    }
                    else if (num3 == 0x320ca3f6)
                    {
                        if (s == "7")
                        {
                            str4 = str4 + "七";
                        }
                    }
                    else if (num3 != 0x330ca589)
                    {
                        if ((num3 == 0x340ca71c) && (s == "1"))
                        {
                            str4 = str4 + "一";
                        }
                    }
                    else if (s == "6")
                    {
                        str4 = str4 + "六";
                    }
                }
                else if (num3 <= 0x360caa42)
                {
                    if (num3 != 0x350ca8af)
                    {
                        if ((num3 == 0x360caa42) && (s == "3"))
                        {
                            str4 = str4 + "三";
                        }
                    }
                    else if (s == "0")
                    {
                        str4 = str4 + "○";
                    }
                }
                else if (num3 == 0x370cabd5)
                {
                    if (s == "2")
                    {
                        str4 = str4 + "二";
                    }
                }
                else if (num3 != 0x3c0cb3b4)
                {
                    if ((num3 == 0x3d0cb547) && (s == "8"))
                    {
                        str4 = str4 + "八";
                    }
                }
                else if (s == "9")
                {
                    str4 = str4 + "九";
                }
                startIndex++;
            }
        }

        public static string ToDBC(string input)
        {
            input = input.Replace('【', '[').Replace('】', ']');
            char[] chArray = input.ToCharArray();
            for (int i = 0; i < chArray.Length; i++)
            {
                if (chArray[i] == '　')
                {
                    chArray[i] = ' ';
                }
                else if ((chArray[i] > 0xff00) && (chArray[i] < 0xff5f))
                {
                    chArray[i] = (char) (chArray[i] - 0xfee0);
                }
            }
            return new string(chArray);
        }

        public static string ToSBC(string input)
        {
            char[] chArray = input.ToCharArray();
            for (int i = 0; i < chArray.Length; i++)
            {
                if (chArray[i] == ' ')
                {
                    chArray[i] = '　';
                }
                else if (chArray[i] < '\x007f')
                {
                    chArray[i] = (char) (chArray[i] + 0xfee0);
                }
            }
            return new string(chArray);
        }

        public static string urlconvertor(string imagesurl1)
        {
            string oldValue = HttpContext.Current.Server.MapPath(HttpContext.Current.Request.ApplicationPath.ToString());
            return imagesurl1.Replace(oldValue, "").Replace("/", "/");
        }

        public static string urlconvertorlocal(string imagesurl1) => 
            HttpContext.Current.Server.MapPath(HttpContext.Current.Request.ApplicationPath.ToString()) + imagesurl1.Replace("/", "/");

        public static bool VeriFy(string val, string regstr) => 
            new Regex(regstr).IsMatch(val);

        public class vertify
        {
            public static string iDecimal =>
                @"\d+(\.\d+)?";

            public static string iInt =>
                @"\d+";

            public static string iMail =>
                @"\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*";

            public static string QSType =>
                @"\^QS\d{4}\ \d{4} \d{4}$";
        }
    }
}

