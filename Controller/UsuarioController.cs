using MySql.Data.MySqlClient;
using ProjetoAgenda.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAgenda.Controller
{
    internal class UsuarioController
    {
        public bool AddUsuario(string nome, string usuario, string telefone, string senha)
        {
            try
            {
                //Cria a conexão, estou utilizando a classe ConexaoDB que está dentro da pasta DATA
                MySqlConnection conexao = ConexaoDB.CriarConexao();

                //Comando SQL que será executado
                string sql = @$"CREATE USER '{usuario}'@'%' IDENTIFIED BY '{senha}'; 
                             GRANT SELECT, INSERT, DELETE, UPDATE ON *.* TO '{usuario}'@'%';
                             INSERT INTO tbUsuarios (nome, usuario, telefone, senha) VALUES (@nome, @usuario, @telefone, @senha);";

                //Abri a conexão com o banco
                conexao.Open();

                //Esse cara é o responsavel por executar o comando SQL
                MySqlCommand comando = new MySqlCommand(sql, conexao);

                //Estou trocanco o valor dos @ pelas informações que serão cadastradas
                //Essas informações vieram dos parametros da função
                comando.Parameters.AddWithValue("@nome", nome);
                comando.Parameters.AddWithValue("@usuario", usuario);
                comando.Parameters.AddWithValue("@telefone", telefone);
                comando.Parameters.AddWithValue("@senha", senha);

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
                MessageBox.Show($"Erro ao cadastrar: {erro.Message}","ERRO",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return false;
            }
        }

        public bool ValidarLogin(string usuario, string senha)
        {
            try { 
            MySqlConnection conexao = ConexaoDB.CriarConexao();
            string sql = @"select * from tbusuarios
                           where usuario = @usuario 
                           and binary senha = @senha;";

            conexao.Open();

            MySqlCommand comando = new MySqlCommand(sql, conexao);

            comando.Parameters.AddWithValue("@usuario", usuario);
            comando.Parameters.AddWithValue("@senha", senha);

            MySqlDataReader resultado = comando.ExecuteReader();

            if (resultado.Read())
            {
                conexao.Close();
                return true;
            }
            else
            {
                conexao.Close();
                return false;
            }

            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao verificar usuário.");
                return false;
            }
        }

        public DataTable GetUsuarios()
        {
            //Criando uma conexao vazia
            MySqlConnection conexao = null;

            try
            {
                //Criando a conexão usando a ConexaoDB que eu já havia criado
                conexao = ConexaoDB.CriarConexao();

                //Montei o select que retorna todas as categorias
                string sql = @"select nome, usuario from tbUsuarios;";

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
                MessageBox.Show($"ERRO AO RECUPERAR USUARIO: {erro.Message}");
                return new DataTable();
            }
            finally
            {
                conexao.Close();
            }
        }

        public bool DelUsuario(string usuario)
        {
            MySqlConnection conexao = null;
            try
            {

                conexao = ConexaoDB.CriarConexao();

                //Comando SQL que será executado
                string sql = "delete from tbUsuarios where usuario = (@usuario);";

                //Abri a conexão com o banco
                conexao.Open();

                //Esse cara é o responsavel por executar o comando SQL
                MySqlCommand comando = new MySqlCommand(sql, conexao);

                //Estou trocanco o valor dos @ pelas informações que serão cadastradas
                //Essas informações vieram dos parametros da função
                comando.Parameters.AddWithValue("@usuario", usuario);

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
                MessageBox.Show($"Erro ao excluir usuario: {erro.Message}", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            finally
            {
                conexao.Close();
            }
        }
    }
}
