using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IHM3D
{
    public partial class ajouter : Form
    {
        private BDD bdd;
        public ajouter()
        {
            InitializeComponent();
            bdd = new BDD();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form Menu = new Menu();
            Menu.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
             string dimensions = "";
                string BIC_CODE = "";
                int Zone = 0;
                int X = 0;
                int Y = 0;
                int Z = 0;

                if (radioButton1.Checked)
                {
                    dimensions = radioButton1.Text;
                }

                else if (radioButton2.Checked)
                {
                    dimensions = radioButton2.Text;
                }
                BIC_CODE = this.textBox1.Text;
                X = int.Parse(this.textBox3.Text);
                Y = int.Parse(this.textBox4.Text);
                Z = int.Parse(this.textBox5.Text);
                Zone = int.Parse(this.textBox2.Text);
                {
                    if (Zone >= 0 && Zone <= 9)
                    {
                        if (X >= 0 && X <= 5)
                        {
                            if (Y >= 0 && Y <= 9)
                            {
                                if (Z >= 0 && Z <= 5)
                                {
                                    bdd.ADD_N(dimensions, BIC_CODE);
                                    label11.Text = "le container a ete placé";
                                }
                                else label11.Text = "erreur sur Z";
                            }
                            else label11.Text = "erreur sur Y";
                        }
                        else label11.Text = "erreur sur X";
                    }
                    else label11.Text = "erreur sur Zone";
                }
                
            }

        private void button2_Click(object sender, EventArgs e)
        {
            {
                string Dimension = "";
                string BIC_CODE = "";
                int Zone = 0;
                int X = 0;
                int Y = 0;
                int Z = 0;

                if (radioButton1.Checked)
                {
                    Dimension = radioButton1.Text;
                }

                else if (radioButton2.Checked)
                {
                    Dimension = radioButton2.Text;
                }
                BIC_CODE = this.textBox1.Text;
                X = int.Parse(this.textBox4.Text);
                Y = int.Parse(this.textBox5.Text);
                Z = int.Parse(this.textBox3.Text);
                Zone = int.Parse(this.textBox2.Text);
                {
                    if (Zone >= 0 && Zone <= 9)
                    {
                        if (X >= 0 && X <= 5)
                        {
                            if (Y >= 0 && Y <= 9)
                            {
                                if (Z >= 0 && Z <= 5)
                                {
                                    bdd.ADD_N(Dimension, BIC_CODE);
                                    label11.Text = "le container a ete retiré";
                                }
                                else label11.Text = "erreur sur Z";
                            }
                            else label11.Text = "erreur sur Y";
                        }
                        else label11.Text = "erreur sur X";
                    }
                    else label11.Text = "erreur sur Zone";
                }
            }

        }

        private void ajouter_Load(object sender, EventArgs e)
        {

        }

    }
  }
    
