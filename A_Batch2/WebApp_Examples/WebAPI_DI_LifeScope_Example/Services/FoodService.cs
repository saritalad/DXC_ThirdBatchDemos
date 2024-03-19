using System;
using System.Collections.Generic;

namespace WebAPI_DI_LifeScope_Example.Services
{
    public class FoodService:iFoodService
    {
        private readonly int _randomId;
        private readonly Dictionary<int, string> _foodDictionary = new()
        {
            { 1, "South Indian 🍲 " },
            { 2, "North Indian 🍲" },
            { 3, "Veg Food 🍲" },
            { 4, "Continental 🍲" },
            {5,"Chineese 🍲" }
        };
        public FoodService()
        {
            _randomId = new Random().Next(1, 5);
        }

        public string GetDish()

        { return _foodDictionary[_randomId]; }
    }

    public interface iFoodService
    {
        string GetDish();


    }

}
