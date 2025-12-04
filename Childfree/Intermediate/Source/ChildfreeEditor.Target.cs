using UnrealBuildTool;

public class ChildfreeEditorTarget : TargetRules
{
	public ChildfreeEditorTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Editor;
		ExtraModuleNames.Add("Childfree");
	}
}
