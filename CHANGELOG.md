# Changelog
All notable changes to this project will be documented in this file using the standards as defined at [Keep a Changelog](https://keepachangelog.com/en/1.0.0/). This project adheres to [Semantic Versioning](https://semver.org/spec/v2.0.0).

### Version 5.0.1 *(2024-10-18)*
This version of the Mintegral Adapter supports the following native SDK dependencies:
  * Android: `com.chartboost:chartboost-mediation-adapter-mintegral:chartboost-mediation-adapter-mintegral:5.16.8.+`
  * iOS: `ChartboostMediationAdapterMintegral: ~> 5.7.6.0`

### Version 5.0.0 *(2024-08-08)*

First version of the Chartboost Mediation Unity SDK - Mintegral Adapter.

#Added
- Support for the following `Mintegral` dependencies. Notice adapter dependencies are optimistic and any patches and hot-fixes will be automatically picked up.:
    * Android: `com.chartboost:chartboost-mediation-adapter-mintegral:5.16.7+`
    * iOS: `ChartboostMediationAdapterMintegral ~> 5.7.6.0`
    
- `MintegralAdapter.cs` with Configuration Properties for `Mintegral`.
- The following properties have been added in `MintegralAdapter.cs`
    * `string AdapterUnityVersion`
    * `string AdapterNativeVersion`
    * `string PartnerSDKVersion`
    * `string PartnerIdentifier`
    * `string PartnerDisplayName`
    * `bool MuteAudio`