﻿using System;
using System.Collections.Generic;
using System.Text;

namespace TGWorkshopCase.Entities.Base
{
    public interface IBaseModel
    {
       Guid Id { get; set; }
       DateTime CreatedDate { get; set; }
       DateTime UpdatedDate { get; set; }
    }
}
