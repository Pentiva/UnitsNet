﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by \generate-code.bat.
//
//     Changes to this file will be lost when the code is regenerated.
//     The build server regenerates the code before each build and a pre-build
//     step will regenerate the code on each local build.
//
//     See https://github.com/angularsen/UnitsNet/wiki/Adding-a-New-Unit for how to add or edit units.
//
//     Add CustomCode\Quantities\MyUnit.extra.cs files to add code to generated quantities.
//     Add Extensions\MyUnitExtensions.cs to decorate quantities with new behavior.
//     Add UnitDefinitions\MyUnit.json and run GeneratUnits.bat to generate new units or quantities.
//
// </auto-generated>
//------------------------------------------------------------------------------

// Copyright (c) 2007 Andreas Gullberg Larsen (andreas.larsen84@gmail.com).
// https://github.com/angularsen/UnitsNet
//
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
// THE SOFTWARE.

using System;
using UnitsNet.Units;
using Xunit;

// Disable build warning CS1718: Comparison made to same variable; did you mean to compare something else?
#pragma warning disable 1718

// ReSharper disable once CheckNamespace
namespace UnitsNet.Tests
{
    /// <summary>
    /// Test of Torque.
    /// </summary>
// ReSharper disable once PartialTypeWithSinglePart
    public abstract partial class TorqueTestsBase
    {
        protected abstract double KilogramForceCentimetersInOneNewtonMeter { get; }
        protected abstract double KilogramForceMetersInOneNewtonMeter { get; }
        protected abstract double KilogramForceMillimetersInOneNewtonMeter { get; }
        protected abstract double KilonewtonCentimetersInOneNewtonMeter { get; }
        protected abstract double KilonewtonMetersInOneNewtonMeter { get; }
        protected abstract double KilonewtonMillimetersInOneNewtonMeter { get; }
        protected abstract double KilopoundForceFeetInOneNewtonMeter { get; }
        protected abstract double KilopoundForceInchesInOneNewtonMeter { get; }
        protected abstract double NewtonCentimetersInOneNewtonMeter { get; }
        protected abstract double NewtonMetersInOneNewtonMeter { get; }
        protected abstract double NewtonMillimetersInOneNewtonMeter { get; }
        protected abstract double PoundForceFeetInOneNewtonMeter { get; }
        protected abstract double PoundForceInchesInOneNewtonMeter { get; }
        protected abstract double TonneForceCentimetersInOneNewtonMeter { get; }
        protected abstract double TonneForceMetersInOneNewtonMeter { get; }
        protected abstract double TonneForceMillimetersInOneNewtonMeter { get; }

// ReSharper disable VirtualMemberNeverOverriden.Global
        protected virtual double KilogramForceCentimetersTolerance { get { return 1e-5; } }
        protected virtual double KilogramForceMetersTolerance { get { return 1e-5; } }
        protected virtual double KilogramForceMillimetersTolerance { get { return 1e-5; } }
        protected virtual double KilonewtonCentimetersTolerance { get { return 1e-5; } }
        protected virtual double KilonewtonMetersTolerance { get { return 1e-5; } }
        protected virtual double KilonewtonMillimetersTolerance { get { return 1e-5; } }
        protected virtual double KilopoundForceFeetTolerance { get { return 1e-5; } }
        protected virtual double KilopoundForceInchesTolerance { get { return 1e-5; } }
        protected virtual double NewtonCentimetersTolerance { get { return 1e-5; } }
        protected virtual double NewtonMetersTolerance { get { return 1e-5; } }
        protected virtual double NewtonMillimetersTolerance { get { return 1e-5; } }
        protected virtual double PoundForceFeetTolerance { get { return 1e-5; } }
        protected virtual double PoundForceInchesTolerance { get { return 1e-5; } }
        protected virtual double TonneForceCentimetersTolerance { get { return 1e-5; } }
        protected virtual double TonneForceMetersTolerance { get { return 1e-5; } }
        protected virtual double TonneForceMillimetersTolerance { get { return 1e-5; } }
// ReSharper restore VirtualMemberNeverOverriden.Global

        [Fact]
        public void NewtonMeterToTorqueUnits()
        {
            Torque newtonmeter = Torque.FromNewtonMeters(1);
            AssertEx.EqualTolerance(KilogramForceCentimetersInOneNewtonMeter, newtonmeter.KilogramForceCentimeters, KilogramForceCentimetersTolerance);
            AssertEx.EqualTolerance(KilogramForceMetersInOneNewtonMeter, newtonmeter.KilogramForceMeters, KilogramForceMetersTolerance);
            AssertEx.EqualTolerance(KilogramForceMillimetersInOneNewtonMeter, newtonmeter.KilogramForceMillimeters, KilogramForceMillimetersTolerance);
            AssertEx.EqualTolerance(KilonewtonCentimetersInOneNewtonMeter, newtonmeter.KilonewtonCentimeters, KilonewtonCentimetersTolerance);
            AssertEx.EqualTolerance(KilonewtonMetersInOneNewtonMeter, newtonmeter.KilonewtonMeters, KilonewtonMetersTolerance);
            AssertEx.EqualTolerance(KilonewtonMillimetersInOneNewtonMeter, newtonmeter.KilonewtonMillimeters, KilonewtonMillimetersTolerance);
            AssertEx.EqualTolerance(KilopoundForceFeetInOneNewtonMeter, newtonmeter.KilopoundForceFeet, KilopoundForceFeetTolerance);
            AssertEx.EqualTolerance(KilopoundForceInchesInOneNewtonMeter, newtonmeter.KilopoundForceInches, KilopoundForceInchesTolerance);
            AssertEx.EqualTolerance(NewtonCentimetersInOneNewtonMeter, newtonmeter.NewtonCentimeters, NewtonCentimetersTolerance);
            AssertEx.EqualTolerance(NewtonMetersInOneNewtonMeter, newtonmeter.NewtonMeters, NewtonMetersTolerance);
            AssertEx.EqualTolerance(NewtonMillimetersInOneNewtonMeter, newtonmeter.NewtonMillimeters, NewtonMillimetersTolerance);
            AssertEx.EqualTolerance(PoundForceFeetInOneNewtonMeter, newtonmeter.PoundForceFeet, PoundForceFeetTolerance);
            AssertEx.EqualTolerance(PoundForceInchesInOneNewtonMeter, newtonmeter.PoundForceInches, PoundForceInchesTolerance);
            AssertEx.EqualTolerance(TonneForceCentimetersInOneNewtonMeter, newtonmeter.TonneForceCentimeters, TonneForceCentimetersTolerance);
            AssertEx.EqualTolerance(TonneForceMetersInOneNewtonMeter, newtonmeter.TonneForceMeters, TonneForceMetersTolerance);
            AssertEx.EqualTolerance(TonneForceMillimetersInOneNewtonMeter, newtonmeter.TonneForceMillimeters, TonneForceMillimetersTolerance);
        }

        [Fact]
        public void FromValueAndUnit()
        {
            AssertEx.EqualTolerance(1, Torque.From(1, TorqueUnit.KilogramForceCentimeter).KilogramForceCentimeters, KilogramForceCentimetersTolerance);
            AssertEx.EqualTolerance(1, Torque.From(1, TorqueUnit.KilogramForceMeter).KilogramForceMeters, KilogramForceMetersTolerance);
            AssertEx.EqualTolerance(1, Torque.From(1, TorqueUnit.KilogramForceMillimeter).KilogramForceMillimeters, KilogramForceMillimetersTolerance);
            AssertEx.EqualTolerance(1, Torque.From(1, TorqueUnit.KilonewtonCentimeter).KilonewtonCentimeters, KilonewtonCentimetersTolerance);
            AssertEx.EqualTolerance(1, Torque.From(1, TorqueUnit.KilonewtonMeter).KilonewtonMeters, KilonewtonMetersTolerance);
            AssertEx.EqualTolerance(1, Torque.From(1, TorqueUnit.KilonewtonMillimeter).KilonewtonMillimeters, KilonewtonMillimetersTolerance);
            AssertEx.EqualTolerance(1, Torque.From(1, TorqueUnit.KilopoundForceFoot).KilopoundForceFeet, KilopoundForceFeetTolerance);
            AssertEx.EqualTolerance(1, Torque.From(1, TorqueUnit.KilopoundForceInch).KilopoundForceInches, KilopoundForceInchesTolerance);
            AssertEx.EqualTolerance(1, Torque.From(1, TorqueUnit.NewtonCentimeter).NewtonCentimeters, NewtonCentimetersTolerance);
            AssertEx.EqualTolerance(1, Torque.From(1, TorqueUnit.NewtonMeter).NewtonMeters, NewtonMetersTolerance);
            AssertEx.EqualTolerance(1, Torque.From(1, TorqueUnit.NewtonMillimeter).NewtonMillimeters, NewtonMillimetersTolerance);
            AssertEx.EqualTolerance(1, Torque.From(1, TorqueUnit.PoundForceFoot).PoundForceFeet, PoundForceFeetTolerance);
            AssertEx.EqualTolerance(1, Torque.From(1, TorqueUnit.PoundForceInch).PoundForceInches, PoundForceInchesTolerance);
            AssertEx.EqualTolerance(1, Torque.From(1, TorqueUnit.TonneForceCentimeter).TonneForceCentimeters, TonneForceCentimetersTolerance);
            AssertEx.EqualTolerance(1, Torque.From(1, TorqueUnit.TonneForceMeter).TonneForceMeters, TonneForceMetersTolerance);
            AssertEx.EqualTolerance(1, Torque.From(1, TorqueUnit.TonneForceMillimeter).TonneForceMillimeters, TonneForceMillimetersTolerance);
        }

        [Fact]
        public void As()
        {
            var newtonmeter = Torque.FromNewtonMeters(1);
            AssertEx.EqualTolerance(KilogramForceCentimetersInOneNewtonMeter, newtonmeter.As(TorqueUnit.KilogramForceCentimeter), KilogramForceCentimetersTolerance);
            AssertEx.EqualTolerance(KilogramForceMetersInOneNewtonMeter, newtonmeter.As(TorqueUnit.KilogramForceMeter), KilogramForceMetersTolerance);
            AssertEx.EqualTolerance(KilogramForceMillimetersInOneNewtonMeter, newtonmeter.As(TorqueUnit.KilogramForceMillimeter), KilogramForceMillimetersTolerance);
            AssertEx.EqualTolerance(KilonewtonCentimetersInOneNewtonMeter, newtonmeter.As(TorqueUnit.KilonewtonCentimeter), KilonewtonCentimetersTolerance);
            AssertEx.EqualTolerance(KilonewtonMetersInOneNewtonMeter, newtonmeter.As(TorqueUnit.KilonewtonMeter), KilonewtonMetersTolerance);
            AssertEx.EqualTolerance(KilonewtonMillimetersInOneNewtonMeter, newtonmeter.As(TorqueUnit.KilonewtonMillimeter), KilonewtonMillimetersTolerance);
            AssertEx.EqualTolerance(KilopoundForceFeetInOneNewtonMeter, newtonmeter.As(TorqueUnit.KilopoundForceFoot), KilopoundForceFeetTolerance);
            AssertEx.EqualTolerance(KilopoundForceInchesInOneNewtonMeter, newtonmeter.As(TorqueUnit.KilopoundForceInch), KilopoundForceInchesTolerance);
            AssertEx.EqualTolerance(NewtonCentimetersInOneNewtonMeter, newtonmeter.As(TorqueUnit.NewtonCentimeter), NewtonCentimetersTolerance);
            AssertEx.EqualTolerance(NewtonMetersInOneNewtonMeter, newtonmeter.As(TorqueUnit.NewtonMeter), NewtonMetersTolerance);
            AssertEx.EqualTolerance(NewtonMillimetersInOneNewtonMeter, newtonmeter.As(TorqueUnit.NewtonMillimeter), NewtonMillimetersTolerance);
            AssertEx.EqualTolerance(PoundForceFeetInOneNewtonMeter, newtonmeter.As(TorqueUnit.PoundForceFoot), PoundForceFeetTolerance);
            AssertEx.EqualTolerance(PoundForceInchesInOneNewtonMeter, newtonmeter.As(TorqueUnit.PoundForceInch), PoundForceInchesTolerance);
            AssertEx.EqualTolerance(TonneForceCentimetersInOneNewtonMeter, newtonmeter.As(TorqueUnit.TonneForceCentimeter), TonneForceCentimetersTolerance);
            AssertEx.EqualTolerance(TonneForceMetersInOneNewtonMeter, newtonmeter.As(TorqueUnit.TonneForceMeter), TonneForceMetersTolerance);
            AssertEx.EqualTolerance(TonneForceMillimetersInOneNewtonMeter, newtonmeter.As(TorqueUnit.TonneForceMillimeter), TonneForceMillimetersTolerance);
        }

        [Fact]
        public void ConversionRoundTrip()
        {
            Torque newtonmeter = Torque.FromNewtonMeters(1);
            AssertEx.EqualTolerance(1, Torque.FromKilogramForceCentimeters(newtonmeter.KilogramForceCentimeters).NewtonMeters, KilogramForceCentimetersTolerance);
            AssertEx.EqualTolerance(1, Torque.FromKilogramForceMeters(newtonmeter.KilogramForceMeters).NewtonMeters, KilogramForceMetersTolerance);
            AssertEx.EqualTolerance(1, Torque.FromKilogramForceMillimeters(newtonmeter.KilogramForceMillimeters).NewtonMeters, KilogramForceMillimetersTolerance);
            AssertEx.EqualTolerance(1, Torque.FromKilonewtonCentimeters(newtonmeter.KilonewtonCentimeters).NewtonMeters, KilonewtonCentimetersTolerance);
            AssertEx.EqualTolerance(1, Torque.FromKilonewtonMeters(newtonmeter.KilonewtonMeters).NewtonMeters, KilonewtonMetersTolerance);
            AssertEx.EqualTolerance(1, Torque.FromKilonewtonMillimeters(newtonmeter.KilonewtonMillimeters).NewtonMeters, KilonewtonMillimetersTolerance);
            AssertEx.EqualTolerance(1, Torque.FromKilopoundForceFeet(newtonmeter.KilopoundForceFeet).NewtonMeters, KilopoundForceFeetTolerance);
            AssertEx.EqualTolerance(1, Torque.FromKilopoundForceInches(newtonmeter.KilopoundForceInches).NewtonMeters, KilopoundForceInchesTolerance);
            AssertEx.EqualTolerance(1, Torque.FromNewtonCentimeters(newtonmeter.NewtonCentimeters).NewtonMeters, NewtonCentimetersTolerance);
            AssertEx.EqualTolerance(1, Torque.FromNewtonMeters(newtonmeter.NewtonMeters).NewtonMeters, NewtonMetersTolerance);
            AssertEx.EqualTolerance(1, Torque.FromNewtonMillimeters(newtonmeter.NewtonMillimeters).NewtonMeters, NewtonMillimetersTolerance);
            AssertEx.EqualTolerance(1, Torque.FromPoundForceFeet(newtonmeter.PoundForceFeet).NewtonMeters, PoundForceFeetTolerance);
            AssertEx.EqualTolerance(1, Torque.FromPoundForceInches(newtonmeter.PoundForceInches).NewtonMeters, PoundForceInchesTolerance);
            AssertEx.EqualTolerance(1, Torque.FromTonneForceCentimeters(newtonmeter.TonneForceCentimeters).NewtonMeters, TonneForceCentimetersTolerance);
            AssertEx.EqualTolerance(1, Torque.FromTonneForceMeters(newtonmeter.TonneForceMeters).NewtonMeters, TonneForceMetersTolerance);
            AssertEx.EqualTolerance(1, Torque.FromTonneForceMillimeters(newtonmeter.TonneForceMillimeters).NewtonMeters, TonneForceMillimetersTolerance);
        }

        [Fact]
        public void ArithmeticOperators()
        {
            Torque v = Torque.FromNewtonMeters(1);
            AssertEx.EqualTolerance(-1, -v.NewtonMeters, NewtonMetersTolerance);
            AssertEx.EqualTolerance(2, (Torque.FromNewtonMeters(3)-v).NewtonMeters, NewtonMetersTolerance);
            AssertEx.EqualTolerance(2, (v + v).NewtonMeters, NewtonMetersTolerance);
            AssertEx.EqualTolerance(10, (v*10).NewtonMeters, NewtonMetersTolerance);
            AssertEx.EqualTolerance(10, (10*v).NewtonMeters, NewtonMetersTolerance);
            AssertEx.EqualTolerance(2, (Torque.FromNewtonMeters(10)/5).NewtonMeters, NewtonMetersTolerance);
            AssertEx.EqualTolerance(2, Torque.FromNewtonMeters(10)/Torque.FromNewtonMeters(5), NewtonMetersTolerance);
        }

        [Fact]
        public void ComparisonOperators()
        {
            Torque oneNewtonMeter = Torque.FromNewtonMeters(1);
            Torque twoNewtonMeters = Torque.FromNewtonMeters(2);

            Assert.True(oneNewtonMeter < twoNewtonMeters);
            Assert.True(oneNewtonMeter <= twoNewtonMeters);
            Assert.True(twoNewtonMeters > oneNewtonMeter);
            Assert.True(twoNewtonMeters >= oneNewtonMeter);

            Assert.False(oneNewtonMeter > twoNewtonMeters);
            Assert.False(oneNewtonMeter >= twoNewtonMeters);
            Assert.False(twoNewtonMeters < oneNewtonMeter);
            Assert.False(twoNewtonMeters <= oneNewtonMeter);
        }

        [Fact]
        public void CompareToIsImplemented()
        {
            Torque newtonmeter = Torque.FromNewtonMeters(1);
            Assert.Equal(0, newtonmeter.CompareTo(newtonmeter));
            Assert.True(newtonmeter.CompareTo(Torque.Zero) > 0);
            Assert.True(Torque.Zero.CompareTo(newtonmeter) < 0);
        }

        [Fact]
        public void CompareToThrowsOnTypeMismatch()
        {
            Torque newtonmeter = Torque.FromNewtonMeters(1);
            Assert.Throws<ArgumentException>(() => newtonmeter.CompareTo(new object()));
        }

        [Fact]
        public void CompareToThrowsOnNull()
        {
            Torque newtonmeter = Torque.FromNewtonMeters(1);
            Assert.Throws<ArgumentNullException>(() => newtonmeter.CompareTo(null));
        }


        [Fact]
        public void EqualityOperators()
        {
            Torque a = Torque.FromNewtonMeters(1);
            Torque b = Torque.FromNewtonMeters(2);

// ReSharper disable EqualExpressionComparison
            Assert.True(a == a);
            Assert.True(a != b);

            Assert.False(a == b);
            Assert.False(a != a);
// ReSharper restore EqualExpressionComparison
        }

        [Fact]
        public void EqualsIsImplemented()
        {
            Torque v = Torque.FromNewtonMeters(1);
            Assert.True(v.Equals(Torque.FromNewtonMeters(1)));
            Assert.False(v.Equals(Torque.Zero));
        }

        [Fact]
        public void EqualsReturnsFalseOnTypeMismatch()
        {
            Torque newtonmeter = Torque.FromNewtonMeters(1);
            Assert.False(newtonmeter.Equals(new object()));
        }

        [Fact]
        public void EqualsReturnsFalseOnNull()
        {
            Torque newtonmeter = Torque.FromNewtonMeters(1);
            Assert.False(newtonmeter.Equals(null));
        }
    }
}
