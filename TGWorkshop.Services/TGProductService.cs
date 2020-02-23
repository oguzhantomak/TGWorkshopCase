using System;
using System.Collections.Generic;
using System.Text;
using TGWorkshop.Services.Base;
using TGWorkshop.Services.Contracts;
using TGWorkshopCase.Context;
using TGWorkshopCase.Entities.Model;

namespace TGWorkshop.Services
{
    public class TGProductService:BaseService<TGProduct>, ITGProductService
    {
        private TGWorkshopContext _context;
        public TGProductService(TGWorkshopContext context) : base(context)
        {
            this._context = context;
        }
    }
}
