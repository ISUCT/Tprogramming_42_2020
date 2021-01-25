using System;

namespace CourseApp
{
        public abstract class Weapon
        {
            private string model;
            private int caliber;

            public Weapon()
            : this (" ", 0, 0)
            {
            }

            public Weapon(string newmodel)
            : this(newmodel, 0, 0)
            {
            }

            public Weapon(string newmodel, int newcaliber)
            : this(newmodel, newcaliber, 0)
            {
            }

            public Weapon(string newmodel, int newcaliber, int newClip)
            {
                this.model = newmodel;
                this.caliber = newcaliber;
                this.Clip = newClip;
            }

            public virtual string Model
            {
                get
                {
                    return model;
                }

                set
                {
                    if (value.Length < 3)
                    {
                        model = "Неизвестно";
                    }
                    else
                    {
                        model = value;
                    }
                }
            }

            public virtual int Caliber
            {
                get
                {
                    return caliber;
                }

                set
                {
                    if (value < 0)
                    {
                        caliber = 0;
                    }
                    else
                    {
                        caliber = value;
                    }
                }
            }

            public virtual int Clip { get; set; }

            public override string ToString() => $"model: {model}  caliber: {caliber}  Clip: {Clip}";

            public virtual void EditInf(string newmodel, int newcaliber, int newClip)
            {
                    model = newmodel;
                    caliber = newcaliber;
                    Clip = newClip;
            }

            public abstract string Shot();
        }
}