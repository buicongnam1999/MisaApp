using Misa.DataLayer.Data;
using Misa.Service.interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Misa.Service.Service
{
    public class DepartmentService<Department> : BaseService<Department>
    {
        #region DECLARE
        // Khai báo làm việc với Data
        DBConnect<Department> _db;
        #endregion

        #region Construct
        public DepartmentService(): base()
        {

        }
        public DepartmentService(DBConnect<Department> db) : base(db)
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
        public IEnumerable<Department> GetAllData()
        {
            // Khởi tạo đối tượng làm việc
            _db = new DBConnect<Department>();

            // Trả về danh sách đối tượng làm việc
            return _db.GetAllData();
        }

        /// <summary>
        /// Hàm thêm mới đối tượng
        /// </summary>
        /// <param name="entity">Đối tượng được truyền vào</param>
        /// <returns>Số bản ghi đãn thêm</returns>
        /// Create By: NamBC (20/02/21)
        public int InsertDepartment(Department entity)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Hàm sửa dữ liệu
        /// </summary>
        /// <param name="entity">Đối tượng được truyền vào</param>
        /// <returns>Kiểu số</returns>
        /// Create By: NamBC (20/02/21)
        public int UpdateDepartment(Department entity)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Hàm xóa một phần tử
        /// </summary>
        /// <param name="entity">Đối tượng được truyền vào</param>
        /// <returns>Kiểu số</returns>
        /// Create By: NamBC (20/02/21)
        public int DeleteDepartment(Department entity)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Hàm xóa một danh sách cần xóa
        /// </summary>
        /// <param name="entities">Danh sách truyền vào</param>
        /// <returns>Kiểu số</returns>
        /// Create By: NamBC (20/02/21)
        public int DeleteDepartments(List<Department> entities)
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
