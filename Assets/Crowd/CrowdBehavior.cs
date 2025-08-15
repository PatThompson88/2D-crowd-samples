using TMPro;
using UnityEngine;
public enum CrowdState { Normal, Celebrate, Sad };
public class CrowdBehavior : MonoBehaviour
{
    public delegate void CrowdEvent(CrowdState state);
    
    public static CrowdEvent onNewState;
    public SO_CrowdSettings crowdSettings;
    public CrowdState crowdState;
    public TextMeshProUGUI tmpCrowdState;
    void Start()
    {
        CrowdNormal();
    }
    public void OnMaxHeightNormalChange(float sliderValue)
    {
        crowdSettings.maxHeightNormal = sliderValue * 0.5f;
    }
    public void OnMaxHeightSadChange(float sliderValue)
    {
        crowdSettings.maxHeightNormal = sliderValue * 0.5f;
    }
    public void OnMaxHeightCelebrateChange(float sliderValue)
    {
        crowdSettings.maxHeightNormal = sliderValue * 0.5f;
    }
    public void OnSpeedNormalChange(float value)
    {
        crowdSettings.speedNormal = value * 3.3f;
    }
    public void OnSpeedCelebrateChange(float value)
    {
        crowdSettings.speedNormal = value * 0.9f;
    }
    public void OnSpeedSadChange(float value)
    {
        crowdSettings.speedNormal = value * 6;
    }
    void OnStateChange()
    {
        onNewState?.Invoke(crowdState);
        tmpCrowdState.text = crowdState.ToString();
    }
    public void CrowdNormal()
    {
        crowdState = CrowdState.Normal;
        OnStateChange();
    }
    public void CrowdCelebrate()
    {
        crowdState = CrowdState.Celebrate;
        OnStateChange();
    }
    public void CrowdSad()
    {
        crowdState = CrowdState.Sad;
        OnStateChange();
    }
}
