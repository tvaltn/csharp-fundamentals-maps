using csharp_fundamentals_maps.Main;
using NUnit.Framework;

namespace csharp_fundamentals_maps.Test
{
    class ExerciseTest
    {
        Exercise exercise;

        public ExerciseTest()
        {
            this.exercise = new Exercise();
        }

        [Test]
        public void shouldReturnMappedValues()
        {
            Assert.AreEqual("Nathan", this.exercise.getValue("firstName"));
            Assert.AreEqual("King", this.exercise.getValue("lastName"));
            Assert.AreEqual("Software Developer", this.exercise.getValue("occupation"));
        }

}