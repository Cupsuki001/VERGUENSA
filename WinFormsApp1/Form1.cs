namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (treeView1.SelectedNode.Text.Equals("Vehiculo"))
            {
                label5.Text = "Vehiculo ";
            }
            else if (treeView1.SelectedNode.Text.Equals("Vivienda"))
            {
                label5.Text = "Vivienda";
            }
           
        }

        private void BTNlimpiar_Click(object sender, EventArgs e)
        {
            OPCplazo.Text = "";
            OPCtiodebien.Text = "";
            TXBcuota.Text = "";
            MASKEDvalor.Text = "";
        }

        private void BTNsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BTNcalcular_Click(object sender, EventArgs e)
        {
            if(OPCplazo.Text == "" && OPCtiodebien.Text == "") 
            {
                MessageBox.Show("ERROR, Ingrese una opcion");
            }
            else if(TXBcuota.Text == "" && MASKEDvalor.Text == "") 
            {
                MessageBox.Show("Ingrese un valor para calcular");
            }
            else if(treeView1.SelectedNode.Text.Equals("Vehiculo")) 
            {
                double valor = Convert.ToDouble(MASKEDvalor.Text);
                if (valor >= 5000 && valor <= 250000)
                {
                    if (OPCplazo.Text == "48 MESES" || OPCplazo.Text == "60 MESES" || OPCplazo.Text == "72 MESES") 
                    {
                        if (OPCtiodebien.Text == "Nuevo")
                        {

                        }
                        else if (OPCtiodebien.Text == "Usado")
                        {

                        }
                        else
                        {
                            MessageBox.Show("Ingrese el estado del bien");
                            OPCtiodebien.Focus();
                        }
                    }
                    else 
                    {
                        MessageBox.Show("LOS MESES NO PUEDEN PASAR DE LOS 72 *Vea la tabal de PLAZO MESES*");
                        OPCplazo.Text = "";
                        OPCplazo.Focus();
                    }
                    
                    
                }
                else 
                {
                    MessageBox.Show("LOS VALORES TIENE QUE SER ENTRE 5000 o 250000");
                    MASKEDvalor.Text = "";
                    MASKEDvalor.Focus();
                }
            }
            else if (treeView1.SelectedNode.Text.Equals("Vivienda")) 
            {
            
            }
            else 
            {
                MessageBox.Show("INGRESE UN TIPO DE PRESTAMO PARA CONTINUAR");
            }
        }

        private void OPCplazo_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}