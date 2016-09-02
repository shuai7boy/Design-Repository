using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace RYJ.Repository
{
    public interface IRepository<TEntity> where TEntity:class
    {
        //获取当前实体查询数据集
        IQueryable<TEntity> Entities { get; }
        //插入实体记录
        int Insert(TEntity entity,bool isSave=true);
        //批量插入实体记录
        int Insert(IEnumerable<TEntity> entities, bool isSave = true);
        //删除指定编号的记录
        int Delete(object id, bool isSave = true);
        //删除实体记录
        int Delete(IEnumerable<TEntity> entity, bool isSave = true);
        //删除所有符合指定表达式的记录
        int Delete(Expression<Func<TEntity, bool>> whereDelete, bool isSave = true);
        //更新实体记录
        bool UpDate(TEntity entity, bool isSave = true);
        //查找指定主键的实体记录
        TEntity GetByKey(object key);
    }
}