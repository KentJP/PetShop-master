using Microsoft.Extensions.DependencyInjection;
using Petshop;
using Petshop.Core.ApplicationService;
using Petshop.Core.DomainService;
using Petshop.Core.Entity;
using Petshop.Infrastructure.Core;
using Petshop.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Net.Sockets;


namespace Petshop
{
    public class Printer : IPrinter
    {
        public readonly IPetService _petService;

        public Printer(IPetService petService)
        {
            _petService = petService;
            StartUI();
        }

        static void Main(string[] args)
        {
            FakeDB.InitializeData();
            var serviceCollection = new ServiceCollection();
            serviceCollection.AddScoped<IPetRepository, PetRepository>();
            serviceCollection.AddScoped<IPetService, PetService>();
            serviceCollection.AddScoped<IPrinter, Printer>();


            var serviceProvider = serviceCollection.BuildServiceProvider();
            var printer = serviceProvider.GetRequiredService<IPrinter>();
            printer.StartUI();

        }

        public void StartUI()
        {
            string[] menuItems =
            {
                "List All Pets",
                "Add Pet",
                "Delete Pet",
                "Update Pet",
                "List of Pets sorted by price",
                "List of Pets sorted by type",
                "Exit"
            };

            var selection = ShowMenu(menuItems);

            while (selection != 7)
            {
                switch (selection)
                {
                    case 1:
                        ShowPets();
                        break;
                    case 2:
                        AddPet();
                        break;
                    case 3:
                        var deleteId = SortById();
                        _petService.Delete(deleteId);
                        break;
                    case 4:
                        Console.WriteLine("Update Pet");
                        var idEdit = SortById();
                        var petToEdit = _petService.SortById(idEdit);
                        
                      
                        Console.WriteLine("Updating " + petToEdit.Name + " " + petToEdit.Price);
                        var newName = AskQuestion("Name:");
                        var newPrice = AskQuestion("Price");
                        var newType = AskQuestion("Race:");
                        _petService.Update(new Pet()
                    {
                        Name = newName,
                        Price = double.Parse(newPrice),
                        Type = newType,


                    }, petToEdit);
                        break;
                    case 5:
                        Console.WriteLine("Cheapest Pets");
                        GetCheapestPets();
                        break;
                    case 6:
                        var sortedList = SortByType();
                        foreach (var pet in sortedList)
                        {
                            Console.WriteLine(pet.Type +" name: " +pet.Name + " price: " + pet.Price);
                        }

                        break;

                }

                selection = ShowMenu(menuItems);
            }

            Console.WriteLine("Bye bye!");

            Console.ReadLine();
        }

        private List<Pet> SortByType()
        {
            return _petService.SortByType();
        }

        private void GetCheapestPets()
        {
            var cheapestPets = _petService.GetCheapestPets();
            foreach (var pet in cheapestPets)
            {
                Console.WriteLine("Pet: " + pet.Name + " Price: " + pet.Price + " type: " + pet.Type);
            }


        }

        



        private void AddPet()
        {
            var pet = _petService.GetPetInstance();
            Console.Write("Type a Pet name");
            pet.Name = Console.ReadLine();
            Console.WriteLine("Type Race");
            pet.Type = Console.ReadLine();
            Console.WriteLine("Type the color");
            pet.Color = Console.ReadLine();
           
            
            pet.SoldDate = DateTime.Now;
            Console.WriteLine("Type the sale price");
            double price;
            while (!double.TryParse(Console.ReadLine(), out price)
                   || price > 5000000
                   || price < 10)
            {
                Console.WriteLine("Please select a number between 10.000 - 5.000.000");
            }
            
           
            var petAdded = _petService.Create(pet);
            if (petAdded.Id > 0)
            {
                Console.WriteLine("Pet has been added");
            }
        }

        int ShowMenu(string[] menuItems)
        {
            Console.WriteLine("Select What you want to do on the list:\n");

            for (int i = 0; i < menuItems.Length; i++)
            {
                //Console.WriteLine((i + 1) + ":" + menuItems[i]);
                Console.WriteLine($"{(i + 1)}: {menuItems[i]}");
            }

            int selection;
            while (!int.TryParse(Console.ReadLine(), out selection)
                   || selection < 1
                   || selection > 6)
            {
                Console.WriteLine("Please select a number between 1-5");
            }

            return selection;
        }

        private void ShowPets()
        {
            var ListOfPets = _petService.GetAllPets();

            foreach (var Pet in ListOfPets)
            {
                Console.WriteLine("Id: {0}\nColor: {1}\nName: {2}\nPrice: {3}\nType: {4}\nBirthdate: {5}",
                    Pet.Id, Pet.Color, Pet.Name, Pet.Price, Pet.Type, Pet.Birthdate);
            }

        }

        int SortById()
        {
            Console.WriteLine("Insert Pet Id: ");
            int id;
            while (!int.TryParse(Console.ReadLine(), out id))
            {
                Console.WriteLine("Please insert a number");
            }

            return id;

        }
        string AskQuestion(string question)
        {
            Console.WriteLine(question);
            return Console.ReadLine();
        }




    }
}

    
