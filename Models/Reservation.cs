using System;
using System.ComponentModel.DataAnnotations;

namespace UdemyCourse_WebApiCoffeeShop.Models
{
    public class Reservation
    {
        public int Id { get; set; }
        //[Required]
        public string Name { get; set; }
        //[Required]
        //[RegularExpression(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$")]
        //[DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        //[Required]
        //[RegularExpression("^[0-9]*$")]
        public string Phone { get; set; }
        //[Required]
        public int TotalPeople { get; set; }
        //[Required]
        public DateTime Date { get; set; }
        //[Required]
        //[DataType(DataType.Time)]
        public string Time { get; set; }
    }
}