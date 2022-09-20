using System;

namespace Jeu_CSharp_LeJustePrix 
{
    class Program
    {
        static int nbEssais=5;

        static bool isWin=false;

        public bool isApplicationOn=true;

        static int nombreChoisi;

        static int usrSaisie;

        static int ChiffreMystere;

        public void Update()
        {
              Console.WriteLine("*******************"); 
              Console.WriteLine("*** LeJustePrix ***"); 
              Console.WriteLine("*******************");

              Random Nb_Rnd = new Random();
              ChiffreMystere = Nb_Rnd.Next(1000);

              while(Program.nbEssais >= 1 && !isWin)
              {
                Console.WriteLine("Entrez vôtre Chiffre ...");
                string stringRecu = Console.ReadLine();

                if(isNumeric(stringRecu))
                {
                    Console.WriteLine("Vous avez choisi : "+ nombreChoisi);
                    if (nombreChoisi == ChiffreMystere)
                    {
                    Console.WriteLine("Bravo c'est gagné !");
                    }
                    else
                    {
                        Program.nbEssais--;
                        Console.WriteLine(" Rejouez, il vous reste : "+ Program.nbEssais + " essais. " + giveIndice());
                        //Dit si c'est plus ou moins 

                        if(Program.nbEssais==0){
                            Console.WriteLine("Désolé mais c'est pardu le nombre était : " + ChiffreMystere);
                            isApplicationOn=false;

              
                            // CODE FONCTION RESTART
                            Console.WriteLine("Choisissez de refaire une nouvelle partie (1) ou de quitter(0) ?");
                            string usrsaisie = Console.ReadLine();
                            if(Restart(usrsaisie) == true)
                            {
                                Console.WriteLine("Vous avez choisi : "+ usrSaisie + " Vôtre nouvelle partie va commencer !");
                                isApplicationOn=true;
                                nbEssais=5;
                                ChiffreMystere = Nb_Rnd.Next(1000);
                            }
                            else
                            {
                                Console.WriteLine("Vous avez choisi : " + usrSaisie + "Merci d'avoir joué !");
                                Console.WriteLine("sortie de la boucle");
                                isApplicationOn=false;
                            }
              
                        }
                    } 
                }
                else
                {
                    Console.WriteLine("Entrez des chiffres Cochon ! ");
                }

              }
              
              

        }

        static bool isNumeric(String value){
            bool isNumeric = false;
            isNumeric = int.TryParse(value, out nombreChoisi);
            return isNumeric;
        }

        // FONCTION RESTART
        static bool Restart(String value){
            bool restartVal = false;
            restartVal = int.TryParse(value, out usrSaisie);
            return restartVal;
        }

        static string giveIndice()
        {
            if(nombreChoisi < ChiffreMystere)
                {
                    return "C'est moins (+)";
                }
           if (nombreChoisi > ChiffreMystere)
                {
                    return "C'est plus (-)";
                }
            else
            {
                    return "";
            }
        }
    }
}


