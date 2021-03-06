// Copyright 1998-2016 Epic Games, Inc. All Rights Reserved.

namespace UnrealBuildTool.Rules
{
	public class GenericGraphEditor : ModuleRules
	{
		public GenericGraphEditor(ReadOnlyTargetRules Target) : base(Target)
        {
			PublicIncludePaths.AddRange(
				new string[] {
					// ... add public include paths required here ...
				}
				);

			PrivateIncludePaths.AddRange(
				new string[] {
                    // ... add other private include paths required here ...
                    "GenericGraphEditor/Private",
				}
				);

			PublicDependencyModuleNames.AddRange(
				new string[]
				{
					"Core",
					"CoreUObject",
                    "Engine",
                    "UnrealEd",
					// ... add other public dependencies that you statically link with here ...
				}
				);

			PrivateDependencyModuleNames.AddRange(
				new string[]
				{
                    "GenericGraphRuntime",
                    "AssetTools",
                    "Slate",
                    "SlateCore",
                    "GraphEditor",
                    "PropertyEditor",
                    "EditorStyle",
                    "Kismet",
                    "KismetWidgets",
					// ... add private dependencies that you statically link with here ...
				}
				);

			DynamicallyLoadedModuleNames.AddRange(
				new string[]
				{
					// ... add any modules that your module loads dynamically here ...
                }
				);
		}
	}
}