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
//     Add CustomCode\Quantities\MyQuantity.extra.cs files to add code to generated quantities.
//     Add Extensions\MyQuantityExtensions.cs to decorate quantities with new behavior.
//     Add UnitDefinitions\MyQuantity.json and run GeneratUnits.bat to generate new units or quantities.
//
// </auto-generated>
//------------------------------------------------------------------------------

// Copyright (c) 2013 Andreas Gullberg Larsen (andreas.larsen84@gmail.com).
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
using System.Collections.Generic;
using System.Globalization;
using System.Text.RegularExpressions;
using System.Linq;
using JetBrains.Annotations;
using UnitsNet.Units;

// ReSharper disable once CheckNamespace

namespace UnitsNet
{
    /// <summary>
    ///     Time is a dimension in which events can be ordered from the past through the present into the future, and also the measure of durations of events and the intervals between them.
    /// </summary>
    // ReSharper disable once PartialTypeWithSinglePart

    // Windows Runtime Component has constraints on public types: https://msdn.microsoft.com/en-us/library/br230301.aspx#Declaring types in Windows Runtime Components
    // Public structures can't have any members other than public fields, and those fields must be value types or strings.
    // Public classes must be sealed (NotInheritable in Visual Basic). If your programming model requires polymorphism, you can create a public interface and implement that interface on the classes that must be polymorphic.
#if WINDOWS_UWP
    public sealed partial class Duration : IQuantity
#else
    public partial struct Duration : IQuantity, IComparable, IComparable<Duration>
#endif
    {
        /// <summary>
        ///     The numeric value this quantity was constructed with.
        /// </summary>
        private readonly double _value;

        /// <summary>
        ///     The unit this quantity was constructed with.
        /// </summary>
        private readonly DurationUnit? _unit;

        /// <summary>
        ///     The unit this quantity was constructed with -or- <see cref="BaseUnit" /> if default ctor was used.
        /// </summary>
        public DurationUnit Unit => _unit.GetValueOrDefault(BaseUnit);

        static Duration()
        {
            BaseDimensions = new BaseDimensions(0, 0, 1, 0, 0, 0, 0);
        }

        /// <summary>
        ///     Creates the quantity with the given value in the base unit Second.
        /// </summary>
        [Obsolete("Use the constructor that takes a unit parameter. This constructor will be removed in a future version.")]
        public Duration(double seconds)
        {
            _value = Convert.ToDouble(seconds);
            _unit = BaseUnit;
        }

        /// <summary>
        ///     Creates the quantity with the given numeric value and unit.
        /// </summary>
        /// <param name="numericValue">Numeric value.</param>
        /// <param name="unit">Unit representation.</param>
        /// <remarks>Value parameter cannot be named 'value' due to constraint when targeting Windows Runtime Component.</remarks>
#if WINDOWS_UWP
        private
#else
        public
#endif
        Duration(double numericValue, DurationUnit unit)
        {
            _value = numericValue;
            _unit = unit;
        }

        // Windows Runtime Component does not allow public methods/ctors with same number of parameters: https://msdn.microsoft.com/en-us/library/br230301.aspx#Overloaded methods
        /// <summary>
        ///     Creates the quantity with the given value assuming the base unit Second.
        /// </summary>
        /// <param name="seconds">Value assuming base unit Second.</param>
#if WINDOWS_UWP
        private
#else
        [Obsolete("Use the constructor that takes a unit parameter. This constructor will be removed in a future version.")]
        public
#endif
        Duration(long seconds) : this(Convert.ToDouble(seconds), BaseUnit) { }

        // Windows Runtime Component does not allow public methods/ctors with same number of parameters: https://msdn.microsoft.com/en-us/library/br230301.aspx#Overloaded methods
        // Windows Runtime Component does not support decimal type
        /// <summary>
        ///     Creates the quantity with the given value assuming the base unit Second.
        /// </summary>
        /// <param name="seconds">Value assuming base unit Second.</param>
#if WINDOWS_UWP
        private
#else
        [Obsolete("Use the constructor that takes a unit parameter. This constructor will be removed in a future version.")]
        public
#endif
        Duration(decimal seconds) : this(Convert.ToDouble(seconds), BaseUnit) { }

        #region Properties

        /// <summary>
        ///     The <see cref="QuantityType" /> of this quantity.
        /// </summary>
        public static QuantityType QuantityType => QuantityType.Duration;

        /// <summary>
        ///     The base unit representation of this quantity for the numeric value stored internally. All conversions go via this value.
        /// </summary>
        public static DurationUnit BaseUnit => DurationUnit.Second;

        /// <summary>
        ///     The <see cref="BaseDimensions" /> of this quantity.
        /// </summary>
        public static BaseDimensions BaseDimensions
        {
            get;
        }

        /// <summary>
        ///     All units of measurement for the Duration quantity.
        /// </summary>
        public static DurationUnit[] Units { get; } = Enum.GetValues(typeof(DurationUnit)).Cast<DurationUnit>().Except(new DurationUnit[]{ DurationUnit.Undefined }).ToArray();

        /// <summary>
        ///     Get Duration in Days.
        /// </summary>
        public double Days => As(DurationUnit.Day);

        /// <summary>
        ///     Get Duration in Hours.
        /// </summary>
        public double Hours => As(DurationUnit.Hour);

        /// <summary>
        ///     Get Duration in Microseconds.
        /// </summary>
        public double Microseconds => As(DurationUnit.Microsecond);

        /// <summary>
        ///     Get Duration in Milliseconds.
        /// </summary>
        public double Milliseconds => As(DurationUnit.Millisecond);

        /// <summary>
        ///     Get Duration in Minutes.
        /// </summary>
        public double Minutes => As(DurationUnit.Minute);

        /// <summary>
        ///     Get Duration in Months.
        /// </summary>
        [System.Obsolete("Use Month30 instead, which makes it clear that this is an approximate unit based on 30 days per month. The duration of a month varies, but the Gregorian solar calendar has 365.2425/12 = 30.44 days on average.")]
        public double Months => As(DurationUnit.Month);

        /// <summary>
        ///     Get Duration in Months30.
        /// </summary>
        public double Months30 => As(DurationUnit.Month30);

        /// <summary>
        ///     Get Duration in Nanoseconds.
        /// </summary>
        public double Nanoseconds => As(DurationUnit.Nanosecond);

        /// <summary>
        ///     Get Duration in Seconds.
        /// </summary>
        public double Seconds => As(DurationUnit.Second);

        /// <summary>
        ///     Get Duration in Weeks.
        /// </summary>
        public double Weeks => As(DurationUnit.Week);

        /// <summary>
        ///     Get Duration in Years.
        /// </summary>
        [System.Obsolete("Use Year365 instead, which makes it clear that this is an approximate unit based on 365 days per year. The duration of a year varies due to corrections such as leap years, since a Gregorian solar calendar has 365.2425 days.")]
        public double Years => As(DurationUnit.Year);

        /// <summary>
        ///     Get Duration in Years365.
        /// </summary>
        public double Years365 => As(DurationUnit.Year365);

        #endregion

        #region Static

        /// <summary>
        ///     Gets an instance of this quantity with a value of 0 in the base unit Second.
        /// </summary>
        public static Duration Zero => new Duration(0, BaseUnit);

        /// <summary>
        ///     Get Duration from Days.
        /// </summary>
#if WINDOWS_UWP
        [Windows.Foundation.Metadata.DefaultOverload]
        public static Duration FromDays(double days)
#else
        public static Duration FromDays(QuantityValue days)
#endif
        {
            double value = (double) days;
            return new Duration(value, DurationUnit.Day);
        }

        /// <summary>
        ///     Get Duration from Hours.
        /// </summary>
#if WINDOWS_UWP
        [Windows.Foundation.Metadata.DefaultOverload]
        public static Duration FromHours(double hours)
#else
        public static Duration FromHours(QuantityValue hours)
#endif
        {
            double value = (double) hours;
            return new Duration(value, DurationUnit.Hour);
        }

        /// <summary>
        ///     Get Duration from Microseconds.
        /// </summary>
#if WINDOWS_UWP
        [Windows.Foundation.Metadata.DefaultOverload]
        public static Duration FromMicroseconds(double microseconds)
#else
        public static Duration FromMicroseconds(QuantityValue microseconds)
#endif
        {
            double value = (double) microseconds;
            return new Duration(value, DurationUnit.Microsecond);
        }

        /// <summary>
        ///     Get Duration from Milliseconds.
        /// </summary>
#if WINDOWS_UWP
        [Windows.Foundation.Metadata.DefaultOverload]
        public static Duration FromMilliseconds(double milliseconds)
#else
        public static Duration FromMilliseconds(QuantityValue milliseconds)
#endif
        {
            double value = (double) milliseconds;
            return new Duration(value, DurationUnit.Millisecond);
        }

        /// <summary>
        ///     Get Duration from Minutes.
        /// </summary>
#if WINDOWS_UWP
        [Windows.Foundation.Metadata.DefaultOverload]
        public static Duration FromMinutes(double minutes)
#else
        public static Duration FromMinutes(QuantityValue minutes)
#endif
        {
            double value = (double) minutes;
            return new Duration(value, DurationUnit.Minute);
        }

        /// <summary>
        ///     Get Duration from Months.
        /// </summary>
        [System.Obsolete("Use Month30 instead, which makes it clear that this is an approximate unit based on 30 days per month. The duration of a month varies, but the Gregorian solar calendar has 365.2425/12 = 30.44 days on average.")]
#if WINDOWS_UWP
        [Windows.Foundation.Metadata.DefaultOverload]
        public static Duration FromMonths(double months)
#else
        public static Duration FromMonths(QuantityValue months)
#endif
        {
            double value = (double) months;
            return new Duration(value, DurationUnit.Month);
        }

        /// <summary>
        ///     Get Duration from Months30.
        /// </summary>
#if WINDOWS_UWP
        [Windows.Foundation.Metadata.DefaultOverload]
        public static Duration FromMonths30(double months30)
#else
        public static Duration FromMonths30(QuantityValue months30)
#endif
        {
            double value = (double) months30;
            return new Duration(value, DurationUnit.Month30);
        }

        /// <summary>
        ///     Get Duration from Nanoseconds.
        /// </summary>
#if WINDOWS_UWP
        [Windows.Foundation.Metadata.DefaultOverload]
        public static Duration FromNanoseconds(double nanoseconds)
#else
        public static Duration FromNanoseconds(QuantityValue nanoseconds)
#endif
        {
            double value = (double) nanoseconds;
            return new Duration(value, DurationUnit.Nanosecond);
        }

        /// <summary>
        ///     Get Duration from Seconds.
        /// </summary>
#if WINDOWS_UWP
        [Windows.Foundation.Metadata.DefaultOverload]
        public static Duration FromSeconds(double seconds)
#else
        public static Duration FromSeconds(QuantityValue seconds)
#endif
        {
            double value = (double) seconds;
            return new Duration(value, DurationUnit.Second);
        }

        /// <summary>
        ///     Get Duration from Weeks.
        /// </summary>
#if WINDOWS_UWP
        [Windows.Foundation.Metadata.DefaultOverload]
        public static Duration FromWeeks(double weeks)
#else
        public static Duration FromWeeks(QuantityValue weeks)
#endif
        {
            double value = (double) weeks;
            return new Duration(value, DurationUnit.Week);
        }

        /// <summary>
        ///     Get Duration from Years.
        /// </summary>
        [System.Obsolete("Use Year365 instead, which makes it clear that this is an approximate unit based on 365 days per year. The duration of a year varies due to corrections such as leap years, since a Gregorian solar calendar has 365.2425 days.")]
#if WINDOWS_UWP
        [Windows.Foundation.Metadata.DefaultOverload]
        public static Duration FromYears(double years)
#else
        public static Duration FromYears(QuantityValue years)
#endif
        {
            double value = (double) years;
            return new Duration(value, DurationUnit.Year);
        }

        /// <summary>
        ///     Get Duration from Years365.
        /// </summary>
#if WINDOWS_UWP
        [Windows.Foundation.Metadata.DefaultOverload]
        public static Duration FromYears365(double years365)
#else
        public static Duration FromYears365(QuantityValue years365)
#endif
        {
            double value = (double) years365;
            return new Duration(value, DurationUnit.Year365);
        }


        /// <summary>
        ///     Dynamically convert from value and unit enum <see cref="DurationUnit" /> to <see cref="Duration" />.
        /// </summary>
        /// <param name="value">Value to convert from.</param>
        /// <param name="fromUnit">Unit to convert from.</param>
        /// <returns>Duration unit value.</returns>
#if WINDOWS_UWP
        // Fix name conflict with parameter "value"
        [return: System.Runtime.InteropServices.WindowsRuntime.ReturnValueName("returnValue")]
        public static Duration From(double value, DurationUnit fromUnit)
#else
        public static Duration From(QuantityValue value, DurationUnit fromUnit)
#endif
        {
            return new Duration((double)value, fromUnit);
        }

        /// <summary>
        ///     Get unit abbreviation string.
        /// </summary>
        /// <param name="unit">Unit to get abbreviation for.</param>
        /// <returns>Unit abbreviation string.</returns>
        [UsedImplicitly]
        public static string GetAbbreviation(DurationUnit unit)
        {
            return GetAbbreviation(unit, null);
        }

        #endregion

        #region Equality / IComparable

        public int CompareTo(object obj)
        {
            if(obj is null) throw new ArgumentNullException(nameof(obj));
            if(!(obj is Duration)) throw new ArgumentException("Expected type Duration.", nameof(obj));

            return CompareTo((Duration)obj);
        }

        // Windows Runtime Component does not allow public methods/ctors with same number of parameters: https://msdn.microsoft.com/en-us/library/br230301.aspx#Overloaded methods
#if WINDOWS_UWP
        internal
#else
        public
#endif
        int CompareTo(Duration other)
        {
            return _value.CompareTo(other.AsBaseNumericType(this.Unit));
        }

        /// <summary>
        ///     <para>
        ///     Compare equality to another Duration within the given absolute or relative tolerance.
        ///     </para>
        ///     <para>
        ///     Relative tolerance is defined as the maximum allowable absolute difference between this quantity's value and
        ///     <paramref name="other"/> as a percentage of this quantity's value. <paramref name="other"/> will be converted into
        ///     this quantity's unit for comparison. A relative tolerance of 0.01 means the absolute difference must be within +/- 1% of
        ///     this quantity's value to be considered equal.
        ///     <example>
        ///     In this example, the two quantities will be equal if the value of b is within +/- 1% of a (0.02m or 2cm).
        ///     <code>
        ///     var a = Length.FromMeters(2.0);
        ///     var b = Length.FromInches(50.0);
        ///     a.Equals(b, 0.01, ComparisonType.Relative);
        ///     </code>
        ///     </example>
        ///     </para>
        ///     <para>
        ///     Absolute tolerance is defined as the maximum allowable absolute difference between this quantity's value and
        ///     <paramref name="other"/> as a fixed number in this quantity's unit. <paramref name="other"/> will be converted into
        ///     this quantity's unit for comparison.
        ///     <example>
        ///     In this example, the two quantities will be equal if the value of b is within 0.01 of a (0.01m or 1cm).
        ///     <code>
        ///     var a = Length.FromMeters(2.0);
        ///     var b = Length.FromInches(50.0);
        ///     a.Equals(b, 0.01, ComparisonType.Absolute);
        ///     </code>
        ///     </example>
        ///     </para>
        ///     <para>
        ///     Note that it is advised against specifying zero difference, due to the nature
        ///     of floating point operations and using System.Double internally.
        ///     </para>
        /// </summary>
        /// <param name="other">The other quantity to compare to.</param>
        /// <param name="tolerance">The absolute or relative tolerance value. Must be greater than or equal to 0.</param>
        /// <param name="comparisonType">The comparison type: either relative or absolute.</param>
        /// <returns>True if the absolute difference between the two values is not greater than the specified relative or absolute tolerance.</returns>
        public bool Equals(Duration other, double tolerance, ComparisonType comparisonType)
        {
            if(tolerance < 0)
                throw new ArgumentOutOfRangeException("tolerance", "Tolerance must be greater than or equal to 0.");

            double thisValue = (double)this.Value;
            double otherValueInThisUnits = other.As(this.Unit);

            return UnitsNet.Comparison.Equals(thisValue, otherValueInThisUnits, tolerance, comparisonType);
        }

        /// <summary>
        ///     Returns the hash code for this instance.
        /// </summary>
        /// <returns>A hash code for the current Duration.</returns>
        public override int GetHashCode()
        {
            return new { Value, Unit }.GetHashCode();
        }

        #endregion

        #region Conversion

        /// <summary>
        ///     Convert to the unit representation <paramref name="unit" />.
        /// </summary>
        /// <returns>Value converted to the specified unit.</returns>
        public double As(DurationUnit unit)
        {
            if(Unit == unit)
                return Convert.ToDouble(Value);

            var converted = AsBaseNumericType(unit);
            return Convert.ToDouble(converted);
        }

        /// <summary>
        ///     Converts this Duration to another Duration with the unit representation <paramref name="unit" />.
        /// </summary>
        /// <returns>A Duration with the specified unit.</returns>
        public Duration ToUnit(DurationUnit unit)
        {
            var convertedValue = AsBaseNumericType(unit);
            return new Duration(convertedValue, unit);
        }

        /// <summary>
        ///     Converts the current value + unit to the base unit.
        ///     This is typically the first step in converting from one unit to another.
        /// </summary>
        /// <returns>The value in the base unit representation.</returns>
        private double AsBaseUnit()
        {
            switch(Unit)
            {
                case DurationUnit.Day: return _value*24*3600;
                case DurationUnit.Hour: return _value*3600;
                case DurationUnit.Microsecond: return (_value) * 1e-6d;
                case DurationUnit.Millisecond: return (_value) * 1e-3d;
                case DurationUnit.Minute: return _value*60;
                case DurationUnit.Month: return _value*30*24*3600;
                case DurationUnit.Month30: return _value*30*24*3600;
                case DurationUnit.Nanosecond: return (_value) * 1e-9d;
                case DurationUnit.Second: return _value;
                case DurationUnit.Week: return _value*7*24*3600;
                case DurationUnit.Year: return _value*365*24*3600;
                case DurationUnit.Year365: return _value*365*24*3600;
                default:
                    throw new NotImplementedException($"Can not convert {Unit} to base units.");
            }
        }

        private double AsBaseNumericType(DurationUnit unit)
        {
            if(Unit == unit)
                return _value;

            var baseUnitValue = AsBaseUnit();

            switch(unit)
            {
                case DurationUnit.Day: return baseUnitValue/(24*3600);
                case DurationUnit.Hour: return baseUnitValue/3600;
                case DurationUnit.Microsecond: return (baseUnitValue) / 1e-6d;
                case DurationUnit.Millisecond: return (baseUnitValue) / 1e-3d;
                case DurationUnit.Minute: return baseUnitValue/60;
                case DurationUnit.Month: return baseUnitValue/(30*24*3600);
                case DurationUnit.Month30: return baseUnitValue/(30*24*3600);
                case DurationUnit.Nanosecond: return (baseUnitValue) / 1e-9d;
                case DurationUnit.Second: return baseUnitValue;
                case DurationUnit.Week: return baseUnitValue/(7*24*3600);
                case DurationUnit.Year: return baseUnitValue/(365*24*3600);
                case DurationUnit.Year365: return baseUnitValue/(365*24*3600);
                default:
                    throw new NotImplementedException($"Can not convert {Unit} to {unit}.");
            }
        }

        #endregion

        #region Parsing

        /// <summary>
        ///     Parse a string with one or two quantities of the format "&lt;quantity&gt; &lt;unit&gt;".
        /// </summary>
        /// <param name="str">String to parse. Typically in the form: {number} {unit}</param>
        /// <example>
        ///     Length.Parse("5.5 m", new CultureInfo("en-US"));
        /// </example>
        /// <exception cref="ArgumentNullException">The value of 'str' cannot be null. </exception>
        /// <exception cref="ArgumentException">
        ///     Expected string to have one or two pairs of quantity and unit in the format
        ///     "&lt;quantity&gt; &lt;unit&gt;". Eg. "5.5 m" or "1ft 2in"
        /// </exception>
        /// <exception cref="AmbiguousUnitParseException">
        ///     More than one unit is represented by the specified unit abbreviation.
        ///     Example: Volume.Parse("1 cup") will throw, because it can refer to any of
        ///     <see cref="VolumeUnit.MetricCup" />, <see cref="VolumeUnit.UsLegalCup" /> and <see cref="VolumeUnit.UsCustomaryCup" />.
        /// </exception>
        /// <exception cref="UnitsNetException">
        ///     If anything else goes wrong, typically due to a bug or unhandled case.
        ///     We wrap exceptions in <see cref="UnitsNetException" /> to allow you to distinguish
        ///     Units.NET exceptions from other exceptions.
        /// </exception>
        public static Duration Parse(string str)
        {
            return Parse(str, null);
        }

        /// <summary>
        ///     Try to parse a string with one or two quantities of the format "&lt;quantity&gt; &lt;unit&gt;".
        /// </summary>
        /// <param name="str">String to parse. Typically in the form: {number} {unit}</param>
        /// <param name="result">Resulting unit quantity if successful.</param>
        /// <example>
        ///     Length.Parse("5.5 m", new CultureInfo("en-US"));
        /// </example>
        public static bool TryParse([CanBeNull] string str, out Duration result)
        {
            return TryParse(str, null, out result);
        }

        /// <summary>
        ///     Parse a unit string.
        /// </summary>
        /// <param name="str">String to parse. Typically in the form: {number} {unit}</param>
        /// <example>
        ///     Length.ParseUnit("m", new CultureInfo("en-US"));
        /// </example>
        /// <exception cref="ArgumentNullException">The value of 'str' cannot be null. </exception>
        /// <exception cref="UnitsNetException">Error parsing string.</exception>
        public static DurationUnit ParseUnit(string str)
        {
            return ParseUnit(str, (IFormatProvider)null);
        }

        #endregion

        /// <summary>
        ///     Set the default unit used by ToString(). Default is Second
        /// </summary>
        [Obsolete("This is no longer used since we will instead use the quantity's Unit value as default.")]
        public static DurationUnit ToStringDefaultUnit { get; set; } = DurationUnit.Second;

        /// <summary>
        ///     Get default string representation of value and unit.
        /// </summary>
        /// <returns>String representation.</returns>
        public override string ToString()
        {
            return ToString(Unit);
        }

        /// <summary>
        ///     Get string representation of value and unit. Using current UI culture and two significant digits after radix.
        /// </summary>
        /// <param name="unit">Unit representation to use.</param>
        /// <returns>String representation.</returns>
        public string ToString(DurationUnit unit)
        {
            return ToString(unit, null, 2);
        }

        /// <summary>
        /// Represents the largest possible value of Duration
        /// </summary>
        public static Duration MaxValue => new Duration(double.MaxValue, BaseUnit);

        /// <summary>
        /// Represents the smallest possible value of Duration
        /// </summary>
        public static Duration MinValue => new Duration(double.MinValue, BaseUnit);

        /// <summary>
        ///     The <see cref="QuantityType" /> of this quantity.
        /// </summary>
        public QuantityType Type => Duration.QuantityType;

        /// <summary>
        ///     The <see cref="BaseDimensions" /> of this quantity.
        /// </summary>
        public BaseDimensions Dimensions => Duration.BaseDimensions;
    }
}
