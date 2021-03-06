﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GIR.SIGIMGERENCIAL.Domain;
using GIR.SIGIMGERENCIAL.Domain.Entity;

namespace GIR.SIGIMGERENCIAL.Infrastructure.Data
{
    public interface IQueryableUnitOfWork : IUnitOfWork
    {
        DbSet<TEntity> CreateSet<TEntity>() where TEntity : BaseEntity;
        void Attach<TEntity>(TEntity item) where TEntity : BaseEntity;
        void SetModified<TEntity>(TEntity item) where TEntity : BaseEntity;
        void ApplyCurrentValues<TEntity>(TEntity original, TEntity current) where TEntity : BaseEntity;
    }
}