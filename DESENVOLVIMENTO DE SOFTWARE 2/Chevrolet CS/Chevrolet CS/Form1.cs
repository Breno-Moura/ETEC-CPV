using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chevrolet_CS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tableBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tableBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bandodecadosDataSet1);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bandodecadosDataSet1.Table' table. You can move, or remove it, as needed.
            this.tableTableAdapter.Fill(this.bandodecadosDataSet1.Table);

        }

        private void modeloToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.tableTableAdapter.modelo(this.bandodecadosDataSet1.Table, modeloToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
