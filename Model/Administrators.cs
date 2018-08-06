using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
    #region << 版 本 注 释 >>
    /*----------------------------------------------------------------
	* 类 名 称 ：Administrators
	* 类 描 述 ：
	* 作    者 ：Administrator
	* 创建时间 ：2018/8/6 8:30:47
	* 更新人员 ：
	* 更新时间 ：2018/8/6 8:30:47
	* 版 本 号 ：v1.0.0.0
	*******************************************************************
	* Copyright @ Administrator 2018. All rights reserved.
	*******************************************************************
	*----------------------------------------------------------------*/
    #endregion
   public class Administrators
    {
        public int Id { get; set; }

        public string AccountName { get; set; }

        public string Pwd { get; set; }

        public int Type { get; set; }

        public DateTime LoginTime { get; set; }

        public DateTime CreateTime { get; set; }

    }
}
