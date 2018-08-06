using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Remoting.Messaging;
using System.Data.Entity;
using Model;

namespace DAL
{
    #region << 版 本 注 释 >>
    /*----------------------------------------------------------------
	* 类 名 称 ：DBContextFactory
	* 类 描 述 ：
	* 作    者 ：Administrator
	* 创建时间 ：2018/8/6 8:10:08
	* 更新人员 ：
	* 更新时间 ：2018/8/6 8:10:08
	* 版 本 号 ：v1.0.0.0
	*******************************************************************
	* Copyright @ Administrator 2018. All rights reserved.
	*******************************************************************
	*----------------------------------------------------------------*/
    #endregion
    public partial class DBContextFactory
    {
        public static DbContext Create()
        {
            DbContext dbContext = CallContext.GetData("DBContext") as DbContext;
            if (dbContext == null)
            {
                dbContext = new DBContextEntities();
                CallContext.SetData("DBContext", dbContext);
            }
            return dbContext;
        }
    }
}
