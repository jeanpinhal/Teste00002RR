using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Novo_teste_C
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        { int x = 2;
            int y = 3;
            if (x == y)
            MessageBox.Show("2");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int x = 2;
            int y = 3;
            if (x == y)
                MessageBox.Show("1");
        }
    }
}
