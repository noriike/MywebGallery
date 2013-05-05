using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MywebGallery.resources.Data.car
{
    public class Car
    {
        public static String Id { set; get; }

        public string CarId { get; set; }

        public String Name { set; get; }

        public String Price { get; set; }

        public CarMaker Maker { get; set; }

        public String ImagePath { get; set; }

        public Car()
        {
            
        }

        public Car(string name, string price, CarMaker maker)
        {
            if (Id == null)
            {
                Id = "0";
            }

            Id =(int.Parse(Id) + 1).ToString();
            this.CarId = Id;
            this.Name = name;
            this.Price = price;
            this.Maker = maker;
        }

    }
}