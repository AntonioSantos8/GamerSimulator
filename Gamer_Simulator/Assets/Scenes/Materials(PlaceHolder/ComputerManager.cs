using UnityEngine;

public class ComputerManager : MonoBehaviour
{
    [SerializeField] private GameObject computerUi; 
    void Start()
    {
        PlayerStates.instance.OnStream.AddListener(delegate
        {
             computerUi.SetActive(false);
        });
      
    }     
   void Update()
   {
       if (Input.GetKeyDown(KeyCode.E) && PlayerStates.instance.currentState == PlayerState.Sit)
       {
            if (PlayerStates.instance.currentState == PlayerState.Sit || PlayerStates.instance.currentState == PlayerState.Streaming)
            {
                computerUi.SetActive(!computerUi.activeSelf);
            }

             
         
       }
     
   }
}
