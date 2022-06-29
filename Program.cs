
using csharp_oop_shop;

Prodotto p = new Prodotto("T-shirt-casual", "Una T-shirt casual per le situazioni più disparate", 12.50, 22);

Console.WriteLine(p.getPrezzo());

Console.WriteLine(p.getPrezzoConIVA());

Console.WriteLine(p.getFullName());