using System.Security.Cryptography.X509Certificates;

namespace csharp_abstract_animals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Animale> animali = new List<Animale>();
            animali.Add(new Cane());
            animali.Add(new Mucca());
            animali.Add(new Tigre());
            animali.Add(new Balena());
            animali.Add(new Piccione());

            foreach (Animale animale in animali)
            {
                Console.WriteLine(animale.ToString().Substring(24));
                animale.Verso();
                animale.Mangia();
                Console.WriteLine("\n");
            }

            void FaiVolare(IVolante v)
            {
                v.Vola();
            }

            void FaiNuotare(INuotante n)
            {
                n.Nuota();
            }

            Piccione piccione = new Piccione();
            Console.Write($"\nPiccione dice: ");
            FaiVolare(piccione);

            Balena balena = new Balena();
            Console.Write($"\nBalena dice: ");
            FaiNuotare(balena);
        }
    }
}
