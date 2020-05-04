namespace tsukasa_starter
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.tsukasa_textBox = new System.Windows.Forms.TextBox();
            this.tsukasa_button = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tsukasa_param_comboBox = new System.Windows.Forms.ComboBox();
            this.param_button = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.okiba_URL_comboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tsukasa_group = new System.Windows.Forms.GroupBox();
            this.rerun_checkBox = new System.Windows.Forms.CheckBox();
            this.tsukasa_rtmp_comboBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.rtmp_button = new System.Windows.Forms.Button();
            this.okiba_groupBox = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.linkLabel = new System.Windows.Forms.LinkLabel();
            this.linkLabe_contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.コピーToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.playasxをつけてコピーToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uRLとplayasxをつけてコピーToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.配信URLを開くToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.置き場URLを開くToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.okiba_portcheck_button = new System.Windows.Forms.Button();
            this.okiba_port_comboBox = new System.Windows.Forms.ComboBox();
            this.kagami_button = new System.Windows.Forms.Button();
            this.out_richTextBox = new System.Windows.Forms.RichTextBox();
            this.save_setting_button = new System.Windows.Forms.Button();
            this.start_button = new System.Windows.Forms.Button();
            this.tsukasa_openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.process_timer = new System.Windows.Forms.Timer(this.components);
            this.tsukasa_group.SuspendLayout();
            this.okiba_groupBox.SuspendLayout();
            this.linkLabe_contextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "tsukasa(ffmpeg)の場所";
            // 
            // tsukasa_textBox
            // 
            this.tsukasa_textBox.Location = new System.Drawing.Point(7, 33);
            this.tsukasa_textBox.Name = "tsukasa_textBox";
            this.tsukasa_textBox.Size = new System.Drawing.Size(225, 19);
            this.tsukasa_textBox.TabIndex = 1;
            this.tsukasa_textBox.TextChanged += new System.EventHandler(this.tsukasa_textBox_TextChanged);
            // 
            // tsukasa_button
            // 
            this.tsukasa_button.Location = new System.Drawing.Point(238, 31);
            this.tsukasa_button.Name = "tsukasa_button";
            this.tsukasa_button.Size = new System.Drawing.Size(55, 23);
            this.tsukasa_button.TabIndex = 2;
            this.tsukasa_button.Text = "参照";
            this.tsukasa_button.UseVisualStyleBackColor = true;
            this.tsukasa_button.Click += new System.EventHandler(this.tsukasa_button_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "ffmpegパラメータ";
            // 
            // tsukasa_param_comboBox
            // 
            this.tsukasa_param_comboBox.FormattingEnabled = true;
            this.tsukasa_param_comboBox.Location = new System.Drawing.Point(6, 108);
            this.tsukasa_param_comboBox.Name = "tsukasa_param_comboBox";
            this.tsukasa_param_comboBox.Size = new System.Drawing.Size(226, 20);
            this.tsukasa_param_comboBox.TabIndex = 4;
            // 
            // param_button
            // 
            this.param_button.Location = new System.Drawing.Point(238, 106);
            this.param_button.Name = "param_button";
            this.param_button.Size = new System.Drawing.Size(55, 23);
            this.param_button.TabIndex = 5;
            this.param_button.Text = "カスタム";
            this.param_button.UseVisualStyleBackColor = true;
            this.param_button.Click += new System.EventHandler(this.param_button_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 12);
            this.label3.TabIndex = 6;
            this.label3.Text = "鏡置き場URL";
            // 
            // okiba_URL_comboBox
            // 
            this.okiba_URL_comboBox.FormattingEnabled = true;
            this.okiba_URL_comboBox.Location = new System.Drawing.Point(7, 30);
            this.okiba_URL_comboBox.Name = "okiba_URL_comboBox";
            this.okiba_URL_comboBox.Size = new System.Drawing.Size(138, 20);
            this.okiba_URL_comboBox.TabIndex = 7;
            this.okiba_URL_comboBox.SelectedIndexChanged += new System.EventHandler(this.okiba_URL_comboBox_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 12);
            this.label4.TabIndex = 8;
            this.label4.Text = "置き場ポート番号";
            // 
            // tsukasa_group
            // 
            this.tsukasa_group.Controls.Add(this.rerun_checkBox);
            this.tsukasa_group.Controls.Add(this.tsukasa_rtmp_comboBox);
            this.tsukasa_group.Controls.Add(this.tsukasa_param_comboBox);
            this.tsukasa_group.Controls.Add(this.label1);
            this.tsukasa_group.Controls.Add(this.tsukasa_textBox);
            this.tsukasa_group.Controls.Add(this.label5);
            this.tsukasa_group.Controls.Add(this.tsukasa_button);
            this.tsukasa_group.Controls.Add(this.rtmp_button);
            this.tsukasa_group.Controls.Add(this.label2);
            this.tsukasa_group.Controls.Add(this.param_button);
            this.tsukasa_group.Location = new System.Drawing.Point(12, 12);
            this.tsukasa_group.Name = "tsukasa_group";
            this.tsukasa_group.Size = new System.Drawing.Size(299, 138);
            this.tsukasa_group.TabIndex = 9;
            this.tsukasa_group.TabStop = false;
            this.tsukasa_group.Text = "tsukasa(ffmpeg)";
            // 
            // rerun_checkBox
            // 
            this.rerun_checkBox.AutoSize = true;
            this.rerun_checkBox.Location = new System.Drawing.Point(132, 14);
            this.rerun_checkBox.Name = "rerun_checkBox";
            this.rerun_checkBox.Size = new System.Drawing.Size(100, 16);
            this.rerun_checkBox.TabIndex = 14;
            this.rerun_checkBox.Text = "tsukasa再実行";
            this.rerun_checkBox.UseVisualStyleBackColor = true;
            this.rerun_checkBox.CheckedChanged += new System.EventHandler(this.rerun_checkBox_CheckedChanged);
            // 
            // tsukasa_rtmp_comboBox
            // 
            this.tsukasa_rtmp_comboBox.FormattingEnabled = true;
            this.tsukasa_rtmp_comboBox.Location = new System.Drawing.Point(6, 70);
            this.tsukasa_rtmp_comboBox.Name = "tsukasa_rtmp_comboBox";
            this.tsukasa_rtmp_comboBox.Size = new System.Drawing.Size(226, 20);
            this.tsukasa_rtmp_comboBox.TabIndex = 4;
            this.tsukasa_rtmp_comboBox.Text = "rtmp://127.0.0.1:1935/live/livestream";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 12);
            this.label5.TabIndex = 3;
            this.label5.Text = "rtmpURL";
            // 
            // rtmp_button
            // 
            this.rtmp_button.Location = new System.Drawing.Point(238, 70);
            this.rtmp_button.Name = "rtmp_button";
            this.rtmp_button.Size = new System.Drawing.Size(55, 23);
            this.rtmp_button.TabIndex = 5;
            this.rtmp_button.Text = "カスタム";
            this.rtmp_button.UseVisualStyleBackColor = true;
            this.rtmp_button.Click += new System.EventHandler(this.rtmp_button_Click);
            // 
            // okiba_groupBox
            // 
            this.okiba_groupBox.Controls.Add(this.label6);
            this.okiba_groupBox.Controls.Add(this.linkLabel);
            this.okiba_groupBox.Controls.Add(this.okiba_portcheck_button);
            this.okiba_groupBox.Controls.Add(this.okiba_port_comboBox);
            this.okiba_groupBox.Controls.Add(this.okiba_URL_comboBox);
            this.okiba_groupBox.Controls.Add(this.kagami_button);
            this.okiba_groupBox.Controls.Add(this.label4);
            this.okiba_groupBox.Controls.Add(this.label3);
            this.okiba_groupBox.Location = new System.Drawing.Point(317, 12);
            this.okiba_groupBox.Name = "okiba_groupBox";
            this.okiba_groupBox.Size = new System.Drawing.Size(212, 112);
            this.okiba_groupBox.TabIndex = 10;
            this.okiba_groupBox.TabStop = false;
            this.okiba_groupBox.Text = "鏡置き場";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(5, 93);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 12);
            this.label6.TabIndex = 11;
            this.label6.Text = "配信URL:";
            // 
            // linkLabel
            // 
            this.linkLabel.AutoSize = true;
            this.linkLabel.ContextMenuStrip = this.linkLabe_contextMenuStrip;
            this.linkLabel.Location = new System.Drawing.Point(58, 93);
            this.linkLabel.Name = "linkLabel";
            this.linkLabel.Size = new System.Drawing.Size(51, 12);
            this.linkLabel.TabIndex = 10;
            this.linkLabel.TabStop = true;
            this.linkLabel.Text = "配信URL";
            this.linkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_LinkClicked);
            // 
            // linkLabe_contextMenuStrip
            // 
            this.linkLabe_contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.コピーToolStripMenuItem,
            this.playasxをつけてコピーToolStripMenuItem,
            this.uRLとplayasxをつけてコピーToolStripMenuItem,
            this.配信URLを開くToolStripMenuItem,
            this.置き場URLを開くToolStripMenuItem});
            this.linkLabe_contextMenuStrip.Name = "linkLabe_contextMenuStrip";
            this.linkLabe_contextMenuStrip.Size = new System.Drawing.Size(231, 114);
            // 
            // コピーToolStripMenuItem
            // 
            this.コピーToolStripMenuItem.Name = "コピーToolStripMenuItem";
            this.コピーToolStripMenuItem.Size = new System.Drawing.Size(230, 22);
            this.コピーToolStripMenuItem.Text = "配信URLをコピー";
            this.コピーToolStripMenuItem.Click += new System.EventHandler(this.コピーToolStripMenuItem_Click);
            // 
            // playasxをつけてコピーToolStripMenuItem
            // 
            this.playasxをつけてコピーToolStripMenuItem.Name = "playasxをつけてコピーToolStripMenuItem";
            this.playasxをつけてコピーToolStripMenuItem.Size = new System.Drawing.Size(230, 22);
            this.playasxをつけてコピーToolStripMenuItem.Text = "play.asxをつけてコピー";
            this.playasxをつけてコピーToolStripMenuItem.Click += new System.EventHandler(this.playasxをつけてコピーToolStripMenuItem_Click);
            // 
            // uRLとplayasxをつけてコピーToolStripMenuItem
            // 
            this.uRLとplayasxをつけてコピーToolStripMenuItem.Name = "uRLとplayasxをつけてコピーToolStripMenuItem";
            this.uRLとplayasxをつけてコピーToolStripMenuItem.Size = new System.Drawing.Size(230, 22);
            this.uRLとplayasxをつけてコピーToolStripMenuItem.Text = "配信URLとplay.asxをつけてコピー";
            this.uRLとplayasxをつけてコピーToolStripMenuItem.Click += new System.EventHandler(this.uRLとplayasxをつけてコピーToolStripMenuItem_Click);
            // 
            // 配信URLを開くToolStripMenuItem
            // 
            this.配信URLを開くToolStripMenuItem.Name = "配信URLを開くToolStripMenuItem";
            this.配信URLを開くToolStripMenuItem.Size = new System.Drawing.Size(230, 22);
            this.配信URLを開くToolStripMenuItem.Text = "配信URLを開く";
            this.配信URLを開くToolStripMenuItem.Click += new System.EventHandler(this.配信URLを開くToolStripMenuItem_Click);
            // 
            // 置き場URLを開くToolStripMenuItem
            // 
            this.置き場URLを開くToolStripMenuItem.Name = "置き場URLを開くToolStripMenuItem";
            this.置き場URLを開くToolStripMenuItem.Size = new System.Drawing.Size(230, 22);
            this.置き場URLを開くToolStripMenuItem.Text = "置き場URLを開く";
            this.置き場URLを開くToolStripMenuItem.Click += new System.EventHandler(this.置き場URLを開くToolStripMenuItem_Click);
            // 
            // okiba_portcheck_button
            // 
            this.okiba_portcheck_button.Location = new System.Drawing.Point(131, 68);
            this.okiba_portcheck_button.Name = "okiba_portcheck_button";
            this.okiba_portcheck_button.Size = new System.Drawing.Size(75, 23);
            this.okiba_portcheck_button.TabIndex = 9;
            this.okiba_portcheck_button.Text = "portcheck";
            this.okiba_portcheck_button.UseVisualStyleBackColor = true;
            this.okiba_portcheck_button.Click += new System.EventHandler(this.okiba_portcheck_button_Click);
            // 
            // okiba_port_comboBox
            // 
            this.okiba_port_comboBox.FormattingEnabled = true;
            this.okiba_port_comboBox.Location = new System.Drawing.Point(6, 68);
            this.okiba_port_comboBox.Name = "okiba_port_comboBox";
            this.okiba_port_comboBox.Size = new System.Drawing.Size(88, 20);
            this.okiba_port_comboBox.TabIndex = 7;
            this.okiba_port_comboBox.SelectedIndexChanged += new System.EventHandler(this.okiba_port_comboBox_SelectedIndexChanged);
            // 
            // kagami_button
            // 
            this.kagami_button.Location = new System.Drawing.Point(151, 28);
            this.kagami_button.Name = "kagami_button";
            this.kagami_button.Size = new System.Drawing.Size(55, 23);
            this.kagami_button.TabIndex = 5;
            this.kagami_button.Text = "カスタム";
            this.kagami_button.UseVisualStyleBackColor = true;
            this.kagami_button.Click += new System.EventHandler(this.kagami_button_Click);
            // 
            // out_richTextBox
            // 
            this.out_richTextBox.Font = new System.Drawing.Font("MS UI Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.out_richTextBox.Location = new System.Drawing.Point(12, 159);
            this.out_richTextBox.Name = "out_richTextBox";
            this.out_richTextBox.ReadOnly = true;
            this.out_richTextBox.Size = new System.Drawing.Size(517, 60);
            this.out_richTextBox.TabIndex = 11;
            this.out_richTextBox.Text = "";
            // 
            // save_setting_button
            // 
            this.save_setting_button.Location = new System.Drawing.Point(317, 130);
            this.save_setting_button.Name = "save_setting_button";
            this.save_setting_button.Size = new System.Drawing.Size(100, 23);
            this.save_setting_button.TabIndex = 12;
            this.save_setting_button.Text = "設定保存";
            this.save_setting_button.UseVisualStyleBackColor = true;
            this.save_setting_button.Click += new System.EventHandler(this.save_setting_button_Click);
            // 
            // start_button
            // 
            this.start_button.Location = new System.Drawing.Point(423, 130);
            this.start_button.Name = "start_button";
            this.start_button.Size = new System.Drawing.Size(100, 23);
            this.start_button.TabIndex = 13;
            this.start_button.Text = "tsukasa実行";
            this.start_button.UseVisualStyleBackColor = true;
            this.start_button.Click += new System.EventHandler(this.start_button_Click);
            // 
            // tsukasa_openFileDialog
            // 
            this.tsukasa_openFileDialog.FileName = "tsukasa_openFileDialog";
            this.tsukasa_openFileDialog.Filter = "実行ファイル (*.exe)|*.exe|すべてのファイル (*.*)|*.*";
            // 
            // process_timer
            // 
            this.process_timer.Tick += new System.EventHandler(this.process_timer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 225);
            this.Controls.Add(this.start_button);
            this.Controls.Add(this.save_setting_button);
            this.Controls.Add(this.out_richTextBox);
            this.Controls.Add(this.okiba_groupBox);
            this.Controls.Add(this.tsukasa_group);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "TsukasaStarter";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_Closing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tsukasa_group.ResumeLayout(false);
            this.tsukasa_group.PerformLayout();
            this.okiba_groupBox.ResumeLayout(false);
            this.okiba_groupBox.PerformLayout();
            this.linkLabe_contextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tsukasa_textBox;
        private System.Windows.Forms.Button tsukasa_button;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox tsukasa_param_comboBox;
        private System.Windows.Forms.Button param_button;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox okiba_URL_comboBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox tsukasa_group;
        private System.Windows.Forms.CheckBox rerun_checkBox;
        private System.Windows.Forms.ComboBox tsukasa_rtmp_comboBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button rtmp_button;
        private System.Windows.Forms.GroupBox okiba_groupBox;
        private System.Windows.Forms.LinkLabel linkLabel;
        private System.Windows.Forms.Button okiba_portcheck_button;
        private System.Windows.Forms.ComboBox okiba_port_comboBox;
        private System.Windows.Forms.Button kagami_button;
        private System.Windows.Forms.RichTextBox out_richTextBox;
        private System.Windows.Forms.Button save_setting_button;
        private System.Windows.Forms.Button start_button;
        private System.Windows.Forms.OpenFileDialog tsukasa_openFileDialog;
        private System.Windows.Forms.ContextMenuStrip linkLabe_contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem コピーToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem playasxをつけてコピーToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uRLとplayasxをつけてコピーToolStripMenuItem;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ToolStripMenuItem 配信URLを開くToolStripMenuItem;
        private System.Windows.Forms.Timer process_timer;
        private System.Windows.Forms.ToolStripMenuItem 置き場URLを開くToolStripMenuItem;
    }
}

