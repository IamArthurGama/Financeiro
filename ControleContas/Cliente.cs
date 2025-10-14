using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ControleContas;

namespace ControleContas
{
    class Cliente
    {
        private string _nome;
        private string _cpf;
        private int _anoNascimento;
        private Conta _conta;

        public Cliente(string nome, string cpf, int anoNascimento)
        {
            int anoAtual = DateTime.Now.Year;
            if ((anoAtual - anoNascimento) < 18)
            {
                throw new ArgumentException("O cliente deve ter no mínimo 18 anos.");
            }else
            {
                this._anoNascimento = anoNascimento;
            }

            if(!(cpf.Length == 11))
            {
                throw new ArgumentException("O CPF precisa ter 11 digitos");
            }
            else
            {
                this._cpf = cpf;
            }

            this._nome = nome;
        }

        public string Nome
        {
            get => _nome;
            private set => _nome = value;
        }

        public string Cpf 
        { 
            get => _cpf; 
            private set => _cpf = value; 
        }

        public int AnoNascimento
        {
            get => _anoNascimento;
            private set => _anoNascimento = value;
        }

        public Conta Conta
        {
            get => _conta;
            set => _conta = value;
        }





    }
}
