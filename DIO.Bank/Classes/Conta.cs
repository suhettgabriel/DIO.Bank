using System;
namespace DIO.Bank
{
    public class Conta
    {
        public Conta(TipoConta tipoConta, double saldo, double credito, string nome) 
        {
                this.TipoConta = tipoConta;
                this.Saldo = saldo;
                this.Credito = credito;
                this.Nome = nome;
               
        }
        private TipoConta TipoConta {get; set;}
        private double Saldo {get; set;}
        private double Credito {get; set;}
        private string Nome {get; set;}

       

        public bool Sacar (double valorSaque)
        {
            // Verifica se existe saldo e retorna o bool true or false.
            if(this.Saldo - valorSaque < (this.Credito * -1))
            {
                Console.WriteLine("Olá {0},Seu saldo é insuficiente no momento.  seu saldo é de R$ {1} Reais.", this.Nome, this.Saldo);
                return false;
            }

            this.Saldo = this.Saldo - valorSaque;
            Console.WriteLine("Olá {0}, seu saldo é de R$ {1} Reais.", this.Nome, this.Saldo);
            return true;
        }

        public void Depositar (double valorDeposito)
        {
            this.Saldo = this.Saldo + valorDeposito;
            Console.WriteLine("Olá {0}, seu saldo é de R$ {1} Reais.", this.Nome, this.Saldo);
        }
        public void Transferir (double valorTransferencia, Conta contaDestino)
        {
            if(this.Sacar(valorTransferencia))
            {
                contaDestino.Depositar(valorTransferencia);
            }
            Console.WriteLine("Olá {0}, seu saldo é de R$ {1} Reais.", this.Nome, this.Saldo);
        }

        public override string ToString()
        {
            string retorno = "";
            retorno += "TipoConta: " + this.TipoConta + " | ";
            retorno += "Nome: " + this.Nome + " | ";
            retorno += "Saldo R$ " + this.Saldo + ",00 | ";
            retorno += "Credito R$ " + this.Credito +",00";

            return retorno;

        }
    }
}