using UnityEngine;

public class StreamManager : MonoBehaviour
{
    public void StartStream()
    {
        PlayerStates.instance.ChangeState(PlayerState.Streaming);
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && PlayerStates.instance.currentState == PlayerState.Streaming)
        {
            PlayerStates.instance.ChangeState(PlayerState.Sit);
          
        }



     }
}
