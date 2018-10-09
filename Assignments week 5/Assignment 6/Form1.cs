using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_6
{
    public partial class Form1 : Form
    {
        StringBuilder builder = new StringBuilder();
        Random rnd = new Random();

        int[] tblBefore = new int[20];
        int[] tblAfter = new int[20];

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 20; i++)
            {
                tblBefore[i] = rnd.Next(500);
                builder.AppendLine(String.Format("Element {0:D2} = {1}", i, tblBefore[i]));
            }

            ctbLbl.Text = builder.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int compare = int.Parse(cnrTxt.Text);

            builder = new StringBuilder();

            for (int i = 0; i < 20; i++)
            {
                int oldValue = tblBefore[i];

                if (oldValue >= compare)
                {
                    tblAfter[i] = oldValue + 10;
                }
                else
                {
                    tblAfter[i] = oldValue - 5;
                }

                builder.AppendLine(String.Format("Element {0:D2} = {1}",
                    i, tblAfter[i]));
            }

            ctaLbl.Text = builder.ToString();
        }

        private void ctbLbl_Click(object sender, EventArgs e)
        {

        }
        
    }
}
