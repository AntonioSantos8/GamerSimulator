using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public GameObject player;
    float energy;
    public float maxEnergy = 100f;
    public float minSleepEnergy = 20f;
   

    private void Awake()
    {
        instance = this;
    }




}
