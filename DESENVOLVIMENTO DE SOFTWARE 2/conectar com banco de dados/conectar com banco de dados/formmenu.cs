using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace conectar_com_banco_de_dados
{
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }


        private void formmenu_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bando_de_CadosDataSet.tabalunos' table. You can move, or remove it, as needed.
            this.tabalunosTableAdapter.Fill(this.bando_de_CadosDataSet.tabalunos);

        }

        private void opção1ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void tabalunosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tabalunosBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bando_de_CadosDataSet);

        }
    }
}
