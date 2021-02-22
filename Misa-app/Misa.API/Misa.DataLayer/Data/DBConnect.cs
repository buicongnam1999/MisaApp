using Misa.DataLayer.interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using Dapper;
using System.Linq;


namespace Misa.DataLayer.Data
{
    public class DBConnect<T> : IDbConnector<T>
    {
        #region Declare
        /// <summary>
        /// Chuỗi khai báo kết nối
        /// </summary>
        private String _connectString = "" + "Host = 47.241.69.179;"
                + "Port = 3306;"
                + "Database = TEST.MISA.QLTS;"
                + "User id = dev;"
                + "Password = 12345678;"
                ;

        /// <summary>
        /// Đối tượng kết nối cơ sở dữ liệu
        /// </summary>
        private IDbConnection _dbConnection;
        #endregion

        #region Contructor
        public DBConnect()
        {
            _dbConnection = new MySqlConnector.MySqlConnection(_connectString);
        }
        public DBConnect(IDbConnection dbConnection)
        {
            _dbConnection = dbConnection;
        }
        #endregion

        #region Method

        /// <summary>
        /// Lấy danh sách cần lấy
        /// </summary>
        /// <returns>Danh sách</returns>
        /// Create By: NamBC (20/02/21)
        public IEnumerable<T> GetAllData(String sql = null, object paramObjcet = null, CommandType cmd = CommandType.Text)
        {
            if(sql == null)
            {
                // Lây tên đối tượng
                var className = typeof(T).Name;

                // Viết câu truy vẫn nếu chưa có câu truy vấn 
                String query = "SELECT * FROM " + className + "";

                // Lấy danh sách đối tượng theo truy vấn
                var objects =  _dbConnection.Query<T>(query , commandType: cmd);
                return objects;
            }
            else
            {
                // Lấy đối tượng khi có câu truy vấn
                var objects = _dbConnection.Query<T>(sql, commandType: cmd);
                return objects;
            }
        }

        /// <summary>
        /// Hàm Thêm mới đối tượng cần thêm mới
        /// </summary>
        /// <param name="entity"></param>
        /// <returns>Kiểu số bản ghi thực thi</returns>
        /// Create By: NamBC (19/02/21)
        public int InsertObjcet(T entity)
        {
            // Thêm mới đối tượng
           return _dbConnection.Execute("Proc_InsertAsset", param: entity, commandType: CommandType.StoredProcedure);

        }

        /// <summary>
        /// Hàm Sửa dữ liệu cần sửa
        /// </summary>
        /// <param name="entity">Đối tượng truyền vào</param>
        /// <returns>Số bản ghi thực thi</returns>
        /// Create By: NamBC (20/02/21)
        public int UpdateObject(T entity)
        {

            throw new NotImplementedException();
        }
        #endregion

        /// <summary>
        /// Hàm xóa đối tượng cần xóa
        /// </summary>
        /// <param name="entity">Đối tượng truyền vào</param>
        /// <returns>Số bản ghi thực thi</returns>
        /// Create By: NamBC (19/02/21)
        public int DeleteObject(String code)
        {
            // Lấy tên đối tượng
            var className = typeof(T).Name;
            String query = "DELETE FROM " + className + " WHERE " + className + "Code = '" + code + "'";
            return _dbConnection.Execute(query, commandType: CommandType.Text);
        }

        /// <summary>
        /// Hàm xóa nhiều đối tượng
        /// </summary>
        /// <param name="entities">Danh sách đối tượng cần xóa</param>
        /// <returns>Số bản ghi thực thi</returns>
        /// Create By: NamBC (19/02/21)
        public int DeleteObjects(List<T> entities)
        {
            throw new NotImplementedException();
        }


        /// <summary>
        /// Lấy đối tượng theo code
        /// </summary>
        /// <param name="code">Tham số truyền vào</param>
        /// <returns>Kiểu true or false</returns>
        /// Create By: NamBC (20/02/21)
        public Boolean GetObjectCode(string code)
        {
            // Lấy tên của đối tượng cần thêm
            var className = typeof(T).Name;

            // Viết câu lênh
            String query = "SELECT * FROM " + className + " WHERE " + className + "Code = " + code;

            // Thực thi câu lệnh
            var objects = _dbConnection.Query(query, commandType: CommandType.Text);

            // Kiểm tra đối tượng đã tồn tại hay chưa
            if(objects.Count() == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        /// <summary>
        /// Đếm sô lượng bản ghi
        /// </summary>
        /// <returns>Số lượng bản ghi lấy được</returns>
        /// Create By: NamBC (20/02/21)
        public int CountObject()
        {
            // Lấy tên đối tượng
            var className = typeof(T).Name;

            // Viết câu lệnh thực thi
            String query = "SELECT * FROM " + className + "";

            // Thực thi truy vấn
            var objects = _dbConnection.Query<T>(query, commandType: CommandType.Text);

            return objects.Count();

        }
    }
}
