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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ToggleMinimize(this);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            ExitApp();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            LogOutFunction();
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }
    }
}