using System;
using System.Collections.Generic;
using System.Text;

namespace Misa.Common.Class
{
    public class AssetType
    {
        #region Properties

        /// <summary>
        /// Khóa chính
        /// </summary>
        public Guid AssetTypeId { get; set; }

        /// <summary>
        /// Mã kiểu loại
        /// </summary>
        public String AssetTypeCode { get; set; }

        /// <summary>
        /// Tên kiểu loại
        /// </summary>
        public String AssetTypeName { get; set; }

        /// <summary>
        /// Miêu tả
        /// </summary>
        public String Description { get; set; }

        /// <summary>
        /// Ngày tạo
        /// </summary>
        public DateTime CreatedDate { get; set; }

        /// <summary>
        /// Được tạo bởi
        /// </summary>
        public String CreatedBy { get; set; }

        /// <summary>
        /// Ngày sửa đổi
        /// </summary>
        public DateTime ModifiedDate { get; set; }

        /// <summary>
        /// Sửa bởi
        /// </summary>
        public String ModifiedBy { get; set; }
        #endregion

        #region Contructor
        public AssetType()
        {

        }
        #endregion

        #region Method

        #endregion
    }
}
