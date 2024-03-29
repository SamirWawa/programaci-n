﻿internal class Program
{
    private static void Main(string[] args)
    {
        string[] canciones = {
        "Wanna Be Startin' Somethin", "Baby Be Mine", "The Girl Is Mine", "Thriller", "Beat It",
        "Billie Jean", "Human Nature", "P.Y.T. (Pretty Young Thing)", "The Lady in My Life"};
        Disc thriller = new Disc("Thriller", "Michael Jackson", canciones);
        DABRadioCD radioCD = new DABRadioCD();
        ConsoleKeyInfo tecla = new ConsoleKeyInfo();
        do
        {
            try
            {
                Console.WriteLine(radioCD.MessageToDisplay);
                tecla = Console.ReadKey(true);
                Console.Clear();
                switch (tecla.KeyChar)
                {
                    case '1':
                        radioCD.Play();
                        break;
                    case '2':
                        radioCD.Pause();
                        break;
                    case '3':
                        radioCD.Stop();
                        break;
                    case '4':
                        radioCD.Previous();
                        break;
                    case '5':
                        radioCD.Next();
                        break;
                    case '6':
                        radioCD.SwitchMode();
                        break;
                    case '7':
                        radioCD.InsertCD = thriller;
                        break;
                    case '8':
                        radioCD.InsertCD = null;
                        break;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        } while (tecla.Key != ConsoleKey.Escape);
    }
}
