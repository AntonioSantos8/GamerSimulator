using UnityEngine;

public class StreamManager : MonoBehaviour
{
    public void StartStream()
    {
        PlayerStates.instance.ChangeState(PlayerState.Streaming);
   }
}
