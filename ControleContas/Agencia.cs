using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ControleContas;

namespace ControleContas
{
    public class Agencia
    {
        private string _numero;
        private string _cep;
        private string _telefone;
        private Banco _banco;

        public Agencia(string numero, string cep, string telefone, Banco banco)
        {
            _numero = numero;
            _cep = cep;
            _telefone = telefone;
            _banco = banco;
        }

        public string Numero { get => _numero; set => _numero = value; }

        public string Cep { get => _cep; set => _cep = value; }

        public string Telefone { get => _telefone; set => _telefone = value; }

        public Banco Banco { get => _banco; set => _banco = value; }


    }
}
