namespace wechat.Model.sysmes
{
    using System;
    using System.Data;

    public class userinfo
    {
        private string _id;
        private string _v1;
        private string _wxid;
        private string _account;
        private string _nickname;
        private string _headimg;
        private int? _lockstatus;
        private string _phone;
        private string _payalipay;
        private string _truename;
        private string _memo;
        private int? _utype;
        private DateTime? _createtime;

        public userinfo()
        {
        }

        public userinfo(IDataReader reader)
        {
            this._id = reader["id"].ToString();
            if (readerExists(reader, "wxid") && (reader["wxid"] != DBNull.Value))
            {
                this._wxid = reader["wxid"].ToString();
            }
            if (readerExists(reader, "account") && (reader["account"] != DBNull.Value))
            {
                this._account = reader["account"].ToString();
            }
            if (readerExists(reader, "nickname") && (reader["nickname"] != DBNull.Value))
            {
                this._nickname = reader["nickname"].ToString();
            }
            if (readerExists(reader, "lockstatus") && (reader["lockstatus"] != DBNull.Value))
            {
                this._lockstatus = new int?(int.Parse(reader["lockstatus"].ToString()));
            }
            if (readerExists(reader, "phone") && (reader["phone"] != DBNull.Value))
            {
                this._phone = reader["phone"].ToString();
            }
            if (readerExists(reader, "payalipay") && (reader["payalipay"] != DBNull.Value))
            {
                this._payalipay = reader["payalipay"].ToString();
            }
            if (readerExists(reader, "truename") && (reader["truename"] != DBNull.Value))
            {
                this._truename = reader["truename"].ToString();
            }
            if (readerExists(reader, "memo") && (reader["memo"] != DBNull.Value))
            {
                this._memo = reader["memo"].ToString();
            }
            if (readerExists(reader, "utype") && (reader["utype"] != DBNull.Value))
            {
                this._utype = new int?(int.Parse(reader["utype"].ToString()));
            }
            if (readerExists(reader, "createtime") && (reader["createtime"] != DBNull.Value))
            {
                this._createtime = new DateTime?(DateTime.Parse(reader["createtime"].ToString()));
            }
        }

        public static bool readerExists(IDataReader reader, string name)
        {
            int i = 0;
            while (true)
            {
                bool flag2;
                if (i >= reader.FieldCount)
                {
                    flag2 = false;
                }
                else
                {
                    if (!reader.GetName(i).Equals(name, StringComparison.CurrentCultureIgnoreCase))
                    {
                        i++;
                        continue;
                    }
                    flag2 = true;
                }
                return flag2;
            }
        }

        public string id { get; set; }

        public string v1 { get; set; }

        public string wxid { get; set; }

        public string account { get; set; }

        public string nickname { get; set; }

        public string headimg { get; set; }

        public int? lockstatus { get; set; }

        public string phone { get; set; }

        public string payalipay { get; set; }

        public string truename { get; set; }

        public string memo { get; set; }

        public int? utype { get; set; }

        public DateTime? createtime { get; set; }
    }
}

