using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microondas.Controller
{
    /// <summary>
    /// Definicicao de um possivel Microondas passivel de programacao por parte do usuario
    /// </summary>
    public interface IMicroondasProgramavel
    {

        /// <summary>
        /// Lista todas as programacoes definidas pelo usuario
        /// </summary>
        /// <returns>Listagem de programacao do microondas</returns>
        List<ProgramaMicroondas> ListarProgramacao();

        /// <summary>
        /// Retorna apenas um unico objeto referente ao cadastro de uma programacao referente ao id passado
        /// </summary>
        /// <param name="id">Codigo de identificao do registro da programacao</param>
        /// <returns>um objeto de ProgramaMicroondas</returns>
        ProgramaMicroondas RetornarProgramacaoId(int id);

        /// <summary>
        /// Realiza o cadastro de uma nova programacao para o microondas
        /// </summary>
        /// <param name="descricao">Descricao da programacao</param>
        /// <param name="tempo">Tempo de aquecimento em segundos</param>
        /// <param name="potencia">Potencia de aquecimento</param>
        /// <returns>Verdadeiro caso ocorra o cadastro de forma correta</returns>
        bool CadastrarProgramacao(string descricao, int tempo, int potencia, char charArquecimento);

        /// <summary>
        /// Edita um cadastro de programacao existente
        /// </summary>
        /// <param name="id">Codigo que identifica o registro da programacao</param>
        /// <param name="descricao">Nova descricao para o registro da programacao</param>
        /// <param name="tempo">Novo tempo em seguindos para o registro da programacao</param>
        /// <param name="potencia">Nova potencia para o registro da programacao</param>
        /// <returns>Verdadeiro em caso da correta edicao do registro.</returns>
        bool EditarProgramacao(int id, string descricao, int tempo, int potencia, char charAquecimento);

        /// <summary>
        /// Exclui a Programacao existente.
        /// </summary>
        /// <param name="id">Codigo do registro da programacao</param>
        /// <returns>Verdadeiro em caso de correta exclusao do registro.</returns>
        bool ExcluirProgramacao(int id);

        /// <summary>
        /// Realiza o aquecimento com base em uma programacao existente.
        /// </summary>
        /// <param name="texto">string a ser aquecida</param>
        /// <param name="id">codigo identificador do registro da programacao a ser executada.</param>
        /// <returns>string aquecida.</returns>
        string AquecerStringProgramacao(string texto, int id);
    }
}
