﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Hierarchy
{
    public class Tiger : Felime
    {
        public Tiger(string animalName, string animalType, double animalWeight, int foodEaten,
            string livingRegion) : base(animalName,
            animalType, animalWeight, foodEaten, livingRegion)
        {
        }

        public override string ShowAnimal()
        {
            return $"{_animalType} {_animalName}, {_animalWeight}, {_livingRegion}, {_foodEaten}";
        }

        public override string EatFood(Food food)
        {
            if (food is Meat)
            {
                _foodEaten += food._quantity;
                return $"{_animalType} {_animalName} {_animalWeight}, {_livingRegion}, {_foodEaten}";
            }
            else
            {
                return $"{_animalType} is not eating that type of food!";
            }
        }

        public override string MakeSound()
        {
            return "Roarrr...";
        }
    }
}
