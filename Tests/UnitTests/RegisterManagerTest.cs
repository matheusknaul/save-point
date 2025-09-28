using Models.Entities;
using UnitTests.Entities;
using UnitTests.FakeBuilders;

namespace UnitTests
{
    public class RegisterManagerTest
    {
        #region AuxiliaryMethods



        #endregion

        #region Test Methods

        [Theory]
        [InlineData(5)]
        [InlineData(15)]
        [InlineData(35)]
        public void CreateManager_WhenCalled_ShouldAssignIncrementalId(int samplesQuantity)
        {
            var registerManager = new RegisterManager<Sample>();

            for(int i = 0; i < samplesQuantity; i++)
            {
                registerManager.CreateRegister(FakeSample.Create());
            }

            Assert.Equal(samplesQuantity, registerManager.LastId);

        }

        #endregion
    }
}
