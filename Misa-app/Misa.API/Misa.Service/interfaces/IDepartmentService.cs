﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Misa.Service.interfaces
{
    public interface IDepartmentService<T>
    {
        #region Method
        /// <summary>
        /// Hàm lấy toàn bộ dữ liệu
        /// </summary>
        /// <returns></returns>
        /// Create By: NAMBC (20/02/21)
        public IEnumerable<T> GetAllData();

        /// <summary>
        /// Hàm thêm mới dữ liệu
        /// </summary>
        /// <param name="entity">Đối tượng truyền vào</param>
        /// <returns>Kiểu số tự nhiên</returns>
        /// Create by: NamBC (20/02/21)
        public int InsertObjcet(T entity);

        /// <summary>
        /// Hàm sửa thông tin
        /// </summary>
        /// <param name="entity">Đối tượng truyền vào</param>
        /// <returns>Kiểu số tự nhiên</returns>
        /// Create By: NamBC (20/02/21)
        public int UpdateDepartment(T entity);

        /// <summary>
        /// Hàm xóa một đối tượng
        /// </summary>
        /// <param name="entity">Đối tượng được truyền vào</param>
        /// <returns>Kiểu số</returns>
        /// Create By: NamBC (20/02/21)
        public int DeleteDepartment(T entity);

        /// <summary>
        /// Hàm xóa tất cả các đối tượng
        /// </summary>
        /// <param name="entities">Danh sách đối tượng truyền vào</param>
        /// <returns>Kiểu số</returns>
        /// Create By: NamBC (20/02/21)
        public int DeleteDepartments(List<T> entities);

        #endregion
    }
}
