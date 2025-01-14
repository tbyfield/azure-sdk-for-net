// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.HybridContainerService.Models
{
    /// <summary> Contains information about orchestrator. </summary>
    public partial class OrchestratorProfile
    {
        /// <summary> Initializes a new instance of OrchestratorProfile. </summary>
        internal OrchestratorProfile()
        {
        }

        /// <summary> Initializes a new instance of OrchestratorProfile. </summary>
        /// <param name="isPreview"> Whether Kubernetes version is currently in preview. </param>
        /// <param name="orchestratorType"> Orchestrator type. </param>
        /// <param name="orchestratorVersion"> Orchestrator version (major, minor, patch). </param>
        internal OrchestratorProfile(bool? isPreview, string orchestratorType, string orchestratorVersion)
        {
            IsPreview = isPreview;
            OrchestratorType = orchestratorType;
            OrchestratorVersion = orchestratorVersion;
        }

        /// <summary> Whether Kubernetes version is currently in preview. </summary>
        public bool? IsPreview { get; }
        /// <summary> Orchestrator type. </summary>
        public string OrchestratorType { get; }
        /// <summary> Orchestrator version (major, minor, patch). </summary>
        public string OrchestratorVersion { get; }
    }
}
