﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Entities;

namespace Entities.Concrete
{
   public class CarImage:IEntity
    {
        public int Id { get; set; }
        public int CarId { get; set; }
        public string Image { get; set; }
        public DateTime Date { get; set; }
    }
}
