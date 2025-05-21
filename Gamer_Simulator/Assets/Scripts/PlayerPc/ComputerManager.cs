using UnityEngine;

public class ComputerManager : MonoBehaviour
{
    [SerializeField] Animator camAnim;

    bool canAnimate;
    void Start()
    {
        canAnimate = true;
        PlayerStates.instance.OnSit.AddListener(() =>
        {

            if (PlayerStates.instance.wasInPc && canAnimate)
            {
                camAnim.Play("ToFar");
                PlayerStates.instance.wasInPc = false;
                   canAnimate = false;
            }
        });
        PlayerStates.instance.OnPcOpen.AddListener(() =>
       {
           if (!canAnimate) return;

           camAnim.Play("ToPc");
           canAnimate = false;
           PlayerStates.instance.wasInPc = true;
       });

    }
    void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.E) && canAnimate)
        {
            if (PlayerStates.instance.currentState == PlayerState.PcOpen)
            {
                PlayerStates.instance.ChangeState(PlayerState.Sit);

            }
            else if (PlayerStates.instance.currentState == PlayerState.Sit)
            {
                PlayerStates.instance.ChangeState(PlayerState.PcOpen);

            }

        }

    }
    public void SetCanAnimate()
    {
        canAnimate = true;
    }

   
}
