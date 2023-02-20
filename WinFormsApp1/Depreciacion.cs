using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Depreciacion : Form
    {
        public Depreciacion()
        {
            InitializeComponent();
        }

        private void Depreciacion_Load(object sender, EventArgs e)
        {
            TXBresultado.Enabled = false;
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (treeView1.SelectedNode.Text.Equals("Vehiculo"))
            {
                label5.Text = "Vehiculo ";
            }
            else if (treeView1.SelectedNode.Text.Equals("Edificio"))
            {
                label5.Text = "Edificio";
            }
            else if (treeView1.SelectedNode.Text.Equals("E.de mobiliario")) 
            {
                label5.Text = "E.de mobiliario";
            }
        }

        private void BTNlimpiar_Click(object sender, EventArgs e)
        {
            MASKEDvalor.Text = "";
            TXBresultado.Text = "";
            label5.Text = "NINGUNA";
        }

        private void BTNsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BTNcalcular_Click(object sender, EventArgs e)
        {
            if (MASKEDvalor.Text == "") 
            {
                MessageBox.Show("INGRESE UN VALOR");
            }
            else if (treeView1.SelectedNode.Text.Equals("Vehiculo"))
            {
                double val = Convert.ToDouble(MASKEDvalor.Text);
               if(val >= 5000 && val <= 250000) 
               {
                    double tot;

                    tot = val * 5;
                    TXBresultado.Text = tot.ToString();
               }
               else 
               {
                    MessageBox.Show("El valor no puede ser menor a 5000 o menor a 250000"); 
               }
            }
            else if (treeView1.SelectedNode.Text.Equals("Edificio"))
            {
                double val = Convert.ToDouble(MASKEDvalor.Text);
                if (val >= 10000 && val <= 3000000)
                {

                    double tot;

                    tot = val * 20;
                    TXBresultado.Text = tot.ToString();
                }
                else
                {
                    MessageBox.Show("El valor no puede ser menor a 10000 o menor a 3000000");
                }
            }
            else if (treeView1.SelectedNode.Text.Equals("Vehiculo"))
            {
                double val = Convert.ToDouble(MASKEDvalor.Text);
                if (val >= 20 && val <= 10000)
                {
                    double tot;

                    tot = val * 2;
                    TXBresultado.Text = tot.ToString();
                }
                else
                {
                    MessageBox.Show("El valor no puede ser menor a 20 o menor a 10000");
                }
            }
            else 
            {
                MessageBox.Show("INGRESE UNA DEPRECIACION");
            }




        }
    }
}
