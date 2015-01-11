namespace OLED
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.acrec = new AxVideoChatReceiverLib.AxVideoChatReceiver();
            this.button4 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBox2 = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cboaudiocomplex = new System.Windows.Forms.ComboBox();
            this.cboaudioquality = new System.Windows.Forms.ComboBox();
            this.cboaudiodevice = new System.Windows.Forms.ComboBox();
            this.cbovideoformat = new System.Windows.Forms.ComboBox();
            this.chksendaudio = new System.Windows.Forms.CheckBox();
            this.chksendvideo = new System.Windows.Forms.CheckBox();
            this.txtframerate = new System.Windows.Forms.TextBox();
            this.txtVideobitrate = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.cbovideodevice = new System.Windows.Forms.ComboBox();
            this.acsend = new AxVideoChatSenderLib.AxVideoChatSender();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button2 = new System.Windows.Forms.Button();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.label1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.acrec)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.acsend)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.acrec);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.cboaudiocomplex);
            this.panel1.Controls.Add(this.cboaudioquality);
            this.panel1.Controls.Add(this.cboaudiodevice);
            this.panel1.Controls.Add(this.cbovideoformat);
            this.panel1.Controls.Add(this.chksendaudio);
            this.panel1.Controls.Add(this.chksendvideo);
            this.panel1.Controls.Add(this.txtframerate);
            this.panel1.Controls.Add(this.txtVideobitrate);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.cbovideodevice);
            this.panel1.Controls.Add(this.acsend);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.listBox1);
            this.panel1.Location = new System.Drawing.Point(2, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1196, 667);
            this.panel1.TabIndex = 0;
            // 
            // acrec
            // 
            this.acrec.Enabled = true;
            this.acrec.Location = new System.Drawing.Point(956, 433);
            this.acrec.Name = "acrec";
            this.acrec.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("acrec.OcxState")));
            this.acrec.Size = new System.Drawing.Size(235, 184);
            this.acrec.TabIndex = 34;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(875, 620);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 8;
            this.button4.Text = "Notify";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel2.Controls.Add(this.textBox2);
            this.panel2.Location = new System.Drawing.Point(957, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(234, 298);
            this.panel2.TabIndex = 33;
            // 
            // textBox2
            // 
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox2.Location = new System.Drawing.Point(1, 1);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(231, 295);
            this.textBox2.TabIndex = 6;
            this.textBox2.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(49, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 18);
            this.label2.TabIndex = 32;
            this.label2.Text = "List of Students";
            // 
            // cboaudiocomplex
            // 
            this.cboaudiocomplex.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.cboaudiocomplex.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboaudiocomplex.Location = new System.Drawing.Point(838, 548);
            this.cboaudiocomplex.Name = "cboaudiocomplex";
            this.cboaudiocomplex.Size = new System.Drawing.Size(112, 21);
            this.cboaudiocomplex.TabIndex = 30;
            this.cboaudiocomplex.Visible = false;
            // 
            // cboaudioquality
            // 
            this.cboaudioquality.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.cboaudioquality.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboaudioquality.Location = new System.Drawing.Point(838, 575);
            this.cboaudioquality.Name = "cboaudioquality";
            this.cboaudioquality.Size = new System.Drawing.Size(112, 21);
            this.cboaudioquality.TabIndex = 31;
            this.cboaudioquality.Visible = false;
            // 
            // cboaudiodevice
            // 
            this.cboaudiodevice.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.cboaudiodevice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboaudiodevice.Location = new System.Drawing.Point(586, 548);
            this.cboaudiodevice.Name = "cboaudiodevice";
            this.cboaudiodevice.Size = new System.Drawing.Size(246, 21);
            this.cboaudiodevice.TabIndex = 24;
            this.cboaudiodevice.Visible = false;
            this.cboaudiodevice.SelectedIndexChanged += new System.EventHandler(this.cboaudiodevice_SelectedIndexChanged);
            // 
            // cbovideoformat
            // 
            this.cbovideoformat.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.cbovideoformat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbovideoformat.Location = new System.Drawing.Point(586, 579);
            this.cbovideoformat.Name = "cbovideoformat";
            this.cbovideoformat.Size = new System.Drawing.Size(158, 21);
            this.cbovideoformat.TabIndex = 25;
            this.cbovideoformat.Visible = false;
            // 
            // chksendaudio
            // 
            this.chksendaudio.Checked = true;
            this.chksendaudio.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chksendaudio.Location = new System.Drawing.Point(822, 602);
            this.chksendaudio.Name = "chksendaudio";
            this.chksendaudio.Size = new System.Drawing.Size(128, 26);
            this.chksendaudio.TabIndex = 29;
            this.chksendaudio.Text = "Send Audio Stream";
            this.chksendaudio.Visible = false;
            // 
            // chksendvideo
            // 
            this.chksendvideo.Checked = true;
            this.chksendvideo.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chksendvideo.Location = new System.Drawing.Point(688, 607);
            this.chksendvideo.Name = "chksendvideo";
            this.chksendvideo.Size = new System.Drawing.Size(128, 16);
            this.chksendvideo.TabIndex = 28;
            this.chksendvideo.Text = "Send Video Stream";
            this.chksendvideo.Visible = false;
            // 
            // txtframerate
            // 
            this.txtframerate.Location = new System.Drawing.Point(752, 580);
            this.txtframerate.Name = "txtframerate";
            this.txtframerate.Size = new System.Drawing.Size(64, 20);
            this.txtframerate.TabIndex = 26;
            this.txtframerate.Text = "25";
            this.txtframerate.Visible = false;
            // 
            // txtVideobitrate
            // 
            this.txtVideobitrate.Location = new System.Drawing.Point(586, 605);
            this.txtVideobitrate.Name = "txtVideobitrate";
            this.txtVideobitrate.Size = new System.Drawing.Size(96, 20);
            this.txtVideobitrate.TabIndex = 27;
            this.txtVideobitrate.Text = "128000";
            this.txtVideobitrate.Visible = false;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(1165, 620);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(26, 23);
            this.button3.TabIndex = 9;
            this.button3.Text = "o";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // cbovideodevice
            // 
            this.cbovideodevice.FormattingEnabled = true;
            this.cbovideodevice.Location = new System.Drawing.Point(956, 622);
            this.cbovideodevice.Name = "cbovideodevice";
            this.cbovideodevice.Size = new System.Drawing.Size(197, 21);
            this.cbovideodevice.TabIndex = 8;
            // 
            // acsend
            // 
            this.acsend.Enabled = true;
            this.acsend.Location = new System.Drawing.Point(956, 433);
            this.acsend.Name = "acsend";
            this.acsend.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("acsend.OcxState")));
            this.acsend.Size = new System.Drawing.Size(235, 184);
            this.acsend.TabIndex = 7;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(956, 303);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(235, 98);
            this.textBox1.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(956, 406);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(235, 24);
            this.button1.TabIndex = 1;
            this.button1.Text = "Send";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(0, 29);
            this.listBox1.Name = "listBox1";
            this.listBox1.ScrollAlwaysVisible = true;
            this.listBox1.Size = new System.Drawing.Size(221, 667);
            this.listBox1.TabIndex = 5;
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(1168, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(20, 20);
            this.button2.TabIndex = 4;
            this.button2.Text = "X";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Interval = 50;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::OLED.Properties.Resources._3123123;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(3, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(28, 28);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackgroundImage = global::OLED.Properties.Resources.loginbg;
            this.statusStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1,
            this.label1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 678);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1200, 22);
            this.statusStrip1.TabIndex = 5;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(29, 20);
            this.toolStripDropDownButton1.Text = "toolStripDropDownButton1";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Blue;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.LinkColor = System.Drawing.Color.Blue;
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 17);
            this.label1.Text = "toolStripStatusLabel1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(37, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(200, 21);
            this.label3.TabIndex = 7;
            this.label3.Text = "OLED - Online Education";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Blue;
            this.ClientSize = new System.Drawing.Size(1200, 700);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.acrec)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.acsend)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.RichTextBox textBox2;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripStatusLabel label1;
        private AxVideoChatSenderLib.AxVideoChatSender acsend;
        private System.Windows.Forms.ComboBox cbovideodevice;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ComboBox cboaudiocomplex;
        private System.Windows.Forms.ComboBox cboaudioquality;
        private System.Windows.Forms.ComboBox cboaudiodevice;
        private System.Windows.Forms.ComboBox cbovideoformat;
        private System.Windows.Forms.CheckBox chksendaudio;
        private System.Windows.Forms.CheckBox chksendvideo;
        private System.Windows.Forms.TextBox txtframerate;
        private System.Windows.Forms.TextBox txtVideobitrate;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button4;
        private AxVideoChatReceiverLib.AxVideoChatReceiver acrec;
    }
}

