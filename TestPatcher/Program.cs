using System;
using System.Collections.Generic;
using System.Linq;
using Mutagen.Bethesda;
using Mutagen.Bethesda.Synthesis;
using Mutagen.Bethesda.Skyrim;
using System.Threading.Tasks;

namespace TestPatcher
{
    public class Program
    {
        public static async Task<int> Main(string[] args)
        {
            var ret = await SynthesisPipeline.Instance
                .AddRunnabilityCheck(RunnabilityCheck)
                .AddPatch<ISkyrimMod, ISkyrimModGetter>(RunPatch)
                .Run(args);
            return ret;
        }

        public static void RunPatch(IPatcherState<ISkyrimMod, ISkyrimModGetter> state)
        {
            //Your code here!
        }

        public static async Task RunnabilityCheck(IRunnabilityState state)
        {
            state.LoadOrder.AssertHasMod(ModKey.FromNameAndExtension("test.esl"));
        }
    }
}
