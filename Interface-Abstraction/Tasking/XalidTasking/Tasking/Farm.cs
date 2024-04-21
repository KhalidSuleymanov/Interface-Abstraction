using System;
using System.Collections.Generic;
using System.Text;

namespace Tasking
{
    internal class Farm : IFarm
    {
        private Animal[] _animals = new Animal[0];
        public Animal[] Animals { get => _animals; set => _animals = value; }

        private int _sheepLimit;
        private byte _horseLimit;

        public int SheepLimit
        {
            set
            {
                if(value < 40)
                {
                    _sheepLimit = value;
                }
            }
            get
            {
               return _sheepLimit;
            }
        }

        public byte HorseLimit
        {
            set
            {
                if(value < 50)
                {
                    _sheepLimit = value;
                }
            }
            get
            {
                return _horseLimit;
            }
        }
        public void AddAnimal(Animal anim)
        {
            Array.Resize(ref _animals, _animals.Length + 1);
            _animals[_animals.Length - 1] = anim;
        }

        public Horse[] GetHorses(Animal[] arr)
        {
            Horse[] arr1 = new Horse[0]; 
            foreach (Animal item in arr)
            {
                if(item is Horse)
                {
                    Array.Resize(ref arr1, arr1.Length + 1);
                    arr1[arr1.Length - 1] = item as Horse;
                }
            }
            return arr1;
        }

        public Sheep[] GetSheeps(Animal[] arr)
        {
            Sheep[] arr2 = new Sheep[0];
            foreach (Animal item in arr)
            {
                if(item is Sheep)
                {
                    Array.Resize(ref arr2, arr2.Length + 1);
                    arr2[arr2.Length - 1] = item as Sheep;
                }
            }
            return arr2;
        }
    }
}

