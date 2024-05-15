using System.Collections.Generic;
using UnityEditor;
using UnityEngine.XR.OpenXR.Features;
#if UNITY_EDITOR
using UnityEditor.XR.OpenXR.Features;
#endif
namespace UnityEngine.XR.OpenXR.Features.MSFTObserver
{
    /// <summary>
    /// Enables the MSFT secondary view configuration and First person observer feature
    /// </summary>
    ///
#if UNITY_EDITOR
    [OpenXRFeature(UiName = "MSFT Secondary View and Observers",
        BuildTargetGroups = new[] { BuildTargetGroup.Standalone, BuildTargetGroup.WSA, BuildTargetGroup.Android },
        Desc = "Enable MSFT secondary view configuration and observers exts for test purposes",
        Company = "Unity",
        OpenxrExtensionStrings = "XR_MSFT_secondary_view_configuration XR_MSFT_first_person_observer",
        Version = "0.0.1",
        FeatureId = featureId)]
#endif
    public class MSFTObserverFeature : OpenXRFeature
    {
        /// <summary>
        /// The feature id string. This is used to give the feature a well known id for reference.
        /// </summary>
        public const string featureId = "com.unity.openxr.feature.example.msftobserver";
    }
}

