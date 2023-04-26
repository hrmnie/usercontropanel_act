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
    public partial class panel_two : UserControl
    {
        public panel_two()
        {
            InitializeComponent();
        }

        private void panel_two_Load(object sender, EventArgs e)
        {

        }

        private void panelTwoSubmit_Click(object sender, EventArgs e)
        {

            var panelTwoInputOne = this.panelTwoInputOne.Text;
            var panelTwoInputTwo = this.panelTwoInputTwo.Text;

            //parent

            var parent = this.Parent as Form1;
            parent.panelTwoInpOne = panelTwoInputTwo;
            parent.panelTwoInputTwo = panelTwoInputTwo;
            
        }
    }
}
