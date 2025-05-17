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
    Coroutine loseEnergyCoroutine;
    Coroutine gainEnergyCoroutine;

    private void Awake()
    {
        instance = this;
    }
    private void Start()
    {
        PlayerStates.instance.OnSit.AddListener(delegate
        {
            loseEnergyCoroutine = StartCoroutine(LoseEnergy());
        });
         PlayerStates.instance.OnSleep.AddListener(delegate {
            gainEnergyCoroutine = StartCoroutine(GainEnergy());
        });


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
        energyBar.gameObject.SetActive(true);
        energy -= energyToLose; 
        energy = Mathf.Clamp(energy, 0, minSleepEnergy);
        yield return new WaitForSeconds(1f);
        if (CanLoseEnergy())
        {
            StartCoroutine(LoseEnergy());
        }
        else
        { 
            energyBar.gameObject.SetActive(false);


        }
    }
    
    public IEnumerator GainEnergy()
    {
        energyBar.gameObject.SetActive(true);
        energy -= energyToGain; 
        energy = Mathf.Clamp(energy, 0, maxEnergy);
        yield return new WaitForSeconds(1f);
        if (CanGetEnergy())
        {
            StartCoroutine(GainEnergy());

        }
        else
        {
            energyBar.gameObject.SetActive(false);

         }
    }
}
