namespace tsukasa_starter
{
    partial class EditDictionaryForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem("あいうえお");
            this.label1 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.OKbutton = new System.Windows.Forms.Button();
            this.cancelbutton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.buttonBGTriangle1 = new tsukasa_starter.ButtonBGTriangle();
            this.listToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.textboxToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "<1>のリストを編集<2>";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.listView1.HideSelection = false;
            this.listView1.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem4});
            this.listView1.LabelEdit = true;
            this.listView1.Location = new System.Drawing.Point(15, 29);
            this.listView1.Name = "listView1";
            this.listView1.Scrollable = false;
            this.listView1.Size = new System.Drawing.Size(164, 200);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.AfterLabelEdit += new System.Windows.Forms.LabelEditEventHandler(this.ListView1_AfterLabelEdit);
            this.listView1.Click += new System.EventHandler(this.ListView1_Click);
            this.listView1.DoubleClick += new System.EventHandler(this.ListView1_DoubleClick);
            this.listView1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.ListView1_KeyUp);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Width = 160;
            // 
            // OKbutton
            // 
            this.OKbutton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.OKbutton.Location = new System.Drawing.Point(221, 234);
            this.OKbutton.Name = "OKbutton";
            this.OKbutton.Size = new System.Drawing.Size(75, 23);
            this.OKbutton.TabIndex = 3;
            this.OKbutton.Text = "OK";
            this.OKbutton.UseVisualStyleBackColor = true;
            this.OKbutton.Click += new System.EventHandler(this.OKbutton_Click);
            // 
            // cancelbutton
            // 
            this.cancelbutton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelbutton.Location = new System.Drawing.Point(302, 234);
            this.cancelbutton.Name = "cancelbutton";
            this.cancelbutton.Size = new System.Drawing.Size(75, 23);
            this.cancelbutton.TabIndex = 4;
            this.cancelbutton.Text = "キャンセル";
            this.cancelbutton.UseVisualStyleBackColor = true;
            this.cancelbutton.Click += new System.EventHandler(this.cancelbutton_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(213, 29);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(164, 200);
            this.textBox1.TabIndex = 5;
            this.textBox1.Leave += new System.EventHandler(this.TextBox1_Leave);
            // 
            // buttonBGTriangle1
            // 
            this.buttonBGTriangle1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonBGTriangle1.Direction = tsukasa_starter.ButtonBGTriangle.TriangleDirection.Right;
            this.buttonBGTriangle1.Enabled = false;
            this.buttonBGTriangle1.Location = new System.Drawing.Point(185, 116);
            this.buttonBGTriangle1.MaximumSize = new System.Drawing.Size(22, 22);
            this.buttonBGTriangle1.MinimumSize = new System.Drawing.Size(22, 22);
            this.buttonBGTriangle1.Name = "buttonBGTriangle1";
            this.buttonBGTriangle1.Size = new System.Drawing.Size(22, 22);
            this.buttonBGTriangle1.TabIndex = 6;
            this.buttonBGTriangle1.TriangleColor = System.Drawing.SystemColors.ControlText;
            this.buttonBGTriangle1.UseVisualStyleBackColor = true;
            // 
            // listToolTip
            // 
            this.listToolTip.AutoPopDelay = 5000;
            this.listToolTip.InitialDelay = 500;
            this.listToolTip.ReshowDelay = 100;
            // 
            // textboxToolTip
            // 
            this.textboxToolTip.AutoPopDelay = 5000;
            this.textboxToolTip.InitialDelay = 500;
            this.textboxToolTip.ReshowDelay = 100;
            this.textboxToolTip.ShowAlways = true;
            // 
            // EditDictionaryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 269);
            this.Controls.Add(this.buttonBGTriangle1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.cancelbutton);
            this.Controls.Add(this.OKbutton);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.label1);
            this.MinimumSize = new System.Drawing.Size(412, 308);
            this.Name = "EditDictionaryForm";
            this.Text = "EditDictionaryForm";
            this.SizeChanged += new System.EventHandler(this.EditDictionaryForm_SizeChange);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button OKbutton;
        private System.Windows.Forms.Button cancelbutton;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.TextBox textBox1;
        private ButtonBGTriangle buttonBGTriangle1;
        internal System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ToolTip listToolTip;
        private System.Windows.Forms.ToolTip textboxToolTip;
    }
}