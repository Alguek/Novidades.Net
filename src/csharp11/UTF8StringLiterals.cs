using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp11
{
    public class UTF8StringLiterals
    {
        /// <summary>
        /// Foi feito uma simplificação na chamada de conversão para bytes de UTF8
        /// Agora você pode converter a string para bytes UTF8 apenas colocando u8.ToArray()
        /// </summary>
        public UTF8StringLiterals()
        {
            //Example: UTF-8 string literals
            var utf8BeforeCS11 = Encoding.UTF8.GetBytes("Hello C#11");
            var utf8InCS11 = "Hello C#11"u8.ToArray();
        }
    }
}
