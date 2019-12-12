using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microondas.Controller
{
    /// <summary>
    /// Definicao de um microondas generico
    /// </summary>
    public interface IMicroondas
    {
        /// <summary>
        /// Aquece a string com parametros informados pelo usuario.
        /// </summary>
        /// <param name="texto">String a ser aquecida</param>
        /// <param name="tempo">Tempo de aquecimento da string em segundos</param>
        /// <param name="potencia">Potencia da string para aquecimento</param>
        /// <returns>String aquecida</returns>
        string AquecerString(string texto, int tempo, int potencia, char charAquecimento = '*');
    }
}
