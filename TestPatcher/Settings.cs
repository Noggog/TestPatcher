using Noggog;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace TestPatcher
{
    public record Settings
    {
        public bool MyBool;
        public List<bool> MyBools = new List<bool>();
        public int MyInt;
        public List<int> MyInts = new List<int>();
        public HashSet<int> MyUniqueInts = new HashSet<int>();
        public double MyDouble;
        public List<double> MyDoubles = new List<double>();
        public HashSet<double> MyUniqueDoubles = new HashSet<double>();
        public SubSetting MySubsetting = new SubSetting();
        public List<SubSetting> MySubsettings = new List<SubSetting>();
        public HashSet<SubSetting> MyUniqueSubsettings = new HashSet<SubSetting>();
    }

    public record SubSetting
    {
        public int ASetting;
    }
}
