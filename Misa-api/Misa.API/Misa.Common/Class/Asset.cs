using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Misa.Common.Class
{
    public class Asset
    {
        #region Properties
        /// <summary>
        /// Khóa chính 
        /// </summary>
        public Guid AssetId { get; set; }

        /// <summary>
        /// Mã Tài sản
        /// </summary>
        public String AssetCode { get; set; }

        /// <summary>
        /// Tên tài sản
        /// </summary>
        public String AssetName { get; set; }

        /// <summary>
        /// Mã kiểu tài sản
        /// </summary>
        public Guid? AssetTypeId { get; set; }

        /// <summary>
        /// Mã phòng ban
        /// </summary>
        public Guid? DepartmentId { get; set; }

        /// <summary>
        /// Ngày tăng
        /// </summary>
        [JsonConverter(typeof(DateFormatConverter), "dd-MM-yyyy")]
        public DateTime IncreaseDate { get; set; }

        /// <summary>
        /// Thời gian sử dụng
        /// </summary>
        public float TimeUse { get; set; }

        /// <summary>
        /// Tỉ lệ mòn
        /// </summary>
        public float WearRate { get; set; }

        /// <summary>
        /// Gía cả
        /// </summary>
        public float OriginalPrice { get; set; }

        /// <summary>
        /// Mang giá trị
        /// </summary>
        public float WearValue { get; set; }

        /// <summary>
        /// Đã được sử dụng
        /// </summary>
        public int IsUsed { get; set; }

        /// <summary>
        /// Ngày tạo
        /// </summary>
        [JsonConverter(typeof(DateFormatConverter), "dd-MM-yyyy")]
        public DateTime CreatedDate { get; set; }

        /// <summary>
        /// Được tạo bởi
        /// </summary>
        public String CreatedBy { get; set; }

        /// <summary>
        /// Ngày sửa đổi
        /// </summary>
        [JsonConverter(typeof(DateFormatConverter), "dd-MM-yyyy")]
        public DateTime ModifiedDate { get; set; }

        /// <summary>
        /// Được sửa đổi bởi
        /// </summary>
        public String ModifiedBy { get; set; }

        #endregion

        #region Contructor
        public Asset()
        {
            
        }
        #endregion
        #region Method

        #endregion

    }
}
