using GunStore.Enumerable;
using GunStore.Model;
using GunStore.Repository;
using System;

namespace GunStore
{
    public class Program
    {
        static GunRepository repository = new GunRepository();
        public static void Main(string[] args)
        {
            string option = "";

            while (option.ToUpper() != "X")
            {
                option = GetOption();
                switch (option)
                {
                    case "1":
                        GunList();
                        break;
                    case "2":
                        CreateGun();
                        break;
                    case "3":
                        PutGun();
                        break;
                    case "4":
                        DeleteGun();
                        break;
                    case "5":
                        GunListById();
                        break;
                    case "c":
                        Console.Clear();
                        break;
                    default:
                        Console.WriteLine("Digite a opção correta. \n");
                        break;

                }
            }
        }

        public static void PutGun()
        {
            Console.WriteLine("Digite o Id que você quer atualizar: ");
            int ident = int.Parse(Console.ReadLine());

            foreach (int i in Enum.GetValues(typeof(ECalibre)))
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

            repository.Put(ident, newGun);
        }
        public static void CreateGun()
        {
            Console.WriteLine("Adding Gun");

            foreach (int i in Enum.GetValues(typeof(ECalibre)))
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

            repository.Create(newGun);
        }

        public static void DeleteGun() 
        {
            Console.WriteLine("Digite o Id que você quer deletar: ");
            int ident = int.Parse(Console.ReadLine());

            repository.Delete(ident);
        }

        private static void GunListById() 
        {
            Console.WriteLine("Digite o Id que você quer deletar: ");
            int id = int.Parse(Console.ReadLine());

            Console.WriteLine("Listing Gun By Id");
            var list = repository.List();

            if (list.Count == 0)
            {
                Console.WriteLine("Nenhuma arma Cadastrada");
            }
            else
            {
                foreach (var gun in list)
                {
                    if (gun.id == id && gun.Active == true) 
                    {
                        Console.WriteLine(gun.ToString());
                    }
                }
            }

        }
        private static void GunList()
        {
            Console.WriteLine("Listing Guns");

            var list = repository.List();

            if (list.Count == 0)
            {
                Console.WriteLine("Nenhuma arma Cadastrada");
            }
            else
            {
                foreach (var gun in list)
                {
                    if (gun.Active == true)
                    {
                        Console.WriteLine("#ID {0}; - {1}", gun.retornaId(), gun.retornaModelo());
                    }
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
