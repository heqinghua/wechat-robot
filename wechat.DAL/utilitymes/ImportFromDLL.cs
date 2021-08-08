namespace wechat.DAL.utilitymes
{
    using System;
    using System.Runtime.InteropServices;

    public class ImportFromDLL
    {
        [DllImport("WXCommand.dll", CallingConvention=CallingConvention.StdCall)]
        public static extern int WXCmdGetLocalWechatVersion(char[] version, int versionMaxLength);
        [DllImport("WXCommand.dll", CallingConvention=CallingConvention.StdCall)]
        public static extern int WXCmdInitDllPath(string path);
        [DllImport("WXCommand.dll", CallingConvention=CallingConvention.StdCall)]
        public static extern int WXCmdOpenWechat();
        [DllImport("WXCommand.dll", CallingConvention=CallingConvention.StdCall)]
        public static extern int WXCmdRun();
        [DllImport("WXCommand.dll", CallingConvention=CallingConvention.StdCall)]
        public static extern int WXCmdSend(int clientID, byte[] jsonData);
        [DllImport("WXCommand.dll", CallingConvention=CallingConvention.StdCall)]
        public static extern int WXCmdStop();
    }
}

