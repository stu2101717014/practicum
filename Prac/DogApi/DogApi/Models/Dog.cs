using DogApi.Attributes;
using DogApi.Enums;
using System.ComponentModel.DataAnnotations;

namespace DogApi.Models
{
    public class Dog
    {
        [Key]
        public int Id { get; set; }


        public string Name { get; set; }


        public byte[] Image { get; set; }

        public byte[] SmallImage { get; set; }

        [DogExportableAttr]
        public bool IsSmart { get; set; }

        [DogExportableAttr]
        public bool IsEducated { get; set; }

        [DogExportableAttr]
        public bool IsCute { get; set; }


        public DogBreed Breed { get; set; }
    }
}
