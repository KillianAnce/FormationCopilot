using System;

namespace Entity
{
    public class CarEntity
    {
        // Add an id property
        public int Id { get; set; }
        public string? FullName { get; set;}
        public int FuelCharge { get; set; }
        public int HorsesPower { get; set; }
        public bool ExtraInsurance { get; set; }
        public string? Type { get; set; }
        public string? Brand { get; set; }
        public string ? Color { get; set; }
    


    //     private static readonly string[] Brand =
    // [
    //     "Opel", "Peugeot", "Citroen", "Kia", "Volkswagen", "Smart", "Lotus", "BMW", "Ferrari", "Toyota"
    // ];

    // private static readonly string[] Type =
    // [
    //     "Citadine", "Berline", "4x4", "Sport"
    // ];

       
    }
}