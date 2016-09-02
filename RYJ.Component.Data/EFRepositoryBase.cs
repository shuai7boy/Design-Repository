using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;

namespace RYJ.Component.Data
{
    public class EFRepositoryBase<TEntity>:IRepository<TEntity> where TEntity:class
    {
        //获取 仓储上下文的实例
        [Import]
        public IUnitOfWork UnitOfWork { get; set; }


        #region 从接口继承来的内容
        /// <summary>
        /// 获取当前实体查询的数据集
        /// </summary>
        public IQueryable<TEntity> Entites
        {
            get { throw new NotImplementedException(); }
        }

        public int Insert(TEntity entity, bool isSave = true)
        {
            throw new NotImplementedException();
        }

        public int Insert(IEnumerable<TEntity> entites, bool isSave = true)
        {
            throw new NotImplementedException();
        }

        public int Delete(object id, bool isSave = true)
        {
            throw new NotImplementedException();
        }

        public int Delete(TEntity entity, bool isSave = true)
        {
            throw new NotImplementedException();
        }

        public int Delete(IEnumerable<TEntity> entities, bool isSave = true)
        {
            throw new NotImplementedException();
        }

        public int Delete(System.Linq.Expressions.Expression<Func<TEntity, bool>> deleteLambda, bool isSave = true)
        {
            throw new NotImplementedException();
        }

        public int Upldate(TEntity entity, bool isSave = true)
        {
            throw new NotImplementedException();
        }

        public TEntity GetByKey(object key)
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
