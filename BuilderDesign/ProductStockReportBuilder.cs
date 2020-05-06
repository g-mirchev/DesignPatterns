using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace BuilderDesign
{
    /*
     * Logic for building the parts of the report
     */
    public class ProductStockReportBuilder : IProductStockReportBuilder
    {
        private ProductStockReport _productStockReport;
        private IEnumerable<Product> _products;

        /*
         * Take a collection of products in the parameter and create a new report
         */
        public ProductStockReportBuilder(IEnumerable<Product> products)
        {
            _products = products;
            _productStockReport = new ProductStockReport();
        }

        /*
         * Build the header string of the report
         */
        public IProductStockReportBuilder BuildHeader()
        {
            _productStockReport.HeaderPart = $"STOCK REPORT FOR ALL THE PRODUCTS ON DATE: {DateTime.Now}\n";
            return this;
        }

        /*
         * Build the body string of the report by listing all the products and prices
         */
        public IProductStockReportBuilder BuildBody()
        {
            _productStockReport.BodyPart = string.Join(Environment.NewLine, _products.Select(p => $"Product name: {p.Name}, product price: {p.Price}"));
            return this;
        }

        /*
         * Build the footer of the report
         */
        public IProductStockReportBuilder BuildFooter()
        {
            _productStockReport.FooterPart = "\nReport provided by <CompanyName>.";
            return this;
        }

        /*
         * Return a copy of the report
         */
        public ProductStockReport GetReport()
        {
            var productStockReport = _productStockReport;
            Clear();
            return productStockReport;
        }

        /*
         * Clear the report variable by overriding it with a new empty report
         */
        private void Clear() => _productStockReport = new ProductStockReport();
    }
}
