using UnityEngine;
using TMPro;
using UnityEngine.UI;
public class PayCheck : MonoBehaviour
{
    public TMP_Text amountText;
    public TMP_Text timeTillEndText;
    public Button payButton;
    
    float amountToPay;
      public   float daysTillEnd;
 
    public void UpdatePayCheck(float amount, float timeTillEnd)
    {

        amountToPay = amount;
        daysTillEnd = timeTillEnd;
                amountText.text = "$" + amount.ToString();
        timeTillEndText.text = timeTillEnd.ToString("F2") + " Days";


        payButton.onClick.AddListener(() => Pay());

    }
    void Pay()
    {
        if (Money.instance.money >= amountToPay)
        {
            PayCounts.instance.payChecks.Remove(this);
            Money.instance.money -= amountToPay;
            Destroy(gameObject);
        }

    }
}
    

