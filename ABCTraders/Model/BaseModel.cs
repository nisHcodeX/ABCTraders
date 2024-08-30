﻿using System;

namespace ABCTraders.Model
{
    internal class BaseModel
    {
        public int Id { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
