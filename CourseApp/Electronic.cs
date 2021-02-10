using System;

namespace CourseApp
{
    public enum EnumOC
    {
        Windows,
        Linux,
        MacOS,
        IOS,
        Android
    }

    public enum EnumBrand
    {
        Acer,
        Apple,
        Microsoft,
        Dell,
        IBM,
        Honor
    }

    public abstract class Electronic
    {
        private string brand;
        private string oc;
        private int ram;

        public Electronic()
        : this("?", "?", 0)
        {
        }

        public Electronic(string newBrand)
        : this(newBrand, "?", 0)
        {
        }

        public Electronic(string newBrand, string newOC)
        : this(newBrand, newOC, 0)
        {
        }

        public Electronic(string newBrand, string newOC, int newRAM)
        {
            this.Brand = newBrand;
            this.OC = newOC;
            this.RAM = newRAM;
        }

        public virtual string Brand
        {
            get
            {
                return brand;
            }

            set
            {
                foreach (EnumBrand b in Enum.GetValues(typeof(EnumBrand)))
                {
                    if (value == b.ToString())
                    {
                        brand = value;
                        break;
                    }
                }
            }
        }

        public virtual string OC
        {
            get
            {
                return oc;
            }

            set
            {
                foreach (EnumOC b in Enum.GetValues(typeof(EnumOC)))
                {
                    if (value == b.ToString())
                    {
                        oc = value;
                        break;
                    }
                }
            }
        }

        public virtual int RAM
        {
            get
            {
                return ram;
            }

            set
            {
                if (value < 1)
                {
                    Console.WriteLine("RAM неисправна");
                }
                else
                {
                    ram = value;
                }
            }
        }

        public override string ToString()
        {
            return $"Brand: {Brand}\n  OC: {OC}\n  RAM: {RAM}";
        }

        public virtual void SetInfo(string newBrand, string newOC, int newRAM)
        {
                Brand = newBrand;
                OC = newOC;
                RAM = newRAM;
        }

        public abstract string Start();
    }
}