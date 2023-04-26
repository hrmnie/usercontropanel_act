using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace usercontrol
{
    public partial class panel_one : UserControl
    {
        public panel_one()
        {
            InitializeComponent();
        }

        private void panel_one_Load(object sender, EventArgs e)
        {
   
        }

        private void panelOneSubmit_Click(object sender, EventArgs e)
        {
            var panelOneInputOne = this.panelOneInputOne.Text;
            var panelOneInputTwo = this.panelOneInputTwo.Text;

            //parent
            var parent = this.Parent as Form1;
            parent.panelOneInpOne = panelOneInputOne;
            parent.panelOneInpTwo = panelOneInputTwo;
        }
    }
}
