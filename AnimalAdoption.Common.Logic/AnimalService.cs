using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalAdoption.Common.Logic
{
    public class AnimalService
    {
        public Animal[] ListAnimals => new Animal[] {
            new Animal { Id = 1, Name = "Yeonil Jeong", Age = 30, Description = "차장" },
            new Animal { Id = 2, Name = "Areum Han", Age = 29, Description = "대리" },
            new Animal { Id = 3, Name = "Jieun Kim", Age = 28, Description = "사원" }
        };
    }
}
