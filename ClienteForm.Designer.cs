
namespace ControleClientes
{
    partial class ClienteForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tabCliente = new TabControl();
            tpClienteConsulta = new TabPage();
            gridCliente = new DataGridView();
            colId = new DataGridViewTextBoxColumn();
            colNome = new DataGridViewTextBoxColumn();
            colEmail = new DataGridViewTextBoxColumn();
            pnlPesquisa = new Panel();
            btnPesquisar = new Button();
            txtPesquisa = new TextBox();
            pnlAcao = new Panel();
            btnVisualizar = new Button();
            btnNovo = new Button();
            tpClienteCadastro = new TabPage();
            cmbGenero = new ComboBox();
            lblGenero = new Label();
            cmbEstadoCivil = new ComboBox();
            lblEstadoCivil = new Label();
            txtEmail = new TextBox();
            label2 = new Label();
            txtNome = new TextBox();
            label1 = new Label();
            pnlAcaoCadastro = new Panel();
            btnExcluir = new Button();
            btnCancelar = new Button();
            btnSalvar = new Button();
            tabCliente.SuspendLayout();
            tpClienteConsulta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridCliente).BeginInit();
            pnlPesquisa.SuspendLayout();
            pnlAcao.SuspendLayout();
            tpClienteCadastro.SuspendLayout();
            pnlAcaoCadastro.SuspendLayout();
            SuspendLayout();
            // 
            // tabCliente
            // 
            tabCliente.Controls.Add(tpClienteConsulta);
            tabCliente.Controls.Add(tpClienteCadastro);
            tabCliente.Dock = DockStyle.Fill;
            tabCliente.Location = new Point(0, 0);
            tabCliente.Margin = new Padding(3, 4, 3, 4);
            tabCliente.Name = "tabCliente";
            tabCliente.SelectedIndex = 0;
            tabCliente.Size = new Size(762, 383);
            tabCliente.TabIndex = 0;
            // 
            // tpClienteConsulta
            // 
            tpClienteConsulta.Controls.Add(gridCliente);
            tpClienteConsulta.Controls.Add(pnlPesquisa);
            tpClienteConsulta.Controls.Add(pnlAcao);
            tpClienteConsulta.Location = new Point(4, 29);
            tpClienteConsulta.Margin = new Padding(3, 4, 3, 4);
            tpClienteConsulta.Name = "tpClienteConsulta";
            tpClienteConsulta.Padding = new Padding(3, 4, 3, 4);
            tpClienteConsulta.Size = new Size(754, 350);
            tpClienteConsulta.TabIndex = 0;
            tpClienteConsulta.Text = "Consulta";
            tpClienteConsulta.UseVisualStyleBackColor = true;
            // 
            // gridCliente
            // 
            gridCliente.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            gridCliente.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridCliente.Columns.AddRange(new DataGridViewColumn[] { colId, colNome, colEmail });
            gridCliente.Dock = DockStyle.Fill;
            gridCliente.Location = new Point(3, 45);
            gridCliente.Margin = new Padding(3, 4, 3, 4);
            gridCliente.Name = "gridCliente";
            gridCliente.RowHeadersWidth = 20;
            gridCliente.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            gridCliente.Size = new Size(748, 260);
            gridCliente.TabIndex = 4;
            // 
            // colId
            // 
            colId.HeaderText = "ID";
            colId.MinimumWidth = 6;
            colId.Name = "colId";
            // 
            // colNome
            // 
            colNome.HeaderText = "Nome";
            colNome.MinimumWidth = 6;
            colNome.Name = "colNome";
            // 
            // colEmail
            // 
            colEmail.HeaderText = "E-mail";
            colEmail.MinimumWidth = 6;
            colEmail.Name = "colEmail";
            // 
            // pnlPesquisa
            // 
            pnlPesquisa.Controls.Add(btnPesquisar);
            pnlPesquisa.Controls.Add(txtPesquisa);
            pnlPesquisa.Dock = DockStyle.Top;
            pnlPesquisa.Location = new Point(3, 4);
            pnlPesquisa.Margin = new Padding(3, 4, 3, 4);
            pnlPesquisa.Name = "pnlPesquisa";
            pnlPesquisa.Size = new Size(748, 41);
            pnlPesquisa.TabIndex = 3;
            // 
            // btnPesquisar
            // 
            btnPesquisar.Location = new Point(639, 2);
            btnPesquisar.Margin = new Padding(3, 4, 3, 4);
            btnPesquisar.Name = "btnPesquisar";
            btnPesquisar.Size = new Size(104, 31);
            btnPesquisar.TabIndex = 3;
            btnPesquisar.Text = "Pesquisar";
            btnPesquisar.UseVisualStyleBackColor = true;
            btnPesquisar.Click += btnPesquisar_Click;
            // 
            // txtPesquisa
            // 
            txtPesquisa.Location = new Point(0, 4);
            txtPesquisa.Margin = new Padding(3, 4, 3, 4);
            txtPesquisa.Name = "txtPesquisa";
            txtPesquisa.PlaceholderText = "Pesquisar por nome";
            txtPesquisa.Size = new Size(633, 27);
            txtPesquisa.TabIndex = 2;
            // 
            // pnlAcao
            // 
            pnlAcao.Controls.Add(btnVisualizar);
            pnlAcao.Controls.Add(btnNovo);
            pnlAcao.Dock = DockStyle.Bottom;
            pnlAcao.Location = new Point(3, 305);
            pnlAcao.Margin = new Padding(3, 4, 3, 4);
            pnlAcao.Name = "pnlAcao";
            pnlAcao.Size = new Size(748, 41);
            pnlAcao.TabIndex = 2;
            // 
            // btnVisualizar
            // 
            btnVisualizar.Location = new Point(657, 6);
            btnVisualizar.Margin = new Padding(3, 4, 3, 4);
            btnVisualizar.Name = "btnVisualizar";
            btnVisualizar.Size = new Size(86, 31);
            btnVisualizar.TabIndex = 0;
            btnVisualizar.Text = "Visualizar";
            btnVisualizar.UseVisualStyleBackColor = true;
            btnVisualizar.Click += btnVisualizar_Click;
            // 
            // btnNovo
            // 
            btnNovo.Location = new Point(794, 7);
            btnNovo.Margin = new Padding(3, 4, 3, 4);
            btnNovo.Name = "btnNovo";
            btnNovo.Size = new Size(86, 31);
            btnNovo.TabIndex = 1;
            btnNovo.Text = "Novo";
            btnNovo.UseVisualStyleBackColor = true;
            btnNovo.Click += btnNovo_Click;
            // 
            // tpClienteCadastro
            // 
            tpClienteCadastro.Controls.Add(cmbGenero);
            tpClienteCadastro.Controls.Add(lblGenero);
            tpClienteCadastro.Controls.Add(cmbEstadoCivil);
            tpClienteCadastro.Controls.Add(lblEstadoCivil);
            tpClienteCadastro.Controls.Add(txtEmail);
            tpClienteCadastro.Controls.Add(label2);
            tpClienteCadastro.Controls.Add(txtNome);
            tpClienteCadastro.Controls.Add(label1);
            tpClienteCadastro.Controls.Add(pnlAcaoCadastro);
            tpClienteCadastro.Location = new Point(4, 29);
            tpClienteCadastro.Margin = new Padding(3, 4, 3, 4);
            tpClienteCadastro.Name = "tpClienteCadastro";
            tpClienteCadastro.Padding = new Padding(3, 4, 3, 4);
            tpClienteCadastro.Size = new Size(754, 350);
            tpClienteCadastro.TabIndex = 1;
            tpClienteCadastro.Text = "Cadastro";
            tpClienteCadastro.UseVisualStyleBackColor = true;
            // 
            // cmbGenero
            // 
            cmbGenero.FormattingEnabled = true;
            cmbGenero.Location = new Point(9, 260);
            cmbGenero.Name = "cmbGenero";
            cmbGenero.Size = new Size(350, 28);
            cmbGenero.TabIndex = 8;
            // 
            // lblGenero
            // 
            lblGenero.AutoSize = true;
            lblGenero.Location = new Point(9, 237);
            lblGenero.Name = "lblGenero";
            lblGenero.Size = new Size(57, 20);
            lblGenero.TabIndex = 7;
            lblGenero.Text = "Gênero";
            lblGenero.Click += label3_Click;
            // 
            // cmbEstadoCivil
            // 
            cmbEstadoCivil.FormattingEnabled = true;
            cmbEstadoCivil.Location = new Point(9, 185);
            cmbEstadoCivil.Name = "cmbEstadoCivil";
            cmbEstadoCivil.Size = new Size(350, 28);
            cmbEstadoCivil.TabIndex = 6;
            cmbEstadoCivil.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // lblEstadoCivil
            // 
            lblEstadoCivil.AutoSize = true;
            lblEstadoCivil.Location = new Point(9, 162);
            lblEstadoCivil.Name = "lblEstadoCivil";
            lblEstadoCivil.Size = new Size(86, 20);
            lblEstadoCivil.TabIndex = 5;
            lblEstadoCivil.Text = "Estado Civil";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(9, 113);
            txtEmail.Margin = new Padding(3, 4, 3, 4);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(350, 27);
            txtEmail.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(9, 89);
            label2.Name = "label2";
            label2.Size = new Size(52, 20);
            label2.TabIndex = 2;
            label2.Text = "E-mail";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(9, 37);
            txtNome.Margin = new Padding(3, 4, 3, 4);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(350, 27);
            txtNome.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(9, 13);
            label1.Name = "label1";
            label1.Size = new Size(50, 20);
            label1.TabIndex = 0;
            label1.Text = "Nome";
            // 
            // pnlAcaoCadastro
            // 
            pnlAcaoCadastro.Controls.Add(btnExcluir);
            pnlAcaoCadastro.Controls.Add(btnCancelar);
            pnlAcaoCadastro.Controls.Add(btnSalvar);
            pnlAcaoCadastro.Dock = DockStyle.Bottom;
            pnlAcaoCadastro.Location = new Point(3, 309);
            pnlAcaoCadastro.Margin = new Padding(3, 4, 3, 4);
            pnlAcaoCadastro.Name = "pnlAcaoCadastro";
            pnlAcaoCadastro.Size = new Size(748, 37);
            pnlAcaoCadastro.TabIndex = 4;
            // 
            // btnExcluir
            // 
            btnExcluir.Location = new Point(6, 4);
            btnExcluir.Margin = new Padding(3, 4, 3, 4);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(86, 31);
            btnExcluir.TabIndex = 2;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = true;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(794, 3);
            btnCancelar.Margin = new Padding(3, 4, 3, 4);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(86, 31);
            btnCancelar.TabIndex = 1;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(657, 4);
            btnSalvar.Margin = new Padding(3, 4, 3, 4);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(86, 31);
            btnSalvar.TabIndex = 0;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // ClienteForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(762, 383);
            Controls.Add(tabCliente);
            Margin = new Padding(3, 4, 3, 4);
            Name = "ClienteForm";
            Text = "Cadastro de Clientes";
            tabCliente.ResumeLayout(false);
            tpClienteConsulta.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gridCliente).EndInit();
            pnlPesquisa.ResumeLayout(false);
            pnlPesquisa.PerformLayout();
            pnlAcao.ResumeLayout(false);
            tpClienteCadastro.ResumeLayout(false);
            tpClienteCadastro.PerformLayout();
            pnlAcaoCadastro.ResumeLayout(false);
            ResumeLayout(false);
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private TabControl tabCliente;
        private TabPage tpClienteConsulta;
        private TabPage tpClienteCadastro;
        private Panel pnlAcao;
        private Button btnVisualizar;
        private Button btnNovo;
        private Panel pnlPesquisa;
        private Button btnPesquisar;
        private TextBox txtPesquisa;
        private DataGridView gridCliente;
        private DataGridViewTextBoxColumn colId;
        private DataGridViewTextBoxColumn colNome;
        private DataGridViewTextBoxColumn colEmail;
        private Panel pnlAcaoCadastro;
        private Button btnCancelar;
        private Button btnSalvar;
        private TextBox txtEmail;
        private Label label2;
        private TextBox txtNome;
        private Label label1;
        private Button btnExcluir;
        private ComboBox cmbEstadoCivil;
        private Label lblEstadoCivil;
        private ComboBox cmbGenero;
        private Label lblGenero;
    }
}
