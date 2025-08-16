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
    // void Start()
    // {
    //     // Magic numbers must be set to match Range in crowdsettings arguments
    //     maxHeightNormal.minValue = 0.01f;
    //     maxHeightCelebrate.minValue = 0.01f;
    //     maxHeightSad.minValue = 0.01f;
    //     speedNormal.minValue = 0.01f;
    //     speedCelebrate.minValue = 0.01f;
    //     speedSad.minValue = 0.01f;

    //     maxHeightNormal.maxValue = 0.01f;
    //     maxHeightCelebrate.maxValue = 0.01f;
    //     maxHeightSad.maxValue = 0.01f;
    //     speedNormal.maxValue = 0.01f;
    //     speedCelebrate.maxValue = 0.01f;
    //     speedSad.maxValue = 0.01f;
    // }
}
