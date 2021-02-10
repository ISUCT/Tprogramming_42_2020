using System;

namespace CourseApp
{
    public class Smartphone : Electronic
    {
        public Smartphone()
        : base()
        {
        }

        public Smartphone(string newBrand)
        : base(newBrand)
        {
        }

        public Smartphone(string newBrand, string newOC)
        : base(newBrand, newOC)
        {
        }

        public Smartphone(string newBrand, string newOC, int newRAM)
        : base(newBrand, newOC, newRAM)
        {
        }

        public override string ToString()
        {
            return $"Smartphone:\n  Brand: {Brand}\n  OC: {OC}\n  RAM: {RAM}";
        }

        public override void SetInfo(string newBrand, string newOC, int newRAM)
        {
            base.SetInfo(newBrand, newOC, newRAM);
        }

        public override string Start()
        {
            return "Включение\n";
        }
    }
}