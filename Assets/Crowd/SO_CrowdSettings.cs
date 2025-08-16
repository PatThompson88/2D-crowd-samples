using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "CrowdSettings", menuName = "ScriptableObjects/Crowd/CrowdSettings", order = 1)]
public class SO_CrowdSettings : ScriptableObject
{
    public CrowdState crowdState;
    [Range(0.02f, 0.05f)] public float maxHeightNormal;
    [Range(0.04f, 0.1f)] public float maxHeightCelebrate;
    [Range(0.01f, 0.03f)] public float maxHeightSad;
    [Range(4f, 6f)] public float speedNormal;
    [Range(1f, 3f)] public float speedCelebrate;
    [Range(6f, 10f)] public float speedSad;
}
