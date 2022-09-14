using DesafioPOO.Models;

Console.WriteLine("Smartphone iPhone:");
Iphone iphone = new Iphone(numero: "1234", modelo: "Iphone XS", imei: "123123123", memoria: 128);
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Chrome");

Console.WriteLine("\n");

Console.WriteLine("Smartphone Nokia:");
Nokia nokia = new Nokia(numero: "5678", modelo: "Nokia SX", imei: "789987654", memoria: 128);
nokia.ReceberLigacao();
nokia.Ligar();
nokia.InstalarAplicativo("Safari");