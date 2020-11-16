using System;

namespace Desafio
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Aqui estão os nomes dos professores de cada categoria: ");
            Console.WriteLine("*Ronaldo Gomes = Categoria: Infantil A");
            Console.WriteLine("*Arthur Sena = Categoria: Infantil B");
            Console.WriteLine("*Jorge Antunes = Categoria: Juvenil A");
            Console.WriteLine("*Julio Gonçalves = Categoia: Juvenil B");
            Console.WriteLine("*Paulo Borges = Categoria: Sênior");

            Console.WriteLine("---------------------------------------------------");

            Console.WriteLine("Olá! Aqui faremos uma rápida avaliação para saber em qual categoria você se encaixa, digite sua idade:  ");
            int idade = int.Parse(Console.ReadLine());

            if(idade>=5 && idade <=7){
                Console.WriteLine("Você vai para a categoria Infantil A, com o professor Ronaldo Gomes");
            } else{
                if(idade >=8 && idade <=10){
                    Console.WriteLine("Você irá para a categoria Infantil B, com o professor Arthur Sena");
                } else{
                    if(idade >=11 && idade <=13){
                        Console.WriteLine("Você vai para a categoria Juvenil A, com o professor Jorge Antunes");
                    } else{
                        if(idade >=14 && idade <=17){
                            Console.WriteLine("Você vai para a categoria JUvenil B, com o professor Julio Gonçalves");
                        } else{
                            if(idade >=18){
                                Console.WriteLine("Você vai para a categoria Sênior, com o professor Paulo Borges");
                            }
                        }
                    }
                }
            }

        }
    }
}
