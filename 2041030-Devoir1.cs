namespace DevoirSemaine1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            static void DireQuelqueChose()
            {
                Console.WriteLine("bonjour le monde");
            }

            static double CalculAireCarre(int longueurCarre)
            {
                longueurCarre = 3;
                double aireCarre = Math.Pow(longueurCarre, 2);
                return aireCarre;
            }

            static double CalculAireCercle(int diametreCercle)
            {
                double rayonCercle = diametreCercle / 2;
                double aireCercle = Math.PI*Math.Pow(rayonCercle, 2);
                return aireCercle;
            }

            static double ConvertirKMHenMS(int vitesseKM)
            {
                vitesseKM = 30;
                double vitesseMS = vitesseKM * 0.27778;
                return vitesseMS;
                //1 km/h = 0.277778 m/s selon Google, on peut également faire un produit croisé pour déterminer cela.
            }

            static double CalculerDistanceChute(double acceleration, int vitesseInitiale, int tempsAcceleration)
            {
                acceleration = 9.8;
                vitesseInitiale = 0;
                tempsAcceleration = 3;
                double distance = Math.Round(0.5 * acceleration * Math.Pow(tempsAcceleration, 2) + vitesseInitiale * tempsAcceleration, 2);
                return distance;
            }

            static double CalculerDistanceChute2(double acceleration, double vitesseInitiale, int tempsAcceleration)
            {
                acceleration = 2; //2m/s
                vitesseInitiale = 13.889; //50km/h en m/s (on veut les mettre sur la même mesure)
                tempsAcceleration = 5;
                double distance = Math.Round(0.5 * acceleration * Math.Pow(tempsAcceleration, 2) + vitesseInitiale * tempsAcceleration, 2);
                return distance;
            }

            static void TableauCarreAfficher()
            {
                int[] tableau = new int[5]; //Tableau à 5 cellules
                double aire = 0;

                for(int i = 0; i < tableau.Length; i++) //Pour 5 fois
                {
                    tableau[i] = i + 1; //pour avoir un tableau qui fait 1, 2, 3, 4, 5 au lieu de 0, 1, 2, 3, 4, 5..
                    aire = CalculAireCarre(tableau[i]); //tu remplaces l'int longueur par "tableau[i] i + 1"
                    Console.WriteLine("Côté : " + tableau[i] + " - Aire : " + aire);
                }
            }

            static void SavoirCompter(int nombreEntier)
            {
                nombreEntier = 5;
                for(int i = 0; i<= nombreEntier; i++) 
                {
                    //créer une variable pour y mettre tous les résultats de [i]
                }
                //console.WriteLine(variable);
            }
        }
    }
}
