using UnityEngine;

public class Player : MonoBehaviour
{
    Animator anim;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        anim = GetComponent<Animator>();
        PlayerStates.instance.OnWalkToBed.AddListener(delegate
        {
            anim.Play("GoingToBed");
        });
 PlayerStates.instance.OnWalkToChair.AddListener(delegate {
          anim.Play("GoingToChair");
});

    }
    public void OnBed()
    {
       
        PlayerStates.instance.ChangeState(PlayerState.Sleeping);
    }
    public void OnChair()
    {
        PlayerStates.instance.ChangeState(PlayerState.Sit);
        
    }

  
}
