using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CrowdUIBehavior : MonoBehaviour
{
    public SO_CrowdSettings crowdSettings;
    public Slider maxHeightNormal;
    public Slider maxHeightCelebrate;
    public Slider maxHeightSad;
    public Slider speedNormal;
    public Slider speedCelebrate;
    public Slider speedSad;
    void Start()
    {
        // set sliders to correct value
        // maxHeightNormal.value = crowdSettings.maxHeightNormal / crowdSettings.maxHeightNormal
    }
}
