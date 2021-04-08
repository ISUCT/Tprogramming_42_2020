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
            Console.WriteLine($"Население, площадь и плотность не заданы");
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

        public override string ToString()
        {
            return $"Population = {Population}, Area = {Area}, Density = {Density}";
        }

        public void AllInfo()
        {
            {
                Console.WriteLine($"Насление: {population.ToString()}, площадь: {area.ToString()}, плотность: {density.ToString()} ");
            }
        }

        public void PopulationInfo()
        {
            Console.WriteLine($"Население: {population.ToString()}");
        }

        public void AreaInfo()
        {
            Console.WriteLine($"Площадь: {area.ToString()}");
        }

        public void DensityInfo()
        {
            Console.WriteLine($"Плотность населения: {density.ToString()}");
        }
    }
}