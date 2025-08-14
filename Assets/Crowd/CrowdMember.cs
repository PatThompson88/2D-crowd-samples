using UnityEngine;

public class CrowdMember : MonoBehaviour
{
    CrowdBehavior.CrowdState fanState;
    public Transform fanTransform;
    float movementSpeed = 2f;
    void Awake()
    {
        CrowdBehavior.onNewState += HandleNewCrowdState;
    }

    void HandleNewCrowdState(CrowdBehavior.CrowdState newState)
    {
        fanState = newState;
        switch (newState)
        {
            case CrowdBehavior.CrowdState.Normal:
                movementSpeed = Random.Range(1.5f, 2.3f);
                break;
            case CrowdBehavior.CrowdState.Celebrate:
                movementSpeed = Random.Range(1, 1.35f);
                break;
            case CrowdBehavior.CrowdState.Sad:
                movementSpeed = Random.Range(2.6f, 3.2f);
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
