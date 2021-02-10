using System;

namespace CourseApp
{
    public class Computer : Electronic
    {
        public Computer()
        : base()
        {
        }

        public Computer(string newBrand)
        : base(newBrand)
        {
        }

        public Computer(string newBrand, string newOC)
        : base(newBrand, newOC)
        {
        }

        public Computer(string newBrand, string newOC, int newRAM)
        : base(newBrand, newOC, newRAM)
        {
        }

        public override string ToString()
        {
            return $"Computer:\n  Brand: {Brand}\n  OC: {OC}\n  RAM: {RAM}";
        }

        public void SetRAM(int newRAM)
        {
            RAM = newRAM;
        }

        public string GetRAM()
        {
            return $"RAM {RAM}";
        }

        public override void SetInfo(string newBrand, string newOC, int newRAM)
        {
            base.SetInfo(newBrand, newOC, newRAM);
        }

        public override string Start()
        {
            return $"Запуск\n";
        }
    }
}