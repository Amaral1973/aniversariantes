using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppEmpresa
{
    public partial class FormAniversariantes : Form
    {
        public FormAniversariantes()
        {
            InitializeComponent();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormAniversariantes_Load(object sender, EventArgs e)
        {
            Funcionario funcionario = new Funcionario();
            List<Funcionario> func = funcionario.listaaniversariantes();
            dgvAniversariantes.DataSource = func;
        }
    }
}
