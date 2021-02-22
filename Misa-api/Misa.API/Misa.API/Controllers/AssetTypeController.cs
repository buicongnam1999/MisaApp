using Microsoft.AspNetCore.Mvc;
using Misa.Common.Class;
using Misa.Service.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Misa.API.Controllers
{
    [Route("api/assettype")]
    [ApiController]
    public class AssetTypeController : ControllerBase
    {
        #region DECLARE
        /// <summary>
        /// Danh sách cần lấy
        /// </summary>
        private List<AssetType> _asT;

        /// <summary>
        /// Đối tượng thực thi
        /// </summary>
        private AssetTypeService<AssetType> _asTService;
        #endregion

        #region Contructor
        public AssetTypeController()
        {
            _asT = this.listData();
        }
        #endregion

        /// <summary>
        /// Lấy toàn bộ danh sách dữ liệu kiểu Tài sản
        /// </summary>
        /// <returns>Danh sách kiểu tài sản</returns>
        /// Create Bu: NamBC (20/02/21)
        #region Method
        [HttpGet]
        public IEnumerable<AssetType> GetData()
        {
            // Khởi tạo đối tượng thực thi
            _asTService = new AssetTypeService<AssetType>();

            // Trả về danh sách
            return _asTService.GetAllData();
        }

        /// <summary>
        /// Khởi tạo ban đầu
        /// </summary>
        /// <returns>Danh sách ban đầu</returns>
        /// Create By: NamBC (20/02/21)
        public List<AssetType> listData()
        {
            // Khởi tạo danh sách
            var list = new List<AssetType>()
            {
                new AssetType(){}
            };

            return list;
        }
        #endregion
    }
}
