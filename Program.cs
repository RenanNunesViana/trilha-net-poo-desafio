using DesafioPOO.Models;

Console.WriteLine(" Nokia:");
Smartphone nokia = new Nokia("julius number", "model julius", "123456789", 128);
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("freefire");

Console.WriteLine("\n Iphone");
Smartphone iphone = new Iphone("Julia number", "model julia", "987654321", 256);
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("mario cart");
