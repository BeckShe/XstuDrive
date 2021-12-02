using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XstuDrive.Core.BaseClass;
using XstuDrive.Core.Interfaces;
using System.ComponentModel.DataAnnotations.Schema;
namespace XstuDrive.Domain.Base
{
    /// <summary>
    /// 【用户信息类】
    /// </summary>
    [Table("UserInfo")]
    public class UserInfo : AuditEntity, ISoftDelete
    {
        /// <summary>
        /// 用户名
        /// </summary>
        [MaxLength(20)]
        [Required]
        public string UserName { get; set; }
        /// <summary>
        /// 密码MD5
        /// </summary>
        [MaxLength(32)]
        [Required]
        public string PasswordMd5 { get; set; }
        /// <summary>
        /// 手机号码
        /// </summary>
        public string PhoneNumber { get; set; }
        public bool IsDeleted { get; set; }
    }
}
