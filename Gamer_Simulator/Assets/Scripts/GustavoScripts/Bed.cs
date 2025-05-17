using UnityEngine;

public class Bed : MonoBehaviour
{
    void OnMouseDown()
    {
        PlayerStates.instance.ChangeState(PlayerState.Walking);
    }
}
