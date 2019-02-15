// Fill out your copyright notice in the Description page of Project Settings.

using UnrealBuildTool;
using System.Collections.Generic;

public class ArcadeVehicleSystemEditorTarget : TargetRules
{
	public ArcadeVehicleSystemEditorTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Editor;

		ExtraModuleNames.AddRange( new string[] { "ArcadeVehicleSystem" } );
	}
}
