using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderDesign
{
    /*
     * Class to represent builder object
     */
    public class ProductStockReportDirector
    {
        private readonly IProductStockReportBuilder _productStockReportBuilder;

        /*
         * Takes the builder logic as parameter
         */
        public ProductStockReportDirector(IProductStockReportBuilder productStockReportBuilder)
        {
            _productStockReportBuilder = productStockReportBuilder;
        }

        /*
         * Builds the report following the model Header - Body - Footer
         */
        public void BuildStockReport()
        {
            _productStockReportBuilder
                .BuildHeader()
                .BuildBody()
                .BuildFooter();
        }
    }
}
