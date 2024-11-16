using Microsoft.AspNetCore.Mvc;

namespace Travail2.Controllers
{
    public class HomeController : Controller
    {
        public void tri_a_bulle(int[] t, int n)
        {
            int tmp = 0; // Variable de stockage temporaire
            bool en_desordre = true; // Booléen marquant l'arrêt du tri si le tableau est ordonné

            while (en_desordre)
            {
                // Supposons le tableau ordonné
                en_desordre = false;

                for (int j = 0; j < n - 1; j++) // Correction : 'j = 0' et 'j < n - 1'
                {
                    // Si les 2 éléments sont mal triés
                    if (t[j] > t[j + 1])
                    {
                        // Inversion des 2 éléments
                        tmp = t[j];
                        t[j] = t[j + 1];
                        t[j + 1] = tmp;
                        en_desordre = true;
                    }
                }
            }
        }
    }
}
