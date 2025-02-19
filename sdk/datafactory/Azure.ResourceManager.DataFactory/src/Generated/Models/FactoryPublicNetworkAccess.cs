// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.DataFactory.Models
{
    /// <summary> Whether or not public network access is allowed for the data factory. </summary>
    public readonly partial struct FactoryPublicNetworkAccess : IEquatable<FactoryPublicNetworkAccess>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="FactoryPublicNetworkAccess"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public FactoryPublicNetworkAccess(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string EnabledValue = "Enabled";
        private const string DisabledValue = "Disabled";

        /// <summary> Enabled. </summary>
        public static FactoryPublicNetworkAccess Enabled { get; } = new FactoryPublicNetworkAccess(EnabledValue);
        /// <summary> Disabled. </summary>
        public static FactoryPublicNetworkAccess Disabled { get; } = new FactoryPublicNetworkAccess(DisabledValue);
        /// <summary> Determines if two <see cref="FactoryPublicNetworkAccess"/> values are the same. </summary>
        public static bool operator ==(FactoryPublicNetworkAccess left, FactoryPublicNetworkAccess right) => left.Equals(right);
        /// <summary> Determines if two <see cref="FactoryPublicNetworkAccess"/> values are not the same. </summary>
        public static bool operator !=(FactoryPublicNetworkAccess left, FactoryPublicNetworkAccess right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="FactoryPublicNetworkAccess"/>. </summary>
        public static implicit operator FactoryPublicNetworkAccess(string value) => new FactoryPublicNetworkAccess(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is FactoryPublicNetworkAccess other && Equals(other);
        /// <inheritdoc />
        public bool Equals(FactoryPublicNetworkAccess other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
