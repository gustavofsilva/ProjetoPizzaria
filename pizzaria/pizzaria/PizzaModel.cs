using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pizzaria
{
    class PizzaModel
    {
        //string conn = @"Server = PICHAU; Database = pizzaria; Trusted_Connection = True;";
        internal void adicionarPizza(Pizza pizza)
        {
            //definição da string de conexão
            SqlConnection conn = new SqlConnection(@"");
            
            //definição do comando sql
            string sql = "INSERT INTO pedido(nome, endereco, telefone, pedido, observacao, preco, data) VALUES(@nome, @endereco, @telefone, @pedido, @observacao, @preco, @data)";


            try
            {
                    //Cria uma objeto do tipo comando passando como parametro a string sql e a string de conexão
                    SqlCommand comando = new SqlCommand(sql, conn);
                    //Adicionando o valor das textBox nos parametros do comando
                    comando.Parameters.Add(new SqlParameter("@nome", pizza.nome));
                    comando.Parameters.Add(new SqlParameter("@endereco", pizza.endereco));
                    comando.Parameters.Add(new SqlParameter("@telefone", pizza.telefone));
                    comando.Parameters.Add(new SqlParameter("@pedido", pizza.pedido));
                    comando.Parameters.Add(new SqlParameter("@observacao", pizza.obs));
                    comando.Parameters.Add(new SqlParameter("@preco", pizza.preco));
                    comando.Parameters.Add(new SqlParameter("@data", pizza.data));
                    //abre a conexao
                    conn.Open();
                    //executa o comando com os parametros que foram adicionados acima
                    comando.ExecuteNonQuery();
                    //fecha a conexao
                    conn.Close();
            }
            catch
            {
             
            }
            finally
            {
            conn.Close();
            }
        }

        internal void DeletaPedidoEntregue(int id)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(@""))
                {
                    con.Open();
                    using (SqlCommand command = new SqlCommand("DELETE FROM pedidoEntregue where id=@id", con))
                    {
                        command.Parameters.Add(new SqlParameter("@id", id));
                        command.ExecuteNonQuery();
                    }
                    con.Close();
                }
            }
            catch (SystemException ex)
            {

            }
        }

        internal DataTable selectTodosEntregues()
        {
            string conn = @"";
            using (SqlConnection sqlCon = new SqlConnection(conn))
            {
                sqlCon.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT * FROM pedidoEntregue order by data", sqlCon);
                DataTable dtable = new DataTable();
                sqlDa.Fill(dtable);
                return dtable;

            }
        }

        internal void DeletaPedido(int id)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(@""))
                {
                    con.Open();
                    using (SqlCommand command = new SqlCommand("DELETE FROM pedido where id=@id", con))
                    {
                        command.Parameters.Add(new SqlParameter("@id", id));
                        command.ExecuteNonQuery();
                    }
                    con.Close();
                }
            }
            catch (SystemException ex)
            {
                
            }
        }
    

        internal void adicionarPizzaEntregue(Pizza pizza)
        {
            
            SqlConnection conn = new SqlConnection(@"");
            string sql = "INSERT INTO pedidoEntregue (nome, endereco, telefone, pedido, observacao, preco, data) VALUES(@nome, @endereco, @telefone, @pedido, @observacao, @preco, @data)";

            try
            {
                //Cria uma objeto do tipo comando passando como parametro a string sql e a string de conexão
                SqlCommand comando = new SqlCommand(sql, conn);
                //Adicionando o valor das textBox nos parametros do comando
                comando.Parameters.Add(new SqlParameter("@nome", pizza.nome));
                comando.Parameters.Add(new SqlParameter("@endereco", pizza.endereco));
                comando.Parameters.Add(new SqlParameter("@telefone", pizza.telefone));
                comando.Parameters.Add(new SqlParameter("@pedido", pizza.pedido));
                comando.Parameters.Add(new SqlParameter("@observacao", pizza.obs));
                comando.Parameters.Add(new SqlParameter("@preco", pizza.preco));
                comando.Parameters.Add(new SqlParameter("@data", pizza.data));
                //abre a conexao
                conn.Open();
                //executa o comando com os parametros que foram adicionados acima
                comando.ExecuteNonQuery();
                //fecha a conexao
                conn.Close();
            }
            catch
            {

            }
            finally
            {
                conn.Close();
            }
        }



        internal Pizza SelectUm(int index)
        {
            Pizza pizza = new Pizza();
            SqlConnection conn = new SqlConnection(@"");//@"Server = PICHAU; Database = pizzaria; Trusted_Connection = True;"
            conn.Open();
            SqlCommand command = new SqlCommand("Select * from pedido where id=@id", conn);            
            command.Parameters.AddWithValue("@id", index);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                pizza.id = Convert.ToInt32(reader["id"].ToString());
                pizza.nome = reader["nome"].ToString();
                pizza.pedido = reader["pedido"].ToString();
                pizza.endereco = reader["endereco"].ToString();
                pizza.telefone = reader["telefone"].ToString();
                pizza.obs = reader["observacao"].ToString();
                pizza.preco = Convert.ToDouble(reader["preco"].ToString());
                pizza.data = Convert.ToDateTime(reader["data"].ToString());
            }
            return pizza;
        }

        internal void AtualizaEntregue(int linha, int coluna)
        {
            
            //definição da string de conexão
            SqlConnection conn = new SqlConnection(@"");

            //definição do comando sql
            string sql = "UPDATE pedido(entregue) VALUES(@entregue) WHERE id = (@id)";


            try
            {
                //Cria uma objeto do tipo comando passando como parametro a string sql e a string de conexão
                SqlCommand comando = new SqlCommand(sql, conn);
                //Adicionando o valor das textBox nos parametros do comando
                comando.Parameters.Add(new SqlParameter("@entregue", "0"));
                comando.Parameters.Add(new SqlParameter("@id", linha));
                //abre a conexao
                conn.Open();
                //executa o comando com os parametros que foram adicionados acima
                comando.ExecuteNonQuery();
                //fecha a conexao
                conn.Close();
            }
            catch
            {

            }
            finally
            {
                conn.Close();
            }
        }

        internal DataTable selectTodos()
        {
            string conn = @"";
            using (SqlConnection sqlCon = new SqlConnection(conn))
            {
                sqlCon.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT * FROM pedido order by data", sqlCon);
                DataTable dtable = new DataTable();
                sqlDa.Fill(dtable);
                return dtable;
                
            }
        }
    }
}
