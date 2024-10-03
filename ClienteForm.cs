using System.Configuration;

namespace ControleClientes
{
    public partial class ClienteForm : Form
    {
        private ClienteRepository clienteRepository = new ClienteRepository();

        List<ItemEstadoCivil> estadoCivilItens = new List<ItemEstadoCivil>()
        {
            new ItemEstadoCivil() { Valor = EstadoCivil.Solteiro, Descricao = "Solteiro"},
            new ItemEstadoCivil() { Valor = EstadoCivil.Casado, Descricao = "Casado"},
            new ItemEstadoCivil() { Valor = EstadoCivil.Divorciado, Descricao = "Divorciado"},
            new ItemEstadoCivil() { Valor = EstadoCivil.Viuvo, Descricao = "Viuvo"}
        };
        List<ItemGenero> generoItens = new List<ItemGenero>()
        {
            new ItemGenero() { Valor = Genero.Masculino, Descricao = "Masculino" },
            new ItemGenero() { Valor = Genero.Feminino, Descricao = "Feminino" }
        };

        private void LoadComboBoxEstadoCivil()
        {
            cmbEstadoCivil.DataSource = estadoCivilItens;
            cmbEstadoCivil.DisplayMember = "Descrição";
            cmbEstadoCivil.ValueMember = "Valor";
        }
        private void LoadComboBoxGenero()
        {
            cmbGenero.DataSource = estadoCivilItens;
            cmbGenero.DisplayMember = "Descrição";
            cmbGenero.ValueMember = "Valor";
        }

        Cliente clienteSelecionado;
        public ClienteForm()
        {
            InitializeComponent();
            LoadComboBoxEstadoCivil();
            LoadComboBoxGenero();
        }
        private void LoadData()
        {
            gridCliente.Rows.Clear();
            foreach (var cliente in clienteRepository.ReadAll())
            {
                gridCliente.Rows.Add(cliente.Id, cliente.Nome, cliente.Email);
            }
        }
        private void Limpar()
        {
            txtNome.Clear();
            txtEmail.Clear();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            clienteSelecionado = null;
            tabCliente.SelectTab(tpClienteCadastro);
            Limpar();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            ItemEstadoCivil estadoCivil = (ItemEstadoCivil)cmbEstadoCivil.SelectedItem;
            if (clienteSelecionado == null)
            {
                var cliente = new Cliente
                {
                    Nome = txtNome.Text,
                    Email = txtEmail.Text,
                    EstadoCivil = estadoCivil.Valor
                };
                clienteRepository.Create(cliente);
            }
            else
            {
                clienteSelecionado.Nome = txtNome.Text;
                clienteSelecionado.Email = txtEmail.Text;
                clienteSelecionado.EstadoCivil = estadoCivil.Valor;
                clienteRepository.Update(clienteSelecionado);
            }
            LoadData();
            tabCliente.SelectTab(tpClienteConsulta);
        }

        private void btnVisualizar_Click(object sender, EventArgs e)
        {
            if (gridCliente.SelectedRows.Count > 0)
            {
                int id = (int)gridCliente.SelectedRows[0].Cells[0].Value;
                clienteSelecionado = clienteRepository.GetById(id);
                txtNome.Text = clienteSelecionado.Nome;
                txtEmail.Text = clienteSelecionado.Email;
                cmbEstadoCivil.SelectedItem = estadoCivilItens.FirstOrDefault(e => e.Valor == clienteSelecionado.EstadoCivil);
                tabCliente.SelectTab(tpClienteCadastro);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Limpar();
            tabCliente.SelectTab(tpClienteConsulta);
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (clienteSelecionado != null)
            {
                if (MessageBox.Show("Excluir?", "Clientes", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    clienteRepository.Delete(clienteSelecionado);
                    Limpar();
                    LoadData();
                    tabCliente.SelectTab(tpClienteConsulta);
                }

            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
