#!/bin/bash

BuildVersion=$1
BuildNumber=$2
CommitHash=$3
ProjectName=$4

ProjectDir="$(dirname $0)/../.."
ClientVersionFile="$ProjectDir/Unity$ProjectName/Assets/BuildScripts/Runtime/GameVersion.cs"

echo "
// This file was generated by jenkins
// Please don't change this
namespace GameFoundation.BuildScripts.Runtime
{
    public class GameVersion
    {
        public static string Version     => \"$BuildVersion\";
        public static int    BuildNumber => $BuildNumber;
        public static string FullInfo    => \"v$BuildVersion - Build: $BuildNumber - $(date)\";
        public static string ProjectName => \"$ProjectName\";
    }
}" >$ClientVersionFile

echo "GameVersion.cs updated:"
cat $ClientVersionFile
