using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ThrowBtn_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int[] dice = new int[6]; // Already defaulted to 0.

            for (int i = 0; i < 6000; i++)
            {
                int thrown = rnd.Next(1, 7);

                dice[thrown - 1]++;
            }

            string text = "";

            for (int i = 0; i < 6; i++)
            {
                text += String.Format("Number of throws of value {0} = {1}\n", i + 1, dice[i]);
            }

            ThrowsLbl.Text = text;
        }
    }
}
