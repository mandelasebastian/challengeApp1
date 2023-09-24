using challengeApp1;
using System.Reflection.Metadata;

namespace ChallengeApp.Test
{
    public class Tests
    {

        [Test]
        public void WhenEmployeeCollectTwoScoresShouldReturnCorrrectResult()
        {
            //arrange
            var employee1 = new Employee("sebastian", "Mandela", 41);
            employee1.AddScore(9);
            employee1.AddScore(10);

            //act
            var result = employee1.Result;


            //assert
            Assert.AreEqual(19, result);
        }
        [Test]
        public void WhenEmployeeColectDifferentScoresShouldResult()
        {
            //arrange
            var employee2 = new Employee("Aldona", "Mandela", 36);
            employee2.AddScore(11);
            employee2.AddScore(-2);

            //act
            var result = employee2.Result;


            //assert
            Assert.AreEqual(9, result);

        }
        [Test]
        public void WhenEmployeeCollectMinusScoreShouldResult()
        {
            //arrange
            var employee3 = new Employee("Iga", "Mandela", 18);
            employee3.AddScore(10);
            employee3.AddScore(-11);
            employee3.AddScore(-6);
            

            //act
            var result = employee3.Result;
        
           


            //assert
            Assert.AreEqual(-7, result);
        }

    }
}