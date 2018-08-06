using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Model;
using IBLL;
using DAL;
using System.Linq.Expressions;

namespace BLL
{
    #region << 版 本 注 释 >>
    /*----------------------------------------------------------------
	* 类 名 称 ：AdministratorsService
	* 类 描 述 ：
	* 作    者 ：Administrator
	* 创建时间 ：2018/8/6 8:48:31
	* 更新人员 ：
	* 更新时间 ：2018/8/6 8:48:31
	* 版 本 号 ：v1.0.0.0
	*******************************************************************
	* Copyright @ Administrator 2018. All rights reserved.
	*******************************************************************
	*----------------------------------------------------------------*/
    #endregion
    public partial class AdministratorsService : BaseService<Administrators>, IAdministratorsService
    {
        //private IAdministratorsDAL AdminDAL = DALContainer.Container.Resolve<IAdministratorsDAL>();

        public override void SetDal()
        {
            //Dal = AdminDAL;
            this.Dal = new AdministratorsDAL();
        }
    }
}
