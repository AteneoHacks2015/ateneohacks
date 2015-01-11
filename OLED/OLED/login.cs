using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.IO;

namespace OLED
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Form form1 = new Form1();
            //form1.Show();
           
            try
            {

                string user = textBox1.Text;
                string pass = textBox2.Text;
                ASCIIEncoding encoding = new ASCIIEncoding();
                string postDATA = "name=" + user + "&pass=" + pass;
                byte[] data = encoding.GetBytes(postDATA);
                WebRequest request = WebRequest.Create("http://192.168.43.15/st/api/loginapi.php");
                request.Method = "POST";
                request.ContentType = "application/x-www-form-urlencoded";
                request.ContentLength = data.Length;

                Stream stream = request.GetRequestStream();
                stream.Write(data, 0, data.Length);
                stream.Close();

                WebResponse response = request.GetResponse();
                stream = response.GetResponseStream();
                stream.Flush();

                StreamReader sr = new StreamReader(stream);

                MessageBox.Show(sr.ReadToEnd());
                if(sr.ReadToEnd().Contains("0:0"))
                {
                    MessageBox.Show("Invalid username/password");
                }
                else if(sr.ReadToEnd().Contains("Teacher"))
                {
                   
                   Form f1 = new Form1(textBox1.Text, 1);
                   
                    f1.Show();
                    
                    this.Hide();
                }
                else
                {
                    Form f1 = new Form1(textBox1.Text, 2);
                    f1.Show();
                    this.Hide();
                }

           

                sr.Close();
                stream.Close();

            }
            catch (Exception ex)
            {
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void login_Load(object sender, EventArgs e)
        {

        }

        private void login_MouseMove(object sender, MouseEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }

    
}
