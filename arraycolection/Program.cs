using System;

namespace arraycolection
{
    class Program
    {
        static void Main(string[] args)
        {
          //string [] alunosams = new string [5]  {
              //"pedro",
              //"bruno",
              //"duda",
              //"vitu",
              //"lucas"
          //};

          //Console.WriteLine(alunosams[2]);

          //alunosams[2] = "Julia";

         // Console.WriteLine($"o novo valor do index 2 {alunosams[2]}");

           //foreach (string aluno in alunosams)
           //{
           //    Console.WriteLine(aluno);
          // }

          string [] alunosams = new string [5];
          alunosams[0] = "Pedro";
          alunosams[1] = "Bruno";
          alunosams[2] = "Julia";
          alunosams[3] = "Vitu";
          alunosams[4] = "Lucas";

          Console.WriteLine(alunosams[2]);

          alunosams[2] = "Duda";

          Console.WriteLine($"o novo valor do index 2 {alunosams[2]}");

          for (int i = 0; i < alunosams.Length; i++)
          {
               Console.WriteLine($" Os nomes são : {alunosams[i]}");
          }
          
        }
    }
}
