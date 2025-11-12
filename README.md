# Chartboost Mediation Unity SDK - Mintegral Adapter

Provides a list of externally configurable properties pertaining to the partner SDK that can be retrieved and set by publishers. 

Dependencies for the adapter are now embedded in the package, and can be found at `com.chartboost.mediation.unity.adapter.mintegral/Editor/MintegralAdapterDependencies.xml`.

# Installation

## Using the public [npm registry](https://www.npmjs.com/search?q=com.chartboost.mediation.unity.adapter.mintegral)

In order to add the Chartboost Mediation Unity SDK - Mintegral Adapter to your project using the npm package, add the following to your Unity Project's ***manifest.json*** file. The scoped registry section is required in order to fetch packages from the NpmJS registry.

```json
"dependencies": {
    "com.chartboost.mediation.unity.adapter.mintegral": "5.1.0",
    ...
},
"scopedRegistries": [
{
    "name": "NpmJS",
    "url": "https://registry.npmjs.org",
    "scopes": [
    "com.chartboost"
    ]
}
]
```
## Using the public [NuGet package](https://www.nuget.org/packages/Chartboost.CSharp.Mediation.Unity.Adapter.Mintegral)

To add the Chartboost Mediation Unity SDK - Mintegral Adapter to your project using the NuGet package, you will first need to add the [NugetForUnity](https://github.com/GlitchEnzo/NuGetForUnity) package into your Unity Project.

This can be done by adding the following to your Unity Project's ***manifest.json***

```json
  "dependencies": {
    "com.github-glitchenzo.nugetforunity": "https://github.com/GlitchEnzo/NuGetForUnity.git?path=/src/NuGetForUnity",
    ...
  },
```

Once <code>NugetForUnity</code> is installed, search for `Chartboost.CSharp.Mediation.Unity.Adapter.Mintegral` in the search bar of Nuget Explorer window(Nuget -> Manage Nuget Packages).
You should be able to see the `Chartboost.CSharp.Mediation.Unity.Adapter.Mintegral` package. Choose the appropriate version and install.

# Usage
The following code block exemplifies usage of the `MintegralAdapter.cs` configuration class.

## IPartnerAdapterConfiguration Properties

```csharp

// AdapterUnityVersion - The partner adapter Unity version, e.g: 5.0.0
Debug.Log($"Adapter Unity Version: {MintegralAdapter.AdapterUnityVersion}");

// AdapterNativeVersion - The partner adapter version, e.g: 5.16.7.71.0
Debug.Log($"Adapter Native Version: {MintegralAdapter.AdapterNativeVersion}");

// PartnerSDKVersion - The partner SDK version, e.g: 16.7.71
Debug.Log($"Partner SDK Version: {MintegralAdapter.PartnerSDKVersion}");

// PartnerIdentifier - The partner ID for internal uses, e.g: mintegral
Debug.Log($"Partner Identifier: {MintegralAdapter.PartnerIdentifier}");

// PartnerDisplayName - The partner name for external uses, e.g: Mintegral
Debug.Log($"Partner Display Name: {MintegralAdapter.PartnerDisplayName}");
```

## Mute Audio
To mute the audio from videos for the Mintegral adapter, the following property has been made available:

```csharp
MintegralAdapter.MuteAudio = true;
```