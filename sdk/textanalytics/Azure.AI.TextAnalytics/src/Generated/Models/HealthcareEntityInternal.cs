// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.AI.TextAnalytics
{
    /// <summary> The HealthcareEntity. </summary>
    internal partial class HealthcareEntityInternal : Entity
    {
        /// <summary> Initializes a new instance of HealthcareEntityInternal. </summary>
        /// <param name="text"> Entity text as appears in the request. </param>
        /// <param name="category"> Entity type. </param>
        /// <param name="offset"> Start position for the entity text. Use of different &apos;stringIndexType&apos; values can affect the offset returned. </param>
        /// <param name="length"> Length for the entity text. Use of different &apos;stringIndexType&apos; values can affect the length returned. </param>
        /// <param name="confidenceScore"> Confidence score between 0 and 1 of the extracted entity. </param>
        /// <param name="isNegated"> . </param>
        /// <exception cref="ArgumentNullException"> <paramref name="text"/> or <paramref name="category"/> is null. </exception>
        internal HealthcareEntityInternal(string text, string category, int offset, int length, double confidenceScore, bool isNegated) : base(text, category, offset, length, confidenceScore)
        {
            if (text == null)
            {
                throw new ArgumentNullException(nameof(text));
            }
            if (category == null)
            {
                throw new ArgumentNullException(nameof(category));
            }

            IsNegated = isNegated;
            Links = new ChangeTrackingList<EntityDataSource>();
        }

        /// <summary> Initializes a new instance of HealthcareEntityInternal. </summary>
        /// <param name="text"> Entity text as appears in the request. </param>
        /// <param name="category"> Entity type. </param>
        /// <param name="subcategory"> (Optional) Entity sub type. </param>
        /// <param name="offset"> Start position for the entity text. Use of different &apos;stringIndexType&apos; values can affect the offset returned. </param>
        /// <param name="length"> Length for the entity text. Use of different &apos;stringIndexType&apos; values can affect the length returned. </param>
        /// <param name="confidenceScore"> Confidence score between 0 and 1 of the extracted entity. </param>
        /// <param name="isNegated"> . </param>
        /// <param name="links"> Entity references in known data sources. </param>
        internal HealthcareEntityInternal(string text, string category, string subcategory, int offset, int length, double confidenceScore, bool isNegated, IReadOnlyList<EntityDataSource> links) : base(text, category, subcategory, offset, length, confidenceScore)
        {
            IsNegated = isNegated;
            Links = links;
        }

        public bool IsNegated { get; }
        /// <summary> Entity references in known data sources. </summary>
        public IReadOnlyList<EntityDataSource> Links { get; }
    }
}