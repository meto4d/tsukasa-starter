using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace tsukasa_starter
{
    public partial class EditDictionaryForm : Form
    {
        public string NEWITEM_text = "*(新規項目)";

        internal string listToolTipStr {
            set
            {
                this.listToolTip.SetToolTip(this.listView1, value);
            }
        }
        internal string textboxToolTipStr {
            set
            {
                this.textboxToolTip.SetToolTip(this.textBox1, value);
            }
        }
        internal Dictionary<string, string> dic;

        private ListViewItem tlvi;


        public EditDictionaryForm(Dictionary<string, string> d)
        {
            InitializeComponent();
            
            this.listView1.Items.Clear();
            foreach(var key in d.Keys)
            {
                this.listView1.Items.Add(key);
            }
            //this.listView1.Items.AddRange( new ListViewItem(dic.Keys.ToArray<string>()));
            this.listView1.Items.Add(NEWITEM_text);

            dic = d;

        }

        private bool isURL(string str)
        {
            return Regex.IsMatch(str, @"^h?ttps?://[-_.!~*'()a-zA-Z0-9;/?:@&=+$,%#]+$");
        }

        private void OKbutton_Click(object sender, EventArgs e)
        {

            if (this.Text.IndexOf("鏡") >= 0)
            {
                foreach(var item in dic)
                {
                    if (!isURL(item.Key))
                    {
                        MessageBox.Show("鏡リストはURL以外を登録することはできません。");
                        return;
                    }
                }
            }

            dic.Remove("");
            var remove_key = dic.Where(x => EqualityComparer<String>.Default.Equals(x.Value, ""))
                .Select(x => x.Key).ToArray();
            foreach(var key in remove_key)
            {
                dic.Remove(key);
            }

            //foreach (var item in dic)
            //{
            //    if (item.Value == "") dic.Remove(item.Key);
            //    if (item.Key == "") dic.Remove(item.Key);
            //}

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void cancelbutton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        // ListView 
        // Ref: https://dobon.net/vb/dotnet/control/lvlabeledit.html

        private void ListView1_AfterLabelEdit(object sender, LabelEditEventArgs e)
        {
            //ラベルが変更されたか調べる
            //e.Labelがnullならば、変更されていない
            if (e.Label != null)
            {
                ListView lv = (ListView)sender;

                // 空白のとき削除
                if (e.Label == "")
                {
                    e.CancelEdit = true;

                    dic.Remove(lv.Items[e.Item].Text);
                    lv.Items.RemoveAt(e.Item);
                } 
                else
                {

                    // 同名の項目があるとき
                    if(dic.ContainsKey(e.Label))
                    {
                        e.CancelEdit = true;
                        string str = e.Label + "(1)";
                        if(dic.ContainsKey(lv.Items[e.Item].Text))
                        {
                            dic.Add(str, dic[lv.Items[e.Item].Text]);
                            dic.Remove(lv.Items[e.Item].Text);
                        } else
                        {
                            dic.Add(str, "");
                        }                            

                        lv.Items[e.Item].Text = str;
                    }
                    // 同名の項目がない時
                    else
                    {
                        if(e.Label == NEWITEM_text)
                        {
                            e.CancelEdit = true;
                            lv.Items[e.Item].Text = e.Label.Replace("*", "");
                        }

                        if (dic.ContainsKey(lv.Items[e.Item].Text))
                        {
                            dic.Add(e.Label, dic[lv.Items[e.Item].Text]);
                            dic.Remove(lv.Items[e.Item].Text);
                        }
                        else
                        {
                            dic.Add(e.Label, "");
                        }
                    }
                
                    // 最終行のとき
                    if (e.Item == lv.Items.Count - 1)
                    {

                        lv.Items.Add(NEWITEM_text);

                    }
                }
            }
        }

        private void ListView1_KeyUp(object sender, KeyEventArgs e)
        {
            ListView lv = (ListView)sender;
            if (e.KeyCode == Keys.F2 && lv.FocusedItem != null && lv.LabelEdit)
            {
                lv.FocusedItem.BeginEdit();
            }
        }
        private void ListView1_Click(object sender, EventArgs e)
        {
            ListView lv = (ListView)sender;

            if (lv.FocusedItem != null && lv.LabelEdit)
            {
                tlvi = lv.FocusedItem;
                try
                {
                    this.textBox1.Text = dic[lv.FocusedItem.Text];
                } catch
                {
                    this.textBox1.Text = "";
                }
            }
        }

        private void ListView1_DoubleClick(object sender, EventArgs e)
        {
            ListView lv = (ListView)sender;
            if (lv.FocusedItem != null && lv.LabelEdit)
            {
                tlvi = lv.FocusedItem;
                lv.FocusedItem.BeginEdit();
            }
        }

        // テキストボックスの編集が終了したとき
        // リスト項目をキーとしたDicの項目に代入する
        // リスト項目のキーがNEWITEM_textならば、リスト項目のキーを現時刻にして、Dicに追加
        private void TextBox1_Leave(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;

            if(tlvi == null)
            {
                return;
            }

            if (tlvi.Text != NEWITEM_text && dic.ContainsKey(tlvi.Text))
            {
                dic[tlvi.Text] = tb.Text;
            } else
            {
                if(tlvi.Text == NEWITEM_text)
                {
                    tlvi.Text = tlvi.Text.Replace("*", "");

                    this.listView1.Items[this.listView1.Items.Count - 1].Text = tlvi.Text;
                    this.listView1.Items.Add(NEWITEM_text);
                }

                dic.Add(tlvi.Text, tb.Text);
            }
        }

        private void EditDictionaryForm_SizeChange(object sender, EventArgs e)
        {
            EditDictionaryForm edf = (EditDictionaryForm)sender;
            edf.columnHeader1.Width = -2;
            edf.columnHeader1.Width -= 3;
            edf.listView1.Size = new Size(edf.Size.Width / 2 - 42, edf.Size.Height - 108);

            edf.buttonBGTriangle1.Location = new Point(edf.Size.Width / 2 - 21, edf.Size.Height / 2 - 38);
            
            edf.textBox1.Size = new Size(edf.Size.Width / 2 - 42, edf.Size.Height - 108);
            edf.textBox1.Location = new Point(edf.Size.Width / 2 + 7, edf.textBox1.Location.Y);
        }

    }
}
