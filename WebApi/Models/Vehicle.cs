namespace WebApi.Models;

public class Vehicle
{
      
      public int Id { get; set; } 
      public string Type { get; set; }
     
      
      
      public  class Car : Vehicle
      {
            public int CarId { get; set; }
            public string Color { get; set; }
            public bool Headlights { get; set; }
            public int Wheels { get; set; }
            
      }
      
      public class Bus : Vehicle
      {
            public string Color { get; set; }
            public int BusId { get; set; }
      }
      
      public class Boat : Vehicle
      {
            public int BoatId { get; set; }
            public string Color { get; set; }
      }


      
}