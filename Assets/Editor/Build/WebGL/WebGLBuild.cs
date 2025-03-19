using UnityEditor;
using System.Diagnostics;

public class WebGLBuild
{
  [MenuItem("Build/WebGL")]
  public static void BuildServer()
  {
    string path = "Build/WebGL/";

    BuildPlayerOptions buildPlayerOptions = new BuildPlayerOptions();
    buildPlayerOptions.scenes = new[] { "Assets/Scenes/SampleScene.unity" };
    buildPlayerOptions.locationPathName = path;
    buildPlayerOptions.target = BuildTarget.WebGL;
    buildPlayerOptions.options = BuildOptions.Development;

    BuildPipeline.BuildPlayer(buildPlayerOptions);
  }
}