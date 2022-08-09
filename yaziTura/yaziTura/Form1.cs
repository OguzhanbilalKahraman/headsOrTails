using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace yaziTura
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Random random = new Random();
        //string[] guess = {"Yes","No"};// yes= yazi, no= tura

        private void btnGuess_Click(object sender, EventArgs e)
        {
            string[] guess = { "Yes", "No" };// yes= yazi, no= tura
            string gues = "";
            DialogResult result;
            do
            {
                gues = guess[random.Next(0, 2)];
                 result= MessageBox.Show("Yazi mi? Tura mi?\nYazi ise Evet\nTura ise No","Soru",MessageBoxButtons.YesNo,MessageBoxIcon.Question);


            } while (result.ToString() != gues);
            MessageBox.Show("Kazandiniz.");
        }
    }
}
