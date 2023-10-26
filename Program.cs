using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Nokia n1 = new Nokia(numero: "123456", modelo: "Nokia", imei: "2222", memoria: 2048);
Console.WriteLine("Nokia");
n1.Ligar();
n1.ReceberLigacao();
n1.InstalarAplicativo("Telegram");
Console.WriteLine();
Console.WriteLine("Iphone");
Iphone iph1 = new Iphone(numero: "789456", modelo: "Iphone", imei: "3333", memoria: 4096);
iph1.Ligar();
iph1.ReceberLigacao();
iph1.InstalarAplicativo("Facebook");