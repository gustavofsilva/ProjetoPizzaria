using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pizzaria
{
    class PizzaController
    {
        PizzaModel model = new PizzaModel();
        internal void Adiciona(Pizza pizza)
        {
            model.adicionarPizza(pizza);
        }

        internal DataTable FazGridPedidos()
        {
            return model.selectTodos();
        }

        internal void UpdateCell(int linha, int coluna)
        {
            model.AtualizaEntregue(linha, coluna);
        }

        internal Pizza getData(int index)
        {
            return model.SelectUm(index);
        }

        internal void AdicionaEntregue(Pizza pizza)
        {
            model.adicionarPizzaEntregue(pizza);
        }

        internal void DeletaPedido(int index)
        {
            model.DeletaPedido(index);
        }

        internal DataTable fazGridEntregues()
        {
            return model.selectTodosEntregues();
        }

        internal void DeletaPedidoEntregue(int index)
        {
            model.DeletaPedidoEntregue(index);
        }
    }
}
