using Bogus;
using UnitTests.Entities;

namespace UnitTests.FakeBuilders
{
    public static class FakeSample
    {
        public static Sample Create()
        {
            var sampleFaker = new Faker<Sample>()
                .RuleFor(s => s.Name, f => f.Lorem.Word())
                .RuleFor(s => s.Description, f => f.Lorem.Sentence());
            return sampleFaker.Generate();
        }
    }
}
