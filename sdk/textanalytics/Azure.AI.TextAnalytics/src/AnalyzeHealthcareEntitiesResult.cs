﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using Azure.AI.TextAnalytics.Models;

namespace Azure.AI.TextAnalytics
{
    /// <summary>
    /// DocumentHealthcareEntities.
    /// </summary>
    public partial class AnalyzeHealthcareEntitiesResult : TextAnalyticsResult
    {
        private readonly IReadOnlyCollection<HealthcareEntity> _entities;

        internal AnalyzeHealthcareEntitiesResult(string id, TextDocumentStatistics statistics,
            IReadOnlyList<HealthcareEntity> healthcareEntities,
            IReadOnlyList<TextAnalyticsWarning> warnings)
            : base(id, statistics)
        {
            _entities = healthcareEntities;
            Warnings = warnings;
        }

        internal AnalyzeHealthcareEntitiesResult(string id, TextAnalyticsError error) : base(id, error) { }

        /// <summary> Warnings encountered while processing document. </summary>
        public IReadOnlyCollection<TextAnalyticsWarning> Warnings { get; } = new List<TextAnalyticsWarning>();

        /// <summary>
        /// Gets the collection of healthcare entities in the document.
        /// </summary>
        public IReadOnlyCollection<HealthcareEntity> Entities
        {
            get
            {
                if (HasError)
                {
#pragma warning disable CA1065 // Do not raise exceptions in unexpected locations
                    throw new InvalidOperationException($"Cannot access result for document {Id}, due to error {Error.ErrorCode}: {Error.Message}");
#pragma warning restore CA1065 // Do not raise exceptions in unexpected locations
                }
                return _entities;
            }
        }
    }
}