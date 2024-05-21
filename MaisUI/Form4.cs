using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static MaisUI.ClassMethods;

namespace MaisUI
{
    public partial class Form4 : Form
    {

        public Form4()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ToggleMinimize(this);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ExitApp();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            LogOutFunction();
        }
    }
}
