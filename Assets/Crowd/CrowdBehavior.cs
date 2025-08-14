using TMPro;
using UnityEngine;

public class CrowdBehavior : MonoBehaviour
{
    public delegate void CrowdEvent(CrowdState state);
    public enum CrowdState { Normal, Celebrate, Sad };
    public static CrowdEvent onNewState;
    public CrowdState crowdState;
    public TextMeshProUGUI tmpCrowdState;
    void Start()
    {
        crowdState = CrowdState.Normal;
        onNewState?.Invoke(crowdState);
    }
    void FixedUpdate()
    {
        // update the UI
        tmpCrowdState.text = crowdState.ToString();
    }
    public void CrowdNormal()
    {
        crowdState = CrowdState.Normal;
        onNewState?.Invoke(crowdState);
    }
    public void CrowdCelebrate()
    {
        crowdState = CrowdState.Celebrate;
        onNewState?.Invoke(crowdState);
    }
    public void CrowdSad()
    {
        crowdState = CrowdState.Sad;
        onNewState?.Invoke(crowdState);
    }
}
