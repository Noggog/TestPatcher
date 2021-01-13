using Noggog;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace TestPatcher
{
    public record Settings
    {
        public bool ThrowException = false;
        public sbyte MySByte = 1;
        public List<sbyte> MySBytes = new List<sbyte>();
        public HashSet<sbyte> MyUniqueSByte = new HashSet<sbyte>();
        public int MyInt = 1;
        public List<int> MyInts = new List<int>();
        public HashSet<int> MyUniqueInts = new HashSet<int>();
        public short MyShort = 1;
        public List<short> MyShorts = new List<short>();
        public HashSet<short> MyUniqueShorts = new HashSet<short>();
        public long MyLong = 1;
        public List<long> MyLongs = new List<long>();
        public HashSet<long> MyUniqueLong = new HashSet<long>();
        public byte MyByte = 1;
        public List<byte> MyBytes = new List<byte>();
        public HashSet<byte> MyUniqueByte = new HashSet<byte>();
        public uint MyUInt = 1;
        public List<uint> MyUInts = new List<uint>();
        public HashSet<uint> MyUniqueUInts = new HashSet<uint>();
        public ushort MyUShort = 1;
        public List<ushort> MyUShorts = new List<ushort>();
        public HashSet<ushort> MyUniqueUShorts = new HashSet<ushort>();
        public ulong MyULong = 1;
        public List<ulong> MyULongs = new List<ulong>();
        public HashSet<ulong> MyUniqueULong = new HashSet<ulong>();
        public bool MyBool = true;
        public List<bool> MyBools = new List<bool>();
        public double MyDouble = 2.3;
        public List<double> MyDoubles = new List<double>();
        public float MyFloat = 2.3f;
        public List<float> MyFloats = new List<float>();
        public decimal MyDecimal = 2.3m;
        public List<decimal> MyDecimals = new List<decimal>();
        public SubSetting MySubsetting = new SubSetting();
        public List<SubSetting> MySubsettings = new List<SubSetting>();
        public HashSet<SubSetting> MyUniqueSubsettings = new HashSet<SubSetting>();
    }

    public record SubSetting
    {
        public int ASetting;
    }
}
