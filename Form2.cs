using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace notepad
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Автор программы: " +
                "Maydilsiel (Рамзаев Герман), " +
                "DesConnet," +
                " The.Ertor," +
                " CreeperLifeYT," +
                " Nerok," +
                " TheDanyaWin," +
                " Ivan Movchan (NobootRecord).");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://maydilsiel.7m.pl/maypad");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form newfrm = new Form4();
            newfrm.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Form newfrm = new Form5();
            newfrm.Show();
        }
    }
}
