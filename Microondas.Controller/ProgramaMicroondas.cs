using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microondas.Controller
{
    /// <summary>
    /// Responsavel por representar o registro de um programa do microondas
    /// </summary>
    public class ProgramaMicroondas
    {
        public int Id { get; internal set; }
        public string Descricao { get; internal set; }
        public int Tempo { get; internal set; }
        public int Potencia { get; internal set; }
        public char CharAquecimento { get; internal set; }

        /// <summary>
        /// Cria um novo objeto de ProgramaMicroondas
        /// </summary>
        /// <param name="id">Codigo de identificacao do registro</param>
        /// <param name="descricao">Descricao do registro da programacao</param>
        /// <param name="tempo">Tempo de execucao definido para o registro da programacao</param>
        /// <param name="potencia">Potencia de execucao definido para o registro da programacao</param>
        internal ProgramaMicroondas()
        {
           
        }
    }
}
