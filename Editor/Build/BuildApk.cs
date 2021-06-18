using System.Threading.Tasks;
using UnityEditor;
using UnityEditor.Build.Reporting;
using UnityEngine;

namespace UniTools.Build.Android
{
    [CreateAssetMenu(
        fileName = nameof(BuildApk),
        menuName = nameof(UniTools) + "/Build/Steps/" + nameof(Android) + "/" + nameof(BuildApk)
    )]
    public sealed class BuildApk : ScriptableBuildStepWithOptions
    {
        
        public override BuildTarget Target => BuildTarget.Android;

        public override async Task<BuildReport> Execute()
        {
            BuildPlayerOptions buildPlayerOptions = Options;
            BuildReport report = UnityEditor.BuildPipeline.BuildPlayer(buildPlayerOptions);
            await Task.CompletedTask;

            return report;
        }
    }
}