﻿using AutoMapper;
using Carpool.Model;
using Carpool.Model.Requests;
using Carpool.WebAPI.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Carpool.WebAPI.Services
{
    public class AutomobilService : BaseCRUDService<Model.Automobil, AutomobilSearchRequest, Database.Automobil, AutomobilInsertRequest, AutomobilInsertRequest>
    {
        public AutomobilService(CarpoolContext context, IMapper mapper) : base(context, mapper)
        {
        }
        public override List<Model.Automobil> Get(AutomobilSearchRequest request)
        {
            var query = _context.Autmobili.AsQueryable();

            if (!string.IsNullOrWhiteSpace(request?.Naziv))
            {
                query = query.Where(x => x.Naziv.StartsWith(request.Naziv));
            }
            if (!string.IsNullOrWhiteSpace(request?.Model))
            {
                query = query.Where(x => x.Model.StartsWith(request.Model));
            }
            if (!string.IsNullOrWhiteSpace(request?.Godiste))
            {
                query = query.Where(x => x.Godiste.StartsWith(request.Godiste));
            }

            var result = query.ToList();

            return _mapper.Map<List<Model.Automobil>>(result);
        }
        public override Model.Automobil Insert(AutomobilInsertRequest request)
        {
            var entity = _mapper.Map<Database.Automobil>(request);
            entity.VozacID = 15;
            entity.IsAktivan = true;

            _context.Autmobili.Add(entity);
            _context.SaveChanges();

            return _mapper.Map<Model.Automobil>(entity);
        }
    }
}