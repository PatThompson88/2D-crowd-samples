using UnityEngine;

public enum Team {home, away};
public class CrowdMember : MonoBehaviour
{
    CrowdState fanState;
    public SO_CrowdSettings crowdSettings;
    public Transform fanTransform;
    public GameObject imgNormal;
    public GameObject imgCelebrate;
    public GameObject imgSad;
    float speedReductionFactor = 2f;
    float maxHeight = 0.14f;
    Team team;
    void Awake()
    {
        CrowdBehavior.onNewState += HandleNewCrowdState;

        // randomly choose team
        // crowd should be around 80 - 20 home away
        team = Random.Range(0, 9) > 1 ? team = Team.home : team = Team.away;
    }
    void Start()
    {
        fanTransform.position += Vector3.up * Random.Range(0, 0.03f);
    }
    void DisableAllSprites()
    {
        imgCelebrate.SetActive(false);
        imgNormal.SetActive(false);
        imgSad.SetActive(false);
    }
    void HandleNewCrowdState(CrowdState newState)
    {
        fanState = newState;
        DisableAllSprites();
        switch (newState)
        {
            case CrowdState.Normal:
                speedReductionFactor = crowdSettings.speedNormal + Random.Range(-0.4f, 0.4f);
                maxHeight = crowdSettings.maxHeightNormal + Random.Range(-0.008f, 0.008f);
                imgNormal.SetActive(true);
                break;
            case CrowdState.Celebrate:
                speedReductionFactor = crowdSettings.speedCelebrate + Random.Range(-0.15f, 0.15f);
                maxHeight = crowdSettings.maxHeightCelebrate + Random.Range(-0.01f, 0.01f);
                imgCelebrate.SetActive(true);
                break;
            case CrowdState.Sad:
                speedReductionFactor = crowdSettings.speedSad + Random.Range(-0.6f, 0.6f);
                maxHeight = crowdSettings.maxHeightCelebrate + Random.Range(-0.005f, 0.005f);
                imgSad.SetActive(true);
                break;
        }
        Debug.Log($"now in state {fanState}  |  spd reduction {speedReductionFactor}");
    }

    // move up and down during fixed update cycle
    bool rising = true;
    void FixedUpdate()
    {
        // min max height
        if (rising)
        {
            if (fanTransform.position.y < maxHeight)
            {
                fanTransform.position += Vector3.up * Time.fixedDeltaTime / speedReductionFactor;
            }
            else
            {
                rising = false;
            }
        }
        else
        {
            if (fanTransform.position.y > 0)
            {
                fanTransform.position += -Vector3.up * Time.fixedDeltaTime / speedReductionFactor;
            }
            else
            {
                rising = true;
            }
        }
    }
}
