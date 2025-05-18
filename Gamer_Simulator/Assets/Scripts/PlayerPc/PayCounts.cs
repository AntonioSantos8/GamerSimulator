using UnityEngine;

public class PayCounts : MonoBehaviour
{
    [SerializeField] GameObject payCheckPrefab;
    [SerializeField] Transform payCheckParent;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void CreatePayCheck(float amount, float timeTillEnd)
    {
        GameObject payCheck = Instantiate(payCheckPrefab, payCheckParent);
        PayCheck payCheckScript = payCheck.GetComponent<PayCheck>();
        payCheckScript.UpdatePayCheck(amount, timeTillEnd);
    }
}
