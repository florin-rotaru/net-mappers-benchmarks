using System;

namespace Models
{
    public enum TUndefinedABCEnum
    {
        Undefined,
        A,
        B,
        C
    }
    public enum TABCEnum
    {
        A,
        B,
        C
    }

    public class TC0_Members : IComparable<TC0_Members>
    {
        public int Id { get; set; }
        public bool BooleanMember { get; set; }
        public char CharMember { get; set; }
        public sbyte SByteMember { get; set; }
        public byte ByteMember { get; set; }
        public short Int16SMember { get; set; }
        public ushort UInt16Member { get; set; }
        public int Int32Member { get; set; }
        public uint UInt32Member { get; set; }
        public long Int64Member { get; set; }
        public ulong UInt64Member { get; set; }
        public float SingleMember { get; set; }
        public double DoubleMember { get; set; }
        public decimal DecimalMember { get; set; }
        public string StringMember { get; set; }

        public DateTime DateTimeMember { get; set; }
        public DateTimeOffset DateTimeOffsetMember { get; set; }
        public TimeSpan TimeSpanMember { get; set; }

        public Guid GuidMember { get; set; }

        public TUndefinedABCEnum UndefinedEnumMember { get; set; }
        public TABCEnum EnumMember { get; set; }

        public int CompareTo(TC0_Members other)
        {
            return Id.CompareTo(other.Id);
        }
    }
    public class TC0_I0_Members : IComparable<TC0_I0_Members>
    {
        public bool BooleanMember { get; set; }
        public char CharMember { get; set; }
        public sbyte SByteMember { get; set; }
        public byte ByteMember { get; set; }
        public short Int16SMember { get; set; }
        public ushort UInt16Member { get; set; }
        public int Int32Member { get; set; }
        public uint UInt32Member { get; set; }
        public long Int64Member { get; set; }
        public ulong UInt64Member { get; set; }
        public float SingleMember { get; set; }
        public double DoubleMember { get; set; }
        public decimal DecimalMember { get; set; }
        public string StringMember { get; set; }

        public int CompareTo(TC0_I0_Members other)
        {
            return Int32Member.CompareTo(other.Int32Member);
        }
    }
    public class TC0_I1_Members : IComparable<TC0_I1_Members>
    {
        public bool BooleanMember { get; set; }
        public char CharMember { get; set; }
        public sbyte SByteMember { get; set; }
        public byte ByteMember { get; set; }
        public short Int16SMember { get; set; }
        public ushort UInt16Member { get; set; }
        public int Int32Member { get; set; }
        public uint UInt32Member { get; set; }
        public long Int64Member { get; set; }
        public ulong UInt64Member { get; set; }
        public float SingleMember { get; set; }
        public double DoubleMember { get; set; }
        public decimal DecimalMember { get; set; }
        public string StringMember { get; set; }

        public DateTime DateTimeMember { get; set; }
        public DateTimeOffset DateTimeOffsetMember { get; set; }
        public TimeSpan TimeSpanMember { get; set; }

        public Guid GuidMember { get; set; }

        public TUndefinedABCEnum UndefinedEnumMember { get; set; }
        public TABCEnum EnumMember { get; set; }

        public int CompareTo(TC0_I1_Members other)
        {
            return Int32Member.CompareTo(other.Int32Member);
        }
    }
    public class TC0_I2_Nullable_Members : IComparable<TC0_I2_Nullable_Members>
    {
        public bool? BooleanMember { get; set; }
        public char? CharMember { get; set; }
        public sbyte? SByteMember { get; set; }
        public byte? ByteMember { get; set; }
        public short? Int16SMember { get; set; }
        public ushort? UInt16Member { get; set; }
        public int? Int32Member { get; set; }
        public uint? UInt32Member { get; set; }
        public long? Int64Member { get; set; }
        public ulong? UInt64Member { get; set; }
        public float? SingleMember { get; set; }
        public double? DoubleMember { get; set; }
        public decimal? DecimalMember { get; set; }
        public string StringMember { get; set; }

        public DateTime? DateTimeMember { get; set; }
        public DateTimeOffset? DateTimeOffsetMember { get; set; }
        public TimeSpan? TimeSpanMember { get; set; }

        public Guid? GuidMember { get; set; }

        public TUndefinedABCEnum? UndefinedEnumMember { get; set; }
        public TABCEnum? EnumMember { get; set; }

        public int CompareTo(TC0_I2_Nullable_Members other)
        {
            return (Int32Member != null ? Int32Member.Value : 0)
                .CompareTo(other.Int32Member != null ? other.Int32Member.Value : 0);
        }
    }

    public struct TS0_Members : IComparable<TS0_Members>
    {
        public int Id { get; set; }
        public bool BooleanMember { get; set; }
        public char CharMember { get; set; }
        public sbyte SByteMember { get; set; }
        public byte ByteMember { get; set; }
        public short Int16SMember { get; set; }
        public ushort UInt16Member { get; set; }
        public int Int32Member { get; set; }
        public uint UInt32Member { get; set; }
        public long Int64Member { get; set; }
        public ulong UInt64Member { get; set; }
        public float SingleMember { get; set; }
        public double DoubleMember { get; set; }
        public decimal DecimalMember { get; set; }
        public string StringMember { get; set; }

        public DateTime DateTimeMember { get; set; }
        public DateTimeOffset DateTimeOffsetMember { get; set; }
        public TimeSpan TimeSpanMember { get; set; }

        public Guid GuidMember { get; set; }

        public TUndefinedABCEnum UndefinedEnumMember { get; set; }
        public TABCEnum EnumMember { get; set; }

        public int CompareTo(TS0_Members other)
        {
            return Id.CompareTo(other.Id);
        }
    }
    public struct TS0_I0_Members : IComparable<TS0_I0_Members>
    {
        public bool BooleanMember { get; set; }
        public char CharMember { get; set; }
        public sbyte SByteMember { get; set; }
        public byte ByteMember { get; set; }
        public short Int16SMember { get; set; }
        public ushort UInt16Member { get; set; }
        public int Int32Member { get; set; }
        public uint UInt32Member { get; set; }
        public long Int64Member { get; set; }
        public ulong UInt64Member { get; set; }
        public float SingleMember { get; set; }
        public double DoubleMember { get; set; }
        public decimal DecimalMember { get; set; }
        public string StringMember { get; set; }

        public int CompareTo(TS0_I0_Members other)
        {
            return Int32Member.CompareTo(other.Int32Member);
        }
    }
    public struct TS0_I1_Members : IComparable<TS0_I1_Members>
    {
        public bool BooleanMember { get; set; }
        public char CharMember { get; set; }
        public sbyte SByteMember { get; set; }
        public byte ByteMember { get; set; }
        public short Int16SMember { get; set; }
        public ushort UInt16Member { get; set; }
        public int Int32Member { get; set; }
        public uint UInt32Member { get; set; }
        public long Int64Member { get; set; }
        public ulong UInt64Member { get; set; }
        public float SingleMember { get; set; }
        public double DoubleMember { get; set; }
        public decimal DecimalMember { get; set; }
        public string StringMember { get; set; }

        public DateTime DateTimeMember { get; set; }
        public DateTimeOffset DateTimeOffsetMember { get; set; }
        public TimeSpan TimeSpanMember { get; set; }

        public Guid GuidMember { get; set; }

        public TUndefinedABCEnum UndefinedEnumMember { get; set; }
        public TABCEnum EnumMember { get; set; }

        public int CompareTo(TS0_I1_Members other)
        {
            return Int32Member.CompareTo(other.Int32Member);
        }
    }
    public struct TS0_I2_Nullable_Members : IComparable<TS0_I2_Nullable_Members>
    {
        public bool? BooleanMember { get; set; }
        public char? CharMember { get; set; }
        public sbyte? SByteMember { get; set; }
        public byte? ByteMember { get; set; }
        public short? Int16SMember { get; set; }
        public ushort? UInt16Member { get; set; }
        public int? Int32Member { get; set; }
        public uint? UInt32Member { get; set; }
        public long? Int64Member { get; set; }
        public ulong? UInt64Member { get; set; }
        public float? SingleMember { get; set; }
        public double? DoubleMember { get; set; }
        public decimal? DecimalMember { get; set; }
        public string StringMember { get; set; }

        public DateTime? DateTimeMember { get; set; }
        public DateTimeOffset? DateTimeOffsetMember { get; set; }
        public TimeSpan? TimeSpanMember { get; set; }

        public Guid? GuidMember { get; set; }

        public TUndefinedABCEnum? UndefinedEnumMember { get; set; }
        public TABCEnum? EnumMember { get; set; }

        public int CompareTo(TS0_I2_Nullable_Members other)
        {
            return (Int32Member != null ? Int32Member.Value : 0)
                .CompareTo(other.Int32Member != null ? other.Int32Member.Value : 0);
        }
    }
}
