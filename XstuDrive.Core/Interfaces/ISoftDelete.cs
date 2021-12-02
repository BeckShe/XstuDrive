using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XstuDrive.Core.Interfaces
{
    public interface ISoftDelete
    {
        /// <summary>
        /// 是否删除
        /// </summary>
        bool IsDeleted { get; set; }
    }
}
