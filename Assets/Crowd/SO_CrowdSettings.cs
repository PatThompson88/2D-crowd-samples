using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "CrowdSettings", menuName = "ScriptableObjects/Crowd/CrowdSettings", order = 1)]
public class SO_CrowdSettings : ScriptableObject
{
    public CrowdState crowdState;
    [Range(0.01f, 0.5f)] public float maxHeightNormal;
    [Range(0.01f, 0.5f)] public float maxHeightCelebrate;
    [Range(0.01f, 0.5f)] public float maxHeightSad;
    [Range(1.5f, 3.3f)] public float speedNormal;
    [Range(0.01f, 0.5f)] public float speedCelebrate;
    [Range(0.01f, 0.5f)] public float speedSad;
    
}
