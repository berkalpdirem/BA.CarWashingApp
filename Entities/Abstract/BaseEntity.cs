﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BA.CarWashingApp.Entity.Abstract
{
    public abstract class BaseEntity : IEntity
    {
        public int ID { get; set; }
    }
}
