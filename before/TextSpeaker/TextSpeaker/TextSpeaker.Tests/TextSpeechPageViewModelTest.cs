using Moq;
using NUnit.Framework;
using TextSpeaker.Model;

// ReSharper disable once CheckNamespace
namespace TextSpeaker.ViewModels.Tests
{
    [TestFixture]
    public class TextSpeechPageViewModelTest
    {
        [Test]
        public void SpeechTest()
        {
            var viewModel = new TextSpeechPageViewModel();
            viewModel.Speech();
        }
    }
}
