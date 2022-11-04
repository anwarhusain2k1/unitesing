﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moq;
using NUnit.Framework;

namespace unittesting
{
        [TestFixture]
        public class Class1
        {

            [Test]
            public void Mocking()
            {
                int x = 9, y = 19;
                Mock<ICalculator> mockCalc = new Mock<ICalculator>();
                ICalculator calc = mockCalc.Object;
                Assert.That(calc, Is.Not.Null);
            }
        } 
    
}
