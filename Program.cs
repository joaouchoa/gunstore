using System;
using gunstore.Classes;
using gunstore.Enumeraveis;
using gunstore.Repository;

namespace gunstore // Note: actual namespace depends on the project name.
{
    public class Program
    {
        static GunRepository repository = new GunRepository();
        public static void Main(string[] args)
        {
            string option = GetOption();

            while(option.ToUpper() != "X")
            {
                switch(option)
                {
                    case "1":
                        GunList();
                        break;
                    case "2":
                        break;
                    case "3":
                        break;
                    case "4":
                        break;
                    case "5":
                        break;
                    case "c":
                        break;
                    default:
                        Console.WriteLine("Digite a opção correta. \n");
                        break;
                        
                }
            }
        }
        
        public static void PutGun()
        {
            Console.WriteLine("Adding Gun");

            foreach(int i in Enum.GetValues(typeof(ECalibre)))
                Console.WriteLine("{0}-{1}", i, Enum.GetName(typeof(ECalibre), i));

            Console.WriteLine("Digite o Calibre da sua arma: ");
            int calibre = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o Modelo da Arma: ");
            string modelo = Console.ReadLine();

            Console.WriteLine("Digite a Fabricante: ");
            string fabricante = Console.ReadLine(); 

            Console.WriteLine("Digite a Capacidade: ");
            int capacidade = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o Numero de Série: ");
            string numeroDeSerie = Console.ReadLine();

            Gun newGun = new Gun(fabricante: fabricante,
                                id: repository.NextId(),
                                calibre: (ECalibre)calibre,
                                capacidade: capacidade,
                                modelo: modelo,
                                numeroDeSerie: numeroDeSerie
                                );

            repository.Put(repository.NextId(), newGun);
        }
        
        private static void GunList()
        {
            Console.WriteLine("Listing Guns");

            var list = repository.List();

            if(list.Count == 0)
            {
                Console.WriteLine("Nenhuma série Cadastrada");
            }
            else
            {
                foreach(var gun in list)
                {
                    Console.WriteLine("#ID {0}; - {1}", gun.retornaId(), gun.retornaModelo());
                }
            }


        }
        private static string GetOption()
        {
            Console.WriteLine("");
            Console.WriteLine("Wellcome to GunStore");
            Console.WriteLine("aproveite o ambiente");

            Console.WriteLine("1 - para listar o catalogo de armas: ");
            Console.WriteLine("2 - para adicionar mais uma arma: ");
            Console.WriteLine("3 - para atualizar um cadastro de arma: ");
            Console.WriteLine("4 - para deletar um registro de arma.");
            Console.WriteLine("5 - Inspecionar um Armamento: ");
            Console.WriteLine("C - para limpar a tela: ");
            Console.WriteLine("X - para deixar a loja");
            Console.WriteLine("");

            string option = Console.ReadLine().ToUpper();
            Console.WriteLine("");
            return option;
        }
    }
}