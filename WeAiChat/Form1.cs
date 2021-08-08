using CCWin.SkinClass;
using CCWin.SkinControl;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using wechat.DAL.utilitymes;
using wechat.Model.sysmes;

namespace WeAiChat
{
    public partial class Form1 : Form
    {

        public static int nowClintID;
        private static PRecvMessage prm;
        private static PConnected pcon;
        private static PQuit pqt;
        private List<userinfo> usfrilist = new List<userinfo>();
        private static int usfriflag = 0;
        private List<userinfo> usgrouplist = new List<userinfo>();
        private List<userinfo> uspublist = new List<userinfo>();
        private static string codepath = ConfigurationManager.AppSettings["codepath"];

        public Form1()
        {
            InitializeComponent();
        }


        private void begeinbindusfri()
        {
            while (true)
            {
                if (usfriflag == 1)
                {
                    usfriflag = 0;
                    base.Invoke(new EventHandler(delegate {
                        this.bindgvfriend();
                        this.bindgvgroup();
                        this.bindgvpub();
                    }));
                   
                    return;
                }
                Thread.Sleep(300);
            }
        }

        private void bindgvfriend()
        {
            int num = 0;
            DataTable table = new DataTable("usfri");
            table.Columns.Add(new DataColumn("序号", typeof(string)));
            table.Columns.Add(new DataColumn("昵称", typeof(string)));
            table.Columns.Add(new DataColumn("微信号", typeof(string)));
            table.Columns.Add(new DataColumn("微信id", typeof(string)));
            table.Columns.Add(new DataColumn("头像", typeof(string)));
            foreach (userinfo userinfo in this.usfrilist)
            {
                num++;
                DataRow row = table.NewRow();
                row["序号"] = num.ToString();
                row["昵称"] = userinfo.nickname;
                row["微信号"] = userinfo.account;
                row["微信id"] = userinfo.wxid;
                row["头像"] = userinfo.headimg;
                table.Rows.Add(row);
            }
            this.gvfriend.DataSource = table;
        }

        private void bindgvgroup()
        {
            int num = 0;
            DataTable table = new DataTable("usgroup");
            table.Columns.Add(new DataColumn("序号", typeof(string)));
            table.Columns.Add(new DataColumn("昵称", typeof(string)));
            table.Columns.Add(new DataColumn("微信号", typeof(string)));
            table.Columns.Add(new DataColumn("微信id", typeof(string)));
            table.Columns.Add(new DataColumn("头像", typeof(string)));
            foreach (userinfo userinfo in this.usgrouplist)
            {
                num++;
                DataRow row = table.NewRow();
                row["序号"] = num.ToString();
                row["昵称"] = userinfo.nickname;
                row["微信号"] = userinfo.account;
                row["微信id"] = userinfo.wxid;
                row["头像"] = userinfo.headimg;
                table.Rows.Add(row);
            }
            this.gvgroup.DataSource = table;
        }

        private void bindgvpub()
        {
            int num = 0;
            DataTable table = new DataTable("usgroup");
            table.Columns.Add(new DataColumn("序号", typeof(string)));
            table.Columns.Add(new DataColumn("昵称", typeof(string)));
            table.Columns.Add(new DataColumn("微信号", typeof(string)));
            table.Columns.Add(new DataColumn("微信id", typeof(string)));
            table.Columns.Add(new DataColumn("头像", typeof(string)));
            foreach (userinfo userinfo in this.uspublist)
            {
                num++;
                DataRow row = table.NewRow();
                row["序号"] = num.ToString();
                row["昵称"] = userinfo.nickname;
                row["微信号"] = userinfo.account;
                row["微信id"] = userinfo.wxid;
                row["头像"] = userinfo.headimg;
                table.Rows.Add(row);
            }
            this.gvpub.DataSource = table;
        }

        private void btnaddfri_Click(object sender, EventArgs e)
        {
            string text = this.txtv1.Text;
            string str2 = this.txtv2.Text;
            string str3 = this.txtverifytext.Text;
            string s = this.txtsource.Text;
            if ((string.IsNullOrEmpty(text) || string.IsNullOrEmpty(str2)) || string.IsNullOrEmpty(str3))
            {
                MessageBox.Show("v1,v2不能为空");
            }
            else
            {
                var innerData = new
                {
                    v1 = text,
                    v2 = str2,
                    verifytext = str3,
                    source = int.Parse(s)
                };
                this.sendsimplmes(0xbbf, innerData);
                MessageBox.Show("发送指令成功");
            }
        }

        private void btnbase64_1_Click(object sender, EventArgs e)
        {
            string str = this.txtbasesouce1.Text.Trim();
            if (!string.IsNullOrEmpty(str))
            {
                string str2 = StringHelper.DecodeBase64(Encoding.UTF8, str);
                this.txtbasesouce2.Text = str2;
            }
        }

        private void btnbase64_Click(object sender, EventArgs e)
        {
            string str = this.txtbasesouce.Text.Trim();
            if (!string.IsNullOrEmpty(str))
            {
                string str2 = StringHelper.DecodeBase64(Encoding.UTF8, str);
                this.txtbaseres.Text = str2;
            }
        }

        private void btnclearlog_Click(object sender, EventArgs e)
        {
            this.txtlog.Text = "";
        }

        private void btndownimg_Click(object sender, EventArgs e)
        {
            string str = this.txtaeskey.Text.Trim();
            string str2 = this.txtfileid.Text.Trim();
            string str3 = this.txtpath.Text.Trim();
            string str4 = this.txtimgtype.Text.Trim();
            if ((string.IsNullOrEmpty(str) || (string.IsNullOrEmpty(str2) || string.IsNullOrEmpty(str3))) || string.IsNullOrEmpty(str4))
            {
                MessageBox.Show("请填写完整信息");
            }
            else
            {
                var innerData = new
                {
                    aeskey = str,
                    fileid = str2,
                    path = str3,
                    type = int.Parse(str4)
                };
                this.sendsimplmes(0x1771, innerData);
                MessageBox.Show("发送指令成功");
            }
        }

        private void btndownv_Click(object sender, EventArgs e)
        {
            byte[] buffer = Convert.FromBase64String(this.txtbase64_data.Text);
            using (FileStream stream = new FileStream(this.txtvoicepath.Text, FileMode.Create, FileAccess.Write))
            {
                stream.Write(buffer, 0, buffer.Length);
                stream.Flush();
            }
            MessageBox.Show("完成");
        }

        private void btndownvioce_Click(object sender, EventArgs e)
        {
            string str = this.txtbufid.Text.Trim();
            string str2 = this.txtmsgid.Text.Trim();
            string str3 = this.txtlength.Text.Trim();
            string str4 = this.txtclient_msgid.Text.Trim();
            if ((string.IsNullOrEmpty(str) || (string.IsNullOrEmpty(str2) || string.IsNullOrEmpty(str3))) || string.IsNullOrEmpty(str4))
            {
                MessageBox.Show("请填写完整信息");
            }
            else
            {
                var innerData = new
                {
                    bufid = long.Parse(str),
                    msgid = long.Parse(str2),
                    length = int.Parse(str3),
                    client_msgid = str4
                };
                this.sendsimplmes(0x1775, innerData);
                MessageBox.Show("发送指令成功");
            }
        }

        private void btnforward_Click(object sender, EventArgs e)
        {
            string str = this.txtforwardwxid.Text.Trim();
            string str2 = this.txtforwardmsgid.Text.Trim();
            if (string.IsNullOrEmpty(str) || string.IsNullOrEmpty(str2))
            {
                MessageBox.Show("请填写接收消息的wxid和消息id");
            }
            else
            {
                List<string> list = new List<string>();
                char[] separator = new char[] { ',' };
                string[] strArray = str.Replace("，", ",").Split(separator);
                int index = 0;
                while (true)
                {
                    if (index >= strArray.Length)
                    {
                        var innerData = new
                        {
                            wxidlist = list,
                            msgid = str2
                        };
                        this.sendsimplmes(0x1394, innerData);
                        MessageBox.Show("发送指令成功");
                        break;
                    }
                    string item = strArray[index];
                    list.Add(item);
                    index++;
                }
            }
        }

        private void btnfrimes_Click(object sender, EventArgs e)
        {
            if (nowClintID <= 0)
            {
                MessageBox.Show("请先登陆");
            }
            else
            {
                string text = this.txtwxid.Text;
                if (string.IsNullOrEmpty(text))
                {
                    MessageBox.Show("请填写微信id");
                }
                else
                {
                    var innerData = new
                    {
                        wxid = text
                    };
                    this.sendsimplmes(0x9c5, innerData);
                }
            }
        }

        private void btngetcode_Click(object sender, EventArgs e)
        {
            this.sendsimplmes(0x3e8, null);
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            ImportFromDLL.WXCmdOpenWechat();
        }

        private void btnloginout_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("确定要退出微信吗？", "退出", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.sendsimplmes(0x3ea, null);
            }
        }

        private void btnroomaddfri_Click(object sender, EventArgs e)
        {
            string text = this.txtroom.Text;
            string str2 = this.txtroomwxid.Text;
            string str3 = this.txtroomverifytext.Text;
            if ((string.IsNullOrEmpty(text) || string.IsNullOrEmpty(str2)) || string.IsNullOrEmpty(str3))
            {
                MessageBox.Show("请填写群id等信息");
            }
            else
            {
                var innerData = new
                {
                    room = text,
                    wxid = str2,
                    verifytext = str3
                };
                this.sendsimplmes(0xbc0, innerData);
                MessageBox.Show("发送指令成功");
            }
        }

        private void btnroomlink_Click(object sender, EventArgs e)
        {
            string str = this.txtsendmes.Text.Trim();
            string str2 = this.txtwxid.Text.Trim();
            if (string.IsNullOrEmpty(str) || string.IsNullOrEmpty(str2))
            {
                MessageBox.Show("请填写接收消息的wxid和消息id");
            }
            else
            {
                List<string> list = new List<string>();
                char[] separator = new char[] { ',' };
                string[] strArray = str.Replace("，", ",").Split(separator);
                int index = 0;
                while (true)
                {
                    if (index >= strArray.Length)
                    {
                        var innerData = new
                        {
                            wxidlist = list,
                            room = str2
                        };
                        this.sendsimplmes(0xfa2, innerData);
                        MessageBox.Show("发送指令成功");
                        break;
                    }
                    string item = strArray[index];
                    list.Add(item);
                    index++;
                }
            }
        }

        private void btnsearchfriend_Click(object sender, EventArgs e)
        {
            string text = this.txtsearchfri.Text;
            if (string.IsNullOrEmpty(text))
            {
                MessageBox.Show("请输入号");
            }
            else
            {
                var innerData = new
                {
                    search = text
                };
                this.sendsimplmes(0xbbe, innerData);
                MessageBox.Show("发送指令成功");
            }
        }

        private void btnsendcard_Click(object sender, EventArgs e)
        {
            if (nowClintID <= 0)
            {
                MessageBox.Show("请先登陆");
            }
            else
            {
                string text = this.txtwxid.Text;
                string str2 = this.txtsendmes.Text;
                string str3 = this.txtsharewxid.Text;
                if ((string.IsNullOrEmpty(text) || string.IsNullOrEmpty(str2)) || string.IsNullOrEmpty(str3))
                {
                    MessageBox.Show("请填写微信id和发送内容");
                }
                else
                {
                    var innerData = new
                    {
                        wxid = text,
                        sharedwxid = str3,
                        nickname = str2
                    };
                    this.sendsimplmes(0x138a, innerData);
                }
            }
        }

        private void btnsendfile_Click(object sender, EventArgs e)
        {
            if (nowClintID <= 0)
            {
                MessageBox.Show("请先登陆");
            }
            else
            {
                string text = this.txtwxid.Text;
                string str2 = this.txtsendmes.Text;
                if (string.IsNullOrEmpty(text) || string.IsNullOrEmpty(str2))
                {
                    MessageBox.Show("请填写微信id和发送内容");
                }
                else
                {
                    var innerData = new
                    {
                        wxid = text,
                        path = str2
                    };
                    this.sendsimplmes(0x138d, innerData);
                }
            }
        }

        private void btnsendgif_Click(object sender, EventArgs e)
        {
            if (nowClintID <= 0)
            {
                MessageBox.Show("请先登陆");
            }
            else
            {
                string text = this.txtwxid.Text;
                string str2 = this.txtsendmes.Text;
                if (string.IsNullOrEmpty(text) || string.IsNullOrEmpty(str2))
                {
                    MessageBox.Show("请填写微信id和发送内容");
                }
                else
                {
                    var innerData = new
                    {
                        wxid = text,
                        path = str2
                    };
                    this.sendsimplmes(0x138f, innerData);
                }
            }
        }

        private void btnsendimg_Click(object sender, EventArgs e)
        {
            if (nowClintID <= 0)
            {
                MessageBox.Show("请先登陆");
            }
            else
            {
                string text = this.txtwxid.Text;
                string str2 = this.txtsendmes.Text;
                if (string.IsNullOrEmpty(text) || string.IsNullOrEmpty(str2))
                {
                    MessageBox.Show("请填写微信id和发送内容");
                }
                else
                {
                    var innerData = new
                    {
                        wxid = text,
                        path = str2
                    };
                    this.sendsimplmes(0x138c, innerData);
                }
            }
        }

        private void btnsendimglink_Click(object sender, EventArgs e)
        {
            if (nowClintID <= 0)
            {
                MessageBox.Show("请先登陆");
            }
            else
            {
                string text = this.txtwxid.Text;
                string str2 = this.txtsendtitle.Text;
                string str3 = this.txtsendsubtitle.Text;
                string str4 = this.txtsendurl.Text;
                string str5 = this.txtimglink.Text;
                if ((string.IsNullOrEmpty(text) || string.IsNullOrEmpty(str2)) || string.IsNullOrEmpty(str3))
                {
                    MessageBox.Show("请填写微信id和标题等");
                }
                else
                {
                    var innerData = new
                    {
                        recver = text,
                        linkitem = new
                        {
                            title = str2,
                            description = str3,
                            url = str4,
                            icon = str5
                        }
                    };
                    this.sendsimplmes(0x138b, innerData);
                }
            }
        }

        private void btnsendsm_Click(object sender, EventArgs e)
        {
            if (nowClintID <= 0)
            {
                MessageBox.Show("请先登陆");
            }
            else
            {
                string str = this.txtsmwxid.Text.Trim();
                string str2 = this.txtsmusername.Text.Trim();
                string str3 = this.txtsmappid.Text.Trim();
                string str4 = this.txtsmpagepath.Text.Trim();
                string str5 = this.txtsmtitle.Text.Trim();
                string str6 = this.txtsmdes.Text.Trim();
                string str7 = this.txtsmthumburl.Text.Trim();
                string str8 = this.txtsmiconpath.Text.Trim();
                int num = int.Parse(this.txtsmdisplaytype.Text.Trim());
                if ((string.IsNullOrEmpty(str) || (string.IsNullOrEmpty(str2) || (string.IsNullOrEmpty(str3) || (string.IsNullOrEmpty(str4) || (string.IsNullOrEmpty(str5) || (string.IsNullOrEmpty(str6) || string.IsNullOrEmpty(str7))))))) || string.IsNullOrEmpty(str8))
                {
                    MessageBox.Show("请填写完整信息");
                }
                else
                {
                    var innerData = new
                    {
                        recver = str,
                        username = str2,
                        appid = str3,
                        pagepath = str4,
                        title = str5,
                        des = str6,
                        thumburl = str7,
                        iconpath = str8,
                        displaytype = num
                    };
                    this.sendsimplmes(0x1393, innerData);
                }
            }
        }

        private void btnsendtext_Click(object sender, EventArgs e)
        {
            if (nowClintID <= 0)
            {
                MessageBox.Show("请先登陆");
            }
            else
            {
                string text = this.txtwxid.Text;
                string str2 = this.txtsendmes.Text;
                if (string.IsNullOrEmpty(text) || string.IsNullOrEmpty(str2))
                {
                    MessageBox.Show("请填写微信id和发送内容");
                }
                else
                {
                    var innerData = new
                    {
                        wxid = text,
                        text = str2
                    };
                    this.sendsimplmes(0x1388, innerData);
                }
            }
        }

        private void btnuserlist_Click(object sender, EventArgs e)
        {
            this.sendsimplmes(0xbc1, null);
            new Thread(new ThreadStart(this.begeinbindusfri)).Start();
        }

        private void btnwxmemo_Click(object sender, EventArgs e)
        {
            if (nowClintID <= 0)
            {
                MessageBox.Show("请先登陆");
            }
            else
            {
                string text = this.txtwxid.Text;
                string str2 = this.txtsendmes.Text;
                if (string.IsNullOrEmpty(text) || string.IsNullOrEmpty(str2))
                {
                    MessageBox.Show("请填写微信id和备注内容");
                }
                else
                {
                    var innerData = new
                    {
                        wxid = text,
                        note = str2
                    };
                    this.sendsimplmes(0xbbb, innerData);
                }
            }
        }

        public static bool CompareDate(string dateStr1, string dateStr2) =>
            DateTime.Compare(Convert.ToDateTime(dateStr1), Convert.ToDateTime(dateStr2)) > 0;

        public void Connect(int clientID)
        {
            this.showlogs("客户端链接：" + clientID);
            nowClintID = clientID;
            Thread.Sleep(10);
            if (this.btnlogin.Visible)
            {
                this.sendsimplmes(0x3e9, null);
            }
        }

     

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("确定要退出吗？", "退出", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
            {
                e.Cancel = true;
            }
            else
            {
                Environment.Exit(0);
                e.Cancel = false;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.btngetcode.Visible = false;
            this.killpro();
            DateTime now = DateTime.Now;
            string str = "2021-8-15";
            if (CompareDate(now.ToString("yyyy-MM-dd"), str))
            {
                MessageBox.Show("已到期");
                Environment.Exit(0);
            }
            else
            {
                this.gvfriend.AlternatingRowsDefaultCellStyle.BackColor = Color.PaleTurquoise;
                this.gvgroup.AlternatingRowsDefaultCellStyle.BackColor = Color.PaleTurquoise;
                Control.CheckForIllegalCrossThreadCalls = false;
                this.headimg.Visible = false;
                this.btnloginout.Visible = false;
                this.identifypic();
            }
        }

        private void getcodemes(string mesdata, int clientid)
        {
            JObject obj2 = JObject.Parse(mesdata);
            string path = Application.StartupPath + @"\TempData\qrcode.png";
            string destFileName = codepath + clientid + ".png";
            if (File.Exists(path))
            {
                File.Copy(path, destFileName, true);
            }
        }

        private void getsearchmes(string mesdata)
        {
            JObject obj2 = JObject.Parse(mesdata);
            if (!(((obj2.Property("v1") == null) || (obj2.Property("v2") == null)) ? ((obj2.Property("v3") != null) && (obj2.Property("v4") != null)) : true))
            {
                this.showlogs("未得到v：" + mesdata);
            }
            else
            {
                if ((obj2.Property("v1") != null) && (obj2.Property("v2") != null))
                {
                    this.txtv1.Text = obj2["v1"].ToString();
                    this.txtv2.Text = obj2["v2"].ToString();
                }
                if ((obj2.Property("v3") != null) && (obj2.Property("v4") != null))
                {
                    this.txtv1.Text = obj2["v3"].ToString();
                    this.txtv2.Text = obj2["v4"].ToString();
                }
            }
        }

        private void getselfmes(string mesdata)
        {
            JObject obj2 = JObject.Parse(mesdata);
            string url = obj2["smallavatar"].ToString();
            string result = obj2["nickname"].ToString();
            result = StringHelper.DecodeBase64(Encoding.UTF8, result);
            string str3 = obj2["wxid"].ToString();
            this.headimg.LoadAsync(url);
            this.lblnickname.Text = "昵称：" + result;
            this.headimg.Visible = true;
        }

        private void getusermeslist(string mesdata)
        {
            JArray array = JArray.Parse(JObject.Parse(mesdata)["contactlist"].ToString());
            this.usfrilist.Clear();
            this.usgrouplist.Clear();
            this.uspublist.Clear();
            int num = 0;
            while (true)
            {
                if (num >= array.Count)
                {
                    usfriflag = 1;
                    return;
                }
                bool flag = true;
                JObject obj3 = JObject.Parse(array[num].ToString());
                string str2 = obj3["account"].ToString();
                string result = obj3["nickname"].ToString();
                result = StringHelper.DecodeBase64(Encoding.UTF8, result);
                string str4 = obj3["v1"].ToString();
                string str5 = obj3["wxid"].ToString();
                string str6 = obj3["smallavatar"].ToString();
                int num2 = 1;
                bool flag2 = str2.Length > 9;
                if (flag2 && (str2.Substring(str2.Length - 9, 9) == "@chatroom"))
                {
                    num2 = 2;
                }
                if (flag && (str5.Substring(0, 3) == "gh_"))
                {
                    flag = false;
                }
                if (flag && (str2 == "cctvnewscenter"))
                {
                    flag = false;
                }
                if (!flag)
                {
                    userinfo item = new userinfo
                    {
                        id = str5,
                        v1 = str4,
                        wxid = str5,
                        account = str2,
                        nickname = result,
                        headimg = str6
                    };
                    this.uspublist.Add(item);
                }
                else
                {
                    if (num2 == 1)
                    {
                        userinfo item = new userinfo
                        {
                            id = str5,
                            v1 = str4,
                            wxid = str5,
                            account = str2,
                            nickname = result,
                            headimg = str6
                        };
                        this.usfrilist.Add(item);
                    }
                    if (num2 == 2)
                    {
                        userinfo item = new userinfo
                        {
                            id = str5,
                            v1 = str4,
                            wxid = str5,
                            account = str2,
                            nickname = result,
                            headimg = str6
                        };
                        this.usgrouplist.Add(item);
                    }
                }
                num++;
            }
        }

        private void gvgroup_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            if ((e.Button == MouseButtons.Right) && (e.RowIndex >= 0))
            {
                this.gvgroup.ClearSelection();
                this.gvgroup.Rows[e.RowIndex].Selected = true;
                this.gvgroup.CurrentCell = this.gvgroup.Rows[e.RowIndex].Cells[e.ColumnIndex];
                this.roomstrip.Show(Control.MousePosition.X, Control.MousePosition.Y);
            }
        }

        public void identifypic()
        {
            pcon = new PConnected(this.Connect);
            prm = new PRecvMessage(this.Recv);
            pqt = new PQuit(this.Quit);
            WXCmdInitSocket(pcon, prm, pqt);
            ImportFromDLL.WXCmdInitDllPath(Application.StartupPath + @"\WeChatElf.dll");
            ImportFromDLL.WXCmdGetLocalWechatVersion(new char[100], 100);
            ImportFromDLL.WXCmdRun();
        }


        #region

        private void killpro()
        {
            Process[] processes = Process.GetProcesses();
            for (int i = 0; i < processes.Length; i++)
            {
                if (processes[i].ProcessName.ToString().ToLower() == "wechat")
                {
                    processes[i].Kill();
                }
            }
        }

        private void loginouthandle()
        {
            this.btnlogin.Visible = true;
            this.btnloginout.Visible = false;
            this.headimg.Visible = false;
            this.lblnickname.Visible = false;
        }

        private void promessage(string mestype, string mesdata)
        {
            string s = mestype;
            uint num =PrivateImplementationDetails.ComputeStringHash(s);
            if (num <= 0x728f7b5c)
            {
                if (num == 0x6875e610)
                {
                    if (s == "22500")
                    {
                        this.getselfmes(mesdata);
                    }
                }
                else if (num == 0x6975e7a3)
                {
                    if (s != "22501")
                    {
                    }
                }
                else if ((num == 0x728f7b5c) && (s == "23006"))
                {
                    this.getsearchmes(mesdata);
                }
            }
            else if (num <= 0x79c1b9a8)
            {
                if (num != 0x798f8661)
                {
                    if ((num == 0x79c1b9a8) && (s == "25008"))
                    {
                    }
                }
                else if (s == "23009")
                {
                    this.getusermeslist(mesdata);
                }
            }
            else if (num != 0xf310ded4)
            {
                if ((num == 0xf410e067) && (s == "21001"))
                {
                    this.wxlogin(mesdata);
                }
            }
            else if (s == "21000")
            {
                this.getcodemes(mesdata, nowClintID);
            }
        }

        private void Quit(int clientID)
        {
            this.showlogs("客户端断开连接：" + clientID);
            nowClintID = -1;
            this.loginouthandle();
        }

        private void Recv(int clientID, string jsonData, int dataSize)
        {
            JObject obj2 = null;
            try
            {
                obj2 = JObject.Parse(jsonData);
            }
            catch (Exception exception)
            {
                string str = DateTime.Now.ToString("yyyyMMdd") + "_recvicelog.txt";
                string text1 = AppDomain.CurrentDomain.BaseDirectory + "/wxlogs/" + str;
                string fileName = text1;
                if (text1 == null)
                {
                    string local1 = text1;
                    fileName = "";
                }
                new wxlog(fileName).log("接收数据：" + jsonData + "，出错信息：" + exception.ToString());
                return;
            }
            try
            {
                if ((obj2["type"] == null) || (obj2["type"].ToString() != "20500"))
                {
                    nowClintID = clientID;
                    if (obj2["type"] != null)
                    {
                        string mestype = obj2["type"].ToString();
                        this.promessage(mestype, obj2["data"].ToString());
                    }
                    this.showlogs("接收的信息：" + jsonData);
                }
            }
            catch (Exception exception2)
            {
                string str4 = DateTime.Now.ToString("yyyyMMdd") + "_recvicelog.txt";
                string text2 = AppDomain.CurrentDomain.BaseDirectory + "/wxlogs/" + str4;
                string fileName = text2;
                if (text2 == null)
                {
                    string local2 = text2;
                    fileName = "";
                }
                new wxlog(fileName).log("接收数据：" + jsonData + "，出错信息2：" + exception2.ToString());
            }
        }

        private void roomstripgetuser_Click(object sender, EventArgs e)
        {
            int index = this.gvgroup.CurrentRow.Index;
            var innerData = new
            {
                room = this.gvgroup.Rows[index].Cells[3].Value.ToString()
            };
            this.sendsimplmes(0xfac, innerData);
            MessageBox.Show("发送指令成功");
        }

        private void sendsimplmes(int xtype, object innerData)
        {
            if (innerData == null)
            {
                string s = JsonConvert.SerializeObject(new { type = xtype });
                byte[] bytes = Encoding.UTF8.GetBytes(s);
                int num = ImportFromDLL.WXCmdSend(nowClintID, bytes);
            }
            else
            {
                string s = JsonConvert.SerializeObject(new
                {
                    type = xtype,
                    data = innerData
                });
                byte[] bytes = Encoding.UTF8.GetBytes(s);
                int num2 = ImportFromDLL.WXCmdSend(nowClintID, bytes);
            }
        }

        private void showlogs(string logmes)
        {
            if (this.txtlog.Text.Length > 0xc350)
            {
                this.txtlog.Text = "";
            }
            StringBuilder builder = new StringBuilder();
            builder.AppendLine($"{ "【" + logmes + "】"}");
            this.txtlog.Text = builder.ToString() + "\r\n" + this.txtlog.Text;
            builder.Clear();
        }

        private void skinButton1_Click(object sender, EventArgs e)
        {
            string str = this.txtroomwxids.Text.Trim();
            if (string.IsNullOrEmpty(str))
            {
                MessageBox.Show("请填写接收消息的wxid和消息id");
            }
            else
            {
                List<string> list = new List<string>();
                char[] separator = new char[] { ',' };
                string[] strArray = str.Replace("，", ",").Split(separator);
                int index = 0;
                while (true)
                {
                    if (index >= strArray.Length)
                    {
                        var innerData = new
                        {
                            wxidlist = list
                        };
                        this.sendsimplmes(0xfa0, innerData);
                        MessageBox.Show("发送指令成功");
                        break;
                    }
                    string item = strArray[index];
                    list.Add(item);
                    index++;
                }
            }
        }

        [DllImport("WXCommand.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern int WXCmdInitSocket(PConnected conn, PRecvMessage recv, PQuit quit);
        private void wxlogin(string mesdata)
        {
            JObject obj2 = JObject.Parse(mesdata);
            if (obj2["state"].ToString() != "1")
            {
                this.showlogs("未登陆!");
            }
            else
            {
                string str2 = obj2["wxid"].ToString();
                this.showlogs("登陆成功!");
                this.btnlogin.Visible = false;
                this.btnloginout.Visible = true;
                var innerData = new
                {
                    wxid = str2
                };
                this.sendsimplmes(0x9c4, innerData);
                var type2 = new
                {
                    open = 1
                };
                this.sendsimplmes(0x1390, type2);
            }
        }

        private delegate void PConnected(int clientID);

        private delegate void PQuit(int clientID);

        private delegate void PRecvMessage(int clientID, string jsondata, int dataSize);
        #endregion

    }
}
