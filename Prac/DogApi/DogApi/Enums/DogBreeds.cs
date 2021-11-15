using System.ComponentModel.DataAnnotations;

namespace DogApi.Enums
{
    public enum DogBreed
    {
        All, 
        None,
        [Display(Name = "Jack Russell")]
        JackRussel,
        [Display(Name = "German Shepherd")]
        GermanShepherd,
        Mix,
        [Display(Name = "Golden Retriever")]
        GoldenRetriever,
        Husky,
        Unknown
    }
}
