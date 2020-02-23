using System;
using System.Collections.Generic;
using System.Text;
using TGWorkshopCase.Entities.Base;

namespace TGWorkshopCase.Entities.Model
{
    public class TGSupplierProduct:BaseModel
    {
        public Guid ProductId { get; set; }
        public Guid SupplierId { get; set; }

        public TGProduct TGProduct { get; set; }
        public TGSupplier TGSupplier { get; set; }
    }
}
