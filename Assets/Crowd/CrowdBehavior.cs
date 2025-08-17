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

    // Magic numbers come from Range values in scriptable object SO_CrowdSettings
    public void OnMaxHeightNormalChange(float sliderValue)
    {
        crowdSettings.maxHeightNormal = sliderValue * (0.05f - 0.02f) + 0.05f;
    }
    public void OnMaxHeightSadChange(float sliderValue)
    {
        crowdSettings.maxHeightNormal = sliderValue * (0.03f - 0.01f) + 0.01f;
    }
    public void OnMaxHeightCelebrateChange(float sliderValue)
    {
        crowdSettings.maxHeightNormal = sliderValue * (0.1f - 0.04f) + 0.04f;
    }
    public void OnSpeedNormalChange(float value)
    {
        crowdSettings.speedNormal = value * (6 - 4) + 4;
    }
    public void OnSpeedCelebrateChange(float value)
    {
        crowdSettings.speedNormal = value * (3 - 1) + 1;
    }
    public void OnSpeedSadChange(float value)
    {
        crowdSettings.speedNormal = value * (10 - 6) + 6;
    }
    void OnStateChange()
    {
        onNewState?.Invoke(crowdSettings.crowdState);
        tmpCrowdState.text = crowdSettings.crowdState.ToString();
    }
    public void CrowdNormal()
    {
        crowdSettings.crowdState = CrowdState.Normal;
        OnStateChange();
    }
    public void CrowdCelebrate()
    {
        crowdSettings.crowdState = CrowdState.Celebrate;
        OnStateChange();
    }
    public void CrowdSad()
    {
        crowdSettings.crowdState = CrowdState.Sad;
        OnStateChange();
    }
}
