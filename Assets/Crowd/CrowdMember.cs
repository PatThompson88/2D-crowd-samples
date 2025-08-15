using UnityEngine;

public class CrowdMember : MonoBehaviour
{
    CrowdState fanState;
    public SO_CrowdSettings crowdSettings;
    public Transform fanTransform;
    public GameObject imgNormal;
    public GameObject imgCelebrate;
    public GameObject imgSad;
    float movementSpeed = 2f;
    float maxHeight = 0.14f;
    void Awake()
    {
        CrowdBehavior.onNewState += HandleNewCrowdState;
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
                movementSpeed = Random.Range(2.2f, 2.6f);
                imgNormal.SetActive(true);
                maxHeight = 0.1f;
                break;
            case CrowdState.Celebrate:
                movementSpeed = Random.Range(0.3f, 0.9f);
                imgCelebrate.SetActive(true);
                maxHeight = 0.16f;
                break;
            case CrowdState.Sad:
                movementSpeed = Random.Range(4.8f, 5.8f);
                imgSad.SetActive(true);
                maxHeight = 0.075f;
                break;
        }
        Debug.Log($"now in state {fanState}  |  movement {movementSpeed}");
    }

    // move up and down during fixed update cycle
    bool rising;
    
    void FixedUpdate()
    {
        // min max height
        if (rising)
        {
            if (fanTransform.position.y < maxHeight)
            {
                fanTransform.position += Vector3.up * Time.fixedDeltaTime / movementSpeed;
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
                fanTransform.position += -Vector3.up * Time.fixedDeltaTime / movementSpeed;
            }
            else
            {
                rising = true;
            }
        }
    }
}
