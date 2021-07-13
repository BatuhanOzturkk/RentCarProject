﻿using RentCarProject.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace RentCarProject.Entities.Concrete
{
    public class Brand : IEntity
    {
        public int Id { get; set; }
        public string BrandName { get; set; }
    }
}
