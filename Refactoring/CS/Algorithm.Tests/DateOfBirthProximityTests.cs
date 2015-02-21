using System;
using System.Collections.Generic;
using NUnit.Framework;

namespace Algorithm.Test
{    
    [TestFixture]
    public class DateOfBirthProximityTests
    {
        Person sue = new Person() { Name = "Sue", BirthDate = new DateTime(1950, 1, 1) };
        Person greg = new Person() { Name = "Greg", BirthDate = new DateTime(1952, 6, 1) };
        Person sarah = new Person() { Name = "Sarah", BirthDate = new DateTime(1982, 1, 1) };
        Person mike = new Person() { Name = "Mike", BirthDate = new DateTime(1979, 1, 1) };

        [Test]
        public void Returns_Empty_Results_When_Given_Empty_List()
        {
            var list = new List<Person>();
            var finder = new DateOfBirthProximityService(list);

            var result = finder.Find(DateOfBirthProximity.Closest);

            Assert.Null(result.P1);
            Assert.Null(result.P2);
        }

        [Test]
        public void Returns_Empty_Results_When_Given_One_Person_AndAskedForClosest()
        {
            var list = new List<Person>() { sue };
            var finder = new DateOfBirthProximityService(list);

            var result = finder.Find(DateOfBirthProximity.Closest);

            Assert.That(result.P1, Is.Null);
            Assert.That(result.P2, Is.Null);
        }

        [Test]
        public void Returns_Empty_Results_When_Given_One_Person_AndAskedForFurthest()
        {
            var list = new List<Person>() { sue };
            var finder = new DateOfBirthProximityService(list);

            var result = finder.Find(DateOfBirthProximity.Furthest);

            Assert.That(result.P1, Is.Null);
            Assert.That(result.P2, Is.Null);
        }

        [Test]
        public void Returns_Closest_Two_For_Two_People()
        {
            var list = new List<Person>() { sue, greg };
            var finder = new DateOfBirthProximityService(list);

            var result = finder.Find(DateOfBirthProximity.Closest);

            Assert.That(sue, Is.SameAs(result.P1));
            Assert.That(greg, Is.SameAs(result.P2));
        }

        [Test]
        public void Returns_Furthest_Two_For_Two_People()
        {
            var list = new List<Person>() { greg, mike };
            var finder = new DateOfBirthProximityService(list);

            var result = finder.Find(DateOfBirthProximity.Furthest);

            Assert.That(greg, Is.SameAs(result.P1));
            Assert.That(mike, Is.SameAs(result.P2));
        }

        [Test]
        public void Returns_Closest_Two_For_Three_People()
        {
            var list = new List<Person>() { sue, greg, mike };
            var finder = new DateOfBirthProximityService(list);

            var result = finder.Find(DateOfBirthProximity.Closest);

            Assert.That(sue, Is.SameAs(result.P1));
            Assert.That(greg, Is.SameAs(result.P2));
        }

        [Test]
        public void Returns_Furthest_Two_For_Three_People()
        {
            var list = new List<Person>() { greg, mike, sue };
            var finder = new DateOfBirthProximityService(list);

            var result = finder.Find(DateOfBirthProximity.Furthest);

            Assert.That(sue, Is.SameAs(result.P1));
            Assert.That(mike, Is.SameAs(result.P2));
        }

        [Test]
        public void Returns_Furthest_Two_For_Four_People()
        {
            var list = new List<Person>() { greg, mike, sarah, sue };
            var finder = new DateOfBirthProximityService(list);

            var result = finder.Find(DateOfBirthProximity.Furthest);

            Assert.That(sue, Is.SameAs(result.P1));
            Assert.That(sarah, Is.SameAs(result.P2));
        }

        [Test]
        public void Returns_Closest_Two_For_Four_People()
        {
            var list = new List<Person>() { greg, mike, sarah, sue };
            var finder = new DateOfBirthProximityService(list);

            var result = finder.Find(DateOfBirthProximity.Closest);

            Assert.That(sue, Is.SameAs(result.P1));
            Assert.That(greg, Is.SameAs(result.P2));
        }

    }
}