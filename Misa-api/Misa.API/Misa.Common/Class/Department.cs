using System;
using System.Collections.Generic;
using System.Text;

namespace Misa.Common.Class
{
    public class Department
    {
        #region Properties

        /// <summary>
        /// Khóa chính 
        /// </summary>
        public Guid DepartmentId { get; set; }

        /// <summary>
        /// Mã phòng ban
        /// </summary>
        public String DepartmentCode { get; set; }

        /// <summary>
        /// Tên phòng ban
        /// </summary>
        public String DepartmentName { get; set; }

        /// <summary>
        /// Miêu tả
        /// </summary>
        public String Description { get; set; }

        /// <summary>
        /// Ngày tạo
        /// </summary>
        public DateTime CreatedDate { get; set; }

        /// <summary>
        /// Tạo bởi
        /// </summary>
        public String CreatedBy { get; set; }

        /// <summary>
        /// Ngày sửa đổi
        /// </summary>
        public DateTime ModifiedDate { get; set; }

        /// <summary>
        /// Sửa đổi bởi
        /// </summary>
        public String ModifiedBy { get; set; }
        #endregion

        #region Contructor
        public Department()
        {

        }
        #endregion

        #region Method

        #endregion
    }
}
