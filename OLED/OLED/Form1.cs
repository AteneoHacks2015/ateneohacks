using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;
namespace OLED
{

    

    public partial class Form1 : Form
    {

        string uname;
        int acctType;
        public Form1(string n, int a)
        {
            uname = n;
            acctType = a;
            InitializeComponent();
        }

       System.Net.Sockets.TcpClient clientSocket = new System.Net.Sockets.TcpClient();
       

        private void Form1_Load(object sender, EventArgs e)
        {

            if (acctType == 1)
            {
                acrec.Visible = false;
            }
            else
            {
                acrec.Visible = true;
            }

            try
            {
             //   msg("Client Started");
                clientSocket.Connect("127.0.0.1", 8888);
                label1.Text = "Client Socket Program - Server Connected ...";


                int ivideodevicecount;
                int iaudiodevicecount;

                int i;


                ivideodevicecount = acsend.GetVideoDeviceCount();

                for (i = 0; i < ivideodevicecount; i++)
                {

                    cbovideodevice.Items.Add(acsend.GetVideoDeviceName((short)i));

                }
                if (cbovideodevice.Items.Count > 0)
                    cbovideodevice.SelectedIndex = 0;

                iaudiodevicecount = acsend.GetAudioDeviceCount();

                for (i = 0; i < iaudiodevicecount; i++)
                    cboaudiodevice.Items.Add(acsend.GetAudioDeviceName((short)i));

                if (cboaudiodevice.Items.Count > 0)
                    cboaudiodevice.SelectedIndex = 0;

                cbovideoformat.Items.Add("160x120");
                cbovideoformat.Items.Add("176x144");
                cbovideoformat.Items.Add("320x240");
                cbovideoformat.Items.Add("352x288");
                cbovideoformat.Items.Add("640x480");
                cbovideoformat.SelectedIndex = 2;


                cboaudiocomplex.Items.Add("0");
                cboaudiocomplex.Items.Add("1");
                cboaudiocomplex.Items.Add("2");
                cboaudiocomplex.Items.Add("3");
                cboaudiocomplex.SelectedIndex = 0;



                for (i = 0; i <= 10; i++)
                {


                    cboaudioquality.Items.Add(i.ToString());

                }
                cboaudioquality.SelectedIndex = 8;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                throw;
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NetworkStream serverStream = clientSocket.GetStream();
            if (textBox1.Text.Trim() == "")
            { }
            else
            {
                int conference = 123456;
                byte[] outStream = System.Text.Encoding.ASCII.GetBytes(conference.ToString() + "001" + uname + ": " +  textBox1.Text + "/?$?/");
                serverStream.Write(outStream, 0, outStream.Length);
                serverStream.Flush();
            }

            byte[] inStream = new byte[10025];
            serverStream.Read(inStream, 0, (int)clientSocket.ReceiveBufferSize);
            string returndata = System.Text.Encoding.ASCII.GetString(inStream);

                int conNo = Convert.ToInt32(returndata.Substring(0, 6));     //Conference Number
                int dataid = Convert.ToInt32(returndata.Substring(6, 3));
                //dataid  001 = Message
                //002 = Present
                //003 = Recite

                string maindata = returndata.Substring(9, returndata.Length - 10);
                msg(maindata);
                textBox1.Text = "";
                textBox1.Focus();
        }

        public void msg(string mesg)
        {
            textBox2.Text = textBox2.Text + Environment.NewLine + " >> " + mesg;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            clientSocket.GetStream().Close();
            clientSocket.Close();
             this.Close();
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            acsend.VideoDevice = (short)cbovideodevice.SelectedIndex;
            acsend.AudioDevice = (short)cboaudiodevice.SelectedIndex;


            acsend.VideoFormat = (short)cbovideoformat.SelectedIndex;
            acsend.FrameRate = Convert.ToInt32(txtframerate.Text, 10);
            acsend.VideoBitrate = Convert.ToInt32(txtVideobitrate.Text, 10);
            acsend.AudioComplexity = (short)cboaudiocomplex.SelectedIndex;
            acsend.AudioQuality = (short)cboaudioquality.SelectedIndex;
            acsend.SendAudioStream = chksendaudio.Checked;
            acsend.SendVideoStream = chksendvideo.Checked;

            acsend.ConferenceNumber = 1000;
            acsend.ConferenceUserID = 11;
            int iResult = acsend.Connect("127.0.0.1", Convert.ToInt32("8888", 10));
        }

        private void cboaudiodevice_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        int mousey;
    bool dragy = false;
    int mousex;
    int mouseyy;
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
                    dragy = true;

            mousex =Cursor.Position.X - this.Left;//'Sets variable mousex
            mouseyy = Cursor.Position.Y - this.Top;// 'Sets variable mousey
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragy == true)
            {
            this.Top = Cursor.Position.Y - mouseyy;
            this.Left = Cursor.Position.X - mousex;
            }
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
                    dragy = false;
                    if (this.Top < 0)
                    {

                        this.Top = 0;
                    }
            }

        int i = 0;
        bool checkred = false;
        bool checkgreen = false;
        bool checkblue = false;
        int rndred;
        int rndgreen;
        int rndblue;
        int reds = 0;
        int greens = 0;
        int blues = 139;
        Random rnd = new Random();

        private void timer2_Tick_1(object sender, EventArgs e)
        {  if (checkred == false)
            {
                rndred = 255 * rnd.Next();
                checkred = true;
            }
            if (checkgreen == false)
            {
                rndgreen = 255 * rnd.Next();
                checkgreen = true;
            }
            if (checkblue == false)
            {
                rndblue = 255 * rnd.Next();
                checkblue = true;
            }
            if (reds > rndred)
            {
                reds--;
            }
            else if (reds < rndred)
            {
                reds++;
            }
            else
            {
                checkred = false;
            }
            if (greens > rndgreen)
            {
                greens--;
            }
            else if (greens < rndgreen)
            {
                greens++;
            }
            else
            {
                checkgreen = false;
            }
            if (blues > rndblue)
            {
                blues--;
            }
            else if (blues < rndblue)
            {
                blues++;
            }
            else
            {
                checkblue = false;
            }
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(reds)))), ((int)(((byte)(greens)))), ((int)(((byte)(blues)))));
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ASCIIEncoding encoding = new ASCIIEncoding();
            string postDATA = "name=" + uname;
            byte[] data = encoding.GetBytes(postDATA);
            WebRequest request = WebRequest.Create("http://192.168.43.15/st/chikka/sender.php");
            request.Method = "POST";
            request.ContentType = "application/x-www-form-urlencoded";
            request.ContentLength = data.Length;

            Stream stream = request.GetRequestStream();
            stream.Write(data, 0, data.Length);
            stream.Close();

            WebResponse response = request.GetResponse();
            stream = response.GetResponseStream();
            stream.Flush();
        }
    }
}
