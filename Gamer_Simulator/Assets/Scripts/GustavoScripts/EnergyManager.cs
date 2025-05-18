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
    [HideInInspector]public Coroutine loseEnergyCoroutine;
    [HideInInspector]public Coroutine gainEnergyCoroutine;

    private void Awake()
    {
        instance = this;
    }
    private void Start()
    {
        PlayerStates.instance.OnStream.AddListener(delegate
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
            return true;
        }
        else
        {
            return false;
        }

    }
    public IEnumerator LoseEnergy()
    {
      
        energyBar.gameObject.SetActive(true);
        energyBar.fillAmount = energy / maxEnergy;
        energy -= energyToLose; 
    
        yield return new WaitForSeconds(1f);
        if (CanLoseEnergy())
        {
            StartCoroutine(LoseEnergy());
        }
        else
        { 
            energyBar.gameObject.SetActive(false);
            PlayerStates.instance.ChangeState(PlayerState.Sit);

        }
    }
    
    public IEnumerator GainEnergy()
    {
        energyBar.gameObject.SetActive(true);
          energyBar.fillAmount = energy / maxEnergy;
        energy += energyToGain; 
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
