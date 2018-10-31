using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        int VotoCiro = 0,
            VotoHadadd = 0,
            VotoBolsonaro = 0,
            VotoMarina = 0,
            VotoBoulos = 0,
            VotoAlckmin = 0,
            VotoNulo = 0,
            VotoBranco = 0;









        public Form1()
        {
            InitializeComponent();
            textBox1.MaxLength = 2;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void botao1_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "1";
            
        }

        private void botao2_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "2";
        }

        private void botao3_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "3";
        }

        private void botao4_Click(object sender, EventArgs e)
        {

            textBox1.Text = textBox1.Text + "4";

        }

        private void botao5_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "5";
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            switch (textBox1.Text)
            {

                case "12": pictureBox2.Image; break;
                case "13": VotoHadadd++; break;
                case "17": VotoBolsonaro++; break;
                case "45": VotoAlckmin++; break;
                case "50": VotoBoulos++; break;

            }

        }

        private void botao6_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "6";
        }

        private void botao7_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "7";
        }

        private void botao8_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "8";
        }

        private void botao9_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "9";
        }

        private void botao0_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "0";
        }

        private void btnBranco_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "XX";
        }


        public void BtnConfirma_Click(object sender, EventArgs e)
        {
            switch (textBox1.Text)
            {

                case "12": VotoCiro++; break;
                case "13": VotoHadadd++; break;
                case "17": VotoBolsonaro++; break;
                case "45": VotoAlckmin++; break;
                case "50": VotoBoulos++; break;

            }

            }
        }

        

        
        }

        

        
        
    


