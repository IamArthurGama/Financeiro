using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ControleContas;

namespace ControleContas
{
    public class Banco
    {
        private string _nome;
        private string _numero;
   

        public Banco (string nome, string numero)
            {

            if (nome == null)
            {
                throw new ArgumentException("É necessário que haja um nome para a criacao do banco.");
            }

            if (numero == null)
            {
                throw new ArgumentException("É necessário que haja um numero valido para a criacao do banco.");
            }

            _nome = nome;
            _numero = numero;
            }

        public string Nome { get => _nome; set => _nome = value; }

        public string Numero { get => _numero; set => _numero = value; }
    }
}
