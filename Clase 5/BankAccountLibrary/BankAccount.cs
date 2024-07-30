using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountLibrary
{
    public class BankAccount : IBankAccount
    {
        public string AccountOwner { get; set; }

        public string AccountName { get; private set; }

        public decimal Balance { get; private set; }

        public decimal GetBalance()
        {
            throw new NotImplementedException();
        }

        public void MakeDeposit(decimal amount)
        {
            Balance += amount;
        }

        public void MakeWithdraw(decimal amount)
        {
            if((Balance - amount) < 0)
                throw new NotImplementedException("No hay fondos suficientes");
            if (amount < 0)
                throw new NotImplementedException("La cantidad debe ser mayor que cero");
            
            Balance -= amount;
        }





        //agregar interfaz para crear metodod




    }
}
