using Chartboost.Constants;
using Chartboost.Mediation.Mintegral.Common;
using UnityEngine;

namespace Chartboost.Mediation.Mintegral.Android
{
    internal sealed class MintegralAdapter : IMintegralAdapter
    {
        private const string MintegralAdapterConfiguration = "com.chartboost.mediation.mintegraladapter.MintegralAdapterConfiguration";
        private const string FunctionGetMute = "getMute";
        private const string FunctionSetMute = "setMute";
        
        [RuntimeInitializeOnLoadMethod]
        private static void RegisterInstance()
        {
            if (Application.isEditor)
                return;
            Mintegral.MintegralAdapter.Instance = new MintegralAdapter();
        }
        
        /// <inheritdoc/>
        public string AdapterNativeVersion
        {
            get
            {
                using var adapterConfiguration = new AndroidJavaObject(MintegralAdapterConfiguration);
                return adapterConfiguration.Call<string>(SharedAndroidConstants.FunctionGetAdapterVersion);
            }
        }
        
        /// <inheritdoc/>
        public string PartnerSDKVersion 
        {
            get
            {
                using var adapterConfiguration = new AndroidJavaObject(MintegralAdapterConfiguration);
                return adapterConfiguration.Call<string>(SharedAndroidConstants.FunctionGetPartnerSdkVersion);
            }
        }
        
        /// <inheritdoc/>
        public string PartnerIdentifier
        {
            get
            {
                using var adapterConfiguration = new AndroidJavaObject(MintegralAdapterConfiguration);
                return adapterConfiguration.Call<string>(SharedAndroidConstants.FunctionGetPartnerId);
            }
        }
        
        /// <inheritdoc/>
        public string PartnerDisplayName 
        {
            get
            {
                using var adapterConfiguration = new AndroidJavaObject(MintegralAdapterConfiguration);
                return adapterConfiguration.Call<string>(SharedAndroidConstants.FunctionGetPartnerDisplayName);
            }
        }

        /// <inheritdoc/>
        public bool MuteAudio
        {
            get
            {
                using var adapterConfiguration = new AndroidJavaObject(MintegralAdapterConfiguration);
                return adapterConfiguration.Call<bool>(FunctionGetMute);
            }
            set
            {
                using var adapterConfiguration = new AndroidJavaObject(MintegralAdapterConfiguration);
                adapterConfiguration.Call(FunctionSetMute, value);
            }
        }
    }
}
