using ListaTelefones;
namespace ListaTelefonica
{
    public partial class ListaTelefonica : Form
    {
        private GuardaNumeros guardaNumeros = new GuardaNumeros();

        public ListaTelefonica()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            Lista novoNumero = new Lista();

            novoNumero.Nome = txtNome.Text;
            novoNumero.Numero = txtNumero.Text;

            guardaNumeros.adicionarNumero(novoNumero);
            MessageBox.Show("Número Adicionado com sucesso!!!");

            txtNome.Text = "";
            txtNumero.Text = "";
            
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            listBoxNumeros.Items.Clear();
            foreach (var nums in guardaNumeros.Numeros)
            {
                listBoxNumeros.Items.Add(nums);

            }
        }
    }
}