using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace V3rmProtoAPI
{
    public partial class Form1 : Form
    {
        V3rmAPI.V3rmAPI Tutorial = new V3rmAPI.V3rmAPI();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Tutorial.Inject();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Tutorial.ExecuteScript(richTextBox1.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.richTextBox1.Text = "";
        }
    }
}
