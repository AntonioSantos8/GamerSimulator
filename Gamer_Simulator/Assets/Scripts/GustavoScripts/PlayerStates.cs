using UnityEngine;
using UnityEngine.Events;

public enum PlayerState
{
    Sit,
    Streaming,
    Sleeping,
    Walking
}
public class PlayerStates : MonoBehaviour
{
    public static PlayerStates instance;
    public PlayerState currentState;

    public UnityEvent OnSit, OnStream, OnSleep, OnWalk;
    void Awake()
    {
        instance = this;
        currentState = PlayerState.Sit;
    }

    // Update is called once per frame
    void Update()
    {
       
    }
    public void ChangeState(PlayerState newState)
    {
        if (currentState == newState)
        {
            return;
        }
        

        
        currentState = newState;
        if (currentState != PlayerState.Streaming)
        {
            EarnMoneyManager.instance.StopAllCoroutines();


         }
       switch (currentState)
        {
            case PlayerState.Sit:
                // Handle sit state
                break;
            case PlayerState.Walking:
                //Animação de andar
                //Arrumar posição e rotação do player

                break;
            case PlayerState.Streaming:
                // Handle streaming state
                //perder energia
                break;
            case PlayerState.Sleeping:
                //animacao de dormir 
                //Ganhar energia
                //arrumar posicao e rotacao do player
                break;
        }
    }
}
