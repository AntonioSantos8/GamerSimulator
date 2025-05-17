using UnityEngine;

public class Bed : MonoBehaviour
{
    void OnMouseDown()
    {
        if (PlayerStates.instance.currentState == PlayerState.Sit)
        {
            PlayerStates.instance.ChangeState(PlayerState.WalkingToBed);
        }
    }
}
