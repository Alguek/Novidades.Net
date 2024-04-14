using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace csharp12
{
    public class LambdaExpressionParametersDefaultValues
    {
        public LambdaExpressionParametersDefaultValues()
        {
            var multiplyWithDefault = (int addTo = 2) => addTo * 2;

            Console.WriteLine(multiplyWithDefault()); //4

            Console.WriteLine(multiplyWithDefault(5)); //10
        }
    }
}
