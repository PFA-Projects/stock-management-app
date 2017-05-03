using System;
using System.Data.Entity;
using App.Gwin.Entities;
using App.Gwin.Application.BAL;
using StockManagement.DAL;

namespace StockManagement.BAL
{
    public class BaseBLO<T> : GwinBaseBLO<T> ,IGwinBaseBLO where T : BaseEntity
    {
     
        #region construcreur
        public BaseBLO(DbContext context):base(context)
        {
            this.Context = (ModelContext) context;
            if (this.Context == null) this.Context = new ModelContext();

            this.DbSet = this.Context.Set<T>();
            this.TypeEntity = typeof(T);
        }
        public BaseBLO() : this(null) { }
        #endregion

        #region Context
 
        public override void Dispose()
        {
            if (this.Context != null)
            {
                this.Context.Dispose();
            }
        }
        #endregion

        #region CreateInstance
        public override object CreateEntityInstance()
        {
            return this.Context.Set<T>().Create();
        }

        /// <summary>
        /// Creating an instance of the Service object from the entity type
        /// </summary>
        /// <param name="TypeEntity">the entity type</param>
        /// <returns></returns>
        public override IGwinBaseBLO CreateServiceBLOInstanceByTypeEntity(Type TypeEntity)
        {
            Type TypeEntityService = typeof(BaseBLO<>).MakeGenericType(TypeEntity);
            IGwinBaseBLO EntityService = (IGwinBaseBLO)Activator.CreateInstance(TypeEntityService, this.Context);
            return EntityService;
        }
        /// <summary>
        /// Creating an instance of the Service object from the entity type and Context
        /// </summary>
        /// <param name="TypeEntity">the entity type</param>
        /// <param name="context">the context</param>
        /// <returns></returns>
        public virtual IGwinBaseBLO CreateServiceBLOInstanceByTypeEntityAndContext(Type TypeEntity, DbContext context)
        {

            Type TypeEntityService = typeof(BaseBLO<>).MakeGenericType(TypeEntity);
            IGwinBaseBLO EntityService = (IGwinBaseBLO)Activator.CreateInstance(TypeEntityService, context);
            return EntityService;
        }
        #endregion

       

    }
}
