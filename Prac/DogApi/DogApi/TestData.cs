using DogApi.Contexts;
using DogApi.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;

namespace DogApi
{
    public class TestData
    {
        public void AddTestData(DogDBContext dogDBContext)
        {
            var listOfDogos = new List<Dog>();

            var dog = new Dog();
            dog.Id = 1;
            dog.Breed = Enums.DogBreed.JackRussel;
            dog.Name = "Kiko";
            dog.IsCute = true;
            dog.IsEducated = true;
            dog.IsSmart = true;
            dog.Image = File.ReadAllBytes(Path.Combine(Directory.GetCurrentDirectory(), "./Images/kiko.jpg"));
            dog.SmallImage = File.ReadAllBytes(Path.Combine(Directory.GetCurrentDirectory(), "./Images/resized/kiko.jpg"));
            listOfDogos.Add(dog);

            var dog1 = new Dog();
            dog1.Id = 2;
            dog1.Breed = Enums.DogBreed.JackRussel;
            dog1.Name = "Sparta";
            dog1.IsCute = true;
            dog1.IsEducated = true;
            dog1.IsSmart = true;
            dog1.Image = File.ReadAllBytes(Path.Combine(Directory.GetCurrentDirectory(), "./Images/Sparta.jpg"));
            dog1.SmallImage = File.ReadAllBytes(Path.Combine(Directory.GetCurrentDirectory(), "./Images/resized/Sparta.jpg"));
            listOfDogos.Add(dog1);

            var dog2 = new Dog();
            dog2.Id = 3;
            dog2.Breed = Enums.DogBreed.JackRussel;
            dog2.Name = "Sparko";
            dog2.IsCute = true;
            dog2.IsEducated = true;
            dog2.IsSmart = true;
            dog2.Image = File.ReadAllBytes(Path.Combine(Directory.GetCurrentDirectory(), "./Images/Sparko.jpg"));
            dog2.SmallImage = File.ReadAllBytes(Path.Combine(Directory.GetCurrentDirectory(), "./Images/resized/Sparko.jpg"));
            listOfDogos.Add(dog2);

            var dog3 = new Dog();
            dog3.Id = 4;
            dog3.Breed = Enums.DogBreed.Mix;
            dog3.Name = "Flying dogo";
            dog3.IsEducated = true;
            dog3.Image = File.ReadAllBytes(Path.Combine(Directory.GetCurrentDirectory(), "./Images/0.jpg"));
            dog3.SmallImage = File.ReadAllBytes(Path.Combine(Directory.GetCurrentDirectory(), "./Images/resized/0.jpg"));
            listOfDogos.Add(dog3);

            var dog4 = new Dog();
            dog4.Id = 5;
            dog4.Breed = Enums.DogBreed.Unknown;
            dog4.Name = "Sleeping fluf";
            dog4.IsCute = true;
            dog4.Image = File.ReadAllBytes(Path.Combine(Directory.GetCurrentDirectory(), "./Images/1.jpg"));
            dog4.SmallImage = File.ReadAllBytes(Path.Combine(Directory.GetCurrentDirectory(), "./Images/resized/1.jpg"));
            listOfDogos.Add(dog4);

            var dog5 = new Dog();
            dog5.Id = 6;
            dog5.Breed = Enums.DogBreed.Unknown;
            dog5.Name = "Double trouble";
            dog5.IsCute = true;
            dog5.Image = File.ReadAllBytes(Path.Combine(Directory.GetCurrentDirectory(), "./Images/2.jpg"));
            dog5.SmallImage = File.ReadAllBytes(Path.Combine(Directory.GetCurrentDirectory(), "./Images/resized/2.jpg"));
            listOfDogos.Add(dog5);

            var dog6 = new Dog();
            dog6.Id = 7;
            dog6.Breed = Enums.DogBreed.Unknown;
            dog6.Name = "Poopo";
            dog6.IsCute = true;
            dog6.Image = File.ReadAllBytes(Path.Combine(Directory.GetCurrentDirectory(), "./Images/3.jpg"));
            dog6.SmallImage = File.ReadAllBytes(Path.Combine(Directory.GetCurrentDirectory(), "./Images/resized/3.jpg"));
            listOfDogos.Add(dog6);

            var dog7 = new Dog();
            dog7.Id = 8;
            dog7.Breed = Enums.DogBreed.GermanShepherd;
            dog7.Name = "Rex";
            dog7.IsCute = true;
            dog7.IsEducated = true;
            dog7.IsSmart = true;
            dog7.Image = File.ReadAllBytes(Path.Combine(Directory.GetCurrentDirectory(), "./Images/4.jpg"));
            dog7.SmallImage = File.ReadAllBytes(Path.Combine(Directory.GetCurrentDirectory(), "./Images/resized/4.jpg"));
            listOfDogos.Add(dog7);

            var dog8 = new Dog();
            dog8.Id = 9;
            dog8.Breed = Enums.DogBreed.Unknown;
            dog8.Name = "Fluf";
            dog8.IsCute = true;
            dog8.IsEducated = true;
            dog8.Image = File.ReadAllBytes(Path.Combine(Directory.GetCurrentDirectory(), "./Images/5.jpg"));
            dog8.SmallImage = File.ReadAllBytes(Path.Combine(Directory.GetCurrentDirectory(), "./Images/resized/5.jpg"));
            listOfDogos.Add(dog8);

            var dog9 = new Dog();
            dog9.Id = 10;
            dog9.Breed = Enums.DogBreed.GoldenRetriever;
            dog9.Name = "Smiley";
            dog9.IsCute = true;
            dog9.Image = File.ReadAllBytes(Path.Combine(Directory.GetCurrentDirectory(), "./Images/6.jpg"));
            dog9.SmallImage = File.ReadAllBytes(Path.Combine(Directory.GetCurrentDirectory(), "./Images/resized/6.jpg"));
            listOfDogos.Add(dog9);

            var dog10 = new Dog();
            dog10.Id = 11;
            dog10.Breed = Enums.DogBreed.Unknown;
            dog10.Name = "Covid";
            dog10.IsCute = true;
            dog10.Image = File.ReadAllBytes(Path.Combine(Directory.GetCurrentDirectory(), "./Images/7.jpg"));
            dog10.SmallImage = File.ReadAllBytes(Path.Combine(Directory.GetCurrentDirectory(), "./Images/resized/7.jpg"));
            listOfDogos.Add(dog10);

            var dog11 = new Dog();
            dog11.Id = 12;
            dog11.Breed = Enums.DogBreed.Unknown;
            dog11.Name = "Brownie";
            dog11.IsCute = true;
            dog11.Image = File.ReadAllBytes(Path.Combine(Directory.GetCurrentDirectory(), "./Images/8.jpg"));
            dog11.SmallImage = File.ReadAllBytes(Path.Combine(Directory.GetCurrentDirectory(), "./Images/resized/8.jpg"));
            listOfDogos.Add(dog11);

            var dog12 = new Dog();
            dog12.Id = 13;
            dog12.Breed = Enums.DogBreed.Unknown;
            dog12.Name = "Darkie";
            dog12.IsCute = true;
            dog12.IsSmart = true;
            dog12.Image = File.ReadAllBytes(Path.Combine(Directory.GetCurrentDirectory(), "./Images/9.jpg"));
            dog12.SmallImage = File.ReadAllBytes(Path.Combine(Directory.GetCurrentDirectory(), "./Images/resized/9.jpg"));
            listOfDogos.Add(dog12);

            var dog13 = new Dog();
            dog13.Id = 14;
            dog13.Breed = Enums.DogBreed.GoldenRetriever;
            dog13.Name = "Goldie";
            dog13.IsCute = true;
            dog13.Image = File.ReadAllBytes(Path.Combine(Directory.GetCurrentDirectory(), "./Images/10.jpg"));
            dog13.SmallImage = File.ReadAllBytes(Path.Combine(Directory.GetCurrentDirectory(), "./Images/resized/10.jpg"));
            listOfDogos.Add(dog13);

            var dog14 = new Dog();
            dog14.Id = 15;
            dog14.Breed = Enums.DogBreed.Unknown;
            dog14.Name = "Jumpie";
            dog14.IsCute = true;
            dog14.IsEducated = true;
            dog14.IsSmart = true;
            dog14.Image = File.ReadAllBytes(Path.Combine(Directory.GetCurrentDirectory(), "./Images/11.jpg"));
            dog14.SmallImage = File.ReadAllBytes(Path.Combine(Directory.GetCurrentDirectory(), "./Images/resized/11.jpg"));
            listOfDogos.Add(dog14);

            var dog15 = new Dog();
            dog15.Id = 16;
            dog15.Breed = Enums.DogBreed.GoldenRetriever;
            dog15.Name = "K12";
            dog15.IsEducated = true;
            dog15.IsSmart = true;
            dog15.Image = File.ReadAllBytes(Path.Combine(Directory.GetCurrentDirectory(), "./Images/12.jpg"));
            dog15.SmallImage = File.ReadAllBytes(Path.Combine(Directory.GetCurrentDirectory(), "./Images/resized/12.jpg"));
            listOfDogos.Add(dog15);

            var dog16 = new Dog();
            dog16.Id = 17;
            dog16.Breed = Enums.DogBreed.Unknown;
            dog16.Name = "Satellite ears";
            dog16.IsCute = true;
            dog16.IsEducated = true;
            dog16.IsSmart = true;
            dog16.Image = File.ReadAllBytes(Path.Combine(Directory.GetCurrentDirectory(), "./Images/13.jpg"));
            dog16.SmallImage = File.ReadAllBytes(Path.Combine(Directory.GetCurrentDirectory(), "./Images/resized/13.jpg"));
            listOfDogos.Add(dog16);

            var dog17 = new Dog();
            dog17.Id = 18;
            dog17.Breed = Enums.DogBreed.GoldenRetriever;
            dog17.Name = "Big foot";
            dog17.IsCute = true;
            dog17.IsSmart = true;
            dog17.Image = File.ReadAllBytes(Path.Combine(Directory.GetCurrentDirectory(), "./Images/14.jpg"));
            dog17.SmallImage = File.ReadAllBytes(Path.Combine(Directory.GetCurrentDirectory(), "./Images/resized/14.jpg"));
            listOfDogos.Add(dog17);

            var dog18 = new Dog();
            dog18.Id = 19;
            dog18.Breed = Enums.DogBreed.GermanShepherd;
            dog18.Name = "K11";
            dog18.IsEducated = true;
            dog18.IsSmart = true;
            dog18.Image = File.ReadAllBytes(Path.Combine(Directory.GetCurrentDirectory(), "./Images/15.jpg"));
            dog18.SmallImage = File.ReadAllBytes(Path.Combine(Directory.GetCurrentDirectory(), "./Images/resized/15.jpg"));
            listOfDogos.Add(dog18);

            var dog19 = new Dog();
            dog19.Id = 20;
            dog19.Breed = Enums.DogBreed.Unknown;
            dog19.Name = "Hades";
            dog19.IsEducated = true;
            dog19.Image = File.ReadAllBytes(Path.Combine(Directory.GetCurrentDirectory(), "./Images/16.jpg"));
            dog19.SmallImage = File.ReadAllBytes(Path.Combine(Directory.GetCurrentDirectory(), "./Images/resized/16.jpg"));
            listOfDogos.Add(dog19);

            var dog20 = new Dog();
            dog20.Id = 21;
            dog20.Breed = Enums.DogBreed.GoldenRetriever;
            dog20.Name = "Pancake";
            dog20.IsCute = true;
            dog20.IsSmart = true;
            dog20.Image = File.ReadAllBytes(Path.Combine(Directory.GetCurrentDirectory(), "./Images/17.jpg"));
            dog20.SmallImage = File.ReadAllBytes(Path.Combine(Directory.GetCurrentDirectory(), "./Images/resized/17.jpg"));
            listOfDogos.Add(dog20);

            var dog21 = new Dog();
            dog21.Id = 22;
            dog21.Breed = Enums.DogBreed.GoldenRetriever;
            dog21.Name = "Lemonade";
            dog21.IsCute = true;
            dog21.Image = File.ReadAllBytes(Path.Combine(Directory.GetCurrentDirectory(), "./Images/18.jpg"));
            dog21.SmallImage = File.ReadAllBytes(Path.Combine(Directory.GetCurrentDirectory(), "./Images/resized/18.jpg"));
            listOfDogos.Add(dog21);

            var dog22 = new Dog();
            dog22.Id = 23;
            dog22.Breed = Enums.DogBreed.Mix;
            dog22.Name = "Buddy";
            dog22.IsCute = true;
            dog22.IsEducated = true;
            dog22.IsSmart = true;
            dog22.Image = File.ReadAllBytes(Path.Combine(Directory.GetCurrentDirectory(), "./Images/19.jpg"));
            dog22.SmallImage = File.ReadAllBytes(Path.Combine(Directory.GetCurrentDirectory(), "./Images/resized/19.jpg"));
            listOfDogos.Add(dog22);

            var dog23 = new Dog();
            dog23.Id = 24;
            dog23.Breed = Enums.DogBreed.Unknown;
            dog23.Name = "Rocky";
            dog23.IsCute = true;
            dog23.IsEducated = true;
            dog23.Image = File.ReadAllBytes(Path.Combine(Directory.GetCurrentDirectory(), "./Images/20.jpg"));
            dog23.SmallImage = File.ReadAllBytes(Path.Combine(Directory.GetCurrentDirectory(), "./Images/resized/20.jpg"));
            listOfDogos.Add(dog23);

            var dog24 = new Dog();
            dog24.Id = 25;
            dog24.Breed = Enums.DogBreed.GoldenRetriever;
            dog24.Name = "Leo";
            dog24.IsCute = true;
            dog24.IsEducated = true;
            dog24.Image = File.ReadAllBytes(Path.Combine(Directory.GetCurrentDirectory(), "./Images/21.jpg"));
            dog24.SmallImage = File.ReadAllBytes(Path.Combine(Directory.GetCurrentDirectory(), "./Images/resized/21.jpg"));
            listOfDogos.Add(dog24);

            var dog25 = new Dog();
            dog25.Id = 26;
            dog25.Breed = Enums.DogBreed.JackRussel;
            dog25.Name = "Milo";
            dog25.IsCute = true;
            dog25.IsEducated = true;
            dog25.IsSmart = true;
            dog25.Image = File.ReadAllBytes(Path.Combine(Directory.GetCurrentDirectory(), "./Images/22.jpg"));
            dog25.SmallImage = File.ReadAllBytes(Path.Combine(Directory.GetCurrentDirectory(), "./Images/resized/22.jpg"));
            listOfDogos.Add(dog25);

            var dog26 = new Dog();
            dog26.Id = 27;
            dog26.Breed = Enums.DogBreed.Mix;
            dog26.Name = "Lucky";
            dog26.IsCute = true;
            dog26.IsEducated = true;
            dog26.IsSmart = true;
            dog26.Image = File.ReadAllBytes(Path.Combine(Directory.GetCurrentDirectory(), "./Images/23.jpg"));
            dog26.SmallImage = File.ReadAllBytes(Path.Combine(Directory.GetCurrentDirectory(), "./Images/resized/23.jpg"));
            listOfDogos.Add(dog26);

            var dog27 = new Dog();
            dog27.Id = 28;
            dog27.Breed = Enums.DogBreed.Mix;
            dog27.Name = "Copper";
            dog27.IsCute = true;
            dog27.IsSmart = true;
            dog27.Image = File.ReadAllBytes(Path.Combine(Directory.GetCurrentDirectory(), "./Images/24.jpg"));
            dog27.SmallImage = File.ReadAllBytes(Path.Combine(Directory.GetCurrentDirectory(), "./Images/resized/24.jpg"));
            listOfDogos.Add(dog27);

            var dog28 = new Dog();
            dog28.Id = 29;
            dog28.Breed = Enums.DogBreed.Mix;
            dog28.Name = "Bruno";
            dog28.IsEducated = true;
            dog28.IsSmart = true;
            dog28.Image = File.ReadAllBytes(Path.Combine(Directory.GetCurrentDirectory(), "./Images/25.jpg"));
            dog28.SmallImage = File.ReadAllBytes(Path.Combine(Directory.GetCurrentDirectory(), "./Images/resized/25.jpg"));
            listOfDogos.Add(dog28);

            var dog29 = new Dog();
            dog29.Id = 30;
            dog29.Breed = Enums.DogBreed.Unknown;
            dog29.Name = "Goodie";
            dog29.IsCute = true;
            dog29.Image = File.ReadAllBytes(Path.Combine(Directory.GetCurrentDirectory(), "./Images/26.jpg"));
            listOfDogos.Add(dog29);

            var dog30 = new Dog();
            dog30.Id = 31;
            dog30.Breed = Enums.DogBreed.Unknown;
            dog30.Name = "Benji";
            dog30.IsCute = true;
            dog30.IsEducated = true;
            dog30.Image = File.ReadAllBytes(Path.Combine(Directory.GetCurrentDirectory(), "./Images/27.jpg"));
            listOfDogos.Add(dog30);

            dogDBContext.Dogos.AddRange(listOfDogos);
            dogDBContext.SaveChanges();
        }
    }
}
