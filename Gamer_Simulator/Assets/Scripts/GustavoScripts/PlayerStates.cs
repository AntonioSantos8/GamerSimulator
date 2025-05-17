using UnityEngine;
using UnityEngine.Events;

public enum PlayerState
{
    Sit,
    Streaming,
    Sleeping,
    WalkingToBed,
    WalkingToChair
}
public class PlayerStates : MonoBehaviour
{
    public static PlayerStates instance;
    public PlayerState currentState;

    public UnityEvent OnSit, OnStream, OnSleep, OnWalkToBed, OnWalkToChair;
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

        PlayerState previousState = currentState;
        if (previousState == PlayerState.Sleeping)
        {
            // Stop sleeping coroutine
            if (EnergyManager.instance.gainEnergyCoroutine != null)
            {
                StopCoroutine(EnergyManager.instance.gainEnergyCoroutine);
                EnergyManager.instance.gainEnergyCoroutine = null;
            }
        }
        if (previousState == PlayerState.Streaming)
        {
            // Stop streaming coroutine
            if (EnergyManager.instance.loseEnergyCoroutine != null)
            {
                StopCoroutine(EnergyManager.instance.loseEnergyCoroutine);
                EnergyManager.instance.loseEnergyCoroutine = null;
            }
        }
        {
            


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
