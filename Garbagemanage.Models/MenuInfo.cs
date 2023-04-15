﻿using Common.CustAttributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garbagemanage.Models
{
    /// <summary>
    /// 菜单信息类
    /// </summary>
    [Table("MenuInfos")]
    [PrimaryKey("MenuId", autoIncrement = true)]
    public class MenuInfo
    {
       /// <summary>
       /// 菜单编号
       /// </summary>
        public int Menuld { get; set; }
        /// <summary>
        /// 菜单名称
        /// </summary>
        public string MenuName { get; set; }
        /// <summary>
        /// 父编号
        /// </summary>
        public int Parentld { get; set; }
        /// <summary>
        /// 快捷键
        /// </summary>
        public string MKey { get; set; }
        /// <summary>
        /// 页面名称
        /// </summary>
        public string FrmURL { get; set; }
        /// <summary>
        /// 排序号
        /// </summary>
        public int MOrder { get; set; }
    }
}
