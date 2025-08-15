using UnityEngine;

public class CrowdMember : MonoBehaviour
{
    CrowdBehavior.CrowdState fanState;
    public Transform fanTransform;
    public GameObject imgNormal;
    public GameObject imgCelebrate;
    public GameObject imgSad;
    float movementSpeed = 2f;
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
    void HandleNewCrowdState(CrowdBehavior.CrowdState newState)
    {
        fanState = newState;
        DisableAllSprites();
        switch (newState)
        {
            case CrowdBehavior.CrowdState.Normal:
                movementSpeed = Random.Range(1.9f, 2.4f);
                imgNormal.SetActive(true);
                break;
            case CrowdBehavior.CrowdState.Celebrate:
                movementSpeed = Random.Range(0.8f, 1.15f);
                imgCelebrate.SetActive(true);
                break;
            case CrowdBehavior.CrowdState.Sad:
                movementSpeed = Random.Range(3.2f, 3.9f);
                imgSad.SetActive(true);
                break;
        }
        Debug.Log($"now in state {fanState}  |  movement {movementSpeed}");
    }

    // move up and down during fixed update cycle
    bool rising;
    float maxHeight = 0.14f;
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
