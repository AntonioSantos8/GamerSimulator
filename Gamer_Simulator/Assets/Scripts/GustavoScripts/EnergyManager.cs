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
    public bool CheckEnergyOnBed()
    {
        if (energy >= maxEnergy)
        {
            return false;
        }
        else
        {
            return true;
        }
    }
    void CheckEnergyOnStream()
    {


    }
    public IEnumerator LoseEnergy(float amount)
    {
        while (energy > 0)
        {
            energy -= amount * Time.deltaTime;
            yield return null;
        }
    }
    public IEnumerator GainEnergy(float amount)
    {
        while (energy < maxEnergy)
        {
            energy += amount * Time.deltaTime;
            yield return null;
        }
    }
}
