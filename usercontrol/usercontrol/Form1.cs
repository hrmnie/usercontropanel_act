using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace usercontrol
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public string panelOneInpOne
        {
            set 
            {
                textBox1.Text = value;
            }
        
        }
        public string panelOneInpTwo
        {
            set
            {
                textBox2.Text = value;
            }
        }
        public string panelTwoInpOne
        {
            set
            {
                textBox1.Text = value;
            }
        }
        public string panelTwoInputTwo 
        {
            set
            {
                textBox2.Text = value;
            }
        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            dataPanelDetails.Show();
            panel_one1.Show();
            panel_one1.BringToFront();

            panel_two1.Hide();
        }

        private void panel_one1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataPanelDetails.Hide();

            panel_one1.Show();
            panel_one1.BringToFront();

            panel_two1.Hide();
        }

        private void panelTwoBtn_Click_1(object sender, EventArgs e)
        {
            dataPanelDetails.Show();
            panel_two1.Show();
            panel_two1.BringToFront();

            panel_one1.Hide();
        }
    }
}
