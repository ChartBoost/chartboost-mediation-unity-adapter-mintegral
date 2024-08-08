#import "CBMDelegates.h"
#import "ChartboostUnityUtilities.h"
#import <ChartboostMediationAdapterMintegral/ChartboostMediationAdapterMintegral-Swift.h>

extern "C" {

    const char * _CBMMintegralAdapterAdapterVersion(){
        return toCStringOrNull([MintegralAdapterConfiguration adapterVersion]);
    }

    const char * _CBMMintegralAdapterPartnerSDKVersion(){
        return toCStringOrNull([MintegralAdapterConfiguration partnerSDKVersion]);
    }

    const char * _CBMMintegralAdapterPartnerId(){
        return toCStringOrNull([MintegralAdapterConfiguration partnerID]);
    }

    const char * _CBMMintegralAdapterPartnerDisplayName(){
        return toCStringOrNull([MintegralAdapterConfiguration partnerDisplayName]);
    }

    BOOL _CBMMintegralAdapterGetMuteAudio(){
        return [MintegralAdapterConfiguration isMuted];
    }

    void _CBMMintegralAdapterSetMuteAudio(BOOL muteAudio){
        [MintegralAdapterConfiguration setIsMuted:muteAudio];
    }
}
