using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia(numero: "985268932", modelo: "Modelo A", imei: "1111", memoria: 32);

nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Whatsapp");

Console.WriteLine("-----------------------------");

Console.WriteLine("Smartphone iPhone:");
Smartphone iphone = new Iphone(numero: "978632584", modelo: "Modelo B", imei: "1221", memoria: 128);

iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Youtube");


