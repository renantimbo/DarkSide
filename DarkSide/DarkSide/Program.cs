using DarkSide.Context;
using System;


namespace DarkSide
{
    class Program
    {
        public static void Main()
        {
            var context = new FilmesDbContext();

            //código para criar o banco
            //foreach(var diretor in context.Diretores)
            //{
            //    Console.WriteLine(diretor.Nome);
            //}
        }
    }
}
