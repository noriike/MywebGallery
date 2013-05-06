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

            carlst.Add(new Car("アルファード", "3000000", CarMakerType.TOYOTA));
            carlst.Add(new Car("オデッセイ", "2800000", CarMakerType.HONDA));
            carlst.Add(new Car("レガシー", "2870000", CarMakerType.SUBARU));
            carlst.Add(new Car("カローラ", "1800000", CarMakerType.TOYOTA));
            carlst.Add(new Car("エルグランド", "3200000", CarMakerType.NISSAN));
            carlst.Add(new Car("デリカD5", "2500000", CarMakerType.MITSUBISHI));
            carlst.Add(new Car("GT-R", "5000000", CarMakerType.NISSAN));
            carlst.Add(new Car("ROADSTAR", "2300000", CarMakerType.MAZDA));

            return carlst;

        }

    }
}