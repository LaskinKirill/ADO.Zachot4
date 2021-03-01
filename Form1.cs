using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;
using CodeFirst;

namespace ADO.Zachot4
{
    public partial class Form1 : Form
    {
        Context context = new Context();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "adventureWorks2017DataSet.SalesOrderHeader". При необходимости она может быть перемещена или удалена.
            this.salesOrderHeaderTableAdapter.Fill(this.adventureWorks2017DataSet.SalesOrderHeader);

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Permitbutton_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == Convert.ToString(1111))
            {
                dataGridView1.ReadOnly = false;
              //  salesOrderHeaderBindingSource.AllowEdit = true;
                try
                {
                    MessageBox.Show("Изменения в базе доступны.");
                    this.Refresh();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
                MessageBox.Show("Введите пароль.");
        }

        private void loadsalesbutton_Click(object sender, EventArgs e)
        {
            dataGridView1.Refresh();
            try
            {
                this.dataGridView1.DataSource = salesOrderHeaderBindingSource;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Newsalesbutton_Click(object sender, EventArgs e)
        {        

            dataGridView1.Refresh();
            context.SaveChanges();
            salesOrderHeaderTableAdapter.Update(adventureWorks2017DataSet);
        }      
   
        
    }
}
