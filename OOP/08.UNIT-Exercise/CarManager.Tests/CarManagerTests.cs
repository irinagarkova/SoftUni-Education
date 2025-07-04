namespace CarManager.Tests
{
    using NUnit.Framework;
    using System;
    using static System.Net.Mime.MediaTypeNames;

    [TestFixture]
    public class CarManagerTests
    {
        private string _make;
        private string _model;
        private double _fuelConsumption;
        private double _fuelCapacity;

        [SetUp]
        public void SetUp()
        {
            this._make = GenerateRandomString();
            this._model = GenerateRandomString();
            this. _fuelConsumption = Random.Shared.NextDouble();
            this._fuelCapacity = Random.Shared.NextDouble();
        }

        [Test]
        public void Car_Should_Be_Create_Successfully()
        {
            Car car = this.CreateCar();

            Assert.AreEqual(_make, car.Make);
            Assert.AreEqual(_model, car.Model);
            Assert.AreEqual(_fuelConsumption, car.FuelConsumption);
            Assert.AreEqual(_fuelCapacity, car.FuelCapacity);
            Assert.AreEqual(0, car.FuelAmount);
        }

        [TestCase(null)]
        [TestCase("")]
        public void Car_Should_Notbe_Created_If_Make_Is_Invalid(string make)
        {
            Assert.Throws<ArgumentException>(()
                => new Car(make, _model, _fuelConsumption, _fuelCapacity));
        }

        [TestCase(null)]
        [TestCase("")]
        public void Car_Should_Notbe_Created_If_Model_Is_Invalid(string model)
        {
            Assert.Throws<ArgumentException>(()
                => new Car(_make, model, _fuelConsumption, _fuelCapacity));
        }

        [TestCase(0)]
        [TestCase(-10)]
        public void Car_Should_Notbe_Created_If_fuelConsumption_Is_Invalid(double fuelConsumption)
        {
            Assert.Throws<ArgumentException>(()
                => new Car(_make, _model, fuelConsumption, _fuelCapacity));
        }

        [TestCase(0)]
        [TestCase(-1)]
        public void Car_Should_Notbe_Created_If_fuelCapacity_Is_Invalid(double fuelCapacity)
        {
            Assert.Throws<ArgumentException>(()
                => new Car(_make, _model, _fuelConsumption, fuelCapacity));
        }

        [TestCase(0)]
        [TestCase(-1)]
        public void Refuel_Should_Throw_If_InvalidArgument_IsPassed(double refuelAmount)
        {
            Car car = this.CreateCar();
            Assert.Throws<ArgumentException>(() => car.Refuel(refuelAmount));
        }

        [TestCase(0.5)]
        [TestCase(0.75)]
        [TestCase(1)]
        public void Refuel_Should_Work_Correctly(double fillPercentage)
        {
            Car car = this.CreateCar();
            double refuelAmount = _fuelCapacity * fillPercentage;

            car.Refuel(refuelAmount);
            Assert.AreEqual(refuelAmount, car.FuelAmount);
        }
        [Test]
        public void RefuelShouldBeLimitedToTheFuelCapacity()
        {
            var car = this.CreateCar();
            var refuelAmount = car.FuelCapacity * 2;

            car.Refuel(refuelAmount);

            Assert.AreEqual(car.FuelCapacity, car.FuelAmount);
        }

        [Test]
        public void DriveShouldWorkCorrectly()
        {
            var car = this.CreateCar();

            car.Refuel(car.FuelCapacity);
            car.Drive(100);

            Assert.AreEqual(car.FuelCapacity - car.FuelConsumption, car.FuelAmount);
        }

        [Test]
        public void DriveShouldThrowIfFuelIsNotEnough()
        {
            var car = this.CreateCar();

            car.Refuel(car.FuelCapacity);

            Assert.Throws<InvalidOperationException>(() => car.Drive(10000));
        }

        private Car CreateCar ()
            => new Car(this._make, this._model, this._fuelConsumption, this._fuelCapacity);

        private static string GenerateRandomString()
        {
            var randomTextLength = Random.Shared.Next(minValue: 5, maxValue: 50);
            return GenerateRandomString(randomTextLength);
        }

        private static string GenerateRandomString(int length)
        {
            var symbols = new char[length];
            for (var i = 0; i < length; i++)
            {
                var randomLetterIndex = Random.Shared.Next(maxValue: 26);
                symbols[i] = (char)('a' + randomLetterIndex);
            }

            return new string(symbols);
        }
    }
}