using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Showroom.Models.DataBusiness
{
    public interface  IShowroomRepository
    {
        void Dispose();

        List<Catelogue> GetProductCatelogueList();
        Catelogue GetProductCatelogueInfo(int id);
        bool InsertProductCatelogue(Catelogue item);
        bool UpdateProductCatelogue(Catelogue item);
        bool DeleteProductCatelogue(int Id);

    }
}
