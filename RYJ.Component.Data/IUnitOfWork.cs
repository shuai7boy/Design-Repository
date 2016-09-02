using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RYJ.Component.Data
{
    public interface IUnitOfWork
    {
        #region 属性
        //获取当前单元操作是否已被提交
        bool IsCommitted { get; }
        //提交当前单元操作的结果
        int Commit();
        //回滚成未提交状态
        void Rollback();
        #endregion
    }
}
