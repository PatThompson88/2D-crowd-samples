using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "CrowdSettings", menuName = "ScriptableObjects/Crowd/CrowdSettings", order = 1)]
public class SO_CrowdSettings : ScriptableObject
{
    public CrowdState crowdState;
    [Range(0.03f, 0.08f)] public float maxHeightNormal;
    [Range(0.06f, 0.12f)] public float maxHeightCelebrate;
    [Range(0.01f, 0.03f)] public float maxHeightSad;
    [Range(5f, 9f)] public float speedNormal;
    [Range(.1f, 2f)] public float speedCelebrate;
    [Range(8f, 14f)] public float speedSad;
}
