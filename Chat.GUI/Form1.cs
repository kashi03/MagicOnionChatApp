using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Chat.Client;

namespace Chat.GUI
{
    public partial class Form1 : Form
    {
        ChatClient client;
        public Form1()
        {
            InitializeComponent();
            this.client = new ChatClient(richTextBox1);
            this.client.JoinRoom();

        }
        private void SendMessage(object sender, EventArgs e)
        {
            System.Diagnostics.Debug.WriteLine(textBox1.Text);
            this.client.SendMessage(textBox1.Text);
            //richTextBox1.Text += textBox1.Text+"\n";
            textBox1.Text = "";
        }
    }
}
