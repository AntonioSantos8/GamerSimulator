using UnityEngine;

public class ComputerManager : MonoBehaviour
{
    [SerializeField]Animator camAnim;
    private bool isInPc = false;

    void Start()
    {
        PlayerStates.instance.OnStream.AddListener(() =>
        {
            camAnim.Play("ToPC");
            isInPc = true;
        });
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            var state = PlayerStates.instance.currentState;

            if (state == PlayerState.Sit || state == PlayerState.Streaming)
            {
                if (!isInPc)
                {
                    camAnim.Play("ToPC");
                    isInPc = true;
                }
                else
                {
                    camAnim.Play("ToFar");
                    isInPc = false;
                }
            }
        }
    }
}
