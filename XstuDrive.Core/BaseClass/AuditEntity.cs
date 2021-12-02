using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XstuDrive.Core.BaseClass
{
    public class AuditEntity
    {
        /// <summary>
        /// ID
        /// </summary>
        [Key]
        public Guid Id { get; set; } = Guid.NewGuid();
        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime CreationTime { get; set; } = DateTime.Now;
        /// <summary>
        /// 修改时间
        /// </summary>
        public DateTime ModifiedTime { get; set; }
    }
}
