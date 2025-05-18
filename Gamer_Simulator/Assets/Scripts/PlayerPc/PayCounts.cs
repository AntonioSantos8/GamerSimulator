using UnityEngine;
using System.Collections.Generic;
public class PayCounts : MonoBehaviour
{
    public static PayCounts instance;
    [SerializeField] GameObject payCheckPrefab;
    [SerializeField] Transform payCheckParent;
    float daysTillBill;
    public List<PayCheck> payChecks = new List<PayCheck>();

    void Awake()
    {
        instance = this;
    }
    void Start()
    {
        daysTillBill = 7;
        TimeSystem.instance.OnDayStart.AddListener(() =>
        {
            daysTillBill--;
            foreach (PayCheck payCheck in payChecks)
            {
                payCheck.daysTillEnd--;
                payCheck.timeTillEndText.text = payCheck.daysTillEnd.ToString() + " Days";
                if(payCheck.daysTillEnd <= 0)
                {
                    //Colocar aqui o que acontece se a conta não for paga ate o fim do tempo
                }
            }
            if (daysTillBill <= 0)
            {
                CreatePayCheck(100, 3);
                daysTillBill = 7;
            }
        });
    }

    public void CreatePayCheck(float amount, float timeTillEnd)
    {
        GameObject payCheck = Instantiate(payCheckPrefab, payCheckParent);
        PayCheck payCheckScript = payCheck.GetComponent<PayCheck>();
        payChecks.Add(payCheckScript);
        payCheckScript.UpdatePayCheck(amount, timeTillEnd);
    }
}
