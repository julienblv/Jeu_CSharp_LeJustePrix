using System;


namespace Jeu_CSharp_LeJustePrix 
{
    class Main_JustePrix
    {

        
        static void Main (string[] agrs) 
        {
            bool isApplicationOn=true;
            while(isApplicationOn =true)
            {
                Console.WriteLine("Choisissez une action 1, 2 ou 3");
                String StringRecu = Console.ReadLine();
                int IndiceActionChoisie = Convert.ToInt32(StringRecu);

                // Declaration de la classe Program.cs
                Program pg = new Program();

                switch (IndiceActionChoisie)
                {
                    case 1:
                        sayHello();
                        break;
                    case 2:
                        saySomething("Hey ! On commences la partie");
                        saySomething("Compris");

                        //via Program.cs
                        pg.Update();
                        break;
                    case 3:
                    Console.WriteLine("Es-ce un jour Bonus ??" + isBonusDay());
                        isBonusDay();

                        //via Program.cs
                        pg.Update();
                        break;

                    case 0:
                        Console.WriteLine("Fin de la partie");
                        isApplicationOn = false;
                        break;

                }
        }


        }

        static bool isBonusDay()
        {
            Random rnd = new Random();
            int BonusCode = rnd.Next(2);

            bool BonusDay = BonusCode == 0 ? false:true; //operateur ternaire 

            return BonusDay;
        }
        static void sayHello()
        {
            Console.WriteLine("Hello !");
        }

        static void saySomething(string message)
        {
            Console.WriteLine(message);
        }
    }

}