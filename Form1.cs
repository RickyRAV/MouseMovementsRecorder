using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace keyboard_recorder
{
    public partial class Form1 : Form
    {
        ListViewItem lv;
        int a;
        int b;
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lv = new ListViewItem(Cursor.Position.X.ToString());
            lv.SubItems.Add(Cursor.Position.Y.ToString());
            listView1.Items.Add(lv);
            b++;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (a!=b)
            {
                Cursor.Position = new Point(int.Parse(listView1.Items[a].SubItems[0].Text), int.Parse(listView1.Items[a].SubItems[1].Text));
                a++;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            timer2.Stop();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            timer2.Start();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            a = 0;
            b = 0;
        }
    }
}
