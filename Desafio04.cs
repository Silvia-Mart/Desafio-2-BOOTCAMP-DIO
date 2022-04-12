// using System;
// using System.Linq;

// class MinhaClasse 
// {
//   public static void Main (string[] args) 
//   {

//     int  totalDeCasosDeTeste = int.Parse(Console.ReadLine());
    
//     string[] item = new string[totalDeCasosDeTeste]; 
//     for (int i = 0; i < totalDeCasosDeTeste; i++)
//     {
        
    
    
//         string[] listaDeCompras = Console.ReadLine().Split(" ");
        
//         var itemUnico = listaDeCompras.Distinct().ToArray();
//         var sortedItem = itemUnico.OrderBy(n =>n );
//         item[i] = ($" {string.Join(" ", sortedItem)}");
//     }

//     foreach (var i in item)
//     {
//         Console.WriteLine(i);
//     }
    
    
    
    
    
    
    
//   }
// }