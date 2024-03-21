using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TareaSprin
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void panelLeft_Paint(object sender, PaintEventArgs e)
        {
            panelLeft = new Panel();
            panelLeft.Dock = DockStyle.Left;
            panelLeft.BackColor = System.Drawing.Color.Green;
            panelLeft.Width = 200;
        }

        private void welcomeLabel_Click(object sender, EventArgs e)
        {
            // Etiqueta de bienvenida
            welcomeLabel = new Label();
            welcomeLabel.Text = "¡Welcome!";
            welcomeLabel.ForeColor = System.Drawing.Color.White;
            welcomeLabel.Location = new System.Drawing.Point(50, 200);
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            // Configuración del formulario
            this.Text = "Sistema de Gestión de Citas";
            this.Size = new System.Drawing.Size(800, 450);
        }

        private void welcomeLabel_Click_1(object sender, EventArgs e)
        {
            welcomeLabel = new Label();
            welcomeLabel.Text = "¡Welcome!";
            welcomeLabel.ForeColor = System.Drawing.Color.White;
            welcomeLabel.Location = new System.Drawing.Point(50, 200);

        }

        private void lineShape1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
