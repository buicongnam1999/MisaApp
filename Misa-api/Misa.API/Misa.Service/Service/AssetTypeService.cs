using Misa.DataLayer.Data;
using Misa.Service.interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Misa.Service.Service
{
    public class AssetTypeService<AssetType> : BaseService<AssetType>
    {
        #region DECLARE
        // Khai báo làm việc với Data
        DBConnect<AssetType> _db;
        #endregion

        #region ConStructtor
        public AssetTypeService(): base()
        {
            _db = new DBConnect<AssetType>();
        }

        public AssetTypeService(DBConnect<AssetType> db) : base(db)
        {
            _db = db;
        }
        #endregion

        #region Method
        /// <summary>
        /// Hàm lấy tất cả các dữ liệu
        /// </summary>
        /// <returns>Danh sách đối tượng cần lấy</returns>
        /// Create By: NamBC (20/02/21)
        public IEnumerable<AssetType> GetAllData()
        {
            // Khởi tạo đối tượng
            _db = new DBConnect<AssetType>();

            // Lấy toàn bộ danh sách
            return _db.GetAllData();
        }

        /// <summary>
        /// Hàm thêm mới đối tượng
        /// </summary>
        /// <param name="entity">Đối tượng được truyền vào</param>
        /// <returns></returns>
        public int InsertAssetType(AssetType entity)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Hàm sửa dữ liệu
        /// </summary>
        /// <param name="entity">Đối tượng được truyền vào</param>
        /// <returns>Kiểu số</returns>
        /// Create By: NamBC (20/02/21)
        public int UpdateAssetType(AssetType entity)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Hàm xóa một phần tử
        /// </summary>
        /// <param name="entity">Đối tượng được truyền vào</param>
        /// <returns>Kiểu số</returns>
        /// Create By: NamBC (20/02/21)
        public int DeleteAssetType(AssetType entity)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Hàm xóa một danh sách cần xóa
        /// </summary>
        /// <param name="entities">Danh sách truyền vào</param>
        /// <returns>Kiểu số</returns>
        /// Create By: NamBC (20/02/21)
        public int DeleteAssetTypes(List<AssetType> entities)
        {
            throw new NotImplementedException();
        }
        #endregion


    }
}
