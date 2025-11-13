using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cadastro_Computadores
{
    public partial class frm_computador : Form
    {
        Computador objComputador = new Computador();

        public frm_computador()
        {
            InitializeComponent();
        }

        //LISTA OS COMPUTADORES NO BANCO AO ABRIR O FORMULÁRIO
        private void frm_computador_Load(object sender, EventArgs e)
        {
            dtg_computadores.DataSource = objComputador.ListarComputador();
        }

        //SALVA O COMPUTADOR NO BANCO
        private void btn_salvar_Click(object sender, EventArgs e)
        {
            objComputador.nome = txt_nome.Text;
            objComputador.memoria = txt_memoria.Text;
            objComputador.discoRigido = txt_discoRigido.Text;
            objComputador.processador = txt_processador.Text;
            objComputador.marca = txt_marca.Text;
            objComputador.placaMae = txt_placaMae.Text;
            objComputador.ano = txt_ano.Text;
            objComputador.status = cbx_status.Text;
            objComputador.tipoDeDefeito = txt_tipoDeDefeito.Text;

            objComputador.cadastrarComputador();
            MessageBox.Show("Computador cadastrado com sucesso");

            txt_nome.Clear();
            txt_processador.Clear();
            txt_placaMae.Clear();
            txt_memoria.Clear();
            txt_discoRigido.Clear();
            txt_marca.Clear();
            txt_ano.Clear();
            cbx_status.SelectedIndex = 0;
            txt_tipoDeDefeito.Clear();

            dtg_computadores.DataSource = objComputador.ListarComputador();
        }

        //LIMPA OS CAMPOS
        private void btn_limpar_Click(object sender, EventArgs e)
        {
            txt_nome.Clear();
            txt_processador.Clear();
            txt_placaMae.Clear();
            txt_memoria.Clear();
            txt_discoRigido.Clear();
            txt_marca.Clear();
            txt_ano.Clear();
            cbx_status.SelectedIndex = 0;
            txt_tipoDeDefeito.Clear();
        }
    }
}
