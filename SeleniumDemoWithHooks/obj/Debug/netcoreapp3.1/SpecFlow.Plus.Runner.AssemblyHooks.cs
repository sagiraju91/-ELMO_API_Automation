// <auto-generated />

using global::TechTalk.SpecFlow;
using global::System.Runtime.CompilerServices;

public class SeleniumDemoWithHooks_SpecFlowPlusRunnerAssemblyHooks
{
    [global::TechTalk.SpecRun.AssemblyInitialize]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void AssemblyInitialize()
    {
        TestRunnerManager.OnTestRunStart();
    }

    [global::TechTalk.SpecRun.AssemblyCleanup]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void AssemblyCleanup()
    {
        TestRunnerManager.OnTestRunEnd();
    }
}
