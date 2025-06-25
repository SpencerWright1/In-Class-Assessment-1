using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using eToursLib;
using FluentAssertions;

namespace eTours_Unit_Testing
{
    public class Destination_Should
    {
        //TODO: Activity 1
        //place your unit tests here
        [Fact]
        public void Store_Valid_Location_And_VisitDate()
        {
            var dest = new Destination("Edmonton", DateTime.Today.AddDays(1));
            dest.Location.Should().Be("Edmonton");
            dest.VisitDate.Should().Be(DateTime.Today.AddDays(1));
            dest.ToString().Should().Be("Edmonton," + DateTime.Today.AddDays(1).ToString("MMM dd yyyy"));
        }

        [Fact]
        public void Throw_ArgumentNullException_When_Location_Is_Null()
        {
            Action act = () => new Destination(null, DateTime.Today);
            act.Should().Throw<ArgumentNullException>()
                .WithMessage("*Location is required*");
        }

        [Fact]
        public void Throw_ArgumentException_When_Location_Is_Empty()
        {
            Action act = () => new Destination("   ", DateTime.Today);
            act.Should().Throw<ArgumentException>()
                .WithMessage("*Location cannot be empty*");
        }

        [Fact]
        public void Throw_ArgumentException_When_VisitDate_Is_Past()
        {
            Action act = () => new Destination("Edmonton", DateTime.Today.AddDays(-1));
            act.Should().Throw<ArgumentException>()
                .WithMessage("*VisitDate must be today or in the future*");
        }
    }
}
