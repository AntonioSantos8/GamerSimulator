using UnityEngine;

public class Money : MonoBehaviour
{
    public static Money instance;
    public float money;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        instance = this;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

}
