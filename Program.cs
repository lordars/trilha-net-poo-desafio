using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Nokia nokia = new Nokia("12995481","alcPhor","jsaidfj11131",32);
Iphone iphone = new Iphone("12995481","alcPhor","jsaidfj11131",32);


nokia.InstalarAplicativo("whatsapp");
iphone.InstalarAplicativo("whatsapp");

Console.WriteLine(nokia.Numero);
nokia.CambioDeNumero("12331232132321");

Console.WriteLine(iphone.Numero);
iphone.CambioDeNumero("12331232132321");