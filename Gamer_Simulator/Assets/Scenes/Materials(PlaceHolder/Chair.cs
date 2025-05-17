using UnityEngine;

public class Chair : MonoBehaviour
{
    void OnMouseDown()
    {
        if (PlayerStates.instance.currentState == PlayerState.Sleeping)
        {
            PlayerStates.instance.ChangeState(PlayerState.WalkingToChair);
        }
    }
}
