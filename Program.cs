﻿
using csharp_oop_shop;

Prodotto p = new Prodotto("T-shirt-casual", "Una T-shirt casual per le situazioni più disparate", 12.50, 22);

Console.WriteLine("Il prezzo del prodotto (IVA esclusa) è " + p.getPrezzo() + "€");
Console.WriteLine("Codice identificativo del prodotto: " + p.codice);


Console.WriteLine("Il prezzo pieno del prodotto (IVA inclusa) è " + p.getPrezzoConIVA() + "€");

Console.WriteLine(p.getFullName());

//modifica attributi tramite le properties
p.nome = "T-shirt-elegante"; 
p.prezzo = 25.25;

Console.WriteLine(p.getPrezzo());

Console.WriteLine(p.getPrezzoConIVA());


Console.WriteLine(p.getFullName());

Console.WriteLine(p.getFullCode());