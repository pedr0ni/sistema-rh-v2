using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_de_Controle_RH
{
    public partial class MainForm : Form
    {

        private List<TextBox> todosTXT = new List<TextBox>();

        public MainForm()
        {
            InitializeComponent();

            this.MaximizeBox = false; // Desativa o botão de maximizar
            this.FormBorderStyle = FormBorderStyle.FixedSingle; // Desativa o resize da borda

            foreach (Control ctrls in panel_txt.Controls)
            {
                if (!(ctrls is TextBox)) continue; // Adiciona apenas os Controles do tipo TextBox

                TextBox txt = (TextBox)ctrls;
                todosTXT.Add(txt); // Adiciona na lista
            }

            this.cmb_setor.SelectedIndex = 0;
        }

        private void btn_sair_Click(object sender, EventArgs e)
        {
            Application.Exit(); // Finaliza a aplicação
        }

        private void btn_limpar_Click(object sender, EventArgs e)
        {
            lb_funcionarios.Items.Clear(); // Limpa a ListBox

            cmb_setor.SelectedIndex = 0; // Seta o item selecionado para 0
            foreach (TextBox txt in this.todosTXT)
            {
                txt.Clear(); // Limpa todas as TextBox na lista
            }
        }

        private void btn_cadastrar_Click(object sender, EventArgs e)
        {
            if (cmb_setor.SelectedIndex == 0)
            {
                MessageBox.Show("Escolha um Setor!", "SistemaRH 2.0", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            lb_funcionarios.Items.Add("Funcionário: " + txt_funcionario.Text + '\t' + "Setor: " + cmb_setor.Text);
            lb_funcionarios.Items.Add(gerarLinhas(136, "-"));
            
        }

        /*
         * @return string
         * 
         * @param int tamanho 
         * @param string caracter
         * 
         */ 
        private string gerarLinhas(int tamanho, string caracter)
        {
            string res = "";
            for (int i = 0; i < tamanho; i++)
            {
                res += caracter;
            }

            return res;
        }
    }
}
