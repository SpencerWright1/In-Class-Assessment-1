using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using eToursLib;
using FluentAssertions;

namespace eTours_Unit_Testing
{
    public class Transport_Should
    {
        //TODO: Activity 2
        //place your unit tests here
        [Fact]
        public void Store_Valid_Name_And_Capacity()
        {
            var t = new Transport("StAlbertTransit", 40);
            t.Name.Should().Be("StAlbertTransit");
            t.Capacity.Should().Be(40);
            t.ToString().Should().Be("StAlbertTransit,40");
        }

        [Fact]
        public void Throw_ArgumentNullException_When_Name_Is_Null()
        {
            Action act = () => new Transport(null, 40);
            act.Should().Throw<ArgumentNullException>()
                .WithMessage("*Name is required*");
        }

        [Fact]
        public void Throw_ArgumentException_When_Name_Is_Empty()
        {
            Action act = () => new Transport("   ", 40);
            act.Should().Throw<ArgumentException>()
                .WithMessage("*Name cannot be empty*");
        }

        [Fact]
        public void Throw_ArgumentException_When_Capacity_Is_Invalid()
        {
            Action act = () => new Transport("StAlbertTransit", 0);
            act.Should().Throw<ArgumentException>()
                .WithMessage("*Capacity must be a positive number*");
        }

    }
}
