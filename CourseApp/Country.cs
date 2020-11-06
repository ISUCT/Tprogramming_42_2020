using System;

namespace CourseApp
{
    public class Country
    {
        private int population;
        private int area;
        private double density;

        public Country()
        {
            Console.WriteLine($"Население, площадь и плоность не заданы");
        }

        public Country(int population, int area, double density)
        {
            this.Population = population;
            this.Area = area;
            this.Density = density;
        }

        public int Population
        {
            get
            {
                return population;
            }

            set
            {
                if (value == 0)
                {
                    Console.WriteLine($"Население равна 0");
                }
                else
                {
                    population = value;
                }
            }
        }

        public int Area
        {
            get
            {
                return area;
            }

            set
            {
                if (value == 0)
                {
                    Console.WriteLine($"Площадь равна 0");
                }
                else
                {
                    area = value;
                }
            }
        }

        public double Density
        {
            get
            {
                return density;
            }

            set
            {
                if (value == 0)
                {
                    Console.WriteLine($"Плотность равна 0");
                }
                else
                {
                    density = value;
                }
            }
        }

        public void AllInfo()
        {
            {
                Console.WriteLine($"Насление: {this.population}, площадь: {this.area}, плотность: {this.density} ");
            }
        }

        public void PopulationInfo()
        {
            Console.WriteLine($"Население: {this.population}");
        }

        public void AreaInfo()
        {
            Console.WriteLine($"Площадь: {this.area}");
        }

        public void DensityInfo()
        {
            Console.WriteLine($"Плотность населения: {this.density}");
        }
    }
}