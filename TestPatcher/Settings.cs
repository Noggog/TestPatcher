using Mutagen.Bethesda;
using Mutagen.Bethesda.FormKeys.SkyrimSE;
using Mutagen.Bethesda.Skyrim;
using Mutagen.Bethesda.Synthesis.Settings;
using Noggog;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace TestPatcher
{
    public enum HelloEnum
    {
        Hello,
        Bonjour,
        Aloha,
    }

    public record Settings
    {
        [SynthesisOrder]
        public bool ThrowException = false;

        [SynthesisOrder]
        public sbyte MySByte = 1;

        [SynthesisOrder]
        public List<sbyte> MySBytes = new List<sbyte>();

        [SynthesisOrder]
        public HashSet<sbyte> MyUniqueSByte = new HashSet<sbyte>();

        [SynthesisOrder]
        public int MyInt = 1;

        [SynthesisOrder]
        public List<int> MyInts = new List<int>();

        [SynthesisOrder]
        public HashSet<int> MyUniqueInts = new HashSet<int>();

        [SynthesisOrder]
        public ModKey ModKey;

        [SynthesisOrder]
        public List<ModKey> ModKeys = new List<ModKey>();

        [SynthesisOrder]
        public HashSet<ModKey> UniqueModKeys = new HashSet<ModKey>();

        [SynthesisOrder]
        public FormKey FormKey;

        [SynthesisOrder]
        public FormKey FormKeyUsingLib = Skyrim.Armor.ArmorBladesBoots;

        [SynthesisOrder]
        public List<FormKey> FormKeys = new List<FormKey>();

        [SynthesisOrder]
        public List<FormKey> FormKeysUsingLib = new List<FormKey>()
        {
            Skyrim.Armor.ArmorBladesBoots,
            Skyrim.Armor.ArmorBladesCuirass
        };

        [SynthesisOrder]
        public HashSet<FormKey> UniqueFormKeys = new HashSet<FormKey>();

        [SynthesisOrder]
        public FormLink<IArmorGetter> ArmorFormLink;

        [SynthesisOrder]
        public List<FormLink<IArmorGetter>> ArmorFormLinks = new List<FormLink<IArmorGetter>>();

        [SynthesisOrder]
        public List<FormLink<IArmorGetter>> ArmorFormLinksUsingLib = new List<FormLink<IArmorGetter>>()
        {
            Skyrim.Armor.ArmorBladesBoots,
            Skyrim.Armor.ArmorBladesCuirass
        };

        [SynthesisOrder]
        public HashSet<FormLink<IArmorGetter>> ArmorUniqueFormLinks = new HashSet<FormLink<IArmorGetter>>();

        [SynthesisOrder]
        public short MyShort = 1;

        [SynthesisOrder]
        public List<short> MyShorts = new List<short>();

        [SynthesisOrder]
        public HashSet<short> MyUniqueShorts = new HashSet<short>();

        [SynthesisOrder]
        public long MyLong = 1;

        [SynthesisOrder]
        public List<long> MyLongs = new List<long>();

        [SynthesisOrder]
        public HashSet<long> MyUniqueLong = new HashSet<long>();

        [SynthesisOrder]
        public byte MyByte = 1;

        [SynthesisOrder]
        public List<byte> MyBytes = new List<byte>();

        [SynthesisOrder]
        public HashSet<byte> MyUniqueByte = new HashSet<byte>();

        [SynthesisOrder]
        public uint MyUInt = 1;

        [SynthesisOrder]
        public List<uint> MyUInts = new List<uint>();

        [SynthesisOrder]
        public HashSet<uint> MyUniqueUInts = new HashSet<uint>();

        [SynthesisOrder]
        public ushort MyUShort = 1;

        [SynthesisOrder]
        public List<ushort> MyUShorts = new List<ushort>();

        [SynthesisOrder]
        public HashSet<ushort> MyUniqueUShorts = new HashSet<ushort>();

        [SynthesisOrder]
        public ulong MyULong = 1;

        [SynthesisOrder]
        public List<ulong> MyULongs = new List<ulong>();

        [SynthesisOrder]
        public HashSet<ulong> MyUniqueULong = new HashSet<ulong>();

        [SynthesisOrder]
        public bool MyBool = true;

        [SynthesisOrder]
        public List<bool> MyBools = new List<bool>();

        [SynthesisOrder]
        public double MyDouble = 2.3;

        [SynthesisOrder]
        public List<double> MyDoubles = new List<double>();

        [SynthesisOrder]
        public float MyFloat = 2.3f;

        [SynthesisOrder]
        public List<float> MyFloats = new List<float>();

        [SynthesisOrder]
        public decimal MyDecimal = 2.3m;

        [SynthesisOrder]
        public List<decimal> MyDecimals = new List<decimal>();

        [SynthesisOrder]
        public string MyString = "Hello";

        [SynthesisOrder]
        public List<string> MyStrings = new List<string>()
        {
            "Hello",
            "World"
        };

        [SynthesisOrder]
        public HelloEnum MyEnum;

        [SynthesisOrder]
        public HelloEnum MyEnumWithDefaults = HelloEnum.Aloha;

        [SynthesisOrder]
        public List<HelloEnum> MyEnums = new List<HelloEnum>();

        [SynthesisOrder]
        public SubSetting MySubsetting = new SubSetting();

        [SynthesisOrder]
        public List<SubSetting> MySubsettings = new List<SubSetting>();

        [SynthesisOrder]
        public HashSet<SubSetting> MyUniqueSubsettings = new HashSet<SubSetting>();

        [SynthesisOrder]
        public Dictionary<HelloEnum, SubSetting> StaticEnumSubclassDictionary = new Dictionary<HelloEnum, SubSetting>();

        [SynthesisOrder]
        public Dictionary<HelloEnum, int> StaticEnumSimpleDictionary = new Dictionary<HelloEnum, int>();

        [SynthesisOrder]
        [SynthesisStaticEnumDictionary(false)]
        public Dictionary<HelloEnum, SubSetting> FlexibleEnumSubclassDictionary = new Dictionary<HelloEnum, SubSetting>()
        {
            { HelloEnum.Bonjour, new SubSetting()
            {
                 ASetting = 43
            }}
        };

        [SynthesisOrder]
        [SynthesisStaticEnumDictionary(false)]
        public Dictionary<HelloEnum, int> FlexibleEnumSimpleDictionary = new Dictionary<HelloEnum, int>()
        {
            { HelloEnum.Bonjour, 14 }
        };

        [SynthesisOrder]
        public Dictionary<string, SubSetting> StringSubclassDictionary = new Dictionary<string, SubSetting>()
        {
            { "SomeString", new SubSetting()
            {
                ASetting = 267
            }}
        };

        [SynthesisOrder]
        public Dictionary<string, int> StringSimpleDictionary = new Dictionary<string, int>()
        {
            { "SomeString", 17 }
        };
    }

    public record SubSetting
    {
        public int ASetting;
        public ModKey AModKey;
    }
}
