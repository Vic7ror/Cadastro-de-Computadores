using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro_Computadores
{
    internal class Computador
    {
        public string nome, processador, placaMae, memoria, discoRigido, marca, status, tipoDeDefeito, ano;
        public string tabela = "computador";
        Conexao objConexao = new Conexao();

        public void cadastrarComputador()
        {
            // Comando :
            string cadastrar = $@"INSERT INTO {tabela} values 
                                (null,'{nome}','{memoria}','{discoRigido}','{processador}','{marca}',
                                 '{placaMae}','{ano}','{status}','{tipoDeDefeito}');";
            // Executar:
            objConexao.ExecutarComando(cadastrar);
        }

        public DataTable ListarComputador()
        {
            // Comando :
            string listar = $"SELECT * FROM {tabela} ORDER BY status;";
            // Executar/Retorno :
            return objConexao.ExecutarConsulta(listar);
        }
    }
}
