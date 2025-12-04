using UnrealBuildTool;

public class ChildfreeTarget : TargetRules
{
	public ChildfreeTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Game;
		ExtraModuleNames.Add("Childfree");
	}
}
