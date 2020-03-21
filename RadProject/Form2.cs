using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RadProject
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Mtrix mt = new Mtrix();
            mt.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Graph gr = new Graph();
            gr.Show(); 
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Help Hp= new Help();
            Hp.Show();

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Mtrix Mt = new Mtrix();
            Mt.Show();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Graph Grp=new Graph();
            Grp.Show();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Help Hp = new Help();
            Hp.Show();
        }
    }
}
