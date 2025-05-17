using UnityEngine;

public class EnergyManager : MonoBehaviour
{
    public static EnergyManager instance;
    public float energy;
    [SerializeField] float maxEnergy = 100f;
    [SerializeField] float minSleepEnergy = 20f;


    private void Awake()
    {
        instance = this;
    }
    void CheckStamina()
    {


    }
}
