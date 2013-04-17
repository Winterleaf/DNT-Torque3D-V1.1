Microsoft Visual Studio Solution File, Format Version 11.00
# Visual Studio 2010
{foreach name=projects item=project from=$projects}
{if $project->name eq "DNT FPS Demo No Core"}
Project("{literal}{FAE04EC0-301F-11D3-BF4B-00C04F79EFBC}{/literal}") = "{$project->name}", "{$project->literalPath}", "{$project->guid}"
EndProject
{/if}
{if $project->name eq "DNT Empty Demo"}
Project("{literal}{FAE04EC0-301F-11D3-BF4B-00C04F79EFBC}{/literal}") = "{$project->name}", "{$project->literalPath}", "{$project->guid}"
EndProject
{/if}
{/foreach}

{foreach name=projects item=project from=$projects}
{if $project->name eq "DNT FPS Demo No Core"}
{else}
{if $project->name eq "DNT Empty Demo"}
{else}
{if $project->projectFileExt eq ".csproj"}
{if $project->literalPath eq ""}
Project("{literal}{FAE04EC0-301F-11D3-BF4B-00C04F79EFBC}{/literal}") = "{$project->name}", "projects/{$project->name}{$project_ext}", "{$project->guid}"
{else}
Project("{literal}{FAE04EC0-301F-11D3-BF4B-00C04F79EFBC}{/literal}") = "{$project->name}", "{$project->literalPath}", "{$project->guid}"
{/if}
{else}
Project("{$solution_guid}") = "{$project->name}", "projects/{$project->name}{$project_ext}", "{$project->guid}"
{/if}
EndProject
{/if}
{/if}
{/foreach}
{foreach key=pname item=v from=$projectExtRefs}
Project("{$v[2]}") = "{$pname}", "{$v[0]}", "{$v[1]}"
EndProject
{/foreach}
Global
	GlobalSection(SolutionConfigurationPlatforms) = preSolution
		Debug|Mixed Platforms = Debug|Mixed Platforms
		Debug|Win32 = Debug|Win32
		Debug|x86 = Debug|x86
		Optimized Debug|Mixed Platforms = Optimized Debug|Mixed Platforms
		Optimized Debug|Win32 = Optimized Debug|Win32
		Optimized Debug|x86 = Optimized Debug|x86
		Release|Mixed Platforms = Release|Mixed Platforms
		Release|Win32 = Release|Win32
		Release|x86 = Release|x86
	EndGlobalSection
	GlobalSection(ProjectConfigurationPlatforms) = postSolution
{foreach name=projects item=project from=$projects}
{if $project->literalPath eq ""}
		{$project->guid}.Debug|Mixed Platforms.ActiveCfg = Debug|Win32
		{$project->guid}.Debug|Mixed Platforms.Build.0 = Debug|Win32
		{$project->guid}.Debug|Win32.ActiveCfg = Debug|Win32
		{$project->guid}.Debug|Win32.Build.0 = Debug|Win32
		{$project->guid}.Debug|x86.ActiveCfg = Debug|Win32
		{$project->guid}.Optimized Debug|Mixed Platforms.ActiveCfg = Optimized Debug|Win32
		{$project->guid}.Optimized Debug|Win32.ActiveCfg = Optimized Debug|Win32
		{$project->guid}.Optimized Debug|Win32.Build.0 = Optimized Debug|Win32
		{$project->guid}.Optimized Debug|x86.ActiveCfg = Optimized Debug|Win32
		{$project->guid}.Release|Mixed Platforms.ActiveCfg = Release|Win32
		{$project->guid}.Release|Win32.ActiveCfg = Release|Win32
		{$project->guid}.Release|Win32.Build.0 = Release|Win32
		{$project->guid}.Release|x86.ActiveCfg = Release|Win32
{else}
{if $project->literalPath eq "..\..\DotNet Torque Empty DLL\DNT Empty DLL.csproj"}
		{$project->guid}.Debug|Any CPU.ActiveCfg = Debug|Any CPU
		{$project->guid}.Debug|Any CPU.Build.0 = Debug|Any CPU
		{$project->guid}.Debug|Mixed Platforms.ActiveCfg = Debug|Any CPU
		{$project->guid}.Debug|Mixed Platforms.Build.0 = Debug|Any CPU
		{$project->guid}.Debug|Win32.ActiveCfg = Debug|Any CPU
		{$project->guid}.Debug|x86.ActiveCfg = Debug|Any CPU
		{$project->guid}.Optimized Debug|Any CPU.ActiveCfg = Debug|Any CPU
		{$project->guid}.Optimized Debug|Any CPU.Build.0 = Debug|Any CPU
		{$project->guid}.Optimized Debug|Mixed Platforms.ActiveCfg = Debug|Any CPU
		{$project->guid}.Optimized Debug|Mixed Platforms.Build.0 = Debug|Any CPU
		{$project->guid}.Optimized Debug|Win32.ActiveCfg = Debug|Any CPU
		{$project->guid}.Optimized Debug|x86.ActiveCfg = Debug|Any CPU
		{$project->guid}.Release|Any CPU.ActiveCfg = Release|Any CPU
		{$project->guid}.Release|Any CPU.Build.0 = Release|Any CPU
		{$project->guid}.Release|Mixed Platforms.ActiveCfg = Release|Any CPU
		{$project->guid}.Release|Mixed Platforms.Build.0 = Release|Any CPU
		{$project->guid}.Release|Win32.ActiveCfg = Release|Any CPU
		{$project->guid}.Release|x86.ActiveCfg = Release|Any CPU
{else}
		{$project->guid}.Debug|Mixed Platforms.ActiveCfg = Debug|x86
		{$project->guid}.Debug|Mixed Platforms.Build.0 = Debug|x86
		{$project->guid}.Debug|Win32.ActiveCfg = Debug|x86
		{$project->guid}.Debug|x86.ActiveCfg = Debug|x86
		{$project->guid}.Debug|x86.Build.0 = Debug|x86
		{$project->guid}.Optimized Debug|Mixed Platforms.ActiveCfg = Debug|x86
		{$project->guid}.Optimized Debug|Mixed Platforms.Build.0 = Debug|x86
		{$project->guid}.Optimized Debug|Win32.ActiveCfg = Debug|x86
		{$project->guid}.Optimized Debug|x86.ActiveCfg = Debug|x86
		{$project->guid}.Optimized Debug|x86.Build.0 = Debug|x86
		{$project->guid}.Release|Mixed Platforms.ActiveCfg = Release|x86
		{$project->guid}.Release|Mixed Platforms.Build.0 = Release|x86
		{$project->guid}.Release|Win32.ActiveCfg = Release|x86
		{$project->guid}.Release|x86.ActiveCfg = Release|x86
		{$project->guid}.Release|x86.Build.0 = Release|x86	
{/if}		
{/if}		
{/foreach}
{foreach key=pname item=v from=$projectExtRefs}
		{$v[1]}.Debug|Win32.ActiveCfg = Debug|Win32
		{$v[1]}.Debug|Win32.Build.0 = Debug|Win32
		{$v[1]}.Optimized Debug|Win32.ActiveCfg = Optimized Debug|Win32
		{$v[1]}.Optimized Debug|Win32.Build.0 = Optimized Debug|Win32
		{$v[1]}.Release|Win32.ActiveCfg = Release|Win32
		{$v[1]}.Release|Win32.Build.0 = Release|Win32
{/foreach}
	EndGlobalSection
	GlobalSection(SolutionProperties) = preSolution
		HideSolutionNode = FALSE
	EndGlobalSection
EndGlobal
