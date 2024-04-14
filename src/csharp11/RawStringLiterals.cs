using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp11
{
    public class RawStringLiterals
    {
        /// <summary>
        /// RawStringLiterals são um novo formato para as string. 
        /// Este formato permite diferentes tipos de caracteres especiais sem a necessidade de "dar escape" neles. 
        /// </summary>
        public RawStringLiterals()
        {
            string longStr = $"""
	                         Until recently, the prevailing view assumed lorem ipsum was born as a nonsense text.
	                         "It's not Latin, though it looks like it, and it actually says nothing,"
	                         Before & After magazine answered a curious reader, a
	                         "Its ‘words’ loosely approximate the frequency with which letters occur in English,
	                         which is why at a glance it looks pretty real."
	                         Some have "quoted text" in them.
	                         """;

            Console.WriteLine(longStr);

            float longitude = 72.579946f, latitude = 23.103942f;
            var location = $$"""
                           You are at {{{longitude}}, {{latitude}}}
                           """;

            Console.WriteLine(location);

            int temp = 24;
            string message = $"Human sensation to temperature {temp} is {
            temp switch
            {
                > 45 => "Death",
                > 35 => "Too hot",
                > 25 => "Nice",
                > -10 => "Cold",
                <= -10 => "Death"
            }}";
            Console.WriteLine(message);
        }
    }
}
