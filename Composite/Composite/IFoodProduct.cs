﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    // Component - FoodProduct
    interface IFoodProduct
    {
        void Display();
        decimal GetPrice();
    }
}
