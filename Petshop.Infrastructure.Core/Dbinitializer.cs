using Petshop.Core.Entity;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace Petshop.Infrastructure.Data
{
    public class Dbinitializer
    {

        public static void SeedDB(PetAppContext ptx)
        {
            ptx.Database.EnsureDeleted();
            ptx.Database.EnsureCreated();

            var Owner1 = ptx.Owners.Add(new Owner()

            {
                FirstName = "Kenny",
                id = 99,
                LastName = "Powers",
                Email = "kp@powers.dk",
                PhoneNumber = "28882291",
                Address = "Sunset Boulevard 666"



            }).Entity;
            var Owner2 = ptx.Owners.Add(new Owner()

            {
                FirstName = "Frederik",
                id = 82,
                LastName = "Tubæk",
                Email = "Frederiker12@hotmail.com",
                PhoneNumber = "29427511",
                Address = "Norgesgade 99"



            }).Entity;

            var Owner3 = ptx.Owners.Add(new Owner()

            {
                FirstName = "Daniel",
                id = 84,
                LastName = "Rasmussen",
                Email = "Helpimadad@hotmail.com",
                PhoneNumber = "99214280",
                Address = "Saabygade 78"



            }).Entity;
            var Pet1 = ptx.Pets.Add(new Pet()
            {
                Id = 1,
                Type = "Dog",
                Name = "Fido",
                Color = "Brown",
                PreviousOwner = Owner1,
                Birthdate = new DateTime(2015, 6, 2),
                SoldDate = DateTime.Now,
                Price = 500
            });

            var Pet2 = ptx.Pets.Add(new Pet()
            {
                Id = 2,
                Type = "Cat",
                Name = "Bigglesworth",
                Color = "white",
                PreviousOwner = Owner2,
                Birthdate = new DateTime(2014, 2, 14),
                SoldDate = DateTime.Now,
                Price = 1000000

            });
            var Pet3 = ptx.Pets.Add(new Pet()
            {
                Id = 3,
                Type = "Bird",
                Name = "Charlie",
                Color = "Red",
                PreviousOwner = Owner1,
                Birthdate = new DateTime(2017, 11, 30),
                SoldDate = DateTime.Now,
                Price = 200
            });
            var Pet4 = ptx.Pets.Add(new Pet()
            {
                Id = 4,
                Type = "Dog",
                Name = "Fluffy",
                Color = "Brown",
                PreviousOwner = Owner1,
                Birthdate = new DateTime(2016, 7, 21),
                SoldDate = DateTime.Now,
                Price = 2000,
            });
            var Pet5 = ptx.Pets.Add(new Pet()
            {
                Id = 5,
                Type = "Cat",
                Name = "Tigger",
                Color = "Orange",
                PreviousOwner = Owner2,
                Birthdate = new DateTime(2010, 8, 4),
                SoldDate = DateTime.Now,
                Price = 300,
            });

            var Pet6 = ptx.Pets.Add(new Pet()
            {
                Id = 6,
                Type = "Fish",
                Name = "Goldie",
                Color = "Yellow",
                PreviousOwner = Owner1,
                Birthdate = new DateTime(2018, 8, 22),
                SoldDate = DateTime.Now,
                Price = 400,
            });

            var Pet7 = ptx.Pets.Add(new Pet()
            {
                Id = 7,
                Type = "Goat",
                Name = "Lykketoft",
                Color = "Grey",
                PreviousOwner = Owner2,
                Birthdate = new DateTime(2018, 8, 31),
                SoldDate = DateTime.Now,
                Price = 650,
            });

            var Pet8 = ptx.Pets.Add(new Pet()
            {
                Id = 8,
                Type = "Hedgehog",
                Name = "Sonic",
                Color = "Blue",
                PreviousOwner = Owner1,
                Birthdate = new DateTime(2014, 3, 25),
                SoldDate = DateTime.Now,
                Price = 350,
            });

            var Pet9 = ptx.Pets.Add(new Pet()
            {
                Id = 9,
                Type = "Cat",
                Name = "Floofball",
                Color = "Grey",
                PreviousOwner = Owner2,
                Birthdate = new DateTime(2012, 9, 16),
                SoldDate = DateTime.Now,
                Price = 450,
            });

           

            ptx.SaveChanges();
        }
    }
}
