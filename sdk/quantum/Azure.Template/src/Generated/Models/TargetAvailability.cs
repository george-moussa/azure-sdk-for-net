// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.Quantum.Models
{
    /// <summary> Target availability. </summary>
    public readonly partial struct TargetAvailability : IEquatable<TargetAvailability>
    {
        private readonly string _value;

        /// <summary> Determines if two <see cref="TargetAvailability"/> values are the same. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public TargetAvailability(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string AvailableValue = "Available";
        private const string DegradedValue = "Degraded";
        private const string UnavailableValue = "Unavailable";

        /// <summary> Available. </summary>
        public static TargetAvailability Available { get; } = new TargetAvailability(AvailableValue);
        /// <summary> Degraded. </summary>
        public static TargetAvailability Degraded { get; } = new TargetAvailability(DegradedValue);
        /// <summary> Unavailable. </summary>
        public static TargetAvailability Unavailable { get; } = new TargetAvailability(UnavailableValue);
        /// <summary> Determines if two <see cref="TargetAvailability"/> values are the same. </summary>
        public static bool operator ==(TargetAvailability left, TargetAvailability right) => left.Equals(right);
        /// <summary> Determines if two <see cref="TargetAvailability"/> values are not the same. </summary>
        public static bool operator !=(TargetAvailability left, TargetAvailability right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="TargetAvailability"/>. </summary>
        public static implicit operator TargetAvailability(string value) => new TargetAvailability(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is TargetAvailability other && Equals(other);
        /// <inheritdoc />
        public bool Equals(TargetAvailability other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
