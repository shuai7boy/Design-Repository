using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;

namespace RYJ.Repository
{
    public class Repository<TEntity>:IRepository<TEntity> where TEntity:class
    {

        //获取仓储上下文的实例
        [Import] //命名空间是:System.ComponentModel.Composition

        /// <summary>
        /// 上面是获取上下文操作，下面是继承来的方法
        /// </summary>
    
        public IQueryable<TEntity> Entities
        {
            get { throw new NotImplementedException(); }
        }

        public int Insert(TEntity entity, bool isSave = true)
        {
            throw new NotImplementedException();
        }

        public int Insert(IEnumerable<TEntity> entities, bool isSave = true)
        {
            throw new NotImplementedException();
        }

        public int Delete(object id, bool isSave = true)
        {
            throw new NotImplementedException();
        }

        public int Delete(IEnumerable<TEntity> entity, bool isSave = true)
        {
            throw new NotImplementedException();
        }

        public int Delete(System.Linq.Expressions.Expression<Func<TEntity, bool>> whereDelete, bool isSave = true)
        {
            throw new NotImplementedException();
        }

        public bool UpDate(TEntity entity, bool isSave = true)
        {
            throw new NotImplementedException();
        }

        public TEntity GetByKey(object key)
        {
            throw new NotImplementedException();
        }
    }
}
