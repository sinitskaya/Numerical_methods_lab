using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ЧМ_Краевая_задача
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void тестоваяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            основная тестовая = new основная();
            тестовая.ShowDialog();          
        }

        private void основная1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            тестовая_1 основная_1 = new тестовая_1();
            основная_1.ShowDialog();
        }

        private void основная2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            тестовая_2 основная_2 = new тестовая_2();
            основная_2.ShowDialog();
        }

    }
}
