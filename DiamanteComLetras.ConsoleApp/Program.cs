namespace diamanteLetra.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine();
                Console.WriteLine("Digite uma letra: ");
                string letraCentral = (Console.ReadLine()).ToUpper();
                string alfabetoEmString = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
                char[] arrayDeAlfabeto = alfabetoEmString.ToCharArray();
                int letraValor = alfabetoEmString.IndexOf(letraCentral);


                for (int i = 0; i <= letraValor; i++)
                {
                    Console.WriteLine("\n");
                    for (int x = 0; x < letraValor - i; x++)
                    {
                        Console.Write(" ");
                    }
                    for (int z = 0; z < 1; z++)
                    {
                        Console.Write(arrayDeAlfabeto[i]);

                        for (int r = 0; r <= 2 * i - 2; r++)
                        {
                            Console.Write(" ");
                        }

                        if (i != 0)
                        {
                            Console.WriteLine(arrayDeAlfabeto[i]);
                        }
                    }
                }

                for (int i = letraValor - 1; i >= 0; i--)
                {
                    Console.WriteLine("\n");
                    for (int t = 0; t < letraValor - i; t++)
                    {
                        Console.Write(" ");
                    }
                    for (int o = 0; o < 1; o++)
                    {
                        Console.Write(arrayDeAlfabeto[i]);

                        for (int q = 0; q <= 2 * i - 2; q++)
                        {
                            Console.Write(" ");
                        }
                        if (i != 0)
                        {
                            Console.WriteLine(arrayDeAlfabeto[i]);
                        }
                    }
                }
                Console.ReadLine();
            }
        }
    }
}