using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pizzaria
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void buttonAdicionar_Click(object sender, EventArgs e)
        {
            Pizza pizza = new Pizza();
            

            if (textBoxEndereco.Text != "")
            {
                pizza.endereco = textBoxEndereco.Text;
            } else
            {
                pizza.endereco = "Nada!";
            }

            if (textBoxNome.Text != "")
            {
                pizza.nome = textBoxNome.Text;
            } else
            {
                pizza.nome = "Nada!";
            }

            if (textBoxObs.Text != "")
            {
                pizza.obs = textBoxObs.Text;
            } else
            {
                pizza.obs = "Nada!";
            }

            if (textBoxPizza.Text != "")
            {
                pizza.pedido = textBoxPizza.Text;
            } else
            {
                pizza.pedido = "Nada!";
            }

            if (textBoxTelefone.Text != "")
            {
                pizza.telefone = textBoxTelefone.Text;
            } else
            {
                pizza.telefone = "Nada!"; 
            }
            PizzaController controller = new PizzaController();
            pizza.preco = Convert.ToDouble(textBoxPrecoFinal.Text);
            //pizza.preco += Convert.ToDouble(textBoxTaxaEntrega.Text);
            if (checkBoxTroco.Checked == true)
            {
                pizza.pedido = pizza.pedido + " (" + textBoxTroco.Text + ")";
            }
            
            DateTime dataHora = DateTime.Now;
            pizza.data = dataHora;

            controller.Adiciona(pizza);
            Form1 form1 = Application.OpenForms["Form1"] as Form1;
            form1.FazGrid();
            this.Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            this.Text = "Adicionar Pedido";
        }

        private void buttonPizzaDel_Click(object sender, EventArgs e)
        {
            textBoxPizza.Text = "";
            labelQtdPizza.Text = "0";
            textBoxPrecoFinal.Text = "0";
            textBoxTaxaEntrega.Text = "0";
        }

        private void buttonCalabresa_Click(object sender, EventArgs e)
        {
            textBoxPizza.Text = textBoxPizza.Text + " + 1 calabresa ";
            adicionaUm();
            addPrecoFinalInteira();
        }

        private void addPrecoFinalInteira()
        {
            if (textBoxPrecoFinal.Text == "")
            {
                textBoxPrecoFinal.Text = "0";
            }
            textBoxPrecoFinal.Text = (Convert.ToDouble(textBoxPrecoFinal.Text) + 29.90).ToString();
        }
        private void addPrecoFinalMeia()
        {
            if (textBoxPrecoFinal.Text == "")
            {
                textBoxPrecoFinal.Text = "0";
            }
            textBoxPrecoFinal.Text = (Convert.ToDouble(textBoxPrecoFinal.Text) + (29.90/2)).ToString();
        }

        private void adicionaUm()
        {
           labelQtdPizza.Text = (Convert.ToDouble(labelQtdPizza.Text) + 1).ToString();
        }

        private void buttonCalabresaMeia_Click(object sender, EventArgs e)
        {
            textBoxPizza.Text = textBoxPizza.Text + " + 1/2 calabresa ";
            adicionaMeio();
            addPrecoFinalMeia();
        }

        private void adicionaMeio()
        {
            labelQtdPizza.Text = (Convert.ToDouble(labelQtdPizza.Text) + 0.5).ToString();
        }

        private void buttonCalabCremosa_Click(object sender, EventArgs e)
        {
            textBoxPizza.Text = textBoxPizza.Text + " + 1 calabresa cremosa ";
            adicionaUm();
            addPrecoFinalInteira();
        }

        private void buttonCalabCremMeia_Click(object sender, EventArgs e)
        {
            textBoxPizza.Text = textBoxPizza.Text + " + 1/2 calabresa cremosa ";
            adicionaMeio();
            addPrecoFinalMeia();
        }

        private void buttonFrangoCrem_Click(object sender, EventArgs e)
        {
            textBoxPizza.Text = textBoxPizza.Text + " + 1 frango cremoso ";
            adicionaUm();
            addPrecoFinalInteira();
        }

        private void buttonFrangoCremMeia_Click(object sender, EventArgs e)
        {
            textBoxPizza.Text = textBoxPizza.Text + " + 1/2 frango cremoso ";
            adicionaMeio();
            addPrecoFinalMeia();
        }

        private void buttonMarguerita_Click(object sender, EventArgs e)
        {
            textBoxPizza.Text = textBoxPizza.Text + " + 1 marguerita ";
            adicionaUm();
            addPrecoFinalInteira();
        }

        private void buttonMargMeia_Click(object sender, EventArgs e)
        {
            textBoxPizza.Text = textBoxPizza.Text + " + 1/2 marguerita ";
            adicionaMeio();
            addPrecoFinalMeia();
        }

        private void buttonMexicana_Click(object sender, EventArgs e)
        {
            textBoxPizza.Text = textBoxPizza.Text + " + 1 mexicana ";
            adicionaUm();
            addPrecoFinalInteira();
        }

        private void buttonMexicanaMeia_Click(object sender, EventArgs e)
        {
            textBoxPizza.Text = textBoxPizza.Text + " + 1/2 mexicana ";
            adicionaMeio();
            addPrecoFinalMeia();
        }

        private void buttonPaulistana_Click(object sender, EventArgs e)
        {
            textBoxPizza.Text = textBoxPizza.Text + " + 1 paulistana ";
            adicionaUm();
            addPrecoFinalInteira();
        }

        private void buttonPaulistanaMeia_Click(object sender, EventArgs e)
        {
            textBoxPizza.Text = textBoxPizza.Text + " + 1/2 paulistana ";
            adicionaMeio();
            addPrecoFinalMeia();
        }

        private void buttonVegetariana_Click(object sender, EventArgs e)
        {
            textBoxPizza.Text = textBoxPizza.Text + " + 1 vegetariana ";
            adicionaUm();
            addPrecoFinalInteira();
        }

        private void buttonVegetMeia_Click(object sender, EventArgs e)
        {
            textBoxPizza.Text = textBoxPizza.Text + " + 1/2 vegetariana ";
            adicionaMeio();
            addPrecoFinalMeia();
        }

        private void buttonMussa_Click(object sender, EventArgs e)
        {
            textBoxPizza.Text = textBoxPizza.Text + " + 1 mussarela ";
            adicionaUm();
            addPrecoFinalInteira();
        }

        private void buttonMussaMeia_Click(object sender, EventArgs e)
        {
            textBoxPizza.Text = textBoxPizza.Text + " + 1/2 mussarela ";
            adicionaMeio();
            addPrecoFinalMeia();
        }

        private void buttonCanadense_Click(object sender, EventArgs e)
        {
            textBoxPizza.Text = textBoxPizza.Text + " + 1 canadense ";
            adicionaUm();
            addPrecoFinalInteira();
        }

        private void buttonCanadMeia_Click(object sender, EventArgs e)
        {
            textBoxPizza.Text = textBoxPizza.Text + " + 1/2 canadense ";
            adicionaMeio();
            addPrecoFinalMeia();
        }

        private void buttonModa_Click(object sender, EventArgs e)
        {
            textBoxPizza.Text = textBoxPizza.Text + " + 1 moda ";
            adicionaUm();
            addPrecoFinalInteira();
        }

        private void buttonModaMeia_Click(object sender, EventArgs e)
        {
            textBoxPizza.Text = textBoxPizza.Text + " + 1/2 moda ";
            adicionaMeio();
            addPrecoFinalMeia();
        }

        private void buttonPortu_Click(object sender, EventArgs e)
        {
            textBoxPizza.Text = textBoxPizza.Text + " + 1 portuguesa ";
            adicionaUm();
            addPrecoFinalInteira();
        }

        private void buttonPortuMeia_Click(object sender, EventArgs e)
        {
            textBoxPizza.Text = textBoxPizza.Text + " + 1/2 portuguesa ";
            adicionaMeio();
            addPrecoFinalMeia();
        }

        private void buttonBacon_Click(object sender, EventArgs e)
        {
            textBoxPizza.Text = textBoxPizza.Text + " + 1 bacon ";
            adicionaUm();
            addPrecoFinalInteira();
        }

        private void buttonBacon2_Click(object sender, EventArgs e)
        {
            textBoxPizza.Text = textBoxPizza.Text + " + 1/2 bacon ";
            adicionaMeio();
            addPrecoFinalMeia();
        }

        private void buttonFrangoBacon_Click(object sender, EventArgs e)
        {
            textBoxPizza.Text = textBoxPizza.Text + " + 1 frango bacon ";
            adicionaUm();
            addPrecoFinalInteira();
        }

        private void buttonFranBaconMeia_Click(object sender, EventArgs e)
        {
            textBoxPizza.Text = textBoxPizza.Text + " + 1/2 frango bacon ";
            adicionaMeio();
            addPrecoFinalMeia();
        }

        private void buttonCaipira_Click(object sender, EventArgs e)
        {
            textBoxPizza.Text = textBoxPizza.Text + " + 1 caipira ";
            adicionaUm();
            addPrecoFinalInteira();
        }

        private void buttonCaipiraMeia_Click(object sender, EventArgs e)
        {
            textBoxPizza.Text = textBoxPizza.Text + " + 1/2 caipira ";
            adicionaMeio();
            addPrecoFinalMeia();
        }

        private void buttonAmericana_Click(object sender, EventArgs e)
        {
            textBoxPizza.Text = textBoxPizza.Text + " + 1 americana ";
            adicionaUm();
            addPrecoFinalInteira();
        }

        private void buttonAmericanaMeia_Click(object sender, EventArgs e)
        {
            textBoxPizza.Text = textBoxPizza.Text + " + 1/2 americana ";
            adicionaMeio();
            addPrecoFinalMeia();
        }

        private void buttonBrasileira_Click(object sender, EventArgs e)
        {
            textBoxPizza.Text = textBoxPizza.Text + " + 1 brasileira ";
            adicionaUm();
            addPrecoFinalInteira();
        }

        private void buttonBrasMeia_Click(object sender, EventArgs e)
        {
            textBoxPizza.Text = textBoxPizza.Text + " + 1/2 brasileira ";
            adicionaMeio();
            addPrecoFinalMeia();
        }

        private void buttonPernambucana_Click(object sender, EventArgs e)
        {
            textBoxPizza.Text = textBoxPizza.Text + " + 1 pernambucana ";
            adicionaUm();
            addPrecoFinalInteira();
        }

        private void buttonPernambMeia_Click(object sender, EventArgs e)
        {
            textBoxPizza.Text = textBoxPizza.Text + " + 1/2 pernambucana ";
            adicionaMeio();
            addPrecoFinalMeia();
        }

        private void buttonBananaCanela_Click(object sender, EventArgs e)
        {
            textBoxPizza.Text = textBoxPizza.Text + " + 1 banana canela ";
            adicionaUm();
            addPrecoFinalInteira();
        }

        private void buttonBanaCaneMeia_Click(object sender, EventArgs e)
        {
            textBoxPizza.Text = textBoxPizza.Text + " + 1/2 banana canela ";
            adicionaMeio();
            addPrecoFinalMeia();
        }

        private void buttonChocona_Click(object sender, EventArgs e)
        {
            textBoxPizza.Text = textBoxPizza.Text + " + 1 choconana ";
            adicionaUm();
            addPrecoFinalInteira();
        }

        private void buttonChoconaMeia_Click(object sender, EventArgs e)
        {
            textBoxPizza.Text = textBoxPizza.Text + " + 1/2 choconana ";
            adicionaMeio();
            addPrecoFinalMeia();
        }

        private void buttonBanaFlamb_Click(object sender, EventArgs e)
        {
            textBoxPizza.Text = textBoxPizza.Text + " + 1 banana flambada ";
            adicionaUm();
            addPrecoFinalInteira();
        }

        private void buttonBanaFlambMeia_Click(object sender, EventArgs e)
        {
            textBoxPizza.Text = textBoxPizza.Text + " + 1/2 banan flambada ";
            adicionaMeio();
            addPrecoFinalMeia();
        }

        private void buttonPrestigio_Click(object sender, EventArgs e)
        {
            textBoxPizza.Text = textBoxPizza.Text + " + 1 prestigio ";
            adicionaUm();
            addPrecoFinalInteira();
        }

        private void buttonPrestigioMeia_Click(object sender, EventArgs e)
        {
            textBoxPizza.Text = textBoxPizza.Text + " + 1/2 prestigio ";
            adicionaMeio();
            addPrecoFinalMeia();
        }

        private void buttonChocolate_Click(object sender, EventArgs e)
        {
            textBoxPizza.Text = textBoxPizza.Text + " + 1 chocolate ";
            adicionaUm();
            addPrecoFinalInteira();
        }

        private void buttonChocolateMeia_Click(object sender, EventArgs e)
        {
            textBoxPizza.Text = textBoxPizza.Text + " + 1/2 chocolate ";
            adicionaMeio();
            addPrecoFinalMeia();
        }

        

        private void textBoxTaxaEntrega_KeyDown(object sender, KeyEventArgs e)
        {
            

            if (e.KeyValue != '0' && e.KeyValue != '1' && e.KeyValue != '2' && e.KeyValue != '3' && e.KeyValue != '4' && e.KeyValue != '5' && e.KeyValue != '6' && e.KeyValue != '7' && e.KeyValue != '8' && e.KeyValue != '9')
            {
                MessageBox.Show("APENAS NUMEROS PARA A TAXA DE ENTREGA!!");
                textBoxTaxaEntrega.Text = "0";
            }
        }

        /*private void checkBoxRefri_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxRefri.Checked == true)
            {
                textBoxRefri.Visible = true;
                textBoxRefriPreco.Visible = true;
                labelRefriRS.Visible = true;
            }
            if (checkBoxRefri.Checked == false)
            {
                textBoxRefri.Visible = false;
                textBoxRefriPreco.Visible = false;
                labelRefriRS.Visible = false;
            }
        }*/

        private void buttonEntregaMenos_Click(object sender, EventArgs e)
        {
            if (Convert.ToDouble(textBoxTaxaEntrega.Text) > 0)
            {
                textBoxTaxaEntrega.Text = (Convert.ToDouble(textBoxTaxaEntrega.Text) - 0.5).ToString();
                textBoxPrecoFinal.Text = (Convert.ToDouble(textBoxPrecoFinal.Text) - 0.5).ToString();
            }
            
        }

        private void buttonEntregaMais_Click(object sender, EventArgs e)
        {
            textBoxTaxaEntrega.Text = (Convert.ToDouble(textBoxTaxaEntrega.Text) + 0.5).ToString();
            textBoxPrecoFinal.Text = (Convert.ToDouble(textBoxPrecoFinal.Text) + 0.5).ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBoxPizza.Text = textBoxPizza.Text + " + pizza brotinho";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBoxPizza.Text = textBoxPizza.Text + " + " + textBoxRefri.Text;
            textBoxPrecoFinal.Text = (Convert.ToDouble(textBoxPrecoFinal.Text) + Convert.ToDouble(textBoxRefriPreco.Text)).ToString();
        }

        private void checkBoxTroco_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxTroco.Checked == true)
            {
                textBoxTroco.Visible = true;
            } else
            {
                textBoxTroco.Visible = false;
            }
        }
    }
}
