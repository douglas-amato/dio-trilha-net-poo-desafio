using DesafioPOO.Models;

// Realiza os testes com as classes Nokia e Iphone
Console.WriteLine("Testes com o Nokia:");
Smartphone nokia = new Nokia(numero: "123", modelo: "Modelo N", imei: "98754565102", memoria: 256);
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("WhatsApp");
nokia.ExibirDadosDoAparelho();

Console.WriteLine("\n");

Console.WriteLine("Testes com o Iphone:");
Smartphone iphone = new Iphone(numero: "987", modelo: "Modelo I", imei: "12345678901", memoria: 512);
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("LinkedIn");
iphone.ExibirDadosDoAparelho();