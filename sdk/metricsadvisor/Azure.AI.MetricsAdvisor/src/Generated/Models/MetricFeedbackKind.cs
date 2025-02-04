// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.AI.MetricsAdvisor.Models
{
    /// <summary> feedback type. </summary>
    public readonly partial struct MetricFeedbackKind : IEquatable<MetricFeedbackKind>
    {
        private readonly string _value;

        /// <summary> Determines if two <see cref="MetricFeedbackKind"/> values are the same. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public MetricFeedbackKind(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string AnomalyValue = "Anomaly";
        private const string ChangePointValue = "ChangePoint";
        private const string PeriodValue = "Period";
        private const string CommentValue = "Comment";
        /// <summary> Determines if two <see cref="MetricFeedbackKind"/> values are the same. </summary>
        public static bool operator ==(MetricFeedbackKind left, MetricFeedbackKind right) => left.Equals(right);
        /// <summary> Determines if two <see cref="MetricFeedbackKind"/> values are not the same. </summary>
        public static bool operator !=(MetricFeedbackKind left, MetricFeedbackKind right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="MetricFeedbackKind"/>. </summary>
        public static implicit operator MetricFeedbackKind(string value) => new MetricFeedbackKind(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is MetricFeedbackKind other && Equals(other);
        /// <inheritdoc />
        public bool Equals(MetricFeedbackKind other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
