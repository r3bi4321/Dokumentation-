namespace IMS_Lernatelier
{
    internal class Program
    {
        static void Main(string[] args)



        {
            string antwort = "y";
            while (antwort == "y")
            {

                Console.WriteLine("Welche Schwierigkeitstufe wollen sie? [1|2|3]");
                string entscheidung = Console.ReadLine();
                double Entscheidung = Convert.ToDouble(entscheidung);

                if (Entscheidung == 2)
                {

                    do
                    {

                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        double Geheimzahl = new Random().Next(1, 100);
                        Console.WriteLine("Tippen sie eine Zahl zwischen 1 und 100.");
                        string Zahl1 = Console.ReadLine();
                        double Zahl = Convert.ToDouble(Zahl1);


                        if (Zahl == Geheimzahl)
                        {
                            Console.WriteLine("Glückwunsch du hast die Zahl erraten");
                            Console.ForegroundColor = ConsoleColor.Green;

                        }
                        while (Zahl != Geheimzahl)
                        {
                            if (Zahl < Geheimzahl)
                            {
                                Console.WriteLine("Die Geheimzahl ist grösser als " + Zahl);
                            }
                            else if (Zahl > Geheimzahl)
                            {

                                Console.WriteLine("die Geheimzahl ist kleiner als " + Zahl);
                            }
                            if (Zahl > 101)
                            {

                                Console.WriteLine("Falsche Eingabe Bitte gebën sie nur Zahlen zwischen 1 und 100 ein");
                            }

                            Console.WriteLine("Zahl ist inkorrekt.Geben sie eine andere Zahl ein");
                            Zahl1 = Console.ReadLine();
                            Zahl = Convert.ToDouble(Zahl1);


                        }

                        Console.WriteLine("Gratuliere sie haben die Zahl erraten");
                        Console.WriteLine("Möchten sie noch eine Runde spielen?[y|n]");
                        antwort = Console.ReadLine();
                    } while (antwort == "y");

                }
                else if (Entscheidung == 3)
                {


                    do
                    {

                        Console.BackgroundColor = ConsoleColor.White;
                        Console.ForegroundColor = ConsoleColor.Black;
                        double Geheimzahl = new Random().Next(1, 1000);
                        Console.WriteLine("Tippen sie eine Zahl zwischen 1 und 1000.");
                        string Zahl1 = Console.ReadLine();
                        double Zahl = Convert.ToDouble(Zahl1);






                        if (Zahl == Geheimzahl)
                        {
                            Console.WriteLine("Glückwunsch du hast die Zahl erraten");
                            Console.ForegroundColor = ConsoleColor.Green;

                        }
                        while (Zahl != Geheimzahl)
                        {
                            if (Zahl < Geheimzahl)
                            {
                                Console.WriteLine("Die Geheimzahl ist grösser als " + Zahl);
                            }
                            else if (Zahl > Geheimzahl)
                            {

                                Console.WriteLine("die Geheimzahl ist kleiner als " + Zahl);
                            }
                            if (Zahl > 1001)
                            {

                                Console.WriteLine("Falsche Eingabe Bitte gebën sie nur Zahlen zwischen 1 und 100 ein");
                            }

                            Console.WriteLine("Zahl ist inkorrekt.Geben sie eine andere Zahl ein");
                            Zahl1 = Console.ReadLine();
                            Zahl = Convert.ToDouble(Zahl1);


                        }

                        Console.WriteLine("Gratuliere sie haben die Zahl erraten");
                        Console.WriteLine("Möchten sie noch eine Runde spielen?[y|n]");
                        antwort = Console.ReadLine();
                    } while (antwort == "y");


                }


                else if (Entscheidung == 1) ;
                {

                    do
                    {

                        Console.BackgroundColor = ConsoleColor.Green;
                        Console.ForegroundColor = ConsoleColor.Blue;
                        double Geheimzahl = new Random().Next(1, 50);
                        Console.WriteLine("Tippen sie eine Zahl zwischen 1 und 50.");
                        string Zahl1 = Console.ReadLine();
                        double Zahl = Convert.ToDouble(Zahl1);






                        if (Zahl == Geheimzahl)
                        {
                            Console.WriteLine("Glückwunsch du hast die Zahl erraten");
                            Console.ForegroundColor = ConsoleColor.Green;

                        }
                        while (Zahl != Geheimzahl)
                        {
                            if (Zahl < Geheimzahl)
                            {
                                Console.WriteLine("Die Geheimzahl ist grösser als " + Zahl);
                            }
                            else if (Zahl > Geheimzahl)
                            {

                                Console.WriteLine("die Geheimzahl ist kleiner als " + Zahl);
                            }
                            if (Zahl > 101)
                            {

                                Console.WriteLine("Falsche Eingabe Bitte gebën sie nur Zahlen zwischen 1 und 100 ein");
                            }

                            Console.WriteLine("Zahl ist inkorrekt.Geben sie eine andere Zahl ein");
                            Zahl1 = Console.ReadLine();
                            Zahl = Convert.ToDouble(Zahl1);


                        }

                        Console.WriteLine("Gratuliere sie haben die Zahl erraten");
                        Console.WriteLine("Möchten sie noch eine Runde spielen?[y|n]");
                        antwort = Console.ReadLine();
                    } while (antwort == "y");


                }


                


            }
        }
    }
}          
 





       
    

    
    