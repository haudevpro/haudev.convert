using System;

namespace HauDev.Convert
{
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = true)]
    public class ConverterOfAttribute: Attribute
    {
        /// <summary>
        /// Target => Kiểu dữ liệu mong muốn được thực hiện Convert
        /// </summary>
        public Type Target { set; get; }
    }
}
