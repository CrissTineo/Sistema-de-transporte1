using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capa_presentacion_buses
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void bunifuMetroTextbox1_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

       

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbhora.Text = DateTime.Now.ToShortTimeString();
            lbfecha.Text = DateTime.Now.ToString("d"); 
        }

        private void lbfecha_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            Inf_Choferes ventana = new Inf_Choferes();
            ventana.Show();
            this. Hide();
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            Autobuses ventana = new Autobuses();
            ventana.Show();
            this.Hide();
        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            Rutascs ventana = new Rutascs();
            ventana.Show();
            this.Hide();
        }

        private void txserch_Enter(object sender, EventArgs e)
        {
            if (txserch.Text == "Serch")
            {
                txserch.Text = "";

            }
        }
    }
}
