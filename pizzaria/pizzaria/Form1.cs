using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pizzaria
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonAddPedido_Click(object sender, EventArgs e)
        {
            //addpedido
            Form2 form2 = new Form2();
            form2.Show();
            
        }

        public void Form1_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'pizzariaDataSet1.pedidoEntregue'. Você pode movê-la ou removê-la conforme necessário.
            tabControl1.Size = new Size (System.Windows.Forms.Screen.PrimaryScreen.Bounds.Width , System.Windows.Forms.Screen.PrimaryScreen.Bounds.Height);
            tabPage1.Text = "Pedidos";
            tabPage2.Text = "Controle";

            this.Text = "Pizzaria";
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView1.ClientSize = new Size(this.Width - 70, this.Height - 270);
            dataGridView2.ClientSize = new Size(this.Width - 70, this.Height - 370);

            DataGridViewButtonColumn botaoImprimir = new DataGridViewButtonColumn();
            DataGridViewButtonColumn botaoEntrega = new DataGridViewButtonColumn();
            DataGridViewButtonColumn botaoDeleta = new DataGridViewButtonColumn();
            DataGridViewButtonColumn botaoDeleta2 = new DataGridViewButtonColumn();

            botaoEntrega.Name = "Entregue";
            botaoImprimir.Name = "Imprimir";
            botaoDeleta.Name = "Deletar";
            botaoDeleta2.Name = "Deletar";

            dataGridView1.Columns.Insert(0, botaoEntrega);
            dataGridView1.Columns.Insert(0, botaoImprimir);


            FazGrid();
            dataGridView1.Columns.Insert(dataGridView1.Columns.Count, botaoDeleta);
            FazGrid();

            FazGrid2();
            dataGridView2.Columns.Insert(dataGridView2.Columns.Count, botaoDeleta2);
            FazGrid2();

        }

        
        public void FazGrid()
        {
            

            PizzaController controller = new PizzaController();
            dataGridView1.DataSource = controller.FazGridPedidos();

            

            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
               
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
            

        }

        public void Button1_Click(object sender, EventArgs e)
        {
            FazGrid();
        }

        

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            PizzaController controller = new PizzaController();
            

            if (e.ColumnIndex == 1 && e.RowIndex != -1)
            {

                Pizza pizza = new Pizza();
                pizza = controller.getData(Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString()));
                //MessageBox.Show(pizza.id.ToString());
                
                controller.AdicionaEntregue(pizza);
                controller.DeletaPedido(Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString()));
                FazGrid();
            }
            //int qtd = dataGridView1.ColumnCount;
            //MessageBox.Show(qtd.ToString());
            if (e.ColumnIndex == 2 && e.RowIndex != -1)
            {
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show("Quer mesmo deletar?", "Deletar", buttons);
                if (result == DialogResult.Yes)
                {
                    controller.DeletaPedido(Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString()));
                    FazGrid();
                }
            }




        }

        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            dataGridView1.ClientSize = new Size(this.Width-70, this.Height-270);
            dataGridView2.ClientSize = new Size(this.Width - 70, this.Height - 370);
        }

        private void tabControl1_Click(object sender, EventArgs e)
        {
            FazGrid2();
        }

        private void FazGrid2()
        {
            PizzaController controller = new PizzaController();        

            
            dataGridView2.DataSource = controller.fazGridEntregues(); 
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            PizzaController controller = new PizzaController();
            if (e.ColumnIndex == 8 && e.RowIndex != dataGridView2.Rows.Count-1 && e.RowIndex != -1)
            {
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show("Quer mesmo deletar?", "Deletar", buttons);
                if (result == DialogResult.Yes)
                {
                    controller.DeletaPedidoEntregue(Convert.ToInt32(dataGridView2.Rows[e.RowIndex].Cells[0].Value.ToString()));
                    FazGrid2();
                }
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            FazGrid();
        }
    }
}
