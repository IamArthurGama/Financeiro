using ControleContas;

Banco banco1 = new Banco("Nubank", "1111");

Agencia agencia1 = new Agencia("1234", "27332080", "2134124124", banco1);

Cliente cliente1 = new Cliente("Arthur", "12345678901", 2004);
Cliente cliente2 = new Cliente("Robson", "12145674905", 2003);

Conta conta1 = new Conta("1234", 1_234.42m, cliente1, agencia1);

Conta conta2 = new Conta("654321", 2_341.42m, cliente2, agencia1);

Console.WriteLine($"\nO saldo total da conta1 é: {conta1.Saldo}\nO saldo total da conta2 é: {conta2.Saldo}\n");

if (conta1.Saldo > conta2.Saldo)
{
    Console.WriteLine("O saldo da conta1 é maior do que a da conta2.");
}else
{
    Console.WriteLine("O saldo da conta2 é maior do que a da conta1.");
}

Console.WriteLine($"\nO saldo inicial total geral é de: {conta1.Saldo + conta2.Saldo}");

conta1.Transferencia(500, conta2);

conta2.Transferencia(1500, conta1);
