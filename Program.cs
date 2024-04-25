using DesafioPOO.Models;
namespace DesafioPOO.Models
{
 
// TODO: Realizar os testes com as classes Nokia e Iphone
 class Program
    {
        static void Main(string[] args)
        {
            //TESTE 1 NOKIA
            Console.WriteLine("\nO smartphone 1: ");
            Nokia smartpone1= new Nokia("27 999593880", "S98", "97327823", 8);
            smartpone1.InstalarAplicativo("Whatsapp");
            smartpone1.Ligar();

            //TESTE 2 NOKIA
            Console.WriteLine("\nO smartphone 2: ");
            Nokia smartpone2= new Nokia("27 998439296", "N03 Ultra", "82759842", 16);
            smartpone2.InstalarAplicativo("Whatsapp");
            smartpone2.ReceberLigacao();

            // TESTE 3 IPHONE
            Console.WriteLine("\nO smartphone 3: ");
            Iphone smartpone3= new Iphone("27 99595910", "Xin54", "51615154", 8);
            smartpone3.InstalarAplicativo("Whatsapp");
            smartpone3.ReceberLigacao();

            //TESTE 4 IPHONE
            Console.WriteLine("\nO smartphone 4: ");
            Iphone smartpone4= new Iphone("27 98811-4037", "S98", "97327823", 8);
            smartpone4.InstalarAplicativo("Whatsapp");
            smartpone4.Ligar();
        }
    }

}