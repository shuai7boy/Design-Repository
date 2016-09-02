using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace RYJ.Component.Data
{
    public interface IRepository<TEntity> where TEntity:class
    {
        #region 属性
        //获取当前实体查询的数据集
        IQueryable<TEntity> Entites { get; }
        #endregion
        #region 公共方法
        //添加一个实体
        int Insert(TEntity entity,bool isSave=true);
        //添加多个实体类
        int Insert(IEnumerable<TEntity> entites,bool isSave=true);

        //根据主键删除一个实体
        int Delete(object id,bool isSave=true);
        //单个删除
        int Delete(TEntity entity,bool isSave=true);
        //批量删除
        int Delete(IEnumerable<TEntity> entities,bool isSave=true);
        //根据条件删除
        int Delete(Expression<Func<TEntity, bool>> deleteLambda,bool isSave=true);
        //修改实体
        int Upldate(TEntity entity,bool isSave=true);
        //根据指定主键查询实体
        TEntity GetByKey(object key);

        #endregion
    }
}
