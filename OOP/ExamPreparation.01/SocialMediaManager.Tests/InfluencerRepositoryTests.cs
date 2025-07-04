using System;
using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;

namespace SocialMediaManager.Tests
{
    public class InfluencerRepositoryTests
    {
        private InfluencerRepository influencerRepository;
        [SetUp]
        public void Setup()
        {
            influencerRepository = new();
        }

        [Test]
        public void NewInfluencerRepository_ShouldInitializedInfluencersCollectionCorrectly()
        {
            Assert.NotNull(influencerRepository.Influencers);
            Assert.AreEqual(0, influencerRepository.Influencers.Count);
        }

        [Test]
        public void RegisterInfluencer_ShouldThrowArgumentNullException_WhenInfluencerIsNull()
        {
          Assert.Throws<ArgumentNullException>(() =>_= influencerRepository.RegisterInfluencer(null));
        }

        [Test]
        public void RegisterInfluencer_ShouldThrowInvalidOperationException_WhenInfluencerAlreadyRegistered()
        {
            Influencer influencer = new("Irina", 1234);
            _ = influencerRepository.RegisterInfluencer(influencer);

            Assert.Throws<InvalidOperationException>(() => _ = influencerRepository.RegisterInfluencer(influencer));
        }

        [Test]
        public void RegisterInfluencer_ValidData_ReturnsMessage()
        {
            Influencer influencer = new("Irina", 1234);

           string message = influencerRepository.RegisterInfluencer(influencer);

            Assert.AreEqual($"Successfully added influencer {influencer.Username} with {influencer.Followers}", message);
            Assert.AreEqual(1, influencerRepository.Influencers.Count);
        }

        [TestCase(null)]
        [TestCase("")]
        [TestCase(" ")]
        [TestCase("   ")]
        public void RemoveInfluencer_ShouldThrowArgumentNullException_WhenUserNameIsNullOrWhiteSpace(string name)
        { 
            Assert.Throws<ArgumentNullException>(() => _ = influencerRepository.RemoveInfluencer(name));
        }

        [Test]
        public void RemoveInfluencer_ExistingInfluencer_ShouldReturnTrue()
        {
            Influencer influencer = new("Irina", 1234);
           _= influencerRepository.RegisterInfluencer(influencer);

            bool removed = influencerRepository.RemoveInfluencer(influencer.Username);
            Assert.IsTrue(removed);
        }

        [Test]
        public void RemoveInfluencer_UnexistingInfluencer_ShouldReturnFalse()
        {
            Influencer influencer = new("Irina", 1234);

            bool removed = influencerRepository.RemoveInfluencer(influencer.Username);
            Assert.IsFalse(removed);
        }
        [Test]
        public void GetInfluencerWithMostFollowers_ShouldWorkCorrect()
        {
            Influencer influencer = new("Irina", 1234);
            Influencer influencer2 = new("Ira", 123456);
            Influencer influencer3 = new("Simona", 12345);

            _= influencerRepository.RegisterInfluencer(influencer);
            _= influencerRepository.RegisterInfluencer(influencer2);
            _= influencerRepository.RegisterInfluencer(influencer3);

            Influencer actual = influencerRepository.GetInfluencerWithMostFollowers();
            Assert.AreEqual(influencer2.Username, actual.Username);
            Assert.AreEqual(influencer2.Followers, actual.Followers);
        }
        [Test]
        public void GetInfluencer_WhenFound_ShouldReturnCorrectInfluencer()
        {
            Influencer expected = new("Irina", 1234);

            _ = influencerRepository.RegisterInfluencer(expected);

           Influencer actual= influencerRepository.GetInfluencer(expected.Username);
            Assert.AreEqual(expected.Username, actual.Username);
            Assert.AreEqual(expected.Followers, actual.Followers);
        }
        [Test]
        public void GetInfluencer_WhenNotFound_ShouldReturnNull()
        {
            Influencer expected = new("Irina", 1234);

            Influencer actual = influencerRepository.GetInfluencer(expected.Username);

            Assert.Null(actual);
        }
    }
}