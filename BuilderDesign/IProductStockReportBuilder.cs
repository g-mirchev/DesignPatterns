using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderDesign
{
    /*
     * Interface for the building logic
     */
    public interface IProductStockReportBuilder
    {
        IProductStockReportBuilder BuildHeader();
        IProductStockReportBuilder BuildBody();
        IProductStockReportBuilder BuildFooter();
        ProductStockReport GetReport();
    }
}
