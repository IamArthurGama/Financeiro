using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleContas
{
    class Conta
    {
        private string _numero;
        public decimal _saldo;
        Cliente _titular;
        Agencia _agencia;

        public Conta (string numero, decimal saldo, Cliente titular, Agencia agencia)
        {
            if (!(saldo > 10))
            {
                throw new ArgumentException("O saldo tem que ser superior a 10");
            }

            if (titular == null)
            {
                throw new ArgumentException("É necessário que haja um titular para a criacao da conta");
            }

            if (agencia == null)
            {
                throw new ArgumentException("É necessário que haja uma agencia para a criacao da conta");
            }

            this._saldo = saldo;
            this._numero = numero;
            this._titular = titular;
            this._agencia = agencia;
         


        }


        public string Numero
        {
            get => _numero;
            set => _numero = value;
        }

        public decimal Saldo
        {
            get => _saldo;
            set
            {
                if(value >= 0)
                {
                    _saldo = value;
                }
                else
                {
                    throw new ArgumentException("Saldo nao pode ser negativo.");
                }
            } 
        }

        public void Deposito (decimal valor)
        {
            if(valor > 0)
            {
                _saldo += valor;
            }else
            {
                throw new ArgumentException("O valor tem que ser maior que zero!");
            }
        }
        public void Transferencia(decimal valor, Conta conta)
        {
            if (!(valor > 0))
            {
                throw new ArgumentException("O valor tem que ser maior que zero!");
            }

            if (conta == null)
            {
                throw new ArgumentException("É necessário que seja informado uma conta para a realizacao da transferencia!");
            }

            if(valor > _saldo)
            {
                throw new ArgumentException("Não será possivel realizar a transferencia pois o valor excede o dinheiro em conta!");
            }

            Console.WriteLine($"\nIniciando transferencia ({_titular.Nome}):\n Saldo: {_saldo}");

            _saldo -= valor;
            conta.Deposito(valor);

            Console.WriteLine($"\nTransferencia concluida com sucesso!\nSeu saldo atual ({_titular.Nome}): {_saldo:C2}\nSaldo do transferido ({conta.Titular.Nome}): {conta.Saldo}\n\n");
        



        }

        public void Saque(decimal valor)
        {
            if (valor > 0)
            {
                if (_saldo >= (valor + 0.10m))
                {
                    _saldo -= (valor + 0.10m);
                    Console.WriteLine($"O valor do saque foi de {valor:C2}, e o seu saldo atual é de {_saldo:C2}");
                }
                else
                {
                    throw new ArgumentException("O valor do saque não pode ser maior que o saldo.");
                }

            }
            else
            {
                throw new ArgumentException("O valor do saque tem que ser maior que zero.");
            }

        }

        public Cliente Titular 
        { get => _titular; 
          set => _titular = value; 
        }
    }
}
