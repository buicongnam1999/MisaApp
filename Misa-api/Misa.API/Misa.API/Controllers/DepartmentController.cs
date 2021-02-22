using Microsoft.AspNetCore.Mvc;
using Misa.Common.Class;
using Misa.Service.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Misa.API.Controllers
{
    [Route("api/department")]
    [ApiController]
    public class DepartmentController : ControllerBase
    {
        #region DECLARE
        private List<Department> _dep;
        private DepartmentService<Department> _depService;
        #endregion

        #region Contructor
        public DepartmentController()
        {
            _dep = this.listData();
        }
        #endregion

        #region Method
        [HttpGet]
        public IEnumerable<Department> GetData()
        {
            _depService = new DepartmentService<Department>();
            return _depService.GetAllData();
        }


        public List<Department> listData()
        {
            var list = new List<Department>()
            {
                new Department(){}
            };

            return list;
        }
        #endregion
    }
}
