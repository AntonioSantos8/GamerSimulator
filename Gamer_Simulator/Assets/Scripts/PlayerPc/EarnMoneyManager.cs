using System.Collections;
using UnityEngine;

public class EarnMoneyManager : MonoBehaviour
{
    public static EarnMoneyManager instance;
    public float moneyToEarn;
    public float cooldownEarn = 5;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        instance = this;
        PlayerStates.instance.OnStream.AddListener(delegate {
            StartCoroutine(EarnMoney());
        });
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator EarnMoney()
    {
        Money.instance.money += moneyToEarn;
        yield return new WaitForSeconds(cooldownEarn);
        StartCoroutine(EarnMoney());
    }
}
