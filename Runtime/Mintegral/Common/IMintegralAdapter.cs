using Chartboost.Mediation.Adapters;

namespace Chartboost.Mediation.Mintegral.Common
{
    /// <summary>
    /// The Chartboost Mediation Mintegral adapter.
    /// </summary>
    internal interface IMintegralAdapter : IPartnerAdapterConfiguration
    {
        /// <summary>
        /// Enable/disable Mintegral's mute setting.
        /// </summary>
        public bool MuteAudio { get; set; }
    }
}
