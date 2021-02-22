using Misa.Common.Class;
using Misa.DataLayer.Data;
using Misa.Service.interfaces;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Text;

namespace Misa.Service.Service
{
    public class AssetService<Asset> : BaseService<Asset>
    {
        #region DECLARE
        /// <summary>
        /// Khai báo đối tượng làm việc
        /// </summary>
        private DBConnect<Asset> _db;
        #endregion

        #region Contructor
        public AssetService() : base()
        {
            _db = new DBConnect<Asset>();
        }
        public AssetService(DBConnect<Asset> db) : base(db)
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
        public IEnumerable<Asset> GetAllData()
        {
            // Khởi tạo đối tượng thực thi
            _db = new DBConnect<Asset>();

            // Lấy toàn bộ danh sách
            return _db.GetAllData();
        }

        /// <summary>
        /// Hàm thêm mới đối tượng
        /// </summary>
        /// <param name="entity">Đối tượng được truyền vào</param>
        /// <returns>Số bản ghi thực thi</returns>
        public int InsertAsset(Asset entity)
        {
            // Thêm mới đối tượng
            return _db.InsertObjcet(entity);
        }

        /// <summary>
        /// Hàm sửa dữ liệu
        /// </summary>
        /// <param name="entity">Đối tượng được truyền vào</param>
        /// <returns>Kiểu số</returns>
        /// Create By: NamBC (20/02/21)
        public int UpdateAsset(Asset entity)
        {
            // Sửa đối tượng
            throw new NotImplementedException();
        }

        /// <summary>
        /// Hàm xóa một phần tử
        /// </summary>
        /// <param name="entity">Đối tượng được truyền vào</param>
        /// <returns>Kiểu số</returns>
        /// Create By: NamBC (20/02/21)
        public int DeleteAsset(String code)
        {
            // Kiêm tra đối tượng có tồn tại không
            // Xóa đối tượng
            return _db.DeleteObject(code);
            
        }

        /// <summary>
        /// Hàm xóa một danh sách cần xóa
        /// </summary>
        /// <param name="entities">Danh sách truyền vào</param>
        /// <returns>Kiểu số</returns>
        /// Create By: NamBC (20/02/21)
        public int DeleteAssets(List<String> codes)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Kiểm tra đối tượng đã tồn tại hay chưa
        /// </summary>
        /// <param name="code">Tham số truyền vào</param>
        /// <returns>Kiểu Boolean</returns>
        /// Create By: NamBC (20/02/21)
        public Boolean GetObjectCode(string code)
        {
            // Kiểm tra đối tượng đã tồn tại hay chưa
            Boolean check = _db.GetObjectCode(code);
            return check;
        }


        /// <summary>
        /// Đếm số phần tử gửi về
        /// </summary>
        /// <returns>Số lượng bản ghi</returns>
        /// Create By: NamBC (20/02/21)
        public int CountAssets()
        {

            // Trả về số lượng bản ghi
            return _db.CountObject();

        }

        #endregion


    }
}
