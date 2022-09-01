using bytebank; //chamou a classe bytebank

Console.WriteLine("Bem-vindo ao Bytebank!"); 


ContaCorrente conta1 = new ContaCorrente(); //criou o objeto 

conta1.titular = "Marcella Pereira"; //acessa a prorpeidade com .
conta1.conta = "10123-X";
conta1.numero_agencia = 23;
conta1.nome_agencia = "Ag~encia Central";
conta1.saldo = 100;

Console.WriteLine("Titular: " + conta1.titular); //usa . para acessar e printar o valor na tela
Console.WriteLine("Conta: " + conta1.conta);
Console.WriteLine("Número Agencia: " + conta1.numero_agencia);
Console.WriteLine("Nome da Agencia: " + conta1.nome_agencia);
Console.WriteLine("Saldo: " + conta1.saldo);

Console.ReadKey();