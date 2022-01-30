using AcessoDados.Properties;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcessoDados
{
    public class Asqlbd
    {
        //Criar conexão
        private SqlConnection CriarConexao()
        {
            return new SqlConnection(Settings.Default.StrCon);
        }
        //Parametros que vao ao banco

        private SqlParameterCollection sqlCollection = new SqlCommand().Parameters;
        public void LimparParametros()
        {
            sqlCollection.Clear();
        }
        public void AdicionarParametros(string nomeParametro, object valorParametro)
        {
            sqlCollection.Add(new SqlParameter(nomeParametro, valorParametro));
        }
        //Persistencia C-U-D
        public object ExecutarManipulacao(CommandType command, string nomeProcedureOuTextoSql)
        {
            try
            {
                //Primeiro passo, criar a conexao
                SqlConnection connection = CriarConexao();

                //Abrir conexao
                connection.Open();

                //Criar comando
                SqlCommand comando = connection.CreateCommand();

                //Colocar as coisas dentro de um comando, que ira trafegar na conexao
                comando.CommandType = command; // tipos de comando
                comando.CommandText = nomeProcedureOuTextoSql; // definição se e texto ou procedure
                comando.CommandTimeout = 7200; //tempo representado em sgundos,por default são 30 segundos

                //Adicionar parametros no comando
                foreach (SqlParameter parametros in sqlCollection)
                {
                    comando.Parameters.Add(new SqlParameter(parametros.ParameterName, parametros.Value));
                }

                //Executar o comando e ir ate o banco
                return comando.ExecuteScalar();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        //Consultar registro no banco
        public DataTable ExecutarConsulta(CommandType command, string nomeProcedureOuTextoSql)
        {
            try
            {
                //Criar a conexao
                SqlConnection connection = CriarConexao();

                //Abrir conexao
                connection.Open();

                //Criar comando
                SqlCommand comando = connection.CreateCommand();

                //Colocar dentro do comando as coisas que irão trafegarna conexão
                comando.CommandType = command;
                comando.CommandText = nomeProcedureOuTextoSql;
                comando.CommandTimeout = 7200;

                //Adicionar parametros no comando
                foreach (SqlParameter parametros in sqlCollection)
                {
                    comando.Parameters.Add(new SqlParameter(parametros.ParameterName, parametros.Value));
                }

                //Criar um adaptador
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(comando);

                //Criar um DataTable vazio, onde serão inseridos os dados do banco
                DataTable dataTable = new DataTable();

                //Mandar o comando ir ate o banco, pegar os dados e o adaptador preencher o dt
                sqlDataAdapter.Fill(dataTable);

                return dataTable;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
