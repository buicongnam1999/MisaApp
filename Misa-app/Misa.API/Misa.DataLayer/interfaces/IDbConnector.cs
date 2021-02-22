using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Misa.DataLayer.interfaces
{
    public interface IDbConnector<T>
    {
        /// <summary>
        /// Lấy danh sách đổi tượng cần lấy
        /// </summary>
        /// <returns>Danh sách đối tượng</returns>
        /// Create By: NamBC (19/02/21)
        public IEnumerable<T> GetAllData(String sql = null , object paramObjcet = null , CommandType cmd = CommandType.Text);

        /// <summary>
        /// Lấy đối tượng theo Code
        /// </summary>
        /// <param name="code">Tham số code truyền vào</param>
        /// <returns>Kiểu Boolean</returns>
        /// Create By: NamBC (20/02/21)
        public Boolean GetObjectCode(String code);

        /// <summary>
        /// Thêm mới đối tượng cần thêm mới
        /// </summary>
        /// <returns>Số bản ghi đã thực thi</returns>
        /// Create By: NamBC (19/02/21)
        public int InsertObjcet(T entity);

        /// <summary>
        /// Sửa thông tin đối tượng cần sửa
        /// </summary>
        /// <returns>Số bản ghi đã thực thi</returns>
        /// Create By: NamBC (19/02/21)
        public int UpdateObject(T entity);

        /// <summary>
        /// Xóa đối tượng cần xóa
        /// </summary>
        /// <returns>Số bản ghi đã thực thi</returns>
        /// Create By: NamBC (19/02/21)
        public int DeleteObject(String code);

        /// <summary>
        /// Xóa nhiều đối tượng cần xóa
        /// </summary>
        /// <param name="entities">Danh sách đối tượng cần xóa</param>
        /// <returns></returns>
        /// Create By: NamBC (19/02/21)
        public int DeleteObjects(List<T> entities);

        /// <summary>
        /// Đếm số phần tử
        /// </summary>
        /// <returns>Trả về số lượng phần tử</returns>
        /// Create By: NamBC (20/02/21)
        public int CountObject();
    }
}
