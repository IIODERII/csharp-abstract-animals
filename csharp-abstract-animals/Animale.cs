using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_abstract_animals
{
    public abstract class Animale
    {
        public void Dormi()
        {
            Console.WriteLine("Zzzzz");
        }

        public abstract void Verso();

        public abstract void Mangia();
    }

    public class Mucca : Animale {
        public override void Verso()
        {
            Console.WriteLine("Mucca *** **** MUUUUUUUUUUU");
        }

        public override void Mangia()
        {
            Console.WriteLine("Gnam Gnam sto mangiando l'erba");
        }
    }

    public class Tigre : Animale
    {
        public override void Verso()
        {
            Console.WriteLine("Roaaaaaaar");
        }

        public override void Mangia()
        {
            Console.WriteLine("Gnam Gnam sto mangiando la carne");
        }
    }

    public class Cane : Animale
    {
        public override void Verso()
        {
            Console.WriteLine("Bau Bau");
        }

        public override void Mangia()
        {
            Console.WriteLine("Gnam Gnam sto mangiando i croccantini(?)");
        }
    }

    public class Balena : Animale, INuotante
    {
        public override void Verso()
        {
            Console.WriteLine("WOOOOOOUUUUOOO (Non so come scrivere l'onomatopea di una balena)");
        }

        public override void Mangia()
        {
            Console.WriteLine("Gnam Gnam sto mangiando il Plancton");
        }

        public void Nuota()
        {
            Console.WriteLine("SI NUOTAAAAAAAAAAAAAA");
        }
    }

    public class Piccione : Animale, IVolante
    {
        public override void Verso()
        {
            Console.WriteLine("Prrrr Prrrrr");
        }

        public override void Mangia()
        {
            Console.WriteLine("Gnam Gnam sto mangiando il miglio(?)");
        }

        public void Vola()
        {
            Console.WriteLine("SI VOLAAAAAAAAAAAAAA");
        }
    }

    public interface IVolante
    {
        public void Vola();
    }

    public interface INuotante {
        public void Nuota();
    }
}
