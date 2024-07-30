namespace BankAccountLibrary
{
    public interface IBankAccount
    {
        void MakeDeposit(decimal amount); //la funcion no necesita retornar con void

        void MakeWithdraw(decimal amount);

        decimal GetBalance(); //la funcion va a retornar un decimal

    }
}
