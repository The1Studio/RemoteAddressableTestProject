<#
    .SYNOPSIS
    Set content for MANVersion file so client will know the version of game and other info
#>

Param ($BuildVersion, $BuildNumber, $CommitHash, $ProjectName)

# Include our required utility files
. "$PSScriptRoot/Util_BuildTools.ps1"

# Store our current MNA application version into a globally available variable for client
$ClientVersionFile = "$ProjectDir//Unity$ProjectName/Assets/BuildScripts/Runtime/GameVersion.cs"
echo $ClientVersionFile
Set-Content -Path $ClientVersionFile "// This file was generated by jenkins
// Please don't change this
namespace GameFoundation.BuildScripts.Runtime
{
    public class GameVersion
    {
        public static string Version     => `"$BuildVersion`";
        public static int    BuildNumber => $BuildNumber;
        public static string FullInfo    => `"v$BuildVersion - Build: $BuildNumber - $( Get-Date )`";
        public static string ProjectName => `"$ProjectName`";
    }
}"