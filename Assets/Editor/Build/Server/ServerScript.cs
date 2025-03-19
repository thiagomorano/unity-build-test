using UnityEditor;
using System.IO;

public class ServerBuild
{
  [MenuItem("Build/Server")]
  public static void BuildServer()
  {
    string path = "Build/Server/";

    BuildPlayerOptions buildPlayerOptions = new BuildPlayerOptions();
    buildPlayerOptions.scenes = new[] { "Assets/Scenes/SampleScene.unity" };
    buildPlayerOptions.locationPathName = path + "unity-test.x86_64";
    buildPlayerOptions.target = BuildTarget.StandaloneLinux64;
    buildPlayerOptions.subtarget = (int)StandaloneBuildSubtarget.Server;
    buildPlayerOptions.options = BuildOptions.Development;

    BuildPipeline.BuildPlayer(buildPlayerOptions);

    // Copy over the 
    string dockerfileOutputPath = Path.Combine(path, "Dockerfile");
    File.Copy("Assets/Editor/Build/Server/Dockerfile", dockerfileOutputPath, true);
  }
}