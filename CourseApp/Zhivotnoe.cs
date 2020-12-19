using System;
 
namespace CourseApp {
    public abstract class Zhivotnoe {
        private string name;
        private string breed;
        private int age;
 
        public Zhivotnoe()
        : this(" ", " ", 0) { }
 
        public Zhivotnoe(string newName)
        : this(newName, " ", 0) { }
 
        public Zhivotnoe(string newName, string newBreed)
        : this(newName, newBreed, 0) { }
 
        public Zhivotnoe(string newName, string newBreed, int newAge) {
            this.Name = newName;
            this.Breed = newBreed;
            this.Age = newAge;
        }
 
        public virtual string Name {
            get {
                return name;
            }
 
            set {
                if (value.Length < 3) {
                    name = "Неизвестно";
                } else {
                    name = value;
                }
            }
        }
 
        public virtual string Breed {
            get {
                return breed;
            }
 
            set {
                if (value.Length < 3) {
                    breed = "Неизвестна";
                } else {
                    breed = value;
                }
            }
        }
 
        public virtual int Age {
            get {
                return age;
            }
 
            set {
                if (value < 0) {
                    Console.WriteLine("Возраст неизвестен");
                } else {
                    age = value;
                }
            }
        }
 
        public override string ToString() => $"Name: {Name}  Breed: {Breed}  Age: {Age}";
 
        public virtual void EditInf(string newName, string newBreed, int newAge) {
            Name = newName;
            Breed = newBreed;
            Age = newAge;
        }
 
        public abstract string Vois();
    }
 
    public class Rabbit : Zhivotnoe {
        public Rabbit()
        : base() { }
 
        public Rabbit(string newName)
        : base(newName) { }
 
        public Rabbit(string newName, string newBreed)
        : base(newName, newBreed) { }
 
        public Rabbit(string newName, string newBreed, int newAge)
        : base(newName, newBreed, newAge) { }
 
        public override string ToString() => $"Rabbit:\nName: {Name}  Breed: {Breed}  Age: {Age}";
 
        public override string Vois() => "*Фы *\n";
    }
}