using UnityEngine;

public enum PlayerState
{
    Sit,
    Straming,
    Sleeping,
    Walking
}
public class PlayerStates : MonoBehaviour
{
    public static PlayerStates instance;
    public PlayerState currentState;
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
            return;

        currentState = newState;
       switch (currentState)
        {
            case PlayerState.Sit:
                // Handle sit state
                break;
                 case PlayerState.Walking:
                //Animação de andar
                //Arrumar posição e rotação do player
               
                break;
            case PlayerState.Straming:
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
