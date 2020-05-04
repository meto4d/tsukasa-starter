using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Management;
using System.Net.Http;
using System.Text.RegularExpressions;

namespace tsukasa_starter
{
    public partial class Form1 : Form
    {

        private bool startButton;

        public Form1()
        {
            InitializeComponent();

            startButton = false;
        }

        private void Form1_Closing(object sender, FormClosingEventArgs e)
        {
            save_input();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadSetting();
        }

        private void tsukasa_button_Click(object sender, EventArgs e)
        {
            if(tsukasa_openFileDialog.ShowDialog() == DialogResult.OK)
            {
                tsukasa_textBox.Text = tsukasa_openFileDialog.FileName;
                Tsukasa_starter.tsukasa_path = tsukasa_textBox.Text;
            }
        }

        private void LoadSetting()
        {
            Tsukasa_starter.LoadSetting();

            tsukasa_textBox.Text = Tsukasa_starter.tsukasa_path;
            tsukasa_rtmp_comboBox.Items.AddRange(Tsukasa_starter.tsukasa_rtmp.ToArray());
            tsukasa_rtmp_comboBox.SelectedIndex = (int)Tsukasa_starter.tsukasa_rtmp_ch;
            tsukasa_param_comboBox.Items.AddRange(Tsukasa_starter.tsukasa_param.ToArray());
            tsukasa_param_comboBox.SelectedIndex = (int)Tsukasa_starter.tsukasa_param_ch;
            rerun_checkBox.Checked = Tsukasa_starter.tsukasa_rerun;

            okiba_URL_comboBox.Items.Clear();
            okiba_URL_comboBox.Items.AddRange(Tsukasa_starter.okiba_URL.ToArray());
            okiba_URL_comboBox.SelectedIndex = (int)Tsukasa_starter.okiba_URL_ch;

            okiba_port_comboBox.Items.Clear();
            okiba_port_comboBox.Items.AddRange(Tsukasa_starter.okiba_port[Tsukasa_starter.okiba_URL[(int)Tsukasa_starter.okiba_URL_ch]].ToArray());
            okiba_port_comboBox.SelectedIndex = (int)Tsukasa_starter.okiba_port_ch;
            //tsukasa_param_comboBox tsukasa_starter
        }

        private void okiba_URL_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (okiba_URL_comboBox.SelectedIndex >= 0)
            {
                okiba_port_comboBox.Items.Clear();
                okiba_port_comboBox.Items.AddRange(Tsukasa_starter.okiba_port[Tsukasa_starter.okiba_URL[okiba_URL_comboBox.SelectedIndex]].ToArray());
                Tsukasa_starter.okiba_URL_ch = (uint)okiba_URL_comboBox.SelectedIndex;
                okiba_port_comboBox.SelectedIndex = 0;
            }

            linkLabel.Text = Tsukasa_starter.okiba_output;

        }

        private void okiba_port_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            linkLabel.Text = Tsukasa_starter.okiba_output;
        }

        private void コピーToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(linkLabel.Text);
        }

        private void playasxをつけてコピーToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool lastSlash = (linkLabel.Text.LastIndexOf("/") == linkLabel.Text.Length - 1);
            Clipboard.SetText(linkLabel.Text + (lastSlash ? "play.asx" : "/play.asx"));
        }

        private void uRLとplayasxをつけてコピーToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool lastSlash = (linkLabel.Text.LastIndexOf("/") == linkLabel.Text.Length - 1);
            Clipboard.SetText(linkLabel.Text + Environment.NewLine + linkLabel.Text + (lastSlash ? "play.asx" : "/play.asx"));
        }

        private void linkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Drawing.Point p = System.Windows.Forms.Cursor.Position;
            this.linkLabe_contextMenuStrip.Show(p);
        }

        private void 配信URLを開くToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(linkLabel.Text);
        }

        private void 置き場URLを開くToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(okiba_URL_comboBox.Text);
        }

        private void rerun_checkBox_CheckedChanged(object sender, EventArgs e)
        {
            Tsukasa_starter.tsukasa_rerun = rerun_checkBox.Checked;
            process_timer.Enabled = rerun_checkBox.Checked;
        }

        private void tsukasa_textBox_TextChanged(object sender, EventArgs e)
        {
            Tsukasa_starter.tsukasa_path = tsukasa_textBox.Text;
        }

        private void rtmp_button_Click(object sender, EventArgs e)
        {
            EditListForm form = new EditListForm(tsukasa_rtmp_comboBox.Items.Cast<string>().ToList());
            form.Location = Cursor.Position;
            form.Text = "rtmp list";
            form.listlabel.Text = form.listlabel.Text.Replace("<1>", "RTMP URL");
            //form.Show();

            if ( form.ShowDialog() == DialogResult.OK)
            {
                Tsukasa_starter.tsukasa_rtmp = form.List_textBox.Text.Replace("\r\n", "\n").Split('\n').ToList<string>();
                tsukasa_rtmp_comboBox.Items.Clear();
                tsukasa_rtmp_comboBox.Items.AddRange(Tsukasa_starter.tsukasa_rtmp.ToArray());
            }

        }

        private void param_button_Click(object sender, EventArgs e)
        {
            EditDictionaryForm form = new EditDictionaryForm(Tsukasa_starter.tsukasa_param_str);
            form.Location = Cursor.Position;
            form.Text = "tsukasaパラメータ編集";
            form.label1.Text = form.label1.Text.Replace("<1>", "パラメータ");
            form.label1.Text = form.label1.Text.Replace("<2>", "(空白で削除)");
            form.listToolTipStr = "ffmpegへ渡すパラメータの略称";
            form.textboxToolTipStr = "ffmpegへ渡すパラメータ" + Environment.NewLine + "<RTMP>はrtmpのURLに置換" + Environment.NewLine + "<KAGAMI>は鏡置き場の配信URLに置換";

            if (form.ShowDialog() == DialogResult.OK)
            {
                Tsukasa_starter.tsukasa_param_str = form.dic;
                Tsukasa_starter.tsukasa_param.Clear();
                Tsukasa_starter.tsukasa_param.AddRange(Tsukasa_starter.tsukasa_param_str.Keys.ToArray<string>());

                this.tsukasa_param_comboBox.Items.Clear();
                this.tsukasa_param_comboBox.Items.AddRange(Tsukasa_starter.tsukasa_param.ToArray());
                //pass;
            }
        }

        private void kagami_button_Click(object sender, EventArgs e)
        {
            Dictionary<string, string> tmp_port_dic = new Dictionary<string, string>();
            foreach(var item_okiba in Tsukasa_starter.okiba_port)
            {
                tmp_port_dic.Add(item_okiba.Key, string.Join(",", item_okiba.Value.ToArray()));
            }
            EditDictionaryForm form = new EditDictionaryForm(tmp_port_dic);
            form.Location = Cursor.Position;
            form.Text = "鏡置き場ポートリスト編集";
            form.label1.Text = form.label1.Text.Replace("<1>", "鏡置き場リスト");
            form.label1.Text = form.label1.Text.Replace("<2>", "(ポート番号は改行もしくはコロンで区切り)");
            form.listToolTipStr = "鏡置き場のURL" + Environment.NewLine + "空欄で削除";
            form.textboxToolTipStr = "鏡置き場のポート番号" + Environment.NewLine + "空欄で削除";


            if (form.ShowDialog() == DialogResult.OK)
            {
                List<string> tmp_list;
                Tsukasa_starter.okiba_URL.Clear();
                Tsukasa_starter.okiba_port.Clear();
                tmp_port_dic = form.dic;
                foreach(var item in tmp_port_dic)
                {
                    tmp_list = new List<string>(item.Value.Replace("\r\n", "\n").Replace("\n", ",").Split(','));
                    tmp_list.RemoveAll(s => s == "");
                    tmp_list.Sort();
                    Tsukasa_starter.okiba_URL.Add(item.Key);
                    Tsukasa_starter.okiba_port.Add(item.Key, tmp_list);
                    //tmp_list.Clear();

                }

                this.okiba_URL_comboBox.Items.Clear();
                this.okiba_URL_comboBox.Items.AddRange(Tsukasa_starter.okiba_URL.ToArray());
                this.okiba_port_comboBox.Items.Clear();
                this.okiba_port_comboBox.Items.AddRange(Tsukasa_starter.okiba_port[Tsukasa_starter.okiba_URL[(int)Tsukasa_starter.okiba_URL_ch]].ToArray());

                if( this.okiba_port_comboBox.SelectedIndex + 1 > Tsukasa_starter.okiba_port[Tsukasa_starter.okiba_URL[(int)Tsukasa_starter.okiba_URL_ch]].Count)
                {
                    this.okiba_port_comboBox.SelectedIndex = 0;
                } else
                {
                    this.okiba_port_comboBox.SelectedIndex = this.okiba_port_comboBox.SelectedIndex;
                }
            }

        }

        private void save_setting_button_Click(object sender, EventArgs e)
        {
            save_input();
            out_richTextBox_tmp = "";
            SetRichText(Tsukasa_starter.tsukasa_path + " " + Tsukasa_starter.exe_param());
        }

        // 各入力項目をtsukasa_starterに代入
        private void save_input()
        {
            applyTsukasa_starter();
            Tsukasa_starter.SaveSetting();
        }

        private void applyTsukasa_starter()
        {
            Tsukasa_starter.tsukasa_path = tsukasa_textBox.Text;
            Tsukasa_starter.tsukasa_rtmp_ch = (uint)tsukasa_rtmp_comboBox.SelectedIndex;
            Tsukasa_starter.tsukasa_param_ch = (uint)tsukasa_param_comboBox.SelectedIndex;
            Tsukasa_starter.okiba_URL_ch = okiba_URL_comboBox.SelectedIndex < 0 ? 0 : (uint)okiba_URL_comboBox.SelectedIndex;
            Tsukasa_starter.okiba_port_ch = okiba_port_comboBox.SelectedIndex < 0 ? 0 : (uint)okiba_port_comboBox.SelectedIndex;

        }

        /// <summary>
        /// プロセス関係
        /// </summary>
        private Process process;
        private bool beginReadline = false;
        private bool runProcess = false;
        private void start_button_Click(object sender, EventArgs e)
        {

            if(!startButton)
            {
                save_input();
                out_richTextBox_tmp = "";
                SetRichText(Tsukasa_starter.tsukasa_path + " " + Tsukasa_starter.exe_param());

                startButton = true;
                setProcess();
                startUIEnabler(false);

                runProcess = true;
                process.Start();
                process.BeginOutputReadLine();
                process.BeginErrorReadLine();
                beginReadline = true;

                // 連打禁止
                System.Threading.Thread.Sleep(500);
            }
            else
            {
                if (beginReadline)
                {
                    process.CancelOutputRead();
                    process.CancelErrorRead();
                    beginReadline = false;
                }


                KillProcessAndChildren(process.Id);
                process.Close();

                startUIEnabler(true);
                runProcess = false;
                startButton = false;

                SetRichText("--------------------");
            }

        }

        //frame=  118 fps= 46 q=-1.0 size=     473kB time = 00:05:03.83 bitrate=  12.8kbits/s speed = 120x

        private Regex ffmpeg_encode_str_rgx = new Regex(@"frame=\s*\d+\s*fps=\s*\d+\s*q=\s*[0-9\-\.]+\s*size=\s*\d+\w+\s*time\s*=\s*[0-9:\.]+\s*bitrate=\s*[0-9a-zA-Z\.\/]+\s*speed\s*=\s*\d+\w*");
        private int lastStrLength = 0;
        // コマンドライン表示場所
        private string out_richTextBox_tmp;
        private string out_richTextBox_tmpStr
        {
            get
            {
                return out_richTextBox_tmp;
            }
            set
            {

                if (!ffmpeg_encode_str_rgx.IsMatch(value))
                {
                    out_richTextBox_tmp += value + Environment.NewLine;
                    lastStrLength = value.Length + Environment.NewLine.Length;
                }
                else
                {
                    out_richTextBox_tmp = out_richTextBox_tmp.Substring(0, out_richTextBox_tmp.Length - lastStrLength);
                    out_richTextBox_tmp += value + Environment.NewLine;

                }


                if (out_richTextBox_tmp.Length > 100000)
                {
                    out_richTextBox_tmp = out_richTextBox_tmp.Substring(out_richTextBox_tmp.Length - 100000);
                }

                this.out_richTextBox.Text = out_richTextBox_tmp;
                this.out_richTextBox.SelectionStart = this.out_richTextBox.Text.Length;
                this.out_richTextBox.Focus();
                this.out_richTextBox.ScrollToCaret();
            }
        }


        delegate void deleSetRichText(string str);
        private void SetRichText(string str)
        {
            if(str != null)
            {
                out_richTextBox_tmpStr = str;
            }
        }

        private void setProcess()
        {
            process = new Process();
            //ProcessStartInfo si = new ProcessStartInfo("cmd.exe", "/c " + Tsukasa_starter.exe_param());
            //ProcessStartInfo si = new ProcessStartInfo("cmd.exe", "/c " + exe_str);
            ProcessStartInfo si = new ProcessStartInfo(Tsukasa_starter.tsukasa_path, Tsukasa_starter.exe_param());
            //ProcessStartInfo si = new ProcessStartInfo("cmd.exe", "/c " + "dotnet --info");
            //ProcessStartInfo si = new ProcessStartInfo("ruby", "newline.rb");
            //ProcessStartInfo si = new ProcessStartInfo("ffmpeg", "-version");
            //ProcessStartInfo si = new ProcessStartInfo("notepad");
            si.CreateNoWindow = true;
            si.UseShellExecute = false;
            si.RedirectStandardOutput = true;
            si.RedirectStandardError = true;
            process.StartInfo = si;
            process.EnableRaisingEvents = true;

            process.OutputDataReceived += (sender, e) =>
            {
                Invoke(new deleSetRichText(SetRichText), e.Data);
                //Console.WriteLine($"stdout={e.Data}");
            };

            process.ErrorDataReceived += (sender, e) =>
            {
                Invoke(new deleSetRichText(SetRichText), e.Data);
                //Console.WriteLine($"stderr={e.Data}");
            };

            process.Exited += (sender, e) =>
            {
                KillChildren(process.Id);
                System.Threading.Thread.Sleep(500);

                Invoke(new deleSetRichText(SetRichText), "--------------------");
                if(beginReadline)
                {
                    process.CancelOutputRead();
                    process.CancelErrorRead();
                    beginReadline = false;
                }
                runProcess = false;

                if (!Tsukasa_starter.tsukasa_rerun)
                {
                    Invoke(new deleStartUIEnabler(startUIEnabler), true);
                    startButton = false;
                }

            };
        }

        delegate void deleStartUIEnabler(bool f);
        private void startUIEnabler(bool f)
        {
            //this.tsukasa_group.Enabled = f;
            foreach (Control control in this.tsukasa_group.Controls) control.Enabled = f;
            //this.okiba_groupBox.Enabled = f;
            foreach (Control control in this.okiba_groupBox.Controls) control.Enabled = f;
            this.linkLabel.Enabled = true;

            this.save_setting_button.Enabled = f;
            this.start_button.Text = f ? "tsukasa実行" : "終了";
            this.start_button.Font = new Font(this.start_button.Font, f ? FontStyle.Regular : FontStyle.Bold);
        }

        private void KillChildren(int pid)
        {
            using (var searcher = new ManagementObjectSearcher
    ("Select * From Win32_Process Where ParentProcessID=" + pid))
            {
                var moc = searcher.Get();
                foreach (ManagementObject mo in moc)
                {
                    KillProcessAndChildren(Convert.ToInt32(mo["ProcessID"]));
                }
            }
        }

        private void KillProcessAndChildren(int pid)
        {
            
            using (var searcher = new ManagementObjectSearcher
                ("Select * From Win32_Process Where ParentProcessID=" + pid))
            {
                var moc = searcher.Get();
                foreach (ManagementObject mo in moc)
                {
                    KillProcessAndChildren(Convert.ToInt32(mo["ProcessID"]));
                }
                try
                {
                    var proc = Process.GetProcessById(pid);
                    proc.Kill();
                }
                catch (Exception e)
                {
                    // Process already exited.
                }
            }
        }

        private void process_timer_Tick(object sender, EventArgs e)
        {
            if (Tsukasa_starter.tsukasa_rerun)
            {
                if (!runProcess && startButton)
                {
                    setProcess();
                    process.Start();
                    runProcess = true;
                    process.BeginOutputReadLine();
                    process.BeginErrorReadLine();
                    beginReadline = true;
                }

            }
            else
            {
                // こっちに来ることは無いがSleepの関係で一応
                if (!runProcess && startButton)
                {
                    startButton = false;
                    startUIEnabler(true);
                    KillProcessAndChildren(process.Id);
                    process.Close();
                }
            }
        }

        // 置き場のページ(main.html)を取得して、ポート番号を取得
        private void okiba_portcheck_button_Click(object sender, EventArgs args)
        {

            string main_html = okiba_URL_comboBox.Text;
            main_html = main_html + (main_html[main_html.Length - 1] == '/' ? "" : "/") + "main.html";

            using (var client = new HttpClient())
            {
                try
                {
                    var getMain = client.GetAsync(main_html);
                    getMain.Wait();

                    if(getMain.Result.StatusCode == System.Net.HttpStatusCode.OK)
                    {
                        var body = getMain.Result.Content.ReadAsStringAsync();

                        string[] port = getAttribute(body.Result);
                        if(port != null)
                        {
                            // 置き場URLリストを更新
                            Tsukasa_starter.okiba_port[Tsukasa_starter.okiba_URL[(int)Tsukasa_starter.okiba_URL_ch]].Clear();
                            Tsukasa_starter.okiba_port[Tsukasa_starter.okiba_URL[(int)Tsukasa_starter.okiba_URL_ch]].AddRange(port);

                            refreshOkibaPort();
                        } else
                        {
                            string error_str = "ポート番号の取得に失敗しました。" + Environment.NewLine;

                            MessageBox.Show(error_str, "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                    } else
                    {
                        string error_str = "置き場URLが間違っているか、非対応の置き場が利用されている可能性があります。" + Environment.NewLine + Environment.NewLine;
                        error_str += "HttpStatus:" + getMain.Result.StatusCode.ToString();

                        MessageBox.Show(error_str, "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (System.AggregateException e)
                {
                    string error_str = "置き場URLが間違っているか、置き場が落ちている可能性があります。" + Environment.NewLine + Environment.NewLine + "詳細:";
                    foreach(var e_item in e.InnerExceptions)
                    {
                        error_str += e_item.InnerException.InnerException.Message + Environment.NewLine;
                    }

                    MessageBox.Show(error_str, "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (System.Net.Sockets.SocketException e)
                {
                    Console.WriteLine(e);
                }
                catch (HttpRequestException e)
                {
                    Console.WriteLine(e);
                }
                //catch ()
                //{

                //}


            }
        }

        /// <summary>
        /// 置き場のmain.htmlの文字列から、conn.html?open=<PORT>を取得。
        /// ポート番号の配列を返す
        /// </summary>
        /// <param name="html"></param>
        private string[] getAttribute(string html)
        {
            //
            List<string> port = new List<string>();

            //コメントアウトされてる要素は削除
            int index_start = 0, index_diff = 0;
            while ((index_start = html.IndexOf("<!--", 0)) >= 0)
            {
                index_diff = html.IndexOf("-->", index_start) - index_start + 3;

                html = html.Remove(index_start, index_diff);
            }

            var reg = new Regex(@"conn.html\?open=(\d+)");
            foreach (Match match in reg.Matches(html))
            {
                port.Add(int.Parse(match.Groups[1].ToString()).ToString());
            }

            return port.ToArray();
        }

        /// <summary>
        /// 置き場ポートを更新
        /// </summary>
        private void refreshOkibaPort()
        {
            if (okiba_URL_comboBox.SelectedIndex >= 0)
            {
                okiba_port_comboBox.Items.Clear();
                okiba_port_comboBox.Items.AddRange(Tsukasa_starter.okiba_port[Tsukasa_starter.okiba_URL[okiba_URL_comboBox.SelectedIndex]].ToArray());
                Tsukasa_starter.okiba_URL_ch = (uint)okiba_URL_comboBox.SelectedIndex;
                okiba_port_comboBox.SelectedIndex = 0;
            }

            linkLabel.Text = Tsukasa_starter.okiba_output;
        }

    }
}

