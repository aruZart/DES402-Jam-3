using UnrealBuildTool;

public class ChildfreeClientTarget : TargetRules
{
	public ChildfreeClientTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Client;
		ExtraModuleNames.Add("Childfree");
	}
}
