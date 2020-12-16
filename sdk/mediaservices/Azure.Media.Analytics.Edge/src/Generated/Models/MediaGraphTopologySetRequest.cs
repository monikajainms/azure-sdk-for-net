// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.Media.Analytics.Edge.Models
{
    /// <summary> The MediaGraphTopologySetRequest. </summary>
    public partial class MediaGraphTopologySetRequest : MethodRequest
    {
        /// <summary> Initializes a new instance of MediaGraphTopologySetRequest. </summary>
        /// <param name="graph"> The definition of a media graph topology. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="graph"/> is null. </exception>
        public MediaGraphTopologySetRequest(MediaGraphTopology graph)
        {
            if (graph == null)
            {
                throw new ArgumentNullException(nameof(graph));
            }

            Graph = graph;
            MethodName = "GraphTopologySet";
        }

        /// <summary> Initializes a new instance of MediaGraphTopologySetRequest. </summary>
        /// <param name="methodName"> method name. </param>
        /// <param name="apiVersion"> api version. </param>
        /// <param name="graph"> The definition of a media graph topology. </param>
        internal MediaGraphTopologySetRequest(string methodName, string apiVersion, MediaGraphTopology graph) : base(methodName, apiVersion)
        {
            Graph = graph;
            MethodName = methodName ?? "GraphTopologySet";
        }

        /// <summary> The definition of a media graph topology. </summary>
        public MediaGraphTopology Graph { get; set; }
    }
}