using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderDesign
{
    /*
     * Class to represent a product stock report
     */
    public class ProductStockReport
    {
        public string HeaderPart { get; set; }
        public string BodyPart { get; set; }
        public string FooterPart { get; set; }

        /*
         * Report is constructed part by part following the model Header - Body - Footer
         */
        public override string ToString() =>
                new StringBuilder()
                .AppendLine(HeaderPart)
                .AppendLine(BodyPart)
                .AppendLine(FooterPart)
                .ToString();
    }
}
