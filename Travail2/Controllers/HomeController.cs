using Microsoft.AspNetCore.Mvc;

namespace Travail2.Controllers
{
    public class HomeController : Controller
    {
        public void tri_a_bulle(int[] t, int n)
        {
            int tmp = 0; // Variable de stockage temporaire
            bool en_desordre = true; // Bool�en marquant l'arr�t du tri si le tableau est ordonn�

            while (en_desordre)
            {
                // Supposons le tableau ordonn�
                en_desordre = false;

                for (int j = 0; j < n - 1; j++) // Correction : 'j = 0' et 'j < n - 1'
                {
                    // Si les 2 �l�ments sont mal tri�s
                    if (t[j] > t[j + 1])
                    {
                        // Inversion des 2 �l�ments
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
