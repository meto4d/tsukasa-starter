namespace tsukasa_starter
{
    partial class EditListForm
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
            this.listlabel = new System.Windows.Forms.Label();
            this.OKbutton = new System.Windows.Forms.Button();
            this.cancelbutton = new System.Windows.Forms.Button();
            this.List_textBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // listlabel
            // 
            this.listlabel.AutoSize = true;
            this.listlabel.Location = new System.Drawing.Point(12, 9);
            this.listlabel.Name = "listlabel";
            this.listlabel.Size = new System.Drawing.Size(90, 12);
            this.listlabel.TabIndex = 1;
            this.listlabel.Text = "<1>のリストを編集";
            // 
            // OKbutton
            // 
            this.OKbutton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.OKbutton.Location = new System.Drawing.Point(66, 121);
            this.OKbutton.Name = "OKbutton";
            this.OKbutton.Size = new System.Drawing.Size(75, 23);
            this.OKbutton.TabIndex = 2;
            this.OKbutton.Text = "OK";
            this.OKbutton.UseVisualStyleBackColor = true;
            this.OKbutton.Click += new System.EventHandler(this.OKbutton_Click);
            // 
            // cancelbutton
            // 
            this.cancelbutton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelbutton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelbutton.Location = new System.Drawing.Point(147, 121);
            this.cancelbutton.Name = "cancelbutton";
            this.cancelbutton.Size = new System.Drawing.Size(75, 23);
            this.cancelbutton.TabIndex = 3;
            this.cancelbutton.Text = "キャンセル";
            this.cancelbutton.UseVisualStyleBackColor = true;
            this.cancelbutton.Click += new System.EventHandler(this.cancelbutton_Click);
            // 
            // List_textBox
            // 
            this.List_textBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.List_textBox.Location = new System.Drawing.Point(12, 24);
            this.List_textBox.Multiline = true;
            this.List_textBox.Name = "List_textBox";
            this.List_textBox.Size = new System.Drawing.Size(210, 91);
            this.List_textBox.TabIndex = 4;
            this.List_textBox.Text = "rtmp://127.0.0.1:1935/live/livestream";
            // 
            // EditListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(234, 151);
            this.Controls.Add(this.List_textBox);
            this.Controls.Add(this.cancelbutton);
            this.Controls.Add(this.OKbutton);
            this.Controls.Add(this.listlabel);
            this.Name = "EditListForm";
            this.Text = "EditListForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button OKbutton;
        private System.Windows.Forms.Button cancelbutton;
        internal System.Windows.Forms.Label listlabel;
        internal System.Windows.Forms.TextBox List_textBox;
    }
}