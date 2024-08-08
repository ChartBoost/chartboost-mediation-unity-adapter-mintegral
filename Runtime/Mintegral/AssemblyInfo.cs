using System.Runtime.CompilerServices;
using Chartboost.Mediation.Mintegral;
using UnityEngine.Scripting;

[assembly: AlwaysLinkAssembly]
[assembly: InternalsVisibleTo(AssemblyInfo.MintegralAssemblyInfoAndroid)]
[assembly: InternalsVisibleTo(AssemblyInfo.MintegralAssemblyInfoIOS)]

namespace Chartboost.Mediation.Mintegral
{
    internal class AssemblyInfo
    {
        public const string MintegralAssemblyInfoAndroid = "Chartboost.Mediation.Mintegral.Android";
        public const string MintegralAssemblyInfoIOS = "Chartboost.Mediation.Mintegral.IOS";
    }
}
