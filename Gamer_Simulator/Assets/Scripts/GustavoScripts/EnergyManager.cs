using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class EnergyManager : MonoBehaviour
{
    public static EnergyManager instance;
    public float energy;
    [SerializeField] float maxEnergy = 100f;
    [SerializeField] float minSleepEnergy = 0f;
    [SerializeField] float energyToLose;
       [SerializeField] float energyToGain;
    [SerializeField] Image energyBar;

    private void Awake()
    {
        instance = this;
    }
     bool CanGetEnergy()
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
     bool CanLoseEnergy()
    {
        if (energy >= minSleepEnergy)
        {
            return false;
        }
        else
        {
            return true;
        }

    }
    public IEnumerator LoseEnergy()
    {
        energy -= energyToLose; 
        energy = Mathf.Clamp(energy, 0, minSleepEnergy);
        yield return new WaitForSeconds(1f);
        if (CanLoseEnergy())
        {
            StartCoroutine(LoseEnergy());
        }
    }
    public IEnumerator GainEnergy()
    {

        energy -= energyToGain; 
        energy = Mathf.Clamp(energy, 0, maxEnergy);
        yield return new WaitForSeconds(1f);
        if (CanGetEnergy())
        {
            StartCoroutine(GainEnergy());

        }
    }
}
