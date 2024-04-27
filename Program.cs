using DesafioPOO.Models;

Console.WriteLine("Nokia");
Smartphone nokia  = new Nokia(numero:"1222",modelo:"M1",iMEI:"dd",memoria:"64");
nokia.Ligar();
nokia.InstalarAplicativo("WhatsApp");

Console.WriteLine("\n");
Console.WriteLine("Iphone");
Smartphone iphone = new Iphone(numero: "3333", modelo: "M2", iMEI: "sdsds", memoria: "32");
iphone.Ligar();
iphone.InstalarAplicativo("WhatsApp");