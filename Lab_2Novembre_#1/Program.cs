namespace Lab_2Novembre__1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string texte = ObtenirStringUtilisateur("Entrez une chaîne de caractères en minuscules à vérifier : ");
                bool estPalindrome = EstPalindrome(texte);
                if(estPalindrome)
                {
                    Console.WriteLine($"{texte} est un palindrôme.");
                }
                else
                {
                    Console.WriteLine($"{texte} n'est pas un palindrôme.");
                }
            }
        }

        public static string InverserTexte(string texteEntree)
        {
            string texteSortie = "";

            for (int i = texteEntree.Length - 1; i >= 0 ; i--)
            {
                texteSortie += texteEntree[i];
            }

            return texteSortie;
        }

        public static string ObtenirStringUtilisateur(string message)
        {
            Console.WriteLine("");
            Console.WriteLine(message);
            return Console.ReadLine();
        }

        public static bool EstPalindrome(string texte)
        {
            return InverserTexte(texte) == texte;
        }
    }
}