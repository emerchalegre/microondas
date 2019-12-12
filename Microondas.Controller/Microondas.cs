using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Microondas.Controller
{

    /// <summary>
    /// Abstracao de um Microondas Generico
    /// </summary>
    public class Microondas : IMicroondas, IMicroondasProgramavel
    {
        private List<ProgramaMicroondas> programasMicroondas = new List<ProgramaMicroondas>();

        private void ValidarDescricaoProgramacao(string descricao)
        {
            try
            {
                if (String.IsNullOrEmpty(descricao))
                {
                    throw new Exception("Descricao da programacao nao pode ser vazia ou nula");
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }


        /// <summary>
        /// Validador para o conteudo a ser aquecido
        /// </summary>
        /// <param name="texto">Texto aquecido</param>
        /// <returns>Verdadeiro para um valor correto informado.</returns>
        private bool ValidarTextoAquecimento(string texto)
        {
            try
            {
                if (String.IsNullOrEmpty(texto))
                    throw new Exception("Texto de aquecimento nao pode ser vazio ou nulo");

                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Valida o tempo de aquecimento
        /// </summary>
        /// <param name="tempo">Valor do tempo de aquecimento</param>
        /// <returns>Verdadeiro para um valor correto informado.</returns>
        private bool ValidarTempoAquecimento(int tempo)
        {
            try
            {
                if (tempo < 1 || tempo > 120)
                    throw new Exception("Tempo informado fora do limite permitido (entre 1 e 120 segundos)");

                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Validar a potencia do aquecimento
        /// </summary>
        /// <param name="potencia">Valor da potencia de arqucimento</param>
        /// <returns>Verdadeiro para um valor correto informado.</returns>
        private bool ValidarPotenciaAquecimento(int potencia)
        {
            try
            {
                if (potencia < 1 || potencia > 10)
                {
                    throw new Exception("Potencia informada fora do limite permitido (entre 1 e 10)");
                }

                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public string AquecerString(string texto, int tempo, int potencia, char charArquecimento = '*')
        {
            try
            {
                ValidarTextoAquecimento(texto);
                ValidarTempoAquecimento(tempo);
                ValidarPotenciaAquecimento(potencia);

                for (int i = 0; i < tempo; i++)
                {
                    texto += " " + new String(charArquecimento, potencia);
                }

                return texto;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public string AquecerStringProgramacao(string texto, int id)
        {
            try
            {
                ValidarTextoAquecimento(texto);

                ProgramaMicroondas p = RetornarProgramacaoId(id);

                return AquecerString(texto, p.Tempo, p.Potencia, p.CharAquecimento);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool CadastrarProgramacao(string descricao, int tempo, int potencia, char charAquecimento)
        {
            try
            {
                ValidarDescricaoProgramacao(descricao);
                ValidarTempoAquecimento(tempo);
                ValidarPotenciaAquecimento(potencia);

                ProgramaMicroondas p = new ProgramaMicroondas()
                {
                    Descricao = descricao,
                    Potencia = potencia,
                    Tempo = tempo,
                    CharAquecimento = charAquecimento
                };

                programasMicroondas.Add(p);

                p.Id = programasMicroondas.IndexOf(p);

                return true;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool EditarProgramacao(int id, string descricao, int tempo, int potencia, char charAquecimento)
        {
            try
            {
                ProgramaMicroondas p = RetornarProgramacaoId(id);

                ValidarDescricaoProgramacao(descricao);
                ValidarTempoAquecimento(tempo);
                ValidarPotenciaAquecimento(potencia);

                p.Descricao = descricao;
                p.Tempo = tempo;
                p.Potencia = potencia;
                p.CharAquecimento = charAquecimento;

                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool ExcluirProgramacao(int id)
        {
            try
            {
                ProgramaMicroondas p = RetornarProgramacaoId(id);

                programasMicroondas.Remove(p);

                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<ProgramaMicroondas> ListarProgramacao()
        {
            try
            {
                return programasMicroondas.ToList();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public ProgramaMicroondas RetornarProgramacaoId(int id)
        {
            try
            {
                ProgramaMicroondas p = programasMicroondas.FirstOrDefault(x => x.Id == id);

                if (p is null)
                    throw new Exception("Nenhum ememento foi encontrado com o Id informado.");

                return p;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
