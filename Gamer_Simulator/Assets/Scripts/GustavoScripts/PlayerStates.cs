using UnityEngine;
using UnityEngine.Events;

public enum PlayerState
{
    Sit,
    Streaming,
    Sleeping,
    WalkingToBed,
    WalkingToChair,
    PcOpen
}
public class PlayerStates : MonoBehaviour
{
    public static PlayerStates instance;
    public PlayerState currentState;
    public bool wasInPc;

    public UnityEvent OnSit, OnStream, OnSleep, OnWalkToBed, OnWalkToChair, OnPcOpen;
    void Awake()
    {
        instance = this;
        currentState = PlayerState.Sit;
    }
    public void ChangeState(PlayerState newState)
    {

        PlayerState previousState = currentState;
        if (previousState == PlayerState.Sleeping)
        {
           EnergyManager.instance.StopAllCoroutines();
           
        }
        if (previousState == PlayerState.Streaming)
        {
             EnergyManager.instance.StopAllCoroutines();
        }
       
        
            


         
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
                    OnSit?.Invoke();
                    
                break;
                case PlayerState.PcOpen:
                    OnPcOpen?.Invoke();
                break;
            case PlayerState.WalkingToBed:
                OnWalkToBed?.Invoke();

                break;
                case PlayerState.WalkingToChair:
                OnWalkToChair?.Invoke();

                break;
            case PlayerState.Streaming:
                OnStream?.Invoke();
                //perder energia
                break;
            case PlayerState.Sleeping:
            OnSleep?.Invoke();
                //animacao de dormir 
                //Ganhar energia
                //arrumar posicao e rotacao do player
                break;
        }
    }
}
