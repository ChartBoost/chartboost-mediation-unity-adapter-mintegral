using System.Runtime.InteropServices;
using Chartboost.Constants;
using Chartboost.Mediation.Mintegral.Common;
using UnityEngine;

namespace Chartboost.Mediation.Mintegral.IOS
{
    internal sealed class MintegralAdapter : IMintegralAdapter
    {
        [RuntimeInitializeOnLoadMethod]
        private static void RegisterInstance()
        {
            if (Application.isEditor)
                return;
            Mintegral.MintegralAdapter.Instance = new MintegralAdapter();
        }

        /// <inheritdoc/>
        public string AdapterNativeVersion => _CBMMintegralAdapterAdapterVersion();
        
        /// <inheritdoc/>
        public string PartnerSDKVersion => _CBMMintegralAdapterPartnerSDKVersion();
        
        /// <inheritdoc/>
        public string PartnerIdentifier => _CBMMintegralAdapterPartnerId();
        
        /// <inheritdoc/>
        public string PartnerDisplayName => _CBMMintegralAdapterPartnerDisplayName();

        /// <inheritdoc/>
        public bool MuteAudio
        {
            get => _CBMMintegralAdapterGetMuteAudio();
            set => _CBMMintegralAdapterSetMuteAudio(value);
        }

        [DllImport(SharedIOSConstants.DLLImport)] private static extern string _CBMMintegralAdapterAdapterVersion();
        [DllImport(SharedIOSConstants.DLLImport)] private static extern string _CBMMintegralAdapterPartnerSDKVersion();
        [DllImport(SharedIOSConstants.DLLImport)] private static extern string _CBMMintegralAdapterPartnerId();
        [DllImport(SharedIOSConstants.DLLImport)] private static extern string _CBMMintegralAdapterPartnerDisplayName();
        [DllImport(SharedIOSConstants.DLLImport)] private static extern bool _CBMMintegralAdapterGetMuteAudio();
        [DllImport(SharedIOSConstants.DLLImport)] private static extern void _CBMMintegralAdapterSetMuteAudio(bool muteAudio);
    }
}
