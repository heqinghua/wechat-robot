using CCWin.SkinClass;
using CCWin.SkinControl;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace WeAiChat
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        private TextBox txtlog;
        private SkinButton btnlogin;
        private SkinButton btnloginout;
        private SkinLabel lblnickname;
        private SkinPictureBox headimg;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private SkinButton btnuserlist;
        private DataGridView gvfriend;
        private DataGridView gvgroup;
        private DataGridView gvpub;
        private Label label1;
        private TabControl tabControl2;
        private TabPage tabPage4;
        private TabPage tabPage5;
        private TabPage tabPage6;
        private Label label2;
        private TextBox txtwxid;
        private Label label4;
        private TextBox txtsendmes;
        private SkinButton btnsendtext;
        private SkinButton btnsendimg;
        private SkinButton btnsendgif;
        private SkinButton btnsendfile;
        private SkinButton btnsendcard;
        private TextBox txtsharewxid;
        private Label label3;
        private Label lbltitle;
        private TextBox txtsendtitle;
        private Label label5;
        private TextBox txtsendsubtitle;
        private Label label6;
        private TextBox txtimglink;
        private Label label7;
        private TextBox txtsendurl;
        private SkinButton btnsendimglink;
        private Label label8;
        private SkinButton btnsearchfriend;
        private TextBox txtsearchfri;
        private Label label9;
        private Label label10;
        private TextBox txtv1;
        private Label label11;
        private TextBox txtv2;
        private Label label12;
        private SkinButton btnaddfri;
        private Label label13;
        private TextBox txtverifytext;
        private Label label14;
        private TextBox txtroom;
        private Label label15;
        private TextBox txtroomwxid;
        private Label label16;
        private TextBox txtroomverifytext;
        private SkinButton btnroomaddfri;
        private Label label17;
        private ContextMenuStrip roomstrip;
        private ToolStripMenuItem roomstripgetuser;
        private SkinButton btnclearlog;
        private Label label18;
        private TextBox txtsource;
        private Label label19;
        private Label label20;
        private TextBox txtforwardwxid;
        private Label label21;
        private Label label22;
        private TextBox txtforwardmsgid;
        private Label label23;
        private SkinButton btnforward;
        private SkinButton btnwxmemo;
        private TabPage tabPage7;
        private Label label24;
        private TextBox txtsmwxid;
        private Label label25;
        private TextBox txtsmusername;
        private Label label26;
        private TextBox txtsmappid;
        private Label label27;
        private TextBox txtsmpagepath;
        private Label label28;
        private TextBox txtsmtitle;
        private Label label29;
        private TextBox txtsmdes;
        private Label label30;
        private TextBox txtsmthumburl;
        private Label label31;
        private Label label32;
        private TextBox txtsmiconpath;
        private Label label33;
        private Label label34;
        private TextBox txtsmdisplaytype;
        private Label label35;
        private SkinButton btnsendsm;
        private Label label36;
        private TextBox txtbasesouce;
        private TextBox txtbaseres;
        private SkinButton btnbase64;
        private Label label37;
        private Label label38;
        private TextBox txtroomwxids;
        private SkinButton skinButton1;
        private TabPage tabPage8;
        private Label label39;
        private TextBox txtaeskey;
        private TextBox txtfileid;
        private Label label40;
        private Label label41;
        private TextBox txtpath;
        private Label label42;
        private TextBox txtimgtype;
        private Label label43;
        private SkinButton btndownimg;
        private Label label44;
        private TextBox txtbufid;
        private Label label45;
        private TextBox txtmsgid;
        private Label label46;
        private TextBox txtlength;
        private Label label47;
        private TextBox txtclient_msgid;
        private SkinButton btndownvioce;
        private Label label48;
        private TextBox txtbase64_data;
        private Label label49;
        private TextBox txtvoicepath;
        private SkinButton btndownv;
        private Label label50;
        private TextBox txtbasesouce1;
        private TextBox txtbasesouce2;
        private SkinButton btnbase64_1;
        private SkinButton btnfrimes;
        private SkinButton btngetcode;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.txtlog = new System.Windows.Forms.TextBox();
            this.btnlogin = new CCWin.SkinControl.SkinButton();
            this.btnloginout = new CCWin.SkinControl.SkinButton();
            this.lblnickname = new CCWin.SkinControl.SkinLabel();
            this.headimg = new CCWin.SkinControl.SkinPictureBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.gvfriend = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.gvgroup = new System.Windows.Forms.DataGridView();
            this.roomstrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.roomstripgetuser = new System.Windows.Forms.ToolStripMenuItem();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.gvpub = new System.Windows.Forms.DataGridView();
            this.btnuserlist = new CCWin.SkinControl.SkinButton();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.btngetcode = new CCWin.SkinControl.SkinButton();
            this.btnfrimes = new CCWin.SkinControl.SkinButton();
            this.btnbase64_1 = new CCWin.SkinControl.SkinButton();
            this.txtbasesouce2 = new System.Windows.Forms.TextBox();
            this.txtbasesouce1 = new System.Windows.Forms.TextBox();
            this.label50 = new System.Windows.Forms.Label();
            this.btnwxmemo = new CCWin.SkinControl.SkinButton();
            this.btnforward = new CCWin.SkinControl.SkinButton();
            this.label23 = new System.Windows.Forms.Label();
            this.txtforwardmsgid = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.txtforwardwxid = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnsendimglink = new CCWin.SkinControl.SkinButton();
            this.txtsendurl = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtimglink = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtsendsubtitle = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtsendtitle = new System.Windows.Forms.TextBox();
            this.lbltitle = new System.Windows.Forms.Label();
            this.txtsharewxid = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnsendcard = new CCWin.SkinControl.SkinButton();
            this.btnsendfile = new CCWin.SkinControl.SkinButton();
            this.btnsendgif = new CCWin.SkinControl.SkinButton();
            this.btnsendimg = new CCWin.SkinControl.SkinButton();
            this.btnsendtext = new CCWin.SkinControl.SkinButton();
            this.txtsendmes = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtwxid = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.label19 = new System.Windows.Forms.Label();
            this.txtsource = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.txtverifytext = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.btnaddfri = new CCWin.SkinControl.SkinButton();
            this.label12 = new System.Windows.Forms.Label();
            this.txtv2 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtv1 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtsearchfri = new System.Windows.Forms.TextBox();
            this.btnsearchfriend = new CCWin.SkinControl.SkinButton();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.skinButton1 = new CCWin.SkinControl.SkinButton();
            this.label38 = new System.Windows.Forms.Label();
            this.txtroomwxids = new System.Windows.Forms.TextBox();
            this.label37 = new System.Windows.Forms.Label();
            this.btnbase64 = new CCWin.SkinControl.SkinButton();
            this.txtbaseres = new System.Windows.Forms.TextBox();
            this.txtbasesouce = new System.Windows.Forms.TextBox();
            this.label36 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.btnroomaddfri = new CCWin.SkinControl.SkinButton();
            this.txtroomverifytext = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtroomwxid = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtroom = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.btnsendsm = new CCWin.SkinControl.SkinButton();
            this.label35 = new System.Windows.Forms.Label();
            this.txtsmdisplaytype = new System.Windows.Forms.TextBox();
            this.label34 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.txtsmiconpath = new System.Windows.Forms.TextBox();
            this.label32 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.txtsmthumburl = new System.Windows.Forms.TextBox();
            this.label30 = new System.Windows.Forms.Label();
            this.txtsmdes = new System.Windows.Forms.TextBox();
            this.label29 = new System.Windows.Forms.Label();
            this.txtsmtitle = new System.Windows.Forms.TextBox();
            this.label28 = new System.Windows.Forms.Label();
            this.txtsmpagepath = new System.Windows.Forms.TextBox();
            this.label27 = new System.Windows.Forms.Label();
            this.txtsmappid = new System.Windows.Forms.TextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.txtsmusername = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.txtsmwxid = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.tabPage8 = new System.Windows.Forms.TabPage();
            this.btndownv = new CCWin.SkinControl.SkinButton();
            this.txtvoicepath = new System.Windows.Forms.TextBox();
            this.label49 = new System.Windows.Forms.Label();
            this.txtbase64_data = new System.Windows.Forms.TextBox();
            this.label48 = new System.Windows.Forms.Label();
            this.btndownvioce = new CCWin.SkinControl.SkinButton();
            this.txtclient_msgid = new System.Windows.Forms.TextBox();
            this.label47 = new System.Windows.Forms.Label();
            this.txtlength = new System.Windows.Forms.TextBox();
            this.label46 = new System.Windows.Forms.Label();
            this.txtmsgid = new System.Windows.Forms.TextBox();
            this.label45 = new System.Windows.Forms.Label();
            this.txtbufid = new System.Windows.Forms.TextBox();
            this.label44 = new System.Windows.Forms.Label();
            this.btndownimg = new CCWin.SkinControl.SkinButton();
            this.label43 = new System.Windows.Forms.Label();
            this.txtimgtype = new System.Windows.Forms.TextBox();
            this.label42 = new System.Windows.Forms.Label();
            this.txtpath = new System.Windows.Forms.TextBox();
            this.label41 = new System.Windows.Forms.Label();
            this.txtfileid = new System.Windows.Forms.TextBox();
            this.label40 = new System.Windows.Forms.Label();
            this.txtaeskey = new System.Windows.Forms.TextBox();
            this.label39 = new System.Windows.Forms.Label();
            this.btnclearlog = new CCWin.SkinControl.SkinButton();
            ((System.ComponentModel.ISupportInitialize)(this.headimg)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvfriend)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvgroup)).BeginInit();
            this.roomstrip.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvpub)).BeginInit();
            this.tabControl2.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.tabPage6.SuspendLayout();
            this.tabPage7.SuspendLayout();
            this.tabPage8.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtlog
            // 
            this.txtlog.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtlog.Location = new System.Drawing.Point(12, 228);
            this.txtlog.MaxLength = 80000;
            this.txtlog.Multiline = true;
            this.txtlog.Name = "txtlog";
            this.txtlog.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtlog.Size = new System.Drawing.Size(384, 412);
            this.txtlog.TabIndex = 3;
            this.txtlog.WordWrap = false;
            // 
            // btnlogin
            // 
            this.btnlogin.BackColor = System.Drawing.Color.Transparent;
            this.btnlogin.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btnlogin.DownBack = null;
            this.btnlogin.Location = new System.Drawing.Point(268, 97);
            this.btnlogin.MouseBack = null;
            this.btnlogin.Name = "btnlogin";
            this.btnlogin.NormlBack = null;
            this.btnlogin.Size = new System.Drawing.Size(75, 23);
            this.btnlogin.TabIndex = 4;
            this.btnlogin.Text = "登陆微信";
            this.btnlogin.UseVisualStyleBackColor = false;
            this.btnlogin.Click += new System.EventHandler(this.btnlogin_Click);
            // 
            // btnloginout
            // 
            this.btnloginout.BackColor = System.Drawing.Color.Transparent;
            this.btnloginout.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btnloginout.DownBack = null;
            this.btnloginout.Location = new System.Drawing.Point(268, 46);
            this.btnloginout.MouseBack = null;
            this.btnloginout.Name = "btnloginout";
            this.btnloginout.NormlBack = null;
            this.btnloginout.Size = new System.Drawing.Size(75, 23);
            this.btnloginout.TabIndex = 5;
            this.btnloginout.Text = "退出微信";
            this.btnloginout.UseVisualStyleBackColor = false;
            this.btnloginout.Click += new System.EventHandler(this.btnloginout_Click);
            // 
            // lblnickname
            // 
            this.lblnickname.AutoSize = true;
            this.lblnickname.BackColor = System.Drawing.Color.Transparent;
            this.lblnickname.BorderColor = System.Drawing.Color.White;
            this.lblnickname.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblnickname.Location = new System.Drawing.Point(182, 48);
            this.lblnickname.Name = "lblnickname";
            this.lblnickname.Size = new System.Drawing.Size(0, 17);
            this.lblnickname.TabIndex = 6;
            // 
            // headimg
            // 
            this.headimg.BackColor = System.Drawing.Color.Transparent;
            this.headimg.Location = new System.Drawing.Point(36, 46);
            this.headimg.Name = "headimg";
            this.headimg.Size = new System.Drawing.Size(100, 96);
            this.headimg.TabIndex = 7;
            this.headimg.TabStop = false;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(423, 46);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(640, 238);
            this.tabControl1.TabIndex = 8;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.gvfriend);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(632, 212);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "好友";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // gvfriend
            // 
            this.gvfriend.AllowUserToAddRows = false;
            this.gvfriend.AllowUserToDeleteRows = false;
            this.gvfriend.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.gvfriend.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.gvfriend.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvfriend.EnableHeadersVisualStyles = false;
            this.gvfriend.Location = new System.Drawing.Point(3, 3);
            this.gvfriend.Name = "gvfriend";
            this.gvfriend.RowTemplate.Height = 23;
            this.gvfriend.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvfriend.Size = new System.Drawing.Size(623, 203);
            this.gvfriend.TabIndex = 1;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.gvgroup);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(632, 212);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "群聊";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // gvgroup
            // 
            this.gvgroup.AllowUserToAddRows = false;
            this.gvgroup.AllowUserToDeleteRows = false;
            this.gvgroup.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.gvgroup.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.gvgroup.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvgroup.EnableHeadersVisualStyles = false;
            this.gvgroup.Location = new System.Drawing.Point(5, 5);
            this.gvgroup.Name = "gvgroup";
            this.gvgroup.RowTemplate.ContextMenuStrip = this.roomstrip;
            this.gvgroup.RowTemplate.Height = 23;
            this.gvgroup.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvgroup.Size = new System.Drawing.Size(623, 203);
            this.gvgroup.TabIndex = 2;
            this.gvgroup.CellMouseUp += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.gvgroup_CellMouseUp);
            // 
            // roomstrip
            // 
            this.roomstrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.roomstripgetuser});
            this.roomstrip.Name = "roomstrip";
            this.roomstrip.Size = new System.Drawing.Size(137, 26);
            // 
            // roomstripgetuser
            // 
            this.roomstripgetuser.Name = "roomstripgetuser";
            this.roomstripgetuser.Size = new System.Drawing.Size(136, 22);
            this.roomstripgetuser.Text = "获取群成员";
            this.roomstripgetuser.Click += new System.EventHandler(this.roomstripgetuser_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.gvpub);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(632, 212);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "公众号";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // gvpub
            // 
            this.gvpub.AllowUserToAddRows = false;
            this.gvpub.AllowUserToDeleteRows = false;
            this.gvpub.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.gvpub.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.gvpub.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvpub.EnableHeadersVisualStyles = false;
            this.gvpub.Location = new System.Drawing.Point(5, 5);
            this.gvpub.Name = "gvpub";
            this.gvpub.RowTemplate.Height = 23;
            this.gvpub.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvpub.Size = new System.Drawing.Size(623, 203);
            this.gvpub.TabIndex = 3;
            // 
            // btnuserlist
            // 
            this.btnuserlist.BackColor = System.Drawing.Color.Transparent;
            this.btnuserlist.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btnuserlist.DownBack = null;
            this.btnuserlist.Location = new System.Drawing.Point(963, 12);
            this.btnuserlist.MouseBack = null;
            this.btnuserlist.Name = "btnuserlist";
            this.btnuserlist.NormlBack = null;
            this.btnuserlist.Size = new System.Drawing.Size(96, 23);
            this.btnuserlist.TabIndex = 9;
            this.btnuserlist.Text = "获取/刷新列表";
            this.btnuserlist.UseVisualStyleBackColor = false;
            this.btnuserlist.Click += new System.EventHandler(this.btnuserlist_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 210);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 10;
            this.label1.Text = "消息日志：";
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage4);
            this.tabControl2.Controls.Add(this.tabPage5);
            this.tabControl2.Controls.Add(this.tabPage6);
            this.tabControl2.Controls.Add(this.tabPage7);
            this.tabControl2.Controls.Add(this.tabPage8);
            this.tabControl2.Location = new System.Drawing.Point(427, 290);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(636, 377);
            this.tabControl2.TabIndex = 4;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.btngetcode);
            this.tabPage4.Controls.Add(this.btnfrimes);
            this.tabPage4.Controls.Add(this.btnbase64_1);
            this.tabPage4.Controls.Add(this.txtbasesouce2);
            this.tabPage4.Controls.Add(this.txtbasesouce1);
            this.tabPage4.Controls.Add(this.label50);
            this.tabPage4.Controls.Add(this.btnwxmemo);
            this.tabPage4.Controls.Add(this.btnforward);
            this.tabPage4.Controls.Add(this.label23);
            this.tabPage4.Controls.Add(this.txtforwardmsgid);
            this.tabPage4.Controls.Add(this.label22);
            this.tabPage4.Controls.Add(this.label21);
            this.tabPage4.Controls.Add(this.txtforwardwxid);
            this.tabPage4.Controls.Add(this.label20);
            this.tabPage4.Controls.Add(this.label8);
            this.tabPage4.Controls.Add(this.btnsendimglink);
            this.tabPage4.Controls.Add(this.txtsendurl);
            this.tabPage4.Controls.Add(this.label7);
            this.tabPage4.Controls.Add(this.txtimglink);
            this.tabPage4.Controls.Add(this.label6);
            this.tabPage4.Controls.Add(this.txtsendsubtitle);
            this.tabPage4.Controls.Add(this.label5);
            this.tabPage4.Controls.Add(this.txtsendtitle);
            this.tabPage4.Controls.Add(this.lbltitle);
            this.tabPage4.Controls.Add(this.txtsharewxid);
            this.tabPage4.Controls.Add(this.label3);
            this.tabPage4.Controls.Add(this.btnsendcard);
            this.tabPage4.Controls.Add(this.btnsendfile);
            this.tabPage4.Controls.Add(this.btnsendgif);
            this.tabPage4.Controls.Add(this.btnsendimg);
            this.tabPage4.Controls.Add(this.btnsendtext);
            this.tabPage4.Controls.Add(this.txtsendmes);
            this.tabPage4.Controls.Add(this.label4);
            this.tabPage4.Controls.Add(this.txtwxid);
            this.tabPage4.Controls.Add(this.label2);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(628, 351);
            this.tabPage4.TabIndex = 0;
            this.tabPage4.Text = "消息操作";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // btngetcode
            // 
            this.btngetcode.BackColor = System.Drawing.Color.Transparent;
            this.btngetcode.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btngetcode.DownBack = null;
            this.btngetcode.Location = new System.Drawing.Point(401, 144);
            this.btngetcode.MouseBack = null;
            this.btngetcode.Name = "btngetcode";
            this.btngetcode.NormlBack = null;
            this.btngetcode.Size = new System.Drawing.Size(104, 23);
            this.btngetcode.TabIndex = 36;
            this.btngetcode.Text = "获取登陆二维码";
            this.btngetcode.UseVisualStyleBackColor = false;
            this.btngetcode.Click += new System.EventHandler(this.btngetcode_Click);
            // 
            // btnfrimes
            // 
            this.btnfrimes.BackColor = System.Drawing.Color.Transparent;
            this.btnfrimes.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btnfrimes.DownBack = null;
            this.btnfrimes.Location = new System.Drawing.Point(509, 185);
            this.btnfrimes.MouseBack = null;
            this.btnfrimes.Name = "btnfrimes";
            this.btnfrimes.NormlBack = null;
            this.btnfrimes.Size = new System.Drawing.Size(87, 23);
            this.btnfrimes.TabIndex = 35;
            this.btnfrimes.Text = "返回好友信息";
            this.btnfrimes.UseVisualStyleBackColor = false;
            this.btnfrimes.Click += new System.EventHandler(this.btnfrimes_Click);
            // 
            // btnbase64_1
            // 
            this.btnbase64_1.BackColor = System.Drawing.Color.Transparent;
            this.btnbase64_1.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btnbase64_1.DownBack = null;
            this.btnbase64_1.Location = new System.Drawing.Point(464, 305);
            this.btnbase64_1.MouseBack = null;
            this.btnbase64_1.Name = "btnbase64_1";
            this.btnbase64_1.NormlBack = null;
            this.btnbase64_1.Size = new System.Drawing.Size(86, 23);
            this.btnbase64_1.TabIndex = 34;
            this.btnbase64_1.Text = "解 密";
            this.btnbase64_1.UseVisualStyleBackColor = false;
            this.btnbase64_1.Click += new System.EventHandler(this.btnbase64_1_Click);
            // 
            // txtbasesouce2
            // 
            this.txtbasesouce2.Location = new System.Drawing.Point(274, 307);
            this.txtbasesouce2.Name = "txtbasesouce2";
            this.txtbasesouce2.Size = new System.Drawing.Size(174, 21);
            this.txtbasesouce2.TabIndex = 33;
            // 
            // txtbasesouce1
            // 
            this.txtbasesouce1.Location = new System.Drawing.Point(89, 307);
            this.txtbasesouce1.Name = "txtbasesouce1";
            this.txtbasesouce1.Size = new System.Drawing.Size(156, 21);
            this.txtbasesouce1.TabIndex = 32;
            // 
            // label50
            // 
            this.label50.AutoSize = true;
            this.label50.Location = new System.Drawing.Point(18, 316);
            this.label50.Name = "label50";
            this.label50.Size = new System.Drawing.Size(77, 12);
            this.label50.TabIndex = 31;
            this.label50.Text = "base64解密：";
            // 
            // btnwxmemo
            // 
            this.btnwxmemo.BackColor = System.Drawing.Color.Transparent;
            this.btnwxmemo.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btnwxmemo.DownBack = null;
            this.btnwxmemo.Location = new System.Drawing.Point(509, 109);
            this.btnwxmemo.MouseBack = null;
            this.btnwxmemo.Name = "btnwxmemo";
            this.btnwxmemo.NormlBack = null;
            this.btnwxmemo.Size = new System.Drawing.Size(75, 23);
            this.btnwxmemo.TabIndex = 30;
            this.btnwxmemo.Text = "修改备注";
            this.btnwxmemo.UseVisualStyleBackColor = false;
            this.btnwxmemo.Click += new System.EventHandler(this.btnwxmemo_Click);
            // 
            // btnforward
            // 
            this.btnforward.BackColor = System.Drawing.Color.Transparent;
            this.btnforward.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btnforward.DownBack = null;
            this.btnforward.Location = new System.Drawing.Point(464, 266);
            this.btnforward.MouseBack = null;
            this.btnforward.Name = "btnforward";
            this.btnforward.NormlBack = null;
            this.btnforward.Size = new System.Drawing.Size(86, 23);
            this.btnforward.TabIndex = 29;
            this.btnforward.Text = "转发消息";
            this.btnforward.UseVisualStyleBackColor = false;
            this.btnforward.Click += new System.EventHandler(this.btnforward_Click);
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(212, 271);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(227, 12);
            this.label23.TabIndex = 28;
            this.label23.Text = "接收的消息msgid，从左边的日志里面获取";
            // 
            // txtforwardmsgid
            // 
            this.txtforwardmsgid.Location = new System.Drawing.Point(89, 262);
            this.txtforwardmsgid.Name = "txtforwardmsgid";
            this.txtforwardmsgid.Size = new System.Drawing.Size(100, 21);
            this.txtforwardmsgid.TabIndex = 27;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(36, 265);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(47, 12);
            this.label22.TabIndex = 26;
            this.label22.Text = "msgid：";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(399, 233);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(89, 12);
            this.label21.TabIndex = 25;
            this.label21.Text = "多个用逗号隔开";
            // 
            // txtforwardwxid
            // 
            this.txtforwardwxid.Location = new System.Drawing.Point(125, 233);
            this.txtforwardwxid.Name = "txtforwardwxid";
            this.txtforwardwxid.Size = new System.Drawing.Size(258, 21);
            this.txtforwardwxid.TabIndex = 24;
            this.txtforwardwxid.Text = "filehelper";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(6, 236);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(113, 12);
            this.label20.TabIndex = 23;
            this.label20.Text = "接收转发的微信id：";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(399, 12);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(197, 12);
            this.label8.TabIndex = 22;
            this.label8.Text = "发送图片或文件填写本地的绝对地址";
            // 
            // btnsendimglink
            // 
            this.btnsendimglink.BackColor = System.Drawing.Color.Transparent;
            this.btnsendimglink.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btnsendimglink.DownBack = null;
            this.btnsendimglink.Location = new System.Drawing.Point(401, 185);
            this.btnsendimglink.MouseBack = null;
            this.btnsendimglink.Name = "btnsendimglink";
            this.btnsendimglink.NormlBack = null;
            this.btnsendimglink.Size = new System.Drawing.Size(94, 23);
            this.btnsendimglink.TabIndex = 21;
            this.btnsendimglink.Text = "发送图文链接";
            this.btnsendimglink.UseVisualStyleBackColor = false;
            this.btnsendimglink.Click += new System.EventHandler(this.btnsendimglink_Click);
            // 
            // txtsendurl
            // 
            this.txtsendurl.Location = new System.Drawing.Point(283, 187);
            this.txtsendurl.Name = "txtsendurl";
            this.txtsendurl.Size = new System.Drawing.Size(100, 21);
            this.txtsendurl.TabIndex = 20;
            this.txtsendurl.Text = "https://www.baidu.com/";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(212, 190);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 12);
            this.label7.TabIndex = 19;
            this.label7.Text = "链接url：";
            // 
            // txtimglink
            // 
            this.txtimglink.Location = new System.Drawing.Point(89, 187);
            this.txtimglink.Name = "txtimglink";
            this.txtimglink.Size = new System.Drawing.Size(100, 21);
            this.txtimglink.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 193);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 12);
            this.label6.TabIndex = 17;
            this.label6.Text = "图片本地地址：";
            // 
            // txtsendsubtitle
            // 
            this.txtsendsubtitle.Location = new System.Drawing.Point(283, 149);
            this.txtsendsubtitle.Name = "txtsendsubtitle";
            this.txtsendsubtitle.Size = new System.Drawing.Size(100, 21);
            this.txtsendsubtitle.TabIndex = 16;
            this.txtsendsubtitle.Text = "搜索百度一下";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(218, 155);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 15;
            this.label5.Text = "副标题：";
            // 
            // txtsendtitle
            // 
            this.txtsendtitle.Location = new System.Drawing.Point(89, 155);
            this.txtsendtitle.Name = "txtsendtitle";
            this.txtsendtitle.Size = new System.Drawing.Size(100, 21);
            this.txtsendtitle.TabIndex = 14;
            this.txtsendtitle.Text = "百度";
            // 
            // lbltitle
            // 
            this.lbltitle.AutoSize = true;
            this.lbltitle.Location = new System.Drawing.Point(6, 158);
            this.lbltitle.Name = "lbltitle";
            this.lbltitle.Size = new System.Drawing.Size(41, 12);
            this.lbltitle.TabIndex = 13;
            this.lbltitle.Text = "标题：";
            // 
            // txtsharewxid
            // 
            this.txtsharewxid.Location = new System.Drawing.Point(274, 3);
            this.txtsharewxid.Name = "txtsharewxid";
            this.txtsharewxid.Size = new System.Drawing.Size(100, 21);
            this.txtsharewxid.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(182, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 12);
            this.label3.TabIndex = 11;
            this.label3.Text = "被分享微信id：";
            // 
            // btnsendcard
            // 
            this.btnsendcard.BackColor = System.Drawing.Color.Transparent;
            this.btnsendcard.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btnsendcard.DownBack = null;
            this.btnsendcard.Location = new System.Drawing.Point(401, 109);
            this.btnsendcard.MouseBack = null;
            this.btnsendcard.Name = "btnsendcard";
            this.btnsendcard.NormlBack = null;
            this.btnsendcard.Size = new System.Drawing.Size(75, 23);
            this.btnsendcard.TabIndex = 10;
            this.btnsendcard.Text = "发送名片";
            this.btnsendcard.UseVisualStyleBackColor = false;
            this.btnsendcard.Click += new System.EventHandler(this.btnsendcard_Click);
            // 
            // btnsendfile
            // 
            this.btnsendfile.BackColor = System.Drawing.Color.Transparent;
            this.btnsendfile.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btnsendfile.DownBack = null;
            this.btnsendfile.Location = new System.Drawing.Point(299, 109);
            this.btnsendfile.MouseBack = null;
            this.btnsendfile.Name = "btnsendfile";
            this.btnsendfile.NormlBack = null;
            this.btnsendfile.Size = new System.Drawing.Size(75, 23);
            this.btnsendfile.TabIndex = 9;
            this.btnsendfile.Text = "发送文件";
            this.btnsendfile.UseVisualStyleBackColor = false;
            this.btnsendfile.Click += new System.EventHandler(this.btnsendfile_Click);
            // 
            // btnsendgif
            // 
            this.btnsendgif.BackColor = System.Drawing.Color.Transparent;
            this.btnsendgif.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btnsendgif.DownBack = null;
            this.btnsendgif.Location = new System.Drawing.Point(196, 109);
            this.btnsendgif.MouseBack = null;
            this.btnsendgif.Name = "btnsendgif";
            this.btnsendgif.NormlBack = null;
            this.btnsendgif.Size = new System.Drawing.Size(75, 23);
            this.btnsendgif.TabIndex = 8;
            this.btnsendgif.Text = "发送动画";
            this.btnsendgif.UseVisualStyleBackColor = false;
            this.btnsendgif.Click += new System.EventHandler(this.btnsendgif_Click);
            // 
            // btnsendimg
            // 
            this.btnsendimg.BackColor = System.Drawing.Color.Transparent;
            this.btnsendimg.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btnsendimg.DownBack = null;
            this.btnsendimg.Location = new System.Drawing.Point(101, 109);
            this.btnsendimg.MouseBack = null;
            this.btnsendimg.Name = "btnsendimg";
            this.btnsendimg.NormlBack = null;
            this.btnsendimg.Size = new System.Drawing.Size(75, 23);
            this.btnsendimg.TabIndex = 7;
            this.btnsendimg.Text = "发送图片";
            this.btnsendimg.UseVisualStyleBackColor = false;
            this.btnsendimg.Click += new System.EventHandler(this.btnsendimg_Click);
            // 
            // btnsendtext
            // 
            this.btnsendtext.BackColor = System.Drawing.Color.Transparent;
            this.btnsendtext.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btnsendtext.DownBack = null;
            this.btnsendtext.Location = new System.Drawing.Point(8, 109);
            this.btnsendtext.MouseBack = null;
            this.btnsendtext.Name = "btnsendtext";
            this.btnsendtext.NormlBack = null;
            this.btnsendtext.Size = new System.Drawing.Size(75, 23);
            this.btnsendtext.TabIndex = 6;
            this.btnsendtext.Text = "发送文字";
            this.btnsendtext.UseVisualStyleBackColor = false;
            this.btnsendtext.Click += new System.EventHandler(this.btnsendtext_Click);
            // 
            // txtsendmes
            // 
            this.txtsendmes.Location = new System.Drawing.Point(101, 41);
            this.txtsendmes.Multiline = true;
            this.txtsendmes.Name = "txtsendmes";
            this.txtsendmes.Size = new System.Drawing.Size(513, 60);
            this.txtsendmes.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 12);
            this.label4.TabIndex = 4;
            this.label4.Text = "要发送的消息：";
            // 
            // txtwxid
            // 
            this.txtwxid.Location = new System.Drawing.Point(53, 5);
            this.txtwxid.Name = "txtwxid";
            this.txtwxid.Size = new System.Drawing.Size(100, 21);
            this.txtwxid.TabIndex = 1;
            this.txtwxid.Text = "filehelper";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "微信id：";
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.label19);
            this.tabPage5.Controls.Add(this.txtsource);
            this.tabPage5.Controls.Add(this.label18);
            this.tabPage5.Controls.Add(this.txtverifytext);
            this.tabPage5.Controls.Add(this.label13);
            this.tabPage5.Controls.Add(this.btnaddfri);
            this.tabPage5.Controls.Add(this.label12);
            this.tabPage5.Controls.Add(this.txtv2);
            this.tabPage5.Controls.Add(this.label11);
            this.tabPage5.Controls.Add(this.txtv1);
            this.tabPage5.Controls.Add(this.label10);
            this.tabPage5.Controls.Add(this.label9);
            this.tabPage5.Controls.Add(this.txtsearchfri);
            this.tabPage5.Controls.Add(this.btnsearchfriend);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(628, 351);
            this.tabPage5.TabIndex = 1;
            this.tabPage5.Text = "好友操作";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(195, 204);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(233, 12);
            this.label19.TabIndex = 18;
            this.label19.Text = "好友来源，1：QQ，3：微信号，15：手机号";
            // 
            // txtsource
            // 
            this.txtsource.Location = new System.Drawing.Point(103, 201);
            this.txtsource.Name = "txtsource";
            this.txtsource.Size = new System.Drawing.Size(75, 21);
            this.txtsource.TabIndex = 17;
            this.txtsource.Text = "3";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(32, 204);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(65, 12);
            this.label18.TabIndex = 16;
            this.label18.Text = "好友来源：";
            // 
            // txtverifytext
            // 
            this.txtverifytext.Location = new System.Drawing.Point(103, 166);
            this.txtverifytext.Name = "txtverifytext";
            this.txtverifytext.Size = new System.Drawing.Size(337, 21);
            this.txtverifytext.TabIndex = 15;
            this.txtverifytext.Text = "你好";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(20, 169);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(77, 12);
            this.label13.TabIndex = 14;
            this.label13.Text = "加好友留言：";
            // 
            // btnaddfri
            // 
            this.btnaddfri.BackColor = System.Drawing.Color.Transparent;
            this.btnaddfri.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btnaddfri.DownBack = null;
            this.btnaddfri.Location = new System.Drawing.Point(103, 242);
            this.btnaddfri.MouseBack = null;
            this.btnaddfri.Name = "btnaddfri";
            this.btnaddfri.NormlBack = null;
            this.btnaddfri.Size = new System.Drawing.Size(75, 23);
            this.btnaddfri.TabIndex = 13;
            this.btnaddfri.Text = "添加好友";
            this.btnaddfri.UseVisualStyleBackColor = false;
            this.btnaddfri.Click += new System.EventHandler(this.btnaddfri_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(50, 62);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(467, 12);
            this.label12.TabIndex = 12;
            this.label12.Text = "在上面搜索后，如果存在该用户，且不是你的好友，会自动返回v信息，填充下面的框。";
            // 
            // txtv2
            // 
            this.txtv2.Location = new System.Drawing.Point(103, 131);
            this.txtv2.Name = "txtv2";
            this.txtv2.Size = new System.Drawing.Size(337, 21);
            this.txtv2.TabIndex = 11;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(50, 134);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(47, 12);
            this.label11.TabIndex = 10;
            this.label11.Text = "v2/v4：";
            // 
            // txtv1
            // 
            this.txtv1.Location = new System.Drawing.Point(103, 96);
            this.txtv1.Name = "txtv1";
            this.txtv1.Size = new System.Drawing.Size(337, 21);
            this.txtv1.TabIndex = 9;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(50, 99);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(47, 12);
            this.label10.TabIndex = 8;
            this.label10.Text = "v1/v3：";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(50, 22);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(113, 12);
            this.label9.TabIndex = 7;
            this.label9.Text = "QQ/手机号/微信号：";
            // 
            // txtsearchfri
            // 
            this.txtsearchfri.Location = new System.Drawing.Point(173, 19);
            this.txtsearchfri.Name = "txtsearchfri";
            this.txtsearchfri.Size = new System.Drawing.Size(168, 21);
            this.txtsearchfri.TabIndex = 6;
            // 
            // btnsearchfriend
            // 
            this.btnsearchfriend.BackColor = System.Drawing.Color.Transparent;
            this.btnsearchfriend.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btnsearchfriend.DownBack = null;
            this.btnsearchfriend.Location = new System.Drawing.Point(365, 17);
            this.btnsearchfriend.MouseBack = null;
            this.btnsearchfriend.Name = "btnsearchfriend";
            this.btnsearchfriend.NormlBack = null;
            this.btnsearchfriend.Size = new System.Drawing.Size(75, 23);
            this.btnsearchfriend.TabIndex = 5;
            this.btnsearchfriend.Text = "搜索好友";
            this.btnsearchfriend.UseVisualStyleBackColor = false;
            this.btnsearchfriend.Click += new System.EventHandler(this.btnsearchfriend_Click);
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.skinButton1);
            this.tabPage6.Controls.Add(this.label38);
            this.tabPage6.Controls.Add(this.txtroomwxids);
            this.tabPage6.Controls.Add(this.label37);
            this.tabPage6.Controls.Add(this.btnbase64);
            this.tabPage6.Controls.Add(this.txtbaseres);
            this.tabPage6.Controls.Add(this.txtbasesouce);
            this.tabPage6.Controls.Add(this.label36);
            this.tabPage6.Controls.Add(this.label17);
            this.tabPage6.Controls.Add(this.btnroomaddfri);
            this.tabPage6.Controls.Add(this.txtroomverifytext);
            this.tabPage6.Controls.Add(this.label16);
            this.tabPage6.Controls.Add(this.txtroomwxid);
            this.tabPage6.Controls.Add(this.label15);
            this.tabPage6.Controls.Add(this.txtroom);
            this.tabPage6.Controls.Add(this.label14);
            this.tabPage6.Location = new System.Drawing.Point(4, 22);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Size = new System.Drawing.Size(628, 351);
            this.tabPage6.TabIndex = 2;
            this.tabPage6.Text = "群聊操作";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // skinButton1
            // 
            this.skinButton1.BackColor = System.Drawing.Color.Transparent;
            this.skinButton1.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinButton1.DownBack = null;
            this.skinButton1.Location = new System.Drawing.Point(523, 278);
            this.skinButton1.MouseBack = null;
            this.skinButton1.Name = "skinButton1";
            this.skinButton1.NormlBack = null;
            this.skinButton1.Size = new System.Drawing.Size(75, 23);
            this.skinButton1.TabIndex = 26;
            this.skinButton1.Text = "创建群聊";
            this.skinButton1.UseVisualStyleBackColor = false;
            this.skinButton1.Click += new System.EventHandler(this.skinButton1_Click);
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Location = new System.Drawing.Point(89, 253);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(233, 12);
            this.label38.TabIndex = 25;
            this.label38.Text = "好友微信id，多个英文逗号隔开，最少两个";
            // 
            // txtroomwxids
            // 
            this.txtroomwxids.Location = new System.Drawing.Point(20, 280);
            this.txtroomwxids.Name = "txtroomwxids";
            this.txtroomwxids.Size = new System.Drawing.Size(475, 21);
            this.txtroomwxids.TabIndex = 24;
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Location = new System.Drawing.Point(18, 253);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(65, 12);
            this.label37.TabIndex = 23;
            this.label37.Text = "创建群聊：";
            // 
            // btnbase64
            // 
            this.btnbase64.BackColor = System.Drawing.Color.Transparent;
            this.btnbase64.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btnbase64.DownBack = null;
            this.btnbase64.Location = new System.Drawing.Point(523, 185);
            this.btnbase64.MouseBack = null;
            this.btnbase64.Name = "btnbase64";
            this.btnbase64.NormlBack = null;
            this.btnbase64.Size = new System.Drawing.Size(75, 23);
            this.btnbase64.TabIndex = 22;
            this.btnbase64.Text = "解密";
            this.btnbase64.UseVisualStyleBackColor = false;
            this.btnbase64.Click += new System.EventHandler(this.btnbase64_Click);
            // 
            // txtbaseres
            // 
            this.txtbaseres.Location = new System.Drawing.Point(327, 187);
            this.txtbaseres.Name = "txtbaseres";
            this.txtbaseres.Size = new System.Drawing.Size(168, 21);
            this.txtbaseres.TabIndex = 21;
            // 
            // txtbasesouce
            // 
            this.txtbasesouce.Location = new System.Drawing.Point(114, 187);
            this.txtbasesouce.Name = "txtbasesouce";
            this.txtbasesouce.Size = new System.Drawing.Size(168, 21);
            this.txtbasesouce.TabIndex = 20;
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Location = new System.Drawing.Point(18, 190);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(77, 12);
            this.label36.TabIndex = 19;
            this.label36.Text = "base64解密：";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(54, 35);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(473, 12);
            this.label17.TabIndex = 18;
            this.label17.Text = "首先在上面群聊右键获取群成员信息，在左边消息日志里面复制得到的群成员的wxid填写";
            // 
            // btnroomaddfri
            // 
            this.btnroomaddfri.BackColor = System.Drawing.Color.Transparent;
            this.btnroomaddfri.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btnroomaddfri.DownBack = null;
            this.btnroomaddfri.Location = new System.Drawing.Point(346, 130);
            this.btnroomaddfri.MouseBack = null;
            this.btnroomaddfri.Name = "btnroomaddfri";
            this.btnroomaddfri.NormlBack = null;
            this.btnroomaddfri.Size = new System.Drawing.Size(75, 23);
            this.btnroomaddfri.TabIndex = 17;
            this.btnroomaddfri.Text = "添加群好友";
            this.btnroomaddfri.UseVisualStyleBackColor = false;
            this.btnroomaddfri.Click += new System.EventHandler(this.btnroomaddfri_Click);
            // 
            // txtroomverifytext
            // 
            this.txtroomverifytext.Location = new System.Drawing.Point(114, 130);
            this.txtroomverifytext.Name = "txtroomverifytext";
            this.txtroomverifytext.Size = new System.Drawing.Size(168, 21);
            this.txtroomverifytext.TabIndex = 16;
            this.txtroomverifytext.Text = "你好";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(18, 139);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(77, 12);
            this.label16.TabIndex = 15;
            this.label16.Text = "加好友留言：";
            // 
            // txtroomwxid
            // 
            this.txtroomwxid.Location = new System.Drawing.Point(376, 74);
            this.txtroomwxid.Name = "txtroomwxid";
            this.txtroomwxid.Size = new System.Drawing.Size(168, 21);
            this.txtroomwxid.TabIndex = 11;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(308, 83);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(47, 12);
            this.label15.TabIndex = 10;
            this.label15.Text = "wxid:：";
            // 
            // txtroom
            // 
            this.txtroom.Location = new System.Drawing.Point(114, 74);
            this.txtroom.Name = "txtroom";
            this.txtroom.Size = new System.Drawing.Size(168, 21);
            this.txtroom.TabIndex = 9;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(54, 83);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(41, 12);
            this.label14.TabIndex = 8;
            this.label14.Text = "群id：";
            // 
            // tabPage7
            // 
            this.tabPage7.Controls.Add(this.btnsendsm);
            this.tabPage7.Controls.Add(this.label35);
            this.tabPage7.Controls.Add(this.txtsmdisplaytype);
            this.tabPage7.Controls.Add(this.label34);
            this.tabPage7.Controls.Add(this.label33);
            this.tabPage7.Controls.Add(this.txtsmiconpath);
            this.tabPage7.Controls.Add(this.label32);
            this.tabPage7.Controls.Add(this.label31);
            this.tabPage7.Controls.Add(this.txtsmthumburl);
            this.tabPage7.Controls.Add(this.label30);
            this.tabPage7.Controls.Add(this.txtsmdes);
            this.tabPage7.Controls.Add(this.label29);
            this.tabPage7.Controls.Add(this.txtsmtitle);
            this.tabPage7.Controls.Add(this.label28);
            this.tabPage7.Controls.Add(this.txtsmpagepath);
            this.tabPage7.Controls.Add(this.label27);
            this.tabPage7.Controls.Add(this.txtsmappid);
            this.tabPage7.Controls.Add(this.label26);
            this.tabPage7.Controls.Add(this.txtsmusername);
            this.tabPage7.Controls.Add(this.label25);
            this.tabPage7.Controls.Add(this.txtsmwxid);
            this.tabPage7.Controls.Add(this.label24);
            this.tabPage7.Location = new System.Drawing.Point(4, 22);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage7.Size = new System.Drawing.Size(628, 351);
            this.tabPage7.TabIndex = 3;
            this.tabPage7.Text = "小程序";
            this.tabPage7.UseVisualStyleBackColor = true;
            // 
            // btnsendsm
            // 
            this.btnsendsm.BackColor = System.Drawing.Color.Transparent;
            this.btnsendsm.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btnsendsm.DownBack = null;
            this.btnsendsm.Location = new System.Drawing.Point(236, 281);
            this.btnsendsm.MouseBack = null;
            this.btnsendsm.Name = "btnsendsm";
            this.btnsendsm.NormlBack = null;
            this.btnsendsm.Size = new System.Drawing.Size(75, 23);
            this.btnsendsm.TabIndex = 22;
            this.btnsendsm.Text = "发送小程序";
            this.btnsendsm.UseVisualStyleBackColor = false;
            this.btnsendsm.Click += new System.EventHandler(this.btnsendsm_Click);
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Location = new System.Drawing.Point(234, 218);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(383, 12);
            this.label35.TabIndex = 21;
            this.label35.Text = "=1，发送的小程序为详情页； =2，发送的小程序为指定的pagepath页面";
            // 
            // txtsmdisplaytype
            // 
            this.txtsmdisplaytype.Location = new System.Drawing.Point(101, 209);
            this.txtsmdisplaytype.Name = "txtsmdisplaytype";
            this.txtsmdisplaytype.Size = new System.Drawing.Size(100, 21);
            this.txtsmdisplaytype.TabIndex = 20;
            this.txtsmdisplaytype.Text = "2";
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Location = new System.Drawing.Point(36, 218);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(65, 12);
            this.label34.TabIndex = 19;
            this.label34.Text = "显示类型：";
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(234, 170);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(245, 12);
            this.label33.TabIndex = 18;
            this.label33.Text = "icon路径, 用来显示商品内容，来自本地图片";
            // 
            // txtsmiconpath
            // 
            this.txtsmiconpath.Location = new System.Drawing.Point(101, 170);
            this.txtsmiconpath.Name = "txtsmiconpath";
            this.txtsmiconpath.Size = new System.Drawing.Size(100, 21);
            this.txtsmiconpath.TabIndex = 17;
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(42, 179);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(59, 12);
            this.label32.TabIndex = 16;
            this.label32.Text = "con路径：";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(234, 140);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(227, 12);
            this.label31.TabIndex = 15;
            this.label31.Text = "缩略图，小程序主页的图标，来自网络url";
            // 
            // txtsmthumburl
            // 
            this.txtsmthumburl.Location = new System.Drawing.Point(101, 137);
            this.txtsmthumburl.Name = "txtsmthumburl";
            this.txtsmthumburl.Size = new System.Drawing.Size(100, 21);
            this.txtsmthumburl.TabIndex = 14;
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(42, 140);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(53, 12);
            this.label30.TabIndex = 13;
            this.label30.Text = "缩略图：";
            // 
            // txtsmdes
            // 
            this.txtsmdes.Location = new System.Drawing.Point(326, 93);
            this.txtsmdes.Name = "txtsmdes";
            this.txtsmdes.Size = new System.Drawing.Size(100, 21);
            this.txtsmdes.TabIndex = 12;
            this.txtsmdes.Text = "这是描述";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(270, 96);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(41, 12);
            this.label29.TabIndex = 11;
            this.label29.Text = "描述：";
            // 
            // txtsmtitle
            // 
            this.txtsmtitle.Location = new System.Drawing.Point(101, 93);
            this.txtsmtitle.Name = "txtsmtitle";
            this.txtsmtitle.Size = new System.Drawing.Size(100, 21);
            this.txtsmtitle.TabIndex = 10;
            this.txtsmtitle.Text = "标题";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(48, 102);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(41, 12);
            this.label28.TabIndex = 9;
            this.label28.Text = "标题：";
            // 
            // txtsmpagepath
            // 
            this.txtsmpagepath.Location = new System.Drawing.Point(326, 44);
            this.txtsmpagepath.Name = "txtsmpagepath";
            this.txtsmpagepath.Size = new System.Drawing.Size(100, 21);
            this.txtsmpagepath.TabIndex = 8;
            this.txtsmpagepath.Text = "pages/product/detail/detail.html?id=543020c3915b4ba2891873315049d052";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(258, 53);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(53, 12);
            this.label27.TabIndex = 7;
            this.label27.Text = "子页面：";
            // 
            // txtsmappid
            // 
            this.txtsmappid.Location = new System.Drawing.Point(101, 53);
            this.txtsmappid.Name = "txtsmappid";
            this.txtsmappid.Size = new System.Drawing.Size(100, 21);
            this.txtsmappid.TabIndex = 6;
            this.txtsmappid.Text = "wx9f6c19170edd472b";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(48, 53);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(47, 12);
            this.label26.TabIndex = 5;
            this.label26.Text = "appid：";
            // 
            // txtsmusername
            // 
            this.txtsmusername.Location = new System.Drawing.Point(400, 11);
            this.txtsmusername.Name = "txtsmusername";
            this.txtsmusername.Size = new System.Drawing.Size(181, 21);
            this.txtsmusername.TabIndex = 4;
            this.txtsmusername.Text = "gh_af3dd8111f81@app";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(234, 17);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(179, 12);
            this.label25.TabIndex = 3;
            this.label25.Text = "小程序原始ID（后面加 @app）：";
            // 
            // txtsmwxid
            // 
            this.txtsmwxid.Location = new System.Drawing.Point(101, 14);
            this.txtsmwxid.Name = "txtsmwxid";
            this.txtsmwxid.Size = new System.Drawing.Size(100, 21);
            this.txtsmwxid.TabIndex = 2;
            this.txtsmwxid.Text = "filehelper";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(6, 14);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(89, 12);
            this.label24.TabIndex = 1;
            this.label24.Text = "接收者微信id：";
            // 
            // tabPage8
            // 
            this.tabPage8.Controls.Add(this.btndownv);
            this.tabPage8.Controls.Add(this.txtvoicepath);
            this.tabPage8.Controls.Add(this.label49);
            this.tabPage8.Controls.Add(this.txtbase64_data);
            this.tabPage8.Controls.Add(this.label48);
            this.tabPage8.Controls.Add(this.btndownvioce);
            this.tabPage8.Controls.Add(this.txtclient_msgid);
            this.tabPage8.Controls.Add(this.label47);
            this.tabPage8.Controls.Add(this.txtlength);
            this.tabPage8.Controls.Add(this.label46);
            this.tabPage8.Controls.Add(this.txtmsgid);
            this.tabPage8.Controls.Add(this.label45);
            this.tabPage8.Controls.Add(this.txtbufid);
            this.tabPage8.Controls.Add(this.label44);
            this.tabPage8.Controls.Add(this.btndownimg);
            this.tabPage8.Controls.Add(this.label43);
            this.tabPage8.Controls.Add(this.txtimgtype);
            this.tabPage8.Controls.Add(this.label42);
            this.tabPage8.Controls.Add(this.txtpath);
            this.tabPage8.Controls.Add(this.label41);
            this.tabPage8.Controls.Add(this.txtfileid);
            this.tabPage8.Controls.Add(this.label40);
            this.tabPage8.Controls.Add(this.txtaeskey);
            this.tabPage8.Controls.Add(this.label39);
            this.tabPage8.Location = new System.Drawing.Point(4, 22);
            this.tabPage8.Name = "tabPage8";
            this.tabPage8.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage8.Size = new System.Drawing.Size(628, 351);
            this.tabPage8.TabIndex = 4;
            this.tabPage8.Text = "下载";
            this.tabPage8.UseVisualStyleBackColor = true;
            // 
            // btndownv
            // 
            this.btndownv.BackColor = System.Drawing.Color.Transparent;
            this.btndownv.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btndownv.DownBack = null;
            this.btndownv.Location = new System.Drawing.Point(431, 265);
            this.btndownv.MouseBack = null;
            this.btndownv.Name = "btndownv";
            this.btndownv.NormlBack = null;
            this.btndownv.Size = new System.Drawing.Size(75, 23);
            this.btndownv.TabIndex = 37;
            this.btndownv.Text = "下载语音";
            this.btndownv.UseVisualStyleBackColor = false;
            this.btndownv.Click += new System.EventHandler(this.btndownv_Click);
            // 
            // txtvoicepath
            // 
            this.txtvoicepath.Location = new System.Drawing.Point(281, 267);
            this.txtvoicepath.Name = "txtvoicepath";
            this.txtvoicepath.Size = new System.Drawing.Size(100, 21);
            this.txtvoicepath.TabIndex = 36;
            this.txtvoicepath.Text = "D:\\test.silk";
            // 
            // label49
            // 
            this.label49.AutoSize = true;
            this.label49.Location = new System.Drawing.Point(195, 273);
            this.label49.Name = "label49";
            this.label49.Size = new System.Drawing.Size(65, 12);
            this.label49.TabIndex = 35;
            this.label49.Text = "下载路径：";
            // 
            // txtbase64_data
            // 
            this.txtbase64_data.Location = new System.Drawing.Point(74, 264);
            this.txtbase64_data.Name = "txtbase64_data";
            this.txtbase64_data.Size = new System.Drawing.Size(100, 21);
            this.txtbase64_data.TabIndex = 34;
            // 
            // label48
            // 
            this.label48.AutoSize = true;
            this.label48.Location = new System.Drawing.Point(-2, 267);
            this.label48.Name = "label48";
            this.label48.Size = new System.Drawing.Size(83, 12);
            this.label48.TabIndex = 33;
            this.label48.Text = "base64_data：";
            // 
            // btndownvioce
            // 
            this.btndownvioce.BackColor = System.Drawing.Color.Transparent;
            this.btndownvioce.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btndownvioce.DownBack = null;
            this.btndownvioce.Location = new System.Drawing.Point(431, 201);
            this.btndownvioce.MouseBack = null;
            this.btndownvioce.Name = "btndownvioce";
            this.btndownvioce.NormlBack = null;
            this.btndownvioce.Size = new System.Drawing.Size(75, 23);
            this.btndownvioce.TabIndex = 32;
            this.btndownvioce.Text = "解析语音";
            this.btndownvioce.UseVisualStyleBackColor = false;
            this.btndownvioce.Click += new System.EventHandler(this.btndownvioce_Click);
            // 
            // txtclient_msgid
            // 
            this.txtclient_msgid.Location = new System.Drawing.Point(281, 203);
            this.txtclient_msgid.Name = "txtclient_msgid";
            this.txtclient_msgid.Size = new System.Drawing.Size(100, 21);
            this.txtclient_msgid.TabIndex = 31;
            // 
            // label47
            // 
            this.label47.AutoSize = true;
            this.label47.Location = new System.Drawing.Point(186, 212);
            this.label47.Name = "label47";
            this.label47.Size = new System.Drawing.Size(89, 12);
            this.label47.TabIndex = 30;
            this.label47.Text = "client_msgid：";
            // 
            // txtlength
            // 
            this.txtlength.Location = new System.Drawing.Point(68, 212);
            this.txtlength.Name = "txtlength";
            this.txtlength.Size = new System.Drawing.Size(100, 21);
            this.txtlength.TabIndex = 29;
            // 
            // label46
            // 
            this.label46.AutoSize = true;
            this.label46.Location = new System.Drawing.Point(15, 215);
            this.label46.Name = "label46";
            this.label46.Size = new System.Drawing.Size(53, 12);
            this.label46.TabIndex = 28;
            this.label46.Text = "length：";
            // 
            // txtmsgid
            // 
            this.txtmsgid.Location = new System.Drawing.Point(281, 162);
            this.txtmsgid.Name = "txtmsgid";
            this.txtmsgid.Size = new System.Drawing.Size(100, 21);
            this.txtmsgid.TabIndex = 27;
            // 
            // label45
            // 
            this.label45.AutoSize = true;
            this.label45.Location = new System.Drawing.Point(195, 165);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(47, 12);
            this.label45.TabIndex = 26;
            this.label45.Text = "msgid：";
            // 
            // txtbufid
            // 
            this.txtbufid.Location = new System.Drawing.Point(68, 165);
            this.txtbufid.Name = "txtbufid";
            this.txtbufid.Size = new System.Drawing.Size(100, 21);
            this.txtbufid.TabIndex = 25;
            // 
            // label44
            // 
            this.label44.AutoSize = true;
            this.label44.Location = new System.Drawing.Point(15, 174);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(47, 12);
            this.label44.TabIndex = 24;
            this.label44.Text = "bufid：";
            // 
            // btndownimg
            // 
            this.btndownimg.BackColor = System.Drawing.Color.Transparent;
            this.btndownimg.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btndownimg.DownBack = null;
            this.btndownimg.Location = new System.Drawing.Point(431, 82);
            this.btndownimg.MouseBack = null;
            this.btndownimg.Name = "btndownimg";
            this.btndownimg.NormlBack = null;
            this.btndownimg.Size = new System.Drawing.Size(75, 23);
            this.btndownimg.TabIndex = 23;
            this.btndownimg.Text = "下载";
            this.btndownimg.UseVisualStyleBackColor = false;
            this.btndownimg.Click += new System.EventHandler(this.btndownimg_Click);
            // 
            // label43
            // 
            this.label43.AutoSize = true;
            this.label43.Location = new System.Drawing.Point(27, 18);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(479, 36);
            this.label43.TabIndex = 10;
            this.label43.Text = "根据接收到的文件信息，只要知道aeskey和fileid（图片或者视频的时候用：cdnthumburl\r\n，文件的时候用：cdnattachurl）就能下载文件\r" +
    "\n文件类型type值：2 普通图片 3 视频缩略图 4 视频 5 文件";
            // 
            // txtimgtype
            // 
            this.txtimgtype.Location = new System.Drawing.Point(254, 111);
            this.txtimgtype.Name = "txtimgtype";
            this.txtimgtype.Size = new System.Drawing.Size(100, 21);
            this.txtimgtype.TabIndex = 9;
            this.txtimgtype.Text = "2";
            // 
            // label42
            // 
            this.label42.AutoSize = true;
            this.label42.Location = new System.Drawing.Point(195, 114);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(41, 12);
            this.label42.TabIndex = 8;
            this.label42.Text = "type：";
            // 
            // txtpath
            // 
            this.txtpath.Location = new System.Drawing.Point(74, 111);
            this.txtpath.Name = "txtpath";
            this.txtpath.Size = new System.Drawing.Size(100, 21);
            this.txtpath.TabIndex = 7;
            this.txtpath.Text = "D:\\test.jpg";
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.Location = new System.Drawing.Point(15, 114);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(41, 12);
            this.label41.TabIndex = 6;
            this.label41.Text = "path：";
            // 
            // txtfileid
            // 
            this.txtfileid.Location = new System.Drawing.Point(254, 78);
            this.txtfileid.Name = "txtfileid";
            this.txtfileid.Size = new System.Drawing.Size(100, 21);
            this.txtfileid.TabIndex = 5;
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.Location = new System.Drawing.Point(195, 87);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(53, 12);
            this.label40.TabIndex = 4;
            this.label40.Text = "fileid：";
            // 
            // txtaeskey
            // 
            this.txtaeskey.Location = new System.Drawing.Point(74, 84);
            this.txtaeskey.Name = "txtaeskey";
            this.txtaeskey.Size = new System.Drawing.Size(100, 21);
            this.txtaeskey.TabIndex = 3;
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Location = new System.Drawing.Point(6, 87);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(53, 12);
            this.label39.TabIndex = 2;
            this.label39.Text = "aeskey：";
            // 
            // btnclearlog
            // 
            this.btnclearlog.BackColor = System.Drawing.Color.Transparent;
            this.btnclearlog.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btnclearlog.DownBack = null;
            this.btnclearlog.Location = new System.Drawing.Point(268, 183);
            this.btnclearlog.MouseBack = null;
            this.btnclearlog.Name = "btnclearlog";
            this.btnclearlog.NormlBack = null;
            this.btnclearlog.Size = new System.Drawing.Size(75, 23);
            this.btnclearlog.TabIndex = 12;
            this.btnclearlog.Text = "清空日志";
            this.btnclearlog.UseVisualStyleBackColor = false;
            this.btnclearlog.Click += new System.EventHandler(this.btnclearlog_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1075, 679);
            this.Controls.Add(this.btnclearlog);
            this.Controls.Add(this.tabControl2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnuserlist);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.headimg);
            this.Controls.Add(this.lblnickname);
            this.Controls.Add(this.btnloginout);
            this.Controls.Add(this.btnlogin);
            this.Controls.Add(this.txtlog);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = " 微信机器人";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.headimg)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvfriend)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvgroup)).EndInit();
            this.roomstrip.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvpub)).EndInit();
            this.tabControl2.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            this.tabPage6.ResumeLayout(false);
            this.tabPage6.PerformLayout();
            this.tabPage7.ResumeLayout(false);
            this.tabPage7.PerformLayout();
            this.tabPage8.ResumeLayout(false);
            this.tabPage8.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}

