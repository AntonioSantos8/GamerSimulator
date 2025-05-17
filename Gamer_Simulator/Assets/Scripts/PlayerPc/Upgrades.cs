using UnityEngine;
public enum TypeOfUpgrade
{
    MouseUpg,
    MonitorUpg,
    KeyBoardUpg,
    ChairUpg,
    HeadphoneUpg,
    WebcamUpg,
    BedUpg
}
public class Upgrades : MonoBehaviour
{
    int mouseLevel, monitorLevel, keyboardLevel, chairLevel, headphoneLevel, webcamLevel, bedLevel = 1;
    int levelMax = 10;
    [SerializeField] GameObject[] mouseGmj, monitorGmj, keyBoardGmj, chairGmj, headphoneGmj, webcamGmj, bedGmj;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Upgrade(TypeOfUpgrade upgradeType)
    {
        switch (upgradeType)
        {
            case TypeOfUpgrade.MouseUpg:
                if (mouseLevel < levelMax)
                    mouseLevel++;
                    mouseGmj[mouseLevel].SetActive(true);
                    mouseGmj[mouseLevel-1].SetActive(false);
                break;

            case TypeOfUpgrade.MonitorUpg:
                if (monitorLevel < levelMax)
                    monitorLevel++;
                    monitorGmj[monitorLevel].SetActive(true);
                    monitorGmj[monitorLevel - 1].SetActive(false);
                break;

            case TypeOfUpgrade.KeyBoardUpg:
                if (keyboardLevel < levelMax)
                    keyboardLevel++;
                    keyBoardGmj[keyboardLevel].SetActive(true);
                    keyBoardGmj[keyboardLevel - 1].SetActive(false);
                break;

            case TypeOfUpgrade.ChairUpg:
                if (chairLevel < levelMax)
                    chairLevel++;
                    chairGmj[chairLevel].SetActive(true);
                    chairGmj[chairLevel - 1].SetActive(false);
                break;

            case TypeOfUpgrade.HeadphoneUpg:
                if (headphoneLevel < levelMax)
                    headphoneLevel++;
                    headphoneGmj[headphoneLevel].SetActive(true);
                    headphoneGmj[headphoneLevel - 1].SetActive(false);
                break;

            case TypeOfUpgrade.WebcamUpg:
                if(webcamLevel < levelMax)
                    webcamLevel++;
                    webcamGmj[webcamLevel].SetActive(true);
                    webcamGmj[webcamLevel - 1].SetActive(false);
                break;

            case TypeOfUpgrade.BedUpg:
                if(bedLevel < levelMax)
                    bedLevel++;
                    bedGmj[bedLevel].SetActive(true);
                    bedGmj[bedLevel - 1].SetActive(false);
                break;
        }
    }
}
