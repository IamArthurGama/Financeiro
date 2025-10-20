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


            if (numero == null)
            {
                throw new ArgumentException("É necessário que haja um numero para a criacao do banco.");
            }


            if (cep == null)
            {
                throw new ArgumentException("É necessário informar um CEP para a criação da agência.");
            }

            if (cep.Length != 8)
            {
                throw new ArgumentException("O CEP deve conter exatamente 8 dígitos numéricos.");
            }


            if (telefone == null)
            {
                throw new ArgumentException("É necessário informar um telefone para a criação da agência.");
            }

            if (telefone.Length < 10 || telefone.Length > 11)
            {
                throw new ArgumentException("O telefone deve conter entre 10 e 11 dígitos numéricos (DDD + número).");
            }

            if (banco == null)
            {
                throw new ArgumentException("É necessário informar um banco válido para a criação da agência.");
            }

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
