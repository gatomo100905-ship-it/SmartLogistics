using System.Collections.Generic;

namespace SmartLogistics.Web.Modules.Supplier
{
    public interface ISupplierService
    {
        // Interface declaration placeholder
    }

    public class SupplierService : ISupplierService
    {
        public object GetSupplierQualityScore(int id) { return new { SupplierId = id, OnTimeDeliveryRate = 98.2, DefectRate = 0.5 }; }
    }
}
