using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text;
using System.Text.RegularExpressions;
using System.Diagnostics;

using System.Runtime.InteropServices;


namespace tsukasa_starter
{
    static class Program
    {
        /// <summary>
        /// アプリケーションのメイン エントリ ポイントです。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }

    }

    static class Tsukasa_starter
    {

        static public string tsukasa_path;
        static public uint tsukasa_rtmp_ch;
        static public List<string> tsukasa_rtmp;
        static public uint tsukasa_param_ch;
        static public List<string> tsukasa_param;
        static public Dictionary<string, string> tsukasa_param_str;
        static public bool tsukasa_rerun;
        //static public string tsukasa;

        static public uint okiba_URL_ch;
        static public List<string> okiba_URL;
        static public uint okiba_port_ch;
        static public Dictionary<string, List<string>> okiba_port;

        static public string okiba_output
        {
            get
            {
                string str = okiba_URL[(int)okiba_URL_ch];
                Uri uri = new Uri(okiba_URL[(int)okiba_URL_ch]);

                uri = uri.SetPort(int.Parse(okiba_port[okiba_URL[(int)okiba_URL_ch]][(int)okiba_port_ch]));
                return uri.ToString();
            }
        }

        static public void LoadSetting()
        {

            string iniFile = Application.StartupPath + "/setting.ini";
            StringBuilder sb = new StringBuilder(1024);

            IniFileHandler.GetPrivateProfileString("TSUKASA", "PATH", "ffmpeg.exe", sb, (uint)sb.Capacity, iniFile);
            tsukasa_path = sb.ToString();
            tsukasa_rtmp_ch = IniFileHandler.GetPrivateProfileInt("TSUKASA", "RTMP_C", 0, iniFile);
            IniFileHandler.GetPrivateProfileString("TSUKASA", "RTMP_LIST", "rtmp://127.0.0.1:1935/live/livestream", sb, (uint)sb.Capacity, iniFile);
            tsukasa_rtmp = new List<string>(sb.ToString().Split(','));
            tsukasa_param_ch = IniFileHandler.GetPrivateProfileInt("TSUKASA", "PARAM_C", 0, iniFile);
            IniFileHandler.GetPrivateProfileString("TSUKASA", "PARAM_LIST", "H264,HEVC", sb, (uint)sb.Capacity, iniFile);
            tsukasa_param = new List<string>(sb.ToString().Split(','));
            tsukasa_rerun = IniFileHandler.GetPrivateProfileInt("TSUKASA", "RERUN", 0, iniFile) != 0 ? true : false;

            tsukasa_param_str = new Dictionary<string, string>();
            foreach(var param in tsukasa_param)
            {
                IniFileHandler.GetPrivateProfileString("TSUKASA", "PARAM_" + param, "", sb, (uint)sb.Capacity, iniFile);
                if (sb.ToString() == "") {
                    if (param == "H264") {
                        tsukasa_param_str.Add(param, "-hide_banner -itsoffset 300 -listen 1 -i <RTMP> -c copy -bsf:v h264_mp4toannexb -tag:v H264 -f asf_stream -map a -map v -push 1 -wms 1 <KAGAMI>");
                    } else if (param == "HEVC") {
                        tsukasa_param_str.Add(param, "-hide_banner -itsoffset 300 -listen 1 -i <RTMP> -c copy -bsf:v hevc_mp4toannexb -tag:v HEVC -f asf_stream -map a -map v -push 1 -wms 1 <KAGAMI>");
                    }
                } else {
                    tsukasa_param_str.Add(param, sb.ToString());
                }
            }

            okiba_URL_ch = IniFileHandler.GetPrivateProfileInt("OKIBA", "URL_C", 0, iniFile);
            IniFileHandler.GetPrivateProfileString("OKIBA", "URL_LIST", "http://127.0.0.1:80/", sb, (uint)sb.Capacity, iniFile);
            okiba_URL = new List<string>(sb.ToString().Split(','));
            okiba_port_ch = IniFileHandler.GetPrivateProfileInt("OKIBA", "PORT_C", 0, iniFile);

            okiba_port = new Dictionary<string, List<string>>();
            foreach (var url in okiba_URL)
            {
                IniFileHandler.GetPrivateProfileString("OKIBA", "PORT_" + url, "8100,8200", sb, (uint)sb.Capacity, iniFile);
                okiba_port.Add(url, new List<string>(sb.ToString().Split(',')));

            }

        }

        static public void SaveSetting()
        {
            string iniFile = Application.StartupPath + "/setting.ini";

            IniFileHandler.WritePrivateProfileString("TSUKASA", "PATH",      tsukasa_path,                   iniFile);
            IniFileHandler.WritePrivateProfileString("TSUKASA", "RTMP_C",    tsukasa_rtmp_ch.ToString(),     iniFile);
            IniFileHandler.WritePrivateProfileString("TSUKASA", "RTMP_LIST", ListtoStr(tsukasa_rtmp),        iniFile);
            IniFileHandler.WritePrivateProfileString("TSUKASA", "PARAM_C",   tsukasa_param_ch.ToString(),    iniFile);
            IniFileHandler.WritePrivateProfileString("TSUKASA", "PARAM_LIST",ListtoStr(tsukasa_param),       iniFile);
            //IniFileHandler.WritePrivateProfileString("TSUKASA", "PARAM_LIST",ListtoStr(tsukasa_param),       iniFile);
            foreach(var item in tsukasa_param_str)
            {
                IniFileHandler.WritePrivateProfileString("TSUKASA", "PARAM_LIST_"+item.Key, item.Value, iniFile);
            }

            IniFileHandler.WritePrivateProfileString("TSUKASA", "RERUN",     tsukasa_rerun ? "1":"0", iniFile);

            IniFileHandler.WritePrivateProfileString("OKIBA",   "URL_C",     okiba_URL_ch.ToString(),    iniFile);
            IniFileHandler.WritePrivateProfileString("OKIBA",   "URL_LIST",  ListtoStr(okiba_URL),       iniFile);
            IniFileHandler.WritePrivateProfileString("OKIBA",   "PORT_C",    okiba_port_ch.ToString(),   iniFile);

            foreach (var item in okiba_port)
            {
                IniFileHandler.WritePrivateProfileString("OKIBA", "PORT_" + item.Key, ListtoStr(item.Value), iniFile);
            }
        }

        static private string ListtoStr(List<string> list)
        {
            return string.Join(",", list.ToArray());
        }

        static public string exe_param()
        {
            string param_str = "";
            param_str += tsukasa_param_str[tsukasa_param[(int)tsukasa_param_ch]];
            param_str = Regex.Replace(param_str, "(<RTMP>|%input%)", tsukasa_rtmp[(int)tsukasa_rtmp_ch], RegexOptions.IgnoreCase);
            param_str = Regex.Replace(param_str, "(<KAGAMI>|%output%)", okiba_output, RegexOptions.IgnoreCase);


            return param_str;
        }


    }


}

/// <summary>
/// INIファイル読み書き用
/// </summary>
class IniFileHandler
{
    [DllImport("kernel32.dll")]
    public static extern uint
        GetPrivateProfileString(string lpAppName,
        string lpKeyName, string lpDefault,
        StringBuilder lpReturnedString, uint nSize,
        string lpFileName);

    [DllImport("kernel32.dll", EntryPoint = "GetPrivateProfileStringA")]
    public static extern uint
        GetPrivateProfileStringByByteArray(string lpAppName,
        string lpKeyName, string lpDefault,
        byte[] lpReturnedString, uint nSize,
        string lpFileName);

    [DllImport("kernel32.dll")]
    public static extern uint
        GetPrivateProfileInt(string lpAppName,
        string lpKeyName, int nDefault, string lpFileName);

    [DllImport("kernel32.dll")]
    public static extern uint WritePrivateProfileString(
        string lpAppName,
        string lpKeyName,
        string lpString,
        string lpFileName);
}


/// <summary>
/// URI編集用
/// </summary>
public static class UriExtensions
{
    public static Uri SetPort(this Uri uri, int newPort)
    {
        var builder = new UriBuilder(uri);
        builder.Port = newPort;
        return builder.Uri;
    }
}