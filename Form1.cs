namespace WinFormsApp2
{
    public partial class Form1 : Form
    {

        Persona persona1 = new Persona();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            persona1.ine = int.Parse(txtIne.Text);
            persona1.nombre = txtNombre.Text;
            persona1.edad = int.Parse(txtEdad.Text);
            persona1.domicilio = txtDomicilio.Text;
            persona1.numTelefono = txtnumTelefono.Text;
            MessageBox.Show("Registro ingresado correctamente");
            persona1.Tienepension();

        }




        public void llenarListView()
        {
            ListViewItem fila = new ListViewItem(persona1.ine.ToString());
            fila.SubItems.Add(persona1.nombre);
            fila.SubItems.Add(persona1.edad.ToString());
            fila.SubItems.Add(persona1.domicilio);
            fila.SubItems.Add(persona1.numTelefono.ToString());

            lbVDatos.Items.Add(fila);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            llenarListView();
        }
    }
}
