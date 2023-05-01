﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator_Facade
{
    // Concrete decorator class
    class Ardei : ToppingDecorator
    {
        public Ardei(FoodItem foodItem) : base(foodItem)
        {
        }

        public override string GetDescription()
        {
            return foodItem.GetDescription() + ", Ardei";
        }

        public override double GetPrice()
        {
            return foodItem.GetPrice() + 5.00;
        }
    }
}