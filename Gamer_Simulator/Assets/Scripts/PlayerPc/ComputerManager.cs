using UnityEngine;

public class ComputerManager : MonoBehaviour
{
    [SerializeField] private GameObject farCam;
    [SerializeField] private GameObject pcCam;

    private bool isInPc = false;

    void Start()
    {
        PlayerStates.instance.OnStream.AddListener(() =>
        {
            farCam.SetActive(false);
            pcCam.SetActive(true);
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
                    pcCam.SetActive(true);
                    farCam.SetActive(false);
                    isInPc = true;
                }
                else
                {
                    pcCam.SetActive(false);
                    farCam.SetActive(true);
                    isInPc = false;
                }
            }
        }
    }
}
