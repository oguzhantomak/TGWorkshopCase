using System;
using System.Collections.Generic;
using System.Text;

namespace TGWorkshopCase.Entities.Base
{
    public class BaseModel: IBaseModel
    {
        public Guid Id { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
    }
}
