using System;

namespace HauDev.Convert
{
    [Flags]
    public enum HTypeCode
    {
        [HTypeCodeOf(typeof(short))]
        Int16,

        [HTypeCodeOf(typeof(int))]
        Int32,

        [HTypeCodeOf(typeof(long))]
        Int64,

        [HTypeCodeOf(typeof(float))]
        Single,

        [HTypeCodeOf(typeof(double))]
        Double,

        [HTypeCodeOf(typeof(decimal))]
        Decimal,

        [HTypeCodeOf(typeof(string))]
        String,

        [HTypeCodeOf(typeof(bool))]
        Boolean,

        [HTypeCodeOf(typeof(DateTime))]
        DateTime,

        [HTypeCodeOf(typeof(TimeSpan))]
        TimeSpan,

        [HTypeCodeOf(typeof(byte))]
        Byte,

        [HTypeCodeOf(typeof(Guid))]
        Guid,

        [HTypeCodeOf(typeof(DBNull))]
        DBNull,

        UnKnown
    }
}
