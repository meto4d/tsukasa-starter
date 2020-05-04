using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tsukasa_starter
{
    public partial class EditListForm : Form
    {
        //Form1 form;
        //List<string> list;
        public EditListForm(List<string> list)
        {
            InitializeComponent();
            List_textBox.Text = string.Join("\n", list.ToArray());
        }

        private void OKbutton_Click(object sender, EventArgs e)
        {
            //this.listBox.Items
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void cancelbutton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;

            this.Close();
        }
    }


}
