using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MywebGallery.resources.Data.car
{
    public class CarDao
    {

        public CarCollection Load()
        {
            CarCollection carlst = new CarCollection();

            carlst.Add(new Car("アルファード", "3000000", CarMaker.TOYOTA));
            carlst.Add(new Car("オデッセイ", "2800000", CarMaker.HONDA));
            carlst.Add(new Car("レガシー", "2870000", CarMaker.SUBARU));
            carlst.Add(new Car("カローラ", "1800000", CarMaker.TOYOTA));
            carlst.Add(new Car("エルグランド", "3200000", CarMaker.NISSAN));
            carlst.Add(new Car("デリカD5", "2500000", CarMaker.MITSUBISHI));
            carlst.Add(new Car("GT-R", "5000000", CarMaker.NISSAN));
            carlst.Add(new Car("ROADSTAR", "2300000", CarMaker.MAZDA));

            return carlst;

        }

    }
}