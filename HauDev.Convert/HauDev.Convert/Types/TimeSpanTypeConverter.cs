using System;

namespace HauDev.Convert.Types
{
    [ConverterOf(Target = typeof(TimeSpan))]
    public class TimeSpanTypeConverter: HTypeConverter
    {
    }
}
