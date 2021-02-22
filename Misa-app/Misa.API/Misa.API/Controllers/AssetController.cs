using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Misa.Common.Class;
using Misa.Service.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Misa.API.Controllers
{
    [EnableCors()]
    [Route("api/asset")]
    [ApiController]
    public class AssetController : ControllerBase
    {

        #region DECLARE
        // Danh sách cần lấy
        private List<Asset> _asset;

        /// <summary>
        /// Đối tượng thực thi
        /// </summary>
        private AssetService<Asset> _assetService;
        #endregion

        #region Contructor
        public AssetController()
        {
            _asset = this.listData();
        }
        #endregion

        #region Method

        /// <summary>
        /// Lấy dang sách Tài sản
        /// </summary>
        /// <returns>Danh sách Tài sản</returns>
        /// Create By: NamBC (20/02/21)
        [HttpGet]
        public IEnumerable<Asset> GetData()
        {
            // Khai báo đối tượng thực thi
            _assetService = new AssetService<Asset>();

            // Lấy danh sách đối tượng
            IEnumerable<Asset> list = _assetService.GetAllData();

            // Fomat Time
            foreach(Asset l in list)
            {
                l.IncreaseDate.ToString("yyyy-mm-dd");
            }
            return list;
        }

        [HttpGet("count")]
        public int GetCount()
        {
            // Khai báo đối tượng thực thi
            _assetService = new AssetService<Asset>();

            // Lấy danh số lượng bản ghi
            return _assetService.CountAssets();
            
        }

        /// <summary>
        /// Thêm mới Tài sản
        /// </summary>
        /// <param name="na">Tài sản truyềnvaof</param>
        /// <returns>Thực thi</returns>
        /// Create By: NamBC (20/02/21)
        [HttpPost]
        public ServiceReult InsertData(Asset na)
        {
            _assetService = new AssetService<Asset>();
            // Kiểm tra mã trùng
            var check = _assetService.GetObjectCode(na.AssetCode);
            if (check)
            {
                // Khai báo lỗi
                errMsg e = new errMsg();
                // Thông báo lỗi cho Dev
                e.DevMsg = Misa.Common.Properties.Resources.errMsg_DuplicateAssetCodeDev;
                // Thông báo lỗi cho User
                e.UserMsg = Misa.Common.Properties.Resources.errMsg_DuplicateAssetCodeUser;

                // Khai báo thực thi
                ServiceReult r = new ServiceReult();
                r.Sucess = false;
                r.Data = e;
                return r;

            }
            else
            {
                // Thực thi truyền vào
                var res = _assetService.InsertAsset(na);

                // Khai báo lỗi
                errMsg e;

                // Khai báo thực thi
                ServiceReult r;
                r = new ServiceReult();
                if (res > 0)
                {
                    // Khởi tạo đối tượng thực thi
                    r = new ServiceReult();

                    // Khởi tạo lỗi
                    e = new errMsg();

                    // Thông báo chi Dev
                    e.DevMsg = Misa.Common.Properties.Resources.SucessTrue;

                    // Thông báo cho người dùng
                    e.UserMsg = Misa.Common.Properties.Resources.SucessTrue;

                    // Lấy thông báo
                    r.Data = e;
                    r.Sucess = true;

                    return r;
                }
                else
                {
                    // Khởi tạo đối tượng thực thi
                    r = new ServiceReult();

                    // Khởi tạo lỗi
                    e = new errMsg();

                    // Thông báo chi Dev
                    e.DevMsg = Misa.Common.Properties.Resources.SuccesFalse;

                    // Thông báo cho người dùng
                    e.UserMsg = Misa.Common.Properties.Resources.SuccesFalse;

                    // Lấy thông báo
                    r.Data = e;
                    r.Sucess = false;

                    return r;
                }
            }
            
        }

        /// <summary>
        /// Xóa dữ liệu khi chọn
        /// </summary>
        /// <returns></returns>
        [HttpDelete("{code}")]
        public ServiceReult DeleteData(String code)
        {
            // Khởi tạo đối tượng thực thi
            _assetService = new AssetService<Asset>();

            // Khai báo đối tượng
            ServiceReult r;
            errMsg e;
            // Kiểm tra đối tượng có bị trống hay không

            // Kiểm tra đối tượng có tồn tại hay không
            if (_assetService.GetObjectCode(code))
            {
                

                // Thực thi xóa
                var res = _assetService.DeleteAsset(code);

                if(res > 0)
                {
                    // Khởi tạo đối tượng
                    r = new ServiceReult();
                    e = new errMsg();

                    // Thông báo Thành công
                    e.DevMsg = Misa.Common.Properties.Resources.SucessTrue;
                    e.UserMsg = Misa.Common.Properties.Resources.SucessTrue;
                    r.Sucess = true;
                    r.Data = e;

                    return r;
                }
                else
                {
                    // Khởi tạo đối tượng
                    r = new ServiceReult();
                    e = new errMsg();

                    // Thông báo Thành công
                    e.DevMsg = Misa.Common.Properties.Resources.SucessTrue;
                    e.UserMsg = Misa.Common.Properties.Resources.SucessTrue;
                    r.Sucess = true;
                    r.Data = e;


                    return r;
                }



            }
            else
            {

                // Khởi tạo đối tượng bạn đầu
                r = new ServiceReult();
                e = new errMsg();


                return r;

            }
        }


        /// <summary>
        /// Khởi tạo danh sách ban đầu
        /// </summary>
        /// <returns>Danh sách</returns>
        /// Create By: NamBC (20/02/21)
        public List<Asset> listData()
        {
            // Khởi tạo danh sách
            var list = new List<Asset>()
            {
                new Asset(){}
            };

            return list;
        }
        #endregion
        
        
    }
}
