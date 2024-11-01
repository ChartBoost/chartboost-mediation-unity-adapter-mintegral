using Chartboost.Mediation.Adapters;
using Chartboost.Mediation.Mintegral.Common;
using Chartboost.Mediation.Mintegral.Default;

namespace Chartboost.Mediation.Mintegral
{
    /// <inheritdoc cref="IMintegralAdapter"/>
    public static class MintegralAdapter 
    {
        internal static IMintegralAdapter Instance = new MintegralDefault();
        
        /// <summary>
        /// The partner adapter Unity version.
        /// </summary>
        public const string AdapterUnityVersion = "5.0.1";
        
        /// <inheritdoc cref="IPartnerAdapterConfiguration.AdapterNativeVersion"/>
        public static string AdapterNativeVersion => Instance.AdapterNativeVersion;
        
        /// <inheritdoc cref="IPartnerAdapterConfiguration.PartnerSDKVersion"/>
        public static string PartnerSDKVersion => Instance.PartnerSDKVersion;
        
        /// <inheritdoc cref="IPartnerAdapterConfiguration.PartnerIdentifier"/>
        public static string PartnerIdentifier => Instance.PartnerIdentifier;
        
        /// <inheritdoc cref="IPartnerAdapterConfiguration.PartnerDisplayName"/>
        public static string PartnerDisplayName => Instance.PartnerDisplayName;

        /// <inheritdoc cref="IMintegralAdapter.MuteAudio"/>
        public static bool MuteAudio
        {
            get => Instance.MuteAudio;
            set => Instance.MuteAudio = value;
        }
    }
}
