using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpectreAmplitude
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Créer une liste pour stocker les objets Couple
            List<Couple> couples = new List<Couple>();

            // Ajouter des couples (1/3, 3), (1/5, 5) etc.
            for (int i = 1; i <= 5; i += 2)
            {
                double secondValue = 1.0 / i;
                couples.Add(new Couple(i, secondValue));
            }

            // Afficher les valeurs
            foreach (var couple in couples)
            {
                Console.WriteLine(couple);
            }

            // assesseur
            foreach (var couple in couples)
            {
                int a;
                double b;

                // exemple d'utilisation de l'asseseur get
                a=couple.FirstValue;
                b=couple.SecondValue;

                // exemple d'utilisation de l'assesseur set
                couple.FirstValue = 7;
                couple.SecondValue = 1 / 7.0; 
            }
        }
    }
}
