using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace lab_windowsforms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void sortColor()
        {
            Color[] colors = { Color.Red, Color.Blue, Color.Chocolate, Color.DarkMagenta, Color.DeepPink, Color.Ivory, Color.MediumPurple };

            Random sorteio = new Random();

            int indice = sorteio.Next(colors.Length);

            this.BackColor = colors[indice];
        }

        

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
