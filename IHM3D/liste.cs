using System;
using System.Collections;
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
    public partial class liste : Form
    {
        private BDD bdd;
        ArrayList liste_containers = new ArrayList();
        public liste()
        {
            InitializeComponent();
            bdd = new BDD();
            liste_containers = bdd.Lire_BC();
            for (int i = 0; i < liste_containers.Count; i++)
            {
                this.listBox1.Items.Add(liste_containers[i]);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form Menu = new Menu();
            Menu.Show();
            this.Hide();
        }
    }
}

