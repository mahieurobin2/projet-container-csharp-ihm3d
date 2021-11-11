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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form ajouter = new ajouter();
            ajouter.Show();
            this.Hide();

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            bool list = false;
            {
                Form IHM3D = new IHM3D();
                IHM3D.Show();
                this.Hide();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool list = false;
            {
                Form liste = new liste();
                liste.Show();
                this.Hide();
            }

        }
    }
}
