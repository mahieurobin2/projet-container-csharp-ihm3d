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
    public partial class IHM3D : Form
    {
        public IHM3D()
        {
            InitializeComponent();
            Button monBouton = new Button();
            monBouton.Text = "Menu 1";
            monBouton.Height = 30;
            monBouton.Width = 100;
            monBouton.Left = 10;
            monBouton.Top = 10;
            monBouton.BackColor = Color.Pink;
            monBouton.Click += new EventHandler(button1_Click);
            this.Controls.Add(monBouton);

            int nbligne = 5;
            int nbcolonne = 4;
            int nbetage = 3;
            Button[, ,] btn = new Button[nbligne, nbcolonne, nbetage];
            for (int x = 0; x < nbligne; x++)
            {
                for (int y = 0; y < nbcolonne; y++)
                {
                    for (int z = nbetage - 1; z >= 0; z--)
                    {
                        btn[x, y, z] = new Button();
                        btn[x, y, z].Text = "BIC: " + (x + 1).ToString() + (y + 1).ToString() + (z + 1).ToString();
                        btn[x, y, z].TextAlign = ContentAlignment.TopLeft;
                        btn[x, y, z].Height = 50;
                        if (z > 1) { btn[x, y, z].Width = 50; }
                        else { btn[x, y, z].Width = 100; }
                        btn[x, y, z].Click += new EventHandler(button1_Click);
                        btn[x, y, z].Left = y * 150 + z * 20;
                        btn[x, y, z].Top = 50 + x * 100 + z * 20;
                        this.Controls.Add(btn[x, y, z]);
                    }
                }
            }


        }
        private void button1_Click(object sender, EventArgs e)
        {
            Button bouton = (Button)sender;
            bouton.Text = "Container \n" + bouton.Text;
            bouton.BackColor = Color.Red;
            MessageBox.Show("Position: " + bouton.Text + "\nDATE:");
        }
    }
}
