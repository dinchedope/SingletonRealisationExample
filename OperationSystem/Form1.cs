using System;
using SystemCore;
using SystemCore.Log;
using System.Windows.Forms;
using System.Linq.Expressions;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace OperationSystem
{
    public partial class Form1 : Form
    {
        Singleton Shimbus;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Shimbus = Singleton.GetInstance(textBox1.Text);
            groupBox1.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Log log = new Log("Button 1 press", "bla-bla");
            Shimbus.WriteLog(log.SelfSerialize());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Log log = new Log("Button 2 press", "bla-bla");
            Shimbus.WriteLog(log.SelfSerialize());
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            Log log = new Log("TextBox changing", "bla-bla");
            Shimbus.WriteLog(log.SelfSerialize());
        }
    }
}
