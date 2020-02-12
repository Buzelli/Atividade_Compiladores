using System;

namespace Atividade_Compiladores
{
    class Program
    {
        static void Main(string[] args)
        {
            string line;
  
            System.IO.StreamReader file = new System.IO.StreamReader(@"D:\Programas_Algoritmos\C#\include.txt");
            System.IO.StreamWriter res = new System.IO.StreamWriter(@"D:\Programas_Algoritmos\C#\resultado.txt");
            while ((line = file.ReadLine()) != null)
            {
                if(line == "include")
                {
                    res.WriteLine("c = 250");
                }
                else
                {
                    res.WriteLine(line);
                }
               
            }

            file.Close();
            res.Close();
            System.Console.ReadLine();

        }
    }
}
