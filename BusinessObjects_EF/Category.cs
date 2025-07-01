﻿using System;
using System.Collections.Generic;

namespace BusinessObjects_EF;

public partial class Category
{
    public int CategoryId { get; set; }

    public string CategoryName { get; set; } = null!;

    public virtual ICollection<Product> Products { get; set; } = new List<Product>();
    public override string ToString()
    {
        return CategoryId+"\t"+CategoryName;
    }
}
