using System;
using System.Collections.Generic;
using System.Text;
using TGWorkshopCase.Entities.Base;

namespace TGWorkshopCase.Entities.Model
{
    public class TGUser: BaseModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
    }
}
