using CabVoiceGenerator;
using NUnit.Framework;

namespace CabReservationTestCase
{ 
    public class Tests
    {
        InvoiceGenerator generator;
        [SetUp]
        public void Setup()
        {
            generator = new InvoiceGenerator();
        }
        // UC 1- Total Fare for Single Ride
        [Test]
        [TestCase(6, 6)]
        public void Given_TimeAndDistance_CalculateFare(double distance, double time)
        {
            Ride ride = new Ride(distance, time);
            int expected = 66;
            Assert.AreEqual(expected, generator.CalculateFare(ride));
        }
        /// TC1.1 - Check for Invalid Distance
        [Test]
        public void Given_InvalidDistance_ThrowException()
        {
            Ride ride = new Ride(-5, 1);
            InvoiceGeneratorException invoiceGeneratorException = Assert.Throws<InvoiceGeneratorException>(() => generator.CalculateFare(ride));
            Assert.AreEqual(InvoiceGeneratorException.ExceptionType.INVALID_DISTANCE, invoiceGeneratorException.type);
        }
        // TC1.2- Check for Invalid Time
        [Test]
        public void Given_InvalidTime_ThrowException()
        {
            Ride ride = new Ride(1, -4);
            InvoiceGeneratorException invoiceGeneratorException = Assert.Throws<InvoiceGeneratorException>(() => generator.CalculateFare(ride));
            Assert.AreEqual(InvoiceGeneratorException.ExceptionType.INVALID_TIME, invoiceGeneratorException.type);
        }
    }

}
