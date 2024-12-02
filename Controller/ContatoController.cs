using MySql.Data.MySqlClient;
using ProjetoAgenda.Data;
using ProjetoAgenda.VariableGlobal;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAgenda.Controller
{
    internal class ContatoController
    {
        public DataTable GetContatos()
        {
            //Criando uma conexao vazia
            MySqlConnection conexao = null;

            try
            {
                //Criando a conexão usando a ConexaoDB que eu já havia criado
                conexao = ConexaoDB.CriarConexao();

                //Montei o select que retorna todas as categorias
                string sql = $@"select * from tbcontato where usuario = '{UserSession.usuario}@localhost';";

                //Abri a conexão
                conexao.Open();

                //Criei um adaptador
                MySqlDataAdapter adapter = new MySqlDataAdapter(sql, conexao);

                //Criei uma tabela vazia
                DataTable table = new DataTable();

                //Pedindo para o adaptador preencher a tabela
                adapter.Fill(table);

                //Retorno a tabela preenchida 
                return table;
            }
            catch (Exception erro)
            {
                MessageBox.Show($"ERRO AO RECUPERAR CONTATOS: {erro.Message}");
                return new DataTable();
            }
            finally
            {
                conexao.Close();
            }
        }

        public bool AddContato(string contatos, string telefone, string categoria)
        {
            MySqlConnection conexao = null;
            try
            {

                conexao = ConexaoDB.CriarConexao(UserSession.usuario, UserSession.senha);

                //Comando SQL que será executado
                string sql = "INSERT INTO tbContato (nome, telefone, categoria) VALUES (@nome, @telefone, @categoria);";

                //Abri a conexão com o banco
                conexao.Open();

                //Esse cara é o responsavel por executar o comando SQL
                MySqlCommand comando = new MySqlCommand(sql, conexao);

                //Estou trocanco o valor dos @ pelas informações que serão cadastradas
                //Essas informações vieram dos parametros da função
                comando.Parameters.AddWithValue("@nome", contatos);
                comando.Parameters.AddWithValue("@telefone", telefone);
                comando.Parameters.AddWithValue("@categoria", categoria);

                //Executando no banco de dados
                int linhasAfetadas = comando.ExecuteNonQuery();

                conexao.Close();

                if (linhasAfetadas > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show($"Erro ao cadastrar: {erro.Message}", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            finally
            {
                conexao.Close();
            }
        }

        public bool DelContato(int cod_contato)
        {
            MySqlConnection conexao = null;
            try
            {

                conexao = ConexaoDB.CriarConexao();

                //Comando SQL que será executado
                string sql = "delete from tbcontato where cod_contato = @cod_contato;";

                //Abri a conexão com o banco
                conexao.Open();

                //Esse cara é o responsavel por executar o comando SQL
                MySqlCommand comando = new MySqlCommand(sql, conexao);

                //Estou trocanco o valor dos @ pelas informações que serão cadastradas
                //Essas informações vieram dos parametros da função
                comando.Parameters.AddWithValue("@cod_contato", cod_contato);

                //Executando no banco de dados
                int linhasAfetadas = comando.ExecuteNonQuery();

                conexao.Close();

                if (linhasAfetadas > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show($"Erro ao deletar: {erro.Message}", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            finally
            {
                conexao.Close();
            }
        }

        public bool UpdateContato(int cod_contato, string contato, string telefone, string categoria)
        {
            MySqlConnection conexao = null;
            try
            {

                conexao = ConexaoDB.CriarConexao();

                //Comando SQL que será executado
                string sql = "Update tbcontato set nome = @contato, telefone = @telefone, categoria = @categoria where cod_contato = @cod_contato;";

                //Abri a conexão com o banco
                conexao.Open();

                //Esse cara é o responsavel por executar o comando SQL
                MySqlCommand comando = new MySqlCommand(sql, conexao);

                //Estou trocanco o valor dos @ pelas informações que serão cadastradas
                //Essas informações vieram dos parametros da função
                comando.Parameters.AddWithValue("@cod_contato", cod_contato);
                comando.Parameters.AddWithValue("@contato", contato);
                comando.Parameters.AddWithValue("@telefone", telefone);
                comando.Parameters.AddWithValue("@categoria", categoria);

                //Executando no banco de dados
                int linhasAfetadas = comando.ExecuteNonQuery();

                conexao.Close();

                if (linhasAfetadas > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show($"Erro ao alterar: {erro.Message}", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            finally
            {
                conexao.Close();
            }
        }
    }
}

