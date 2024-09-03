using DesafioPOO.Models;

// IMPLEMENTADO: Realizar os testes com as classes Nokia e Iphone

Smartphone nokia = new Nokia("7190000-0000","Nokia Lumia","1111111",16);
Smartphone iphone = new Iphone("7590000-0000","Iphone 14","1111111",256);

Console.WriteLine("Nokia Lumia");

nokia.Ligar();
nokia.InstalarAplicativo("Jogo da cobrinha");


Console.WriteLine("\n");

Console.WriteLine("Iphone 14");

nokia.Ligar();
nokia.InstalarAplicativo("Twitter");


