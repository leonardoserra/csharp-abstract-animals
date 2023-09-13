﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_abstract_animals.Interfaces
{
    internal interface ICanSwim
    {
        public void StartSwimming(ICanSwim animal);
    }
}
