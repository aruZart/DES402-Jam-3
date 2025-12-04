using UnrealBuildTool;

public class ChildfreeServerTarget : TargetRules
{
	public ChildfreeServerTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Server;
		ExtraModuleNames.Add("Childfree");
	}
}
