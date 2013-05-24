using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Showroom.Models.DataBusiness;

namespace Showroom.Models.DataAccess
{
    public partial class ShowroomRepository : IShowroomRepository 
    {
        /// <summary>
        /// Lấy toàn bộ danh sách thuộc tính sản phẩm
        /// </summary>
        /// <returns>List of Catelogue</returns>
        public List<Product> GetProductsList()
        {
            try
            {
                var list = from p in _dataContext.Products select p;
                return list.ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
