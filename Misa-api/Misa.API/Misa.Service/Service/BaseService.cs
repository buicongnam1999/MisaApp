using Misa.Common.Class;
using Misa.DataLayer.Data;
using Misa.Service.interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Misa.Service.Service
{
    public class BaseService<T> : IBaseService<T>
    {
        #region DECLARE
        // Khởi tạo đối tượng làm viêc
        DBConnect<T> _db;
        #endregion

        #region Contructor
        public BaseService()
        {

        }
        public BaseService( DBConnect<T> db )
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
        public IEnumerable<object> GetAllData()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Hàm thêm mới đối tượng
        /// </summary>
        /// <param name="entity">Đối tượng được truyền vào</param>
        /// <returns></returns>
        public int InsertObjcet(object entity)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Hàm sửa dữ liệu
        /// </summary>
        /// <param name="entity">Đối tượng được truyền vào</param>
        /// <returns>Kiểu số</returns>
        /// Create By: NamBC (20/02/21)
        public int UpdateObject(object entity)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Hàm xóa một phần tử
        /// </summary>
        /// <param name="entity">Đối tượng được truyền vào</param>
        /// <returns>Kiểu số</returns>
        /// Create By: NamBC (20/02/21)
        public int DeleteObject(object entity)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Hàm xóa một danh sách cần xóa
        /// </summary>
        /// <param name="entities">Danh sách truyền vào</param>
        /// <returns>Kiểu số</returns>
        /// Create By: NamBC (20/02/21)
        public int DeleteObjects(List<object> entities)
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
