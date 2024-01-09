using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.BuilderDesignPattern
{
    internal class MealBuilder
    {
        public string mainCourse;
        public string sideDish;
        public string drink;

        public void BuildMainCourse(string main)
        {
            this.mainCourse = main;
        }
        public void BuildSideDish(string side)
        {
            this.sideDish = side;
        }
        public void BuildDrink(string drink)
        {
            this.drink = drink;
        }
        public string Build()
        {
            return mainCourse + sideDish + drink;
        }
    }
}
