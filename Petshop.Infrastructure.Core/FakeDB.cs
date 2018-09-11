using Petshop.Core.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Petshop.Infrastructure.Core
{
    public class FakeDB
    {
        public static List<Pet> Pets;
        public static List<Owner> OwnersList;

        public static void InitializeData()
        {
            var Pet1 = new Pet()
            {
                Id = 1,
                Type = "Dog",
                Name = "Fido",
                Color = "Brown",
                PreviousOwner = "Hans Hansen",
                Birthdate = new DateTime(2015, 6, 2),
                SoldDate = DateTime.Now,
                Price = 500
            };

            var Pet2 = new Pet()
            {
                Id = 2,
                Type = "Cat",
                Name = "Bigglesworth",
                Color = "white",
                PreviousOwner = "Dr. Evil",
                Birthdate = new DateTime(2014, 2, 14),
                SoldDate = DateTime.Now,
                Price = 1000000

            };
            var Pet3 = new Pet()
            {
                Id = 3,
                Type = "Bird",
                Name = "Charlie",
                Color = "Red",
                PreviousOwner = "Captain Hook",
                Birthdate = new DateTime(2017, 11, 30),
                SoldDate = DateTime.Now,
                Price = 200
            };
                var Pet4 = new Pet()
                {
                    Id = 4,
                    Type = "Dog",
                    Name = "Fluffy",
                    Color = "Brown",
                    PreviousOwner = "Hagrid",
                    Birthdate = new DateTime(2016, 7, 21),
                    SoldDate = DateTime.Now,
                    Price = 2000,
                };
             var Pet5 = new Pet()
            {
                Id = 5,
                Type = "Cat",
                Name = "Tigger",
                Color = "Orange",
                PreviousOwner = "Winnie",
                Birthdate = new DateTime(2010, 8, 4),
                 SoldDate = DateTime.Now,
                Price = 300,
            };

            var Pet6 = new Pet()
            {
                Id = 6,
                Type = "Fish",
                Name = "Goldie",
                Color = "Yellow",
                PreviousOwner = "Frederik",
                Birthdate = new DateTime(2018, 8, 22),
                SoldDate = DateTime.Now,
                Price = 400,
            };

            var Pet7 = new Pet()
            {
                Id = 7,
                Type = "Goat",
                Name = "Lykketoft",
                Color = "Grey",
                PreviousOwner = "Helle Thorning",
                Birthdate = new DateTime(2018, 8, 31),
                SoldDate = DateTime.Now,
                Price = 650,
            };

            var Pet8 = new Pet()
            {
                Id = 8,
                Type = "Hedgehog",
                Name = "Sonic",
                Color = "Blue",
                PreviousOwner = "Mad Max",
                Birthdate = new DateTime(2014, 3, 25),
                SoldDate = DateTime.Now,
                Price = 350,
            };

            var Pet9 = new Pet()
            {
                Id = 9,
                Type = "Cat",
                Name = "Floofball",
                Color = "Grey",
                PreviousOwner = "Sam Darnold",
                Birthdate = new DateTime(2012, 9, 16),
                SoldDate = DateTime.Now,
                Price = 450,
            };

            Pets = new List<Pet> { Pet1, Pet2, Pet3, Pet4, Pet5, Pet6, Pet7, Pet8, Pet9 };

            var Owner1 = new Owner()

            {
                FirstName = "Kenny",
                id = 99,
                LastName = "Powers",
                Email = "kp@powers.dk",
                PhoneNumber = "28882291",
                Address = "Sunset Boulevard 666"
                


            };
            var Owner2 = new Owner()

            {
                FirstName = "Frederik",
                id = 99,
                LastName = "Tubæk",
                Email = "Frederiker12@hotmail.com",
                PhoneNumber = "29427511",
                Address = "Norgesgade 99"



            };

            var Owner3 = new Owner()

            {
                FirstName = "Daniel",
                id = 99,
                LastName = "Rasmussen",
                Email = "Helpimadad@hotmail.com",
                PhoneNumber = "99214280",
                Address = "Saabygade 78"



            };

            OwnersList = new List<Owner>{Owner1, Owner2, Owner3};
        }

    }
}

