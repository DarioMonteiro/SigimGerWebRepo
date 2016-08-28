using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GIR.SIGIMGERENCIAL.Domain.Entity;
using GIR.SIGIMGERENCIAL.Domain.Entity.Admin;
using GIR.SIGIMGERENCIAL.Infrastructure.Data;
using GIR.SIGIMGERENCIAL.Infrastructure.Data.Configuration.Admin;
using GIR.SIGIMGERENCIAL.Infrastructure.Data.Configuration.Comum;
using GIR.SIGIMGERENCIAL.Infrastructure.Data.Configuration.Gerencial;

namespace GIR.SIGIMGERENCIAL.Infrastructure.Data
{
    public class UnitOfWork : DbContext, IQueryableUnitOfWork
    {
        #region Constructor

        public UnitOfWork()
            : base("DefaultConnection")
        {
            //Database.SetInitializer<UnitOfWork>(new DropCreateDatabaseIfModelChanges<UnitOfWork>());
            //Database.SetInitializer(new DropCreateDatabaseAlways<UnitOfWork>());
        }

        #endregion

        #region IQueryableUnitOfWork Members

        public DbSet<TEntity> CreateSet<TEntity>() where TEntity : BaseEntity
        {
            return base.Set<TEntity>();
        }

        public void Attach<TEntity>(TEntity item) where TEntity : BaseEntity
        {
            base.Entry<TEntity>(item).State = System.Data.Entity.EntityState.Unchanged;
        }

        public void SetModified<TEntity>(TEntity item) where TEntity : BaseEntity
        {
            if (base.Entry<TEntity>(item).State == System.Data.Entity.EntityState.Detached)
            {
                var oldItem = base.Set<TEntity>().Find(item.Id);
                ApplyCurrentValues<TEntity>(oldItem, item);
            }
            else
            {
                base.Entry<TEntity>(item).State = System.Data.Entity.EntityState.Modified;
            }
        }

        public void ApplyCurrentValues<TEntity>(TEntity original, TEntity current) where TEntity : BaseEntity
        {
            base.Entry<TEntity>(original).CurrentValues.SetValues(current);
        }

        public void Commit()
        {
            try
            {
                base.SaveChanges();
            }
            catch(Exception ex)
            {
                this.RollbackChanges();
                throw ex;
            }
        }

        public void RollbackChanges()
        {
            base.ChangeTracker.Entries()
                              .ToList()
                              .ForEach(entry => entry.State = System.Data.Entity.EntityState.Unchanged);
        }

        #endregion

        #region DbContext Overrides

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();

            modelBuilder.Properties<string>()
                .Configure(p => p.HasColumnType("varchar"));

            #region Admin

            modelBuilder.Configurations.Add(new ModuloConfiguration());
            modelBuilder.Configurations.Add(new PerfilConfiguration());
            modelBuilder.Configurations.Add(new PerfilFuncionalidadeConfiguration());
            modelBuilder.Configurations.Add(new UsuarioConfiguration());
            modelBuilder.Configurations.Add(new UsuarioFuncionalidadeConfiguration());
            modelBuilder.Configurations.Add(new UsuarioPerfilConfiguration());
            //modelBuilder.Configurations.Add(new UnidadeFederacaoConfiguration());

            #endregion

            #region Comum

            modelBuilder.Configurations.Add(new LogAcessoConfiguration());
            modelBuilder.Configurations.Add(new LogOperacaoConfiguration());

            #endregion

            #region Gerencial

            modelBuilder.Configurations.Add(new AnaliseInadimplenciaConfiguration());
            modelBuilder.Configurations.Add(new AnaliseRecebiveisConfiguration());
            modelBuilder.Configurations.Add(new CentroCustoConfiguration());
            modelBuilder.Configurations.Add(new ComercialConfiguration());
            modelBuilder.Configurations.Add(new DespesaConfiguration());
            modelBuilder.Configurations.Add(new FluxoFinanceiroConfiguration());
            modelBuilder.Configurations.Add(new ReceitaConfiguration());
            modelBuilder.Configurations.Add(new ValorPotencialConfiguration());
            modelBuilder.Configurations.Add(new ValorPotencialLiquidoConfiguration());

            #endregion

        }

        #endregion
    }
}