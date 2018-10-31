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

        private void botao6_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "6";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.TextLength >2)
            {
                textBox1.Text = textBox1.Text.Substring(0, 2);
            }

            
              
            switch (textBox1.Text)
            {
                case "12": pictureBox2.Image = Properties.Resources._12; break;
                case "13": pictureBox2.Image = Properties.Resources._13; break;
                case "17": pictureBox2.Image = Properties.Resources._17; break;
                case "45": pictureBox2.Image = Properties.Resources._45; break;
                case "50": pictureBox2.Image = Properties.Resources._50; break;
                case "18": pictureBox2.Image = Properties.Resources._18; break;
                

            }
        }

        private void btnres_Click(object sender, EventArgs e)
        {
            string  res;

            res = "\n Quantidade de votos: Bolsonaro: " + VotoBolsonaro;
            res += "\n Quantidade de votos: Hadad: " + VotoHadadd;
            res += "\n Quantidade de votos: Marina: " + VotoMarina;
            res += "\n Quantidade de votos: Boulos: " + VotoBoulos;
            res += "\n Quantidade de votos: Geraldo A.: " + VotoAlckmin;
            res += "\n Quantidade de votos: Brancos: " + VotoBranco;
            res += "\n Quantidade de votos: Nulos: " + VotoNulo;

            MessageBox.Show(res);

        }

        private void crgbtn_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
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
            switch (textBox1.Text)
            {

                case "": VotoBranco++; break;
                
            }

            MessageBox.Show("Fim");
            textBox1.Clear();
            pictureBox2.Image = null;

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
                case "18":  VotoMarina++;break;
                default: VotoNulo++; break;
            }

            MessageBox.Show("Fim");
            textBox1.Clear();
            pictureBox2.Image = null; 


        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            

        }
    }

        

        
        }

        

        
        
    


