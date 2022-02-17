using NUnit.Framework;

namespace TestProject1
{
    public class Tests
    {
        [TestCase(1, 1, 1,1, 60)]

        public void CalculateDistance(int step, int stepCount, int hour, int minute,int totalDistance)
        {
            var result = CalculateDistance(step,stepCount, hour, minute);
            Assert.That(result, Is.EqualTo(totalDistance));
        }


        [TestCase(1,1,1,60)]
    
        public void ControlStepCount(int stepCount, int hour, int minute, int totalStep)
        {
            var result = CalculateStep(stepCount, hour, minute);
            Assert.That(result, Is.EqualTo(totalStep));
        }

        [Test]
        public void Test1()
        {
            Assert.Pass();
        }
    }
}