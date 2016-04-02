using System;

namespace HauDev.Convert
{
    /// <summary>
    /// Mở rộng của kiểu dữ liệu
    /// </summary>
    [AttributeUsage(AttributeTargets.Field)]
    public class HTypeCodeOfAttribute: Attribute
    {
        private Type type = null;
        /// <summary>
        /// 
        /// </summary>
        public Type Type
        {
            get { return type; }
        }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="type"></param>
        public HTypeCodeOfAttribute(Type type)
        {
            this.type = type;
        }
    }
}
