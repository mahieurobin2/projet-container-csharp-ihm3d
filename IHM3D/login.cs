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
    public partial class login : Form
    {
        public ArrayList laPersonne;
        private BDD bdd;
        public login()
        {
            InitializeComponent();
            bdd = new BDD();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String login = this.textBox1.Text;
            String password = this.textBox2.Text;
            bool list = false;
            list = bdd.login(login,password);
            if(list)
            {
                Form Menu = new Menu();
                Menu.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Erreur de Login ou Mot de passe");
            }
        }
    }
}
