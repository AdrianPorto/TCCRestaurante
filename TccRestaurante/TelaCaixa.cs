using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TccRestaurante { 


    public partial class Caixa : Form
    {


    public static Double Resultado = 0;

        public Caixa()
        {
            InitializeComponent();
        }

        private MySqlConnection Conexao;
        private string data_source = "Server = localhost; Database=restaurantetcc;Uid=root;Pwd=";

        private void Form1_Load(object sender, EventArgs e)
        {

        }

      



        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //new TelaGerarRelatorioVenda().Show();
            //this.Hide();
            TelaGerarRelatorioVenda telaGerarRelatorioVenda = new TelaGerarRelatorioVenda();
            telaGerarRelatorioVenda.ShowDialog();
        }

        private void txtCodigoFuncionario_Leave(object sender, EventArgs e)
        {
            try
            {
                string codigo = txtCodigoFuncionario.Text;

                Conexao = new MySqlConnection(data_source);

                string sql = "SELECT * " +
                            "FROM funcionario " +
                            "WHERE id=" + codigo;

                Conexao.Open();

                MySqlCommand comando = new MySqlCommand(sql, Conexao);
                
                MySqlDataReader reader = comando.ExecuteReader();

                if (reader.Read())
                {
                    txtDescricaoFuncionario.Text = reader.GetString(1);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Conexao.Close();
            }
        }

        private void txtProduto1_Leave(object sender, EventArgs e)
        {
            try
            {
                string codigo = txtProduto1.Text;

                Conexao = new MySqlConnection(data_source);

                string sql = "SELECT * " +
                            "FROM produto " +
                            "WHERE id=" + codigo;

                Conexao.Open();

                MySqlCommand comando = new MySqlCommand(sql, Conexao);

                MySqlDataReader reader = comando.ExecuteReader();

                if (reader.Read())
                {
                    txtDesc1.Text = reader.GetString(1);
                    txtValor1.Text = reader.GetString(3);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Conexao.Close();
            }
        }

        private void txtProduto2_Leave(object sender, EventArgs e)
        {
            try
            {
                string codigo = txtProduto2.Text;

                Conexao = new MySqlConnection(data_source);

                string sql = "SELECT * " +
                            "FROM produto " +
                            "WHERE id=" + codigo;

                Conexao.Open();

                MySqlCommand comando = new MySqlCommand(sql, Conexao);

                MySqlDataReader reader = comando.ExecuteReader();

                if (reader.Read())
                {
                    txtDesc2.Text = reader.GetString(1);
                    txtValor2.Text = reader.GetString(3);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Conexao.Close();
            }
        }

        private void txtProduto3_Leave(object sender, EventArgs e)
        {
            try
            {
                string codigo = txtProduto3.Text;

                Conexao = new MySqlConnection(data_source);

                string sql = "SELECT * " +
                            "FROM produto " +
                            "WHERE id=" + codigo;

                Conexao.Open();

                MySqlCommand comando = new MySqlCommand(sql, Conexao);

                MySqlDataReader reader = comando.ExecuteReader();

                if (reader.Read())
                {
                    txtDesc3.Text = reader.GetString(1);
                    txtValor3.Text = reader.GetString(3);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Conexao.Close();
            }
        }

        private void txtProduto4_Leave(object sender, EventArgs e)
        {
            try
            {
                string codigo = txtProduto4.Text;

                Conexao = new MySqlConnection(data_source);

                string sql = "SELECT * " +
                            "FROM produto " +
                            "WHERE id=" + codigo;

                Conexao.Open();

                MySqlCommand comando = new MySqlCommand(sql, Conexao);

                MySqlDataReader reader = comando.ExecuteReader();

                if (reader.Read())
                {
                    txtDesc4.Text = reader.GetString(1);
                    txtValor4.Text = reader.GetString(3);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Conexao.Close();
            }
        }

        private void txtProduto5_Leave(object sender, EventArgs e)
        {
            try
            {
                string codigo = txtProduto5.Text;

                Conexao = new MySqlConnection(data_source);

                string sql = "SELECT * " +
                            "FROM produto " +
                            "WHERE id=" + codigo;

                Conexao.Open();

                MySqlCommand comando = new MySqlCommand(sql, Conexao);

                MySqlDataReader reader = comando.ExecuteReader();

                if (reader.Read())
                {
                    txtDesc5.Text = reader.GetString(1);
                    txtValor5.Text = reader.GetString(3);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Conexao.Close();
            }
        }

        private void txtProduto6_Leave(object sender, EventArgs e)
        {
            try
            {
                string codigo = txtProduto6.Text;

                Conexao = new MySqlConnection(data_source);

                string sql = "SELECT * " +
                            "FROM produto " +
                            "WHERE id=" + codigo;

                Conexao.Open();

                MySqlCommand comando = new MySqlCommand(sql, Conexao);

                MySqlDataReader reader = comando.ExecuteReader();

                if (reader.Read())
                {
                    txtDesc6.Text = reader.GetString(1);
                    txtValor6.Text = reader.GetString(3);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Conexao.Close();
            }
        }

        private void txtProduto7_Leave(object sender, EventArgs e)
        {
            try
            {
                string codigo = txtProduto7.Text;

                Conexao = new MySqlConnection(data_source);

                string sql = "SELECT * " +
                            "FROM produto " +
                            "WHERE id=" + codigo;

                Conexao.Open();

                MySqlCommand comando = new MySqlCommand(sql, Conexao);

                MySqlDataReader reader = comando.ExecuteReader();

                if (reader.Read())
                {
                    txtDesc7.Text = reader.GetString(1);
                    txtValor7.Text = reader.GetString(3);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Conexao.Close();
            }
        }

        private void txtQtTotal_TextChanged(object sender, EventArgs e)

        {
     
            txtQtTotal.Text = Resultado.ToString();
        }

        private void txtValor1_TextChanged(object sender, EventArgs e)
        {
          
            if (txtQt1.Text != null)
            {
                Double resultado = Convert.ToDouble(txtValor1.Text);
                Double multiplicador = Convert.ToDouble(txtQt1.Text);
                Resultado += resultado * multiplicador;
            }
         }

        private void txtValor2_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtValor3_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        public void Remove1(object sender, EventArgs e)
        {
         

        }
        public void Remove2(object sender, EventArgs e)
        {
           
        }
        public void Remove3(object sender, EventArgs e)
        {
        
        }
        public void Remove4(object sender, EventArgs e)
        {
     
        }
        public void Remove5(object sender, EventArgs e)
        {
       
        }
     

        public void Remove7(object sender, EventArgs e)
        {

        }


        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void txtDesc1_TextChanged(object sender, EventArgs e)
        {
            if(txtDesc1.Text != null)
            {
                Remove.Visible = true;
            } 
        }

        private void txtDesc2_TextChanged(object sender, EventArgs e)
        {
            if (txtDesc2.Text != null)
            {
                RemoveTwo.Visible = true;
            }
        }

        private void txtDesc3_TextChanged(object sender, EventArgs e)
        {
            if (txtDesc3.Text != null)
            {
                RemoveThree.Visible = true;
            }
        }

        private void txtDesc4_TextChanged(object sender, EventArgs e)
        {
            if (txtDesc4.Text != null)
            {
                RemoveFour.Visible = true;
            }
        }

        private void txtDesc5_TextChanged(object sender, EventArgs e)
        {
            if (txtDesc5.Text != null)
            {
                RemoveFive.Visible = true;
            }
        }
        private void txtDesc6_TextChanged_1(object sender, EventArgs e)
        {
            if (txtDesc6.Text != null)
            {
                RemoveSix.Visible = true;
            }
        }
       
        private void txtDesc7_TextChanged(object sender, EventArgs e)
        {
            if (txtDesc7.Text != null)
            {
                RemoveSeven.Visible = true;
            }
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

    

          private void txtProduto1_TextChanged(object sender, EventArgs e)
        {

        }
        private void txtProduto2_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtProduto3_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtProduto4_TextChanged(object sender, EventArgs e)
        {

        }
        private void txtProduto5_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtProduto6_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtProduto7_TextChanged(object sender, EventArgs e)
        {

        }
        private void Remove_click(object sender, EventArgs e)
        {
            txtProduto1.Clear();
            txtDesc1.Clear();
            txtValor1.Clear();
            txtQt1.Clear();
            Remove.Visible = false;
        }
        private void RemoveTwo_Click(object sender, EventArgs e)
        {
            txtProduto2.Clear();
            txtDesc2.Clear();
            txtValor2.Clear();
            txtQt2.Clear();
            RemoveTwo.Visible = false;
        }
        private void RemoveThree_Click(object sender, EventArgs e)
        {
            txtProduto3.Clear();
            txtDesc3.Clear();
            txtValor3.Clear();
            txtQt3.Clear();
            RemoveThree.Visible = false;
        }
        private void RemoveFour_Click(object sender, EventArgs e)
        {
            txtProduto4.Clear();
            txtDesc4.Clear();
            txtValor4.Clear();
            txtQt4.Clear();
            RemoveFour.Visible = false;
        }
        private void RemoveFive_Click(object sender, EventArgs e)
        {
            txtProduto5.Clear();
            txtDesc5.Clear();
            txtValor5.Clear();
            txtQt5.Clear();
            RemoveFive.Visible = false;
        }

        private void RemoveSix_Click(object sender, EventArgs e)
        {
            txtProduto6.Clear();
            txtDesc6.Clear();
            txtValor6.Clear();
            txtQt6.Clear();
            RemoveSix.Visible = false;
        }

        private void RemoveSeven_Click(object sender, EventArgs e)
        {
            txtProduto7.Clear();
            txtDesc7.Clear();
            txtValor7.Clear();
            txtQt7.Clear();
            RemoveSeven.Visible = false;
        }

        private void txtValor4_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtValor5_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtValor6_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtValor7_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtQt1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtQt2_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtQt3_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtQt4_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtQt5_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtQt6_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtQt7_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
