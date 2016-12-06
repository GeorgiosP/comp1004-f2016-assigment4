using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DollarComputers.Models;

namespace DollarComputers
{
    public partial class SelectForm : Form
    {
        private ComputerContext db = new ComputerContext();
        public SelectForm()
        {
            InitializeComponent();
        }

        private void SelectForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cOMP1004DataSet.products' table. You can move, or remove it, as needed.
            this.productsTableAdapter.Fill(this.cOMP1004DataSet.products);

            List<product> ProductList = (from product in db.products
                                         select product).ToList();

            ComputerDataGridView.DataSource = ProductList;

        }
    }
}
