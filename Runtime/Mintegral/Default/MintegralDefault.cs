using Chartboost.Mediation.Mintegral.Common;

namespace Chartboost.Mediation.Mintegral.Default
{
    internal class MintegralDefault : IMintegralAdapter
    {
        /// <inheritdoc/>
        public string AdapterNativeVersion => MintegralAdapter.AdapterUnityVersion;

        /// <inheritdoc/>
        public string PartnerSDKVersion => MintegralAdapter.AdapterUnityVersion;
        
        /// <inheritdoc/>
        public string PartnerIdentifier => "mintegral";
        
        /// <inheritdoc/>
        public string PartnerDisplayName => "Mintegral";

        /// <inheritdoc/>
        public bool MuteAudio { get; set; }
    }
}
