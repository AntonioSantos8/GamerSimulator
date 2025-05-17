using UnityEngine;

public class ComputerManager : MonoBehaviour
{
    [SerializeField] private GameObject computerUi;   
   void Update()
   {
       if (Input.GetKeyDown(KeyCode.E) && PlayerStates.instance.currentState == PlayerState.Sit)
       {
         
          computerUi.SetActive(!computerUi.activeSelf);
       }
     
   }
}
