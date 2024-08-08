using Chartboost.Logging;
using Chartboost.Mediation.Mintegral;
using Chartboost.Tests.Runtime;
using NUnit.Framework;

namespace Chartboost.Tests
{
    internal class MintegralAdapterTests
    {
        [SetUp]
        public void SetUp()
            => LogController.LoggingLevel = LogLevel.Debug;

        [Test]
        public void AdapterNativeVersion()
            => TestUtilities.TestStringGetter(() => MintegralAdapter.AdapterNativeVersion);

        [Test]
        public void PartnerSDKVersion()
            => TestUtilities.TestStringGetter(() => MintegralAdapter.PartnerSDKVersion);

        [Test]
        public void PartnerIdentifier()
            => TestUtilities.TestStringGetter(() => MintegralAdapter.PartnerIdentifier);

        [Test]
        public void PartnerDisplayName()
            => TestUtilities.TestStringGetter(() => MintegralAdapter.PartnerDisplayName);

        [Test]
        public void MuteAudio() =>
            TestUtilities.TestBooleanAccessor(() => MintegralAdapter.MuteAudio, value => MintegralAdapter.MuteAudio = value);
    }
}
