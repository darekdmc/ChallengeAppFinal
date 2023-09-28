﻿namespace ChallengeAppFinal.Tests
{
    public class TypeTests
    {
        [Test]
        public void IntValueType_test()
        {   // arrange
            int number1 = 1;
            int number2 = 2;
            // act
            // assert
            Assert.AreNotEqual(number1, number2);
        }
        [Test]
        public void FloatValueType_test()
        {   // arrange
            float number3 = 2.5f;
            float number4 = 2.5f;
            // act
            var floatsum = number3 + number4;
            // assert
            Assert.AreEqual(5, floatsum);
        }
        [Test]
        public void StringHybridType_test()
        {   // arrange
            string number5 = "1";
            string number6 = "2";
            // act
            // assert
            Assert.AreNotEqual(number5, number6);
        }
        
    }
}

