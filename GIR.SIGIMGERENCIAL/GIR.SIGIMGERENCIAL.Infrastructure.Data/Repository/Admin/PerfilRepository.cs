﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Data.Entity;
using System.Text;
using System.Threading.Tasks;
using GIR.SIGIMGERENCIAL.Domain.Entity.Admin;
using GIR.SIGIMGERENCIAL.Domain.Repository.Admin;
using GIR.SIGIMGERENCIAL.Domain.Specification;

namespace GIR.SIGIMGERENCIAL.Infrastructure.Data.Repository.Admin
{
    public class PerfilRepository : Repository<Perfil>, IPerfilRepository
    {
        #region Constructor

        public PerfilRepository(UnitOfWork unitOfWork)
            : base(unitOfWork)
        {

        }

        #endregion

        #region IPerfilRepository Members

        public List<Perfil> ListarPeloModulo(int moduloId)
        {
            return QueryableUnitOfWork.CreateSet<Perfil>().Where(l => l.ModuloId == moduloId).ToList<Perfil>();
        }

        public override IEnumerable<Perfil> ListarPeloFiltroComPaginacao(
            ISpecification<Perfil> specification,
            int pageIndex,
            int pageCount,
            string orderBy,
            bool ascending,
            out int totalRecords,
            params Expression<Func<Perfil, object>>[] includes)
        {
            var set = CreateSetAsQueryable(includes);

            set = set.Where(specification.SatisfiedBy());

            totalRecords = set.Count();

            switch (orderBy)
            {
                case "id":
                    set = ascending ? set.OrderBy(l => l.Id) : set.OrderByDescending(l => l.Id);
                    break;
                case "descricao":
                    set = ascending ? set.OrderBy(l => l.Descricao) : set.OrderByDescending(l => l.Descricao);
                    break;
                case "codigo":
                default:
                    set = ascending ? set.OrderBy(l => l.Id) : set.OrderByDescending(l => l.Id);
                    break;
            }

            return set.Skip(pageCount * pageIndex).Take(pageCount);
        }

        #endregion
    }
}