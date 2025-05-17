using UnityEngine;
public enum TypeOfUpgrade
{
    MouseUpg,
    MonitorUpg,
    KeyBoardUpg,
    ChairUpg,
    HeadphoneUpg,
    WebcamUpg,
    BedUpg,
    PcUpg
}
public class Upgrades : MonoBehaviour
{
    int mouseLevel = 1, monitorLevel = 1, keyboardLevel = 1, chairLevel = 1, headphoneLevel = 1, webcamLevel = 1, bedLevel = 1, pcLevel = 1;
    int levelMax = 10;
    [SerializeField] GameObject[] mouseGmj, monitorGmj, keyBoardGmj, chairGmj, headphoneGmj, webcamGmj, bedGmj, pcGmj;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    void Upgrade(TypeOfUpgrade upgradeType)
    {
        switch (upgradeType)
        {
            case TypeOfUpgrade.MouseUpg:
                if (mouseLevel < levelMax)
                {
                    mouseLevel++;
                    mouseGmj[mouseLevel].SetActive(true);
                    mouseGmj[mouseLevel - 1].SetActive(false);
                }
                break;

            case TypeOfUpgrade.MonitorUpg:
                if (monitorLevel < levelMax)
                {
                    monitorLevel++;
                    monitorGmj[monitorLevel].SetActive(true);
                    monitorGmj[monitorLevel - 1].SetActive(false);
                }
                break;

            case TypeOfUpgrade.KeyBoardUpg:
                if (keyboardLevel < levelMax)
                {
                    keyboardLevel++;
                    keyBoardGmj[keyboardLevel].SetActive(true);
                    keyBoardGmj[keyboardLevel - 1].SetActive(false);
                }
                break;

            case TypeOfUpgrade.ChairUpg:
                if (chairLevel < levelMax)
                {
                    chairLevel++;
                    chairGmj[chairLevel].SetActive(true);
                    chairGmj[chairLevel - 1].SetActive(false);
                }
                break;

            case TypeOfUpgrade.HeadphoneUpg:
                if (headphoneLevel < levelMax)
                {
                    headphoneLevel++;
                    headphoneGmj[headphoneLevel].SetActive(true);
                    headphoneGmj[headphoneLevel - 1].SetActive(false);
                }
                break;

            case TypeOfUpgrade.WebcamUpg:
                if (webcamLevel < levelMax)
                {
                    webcamLevel++;
                    webcamGmj[webcamLevel].SetActive(true);
                    webcamGmj[webcamLevel - 1].SetActive(false);
                }
                break;

            case TypeOfUpgrade.BedUpg:
                if (bedLevel < levelMax)
                {
                    bedLevel++;
                    bedGmj[bedLevel].SetActive(true);
                    bedGmj[bedLevel - 1].SetActive(false);
                }
                break;

            case TypeOfUpgrade.PcUpg:
                if (pcLevel < levelMax)
                {
                    pcLevel++;
                    pcGmj[pcLevel].SetActive(true);
                    pcGmj[pcLevel - 1].SetActive(false);
                }
                break;
        }
    }
    public void UpgradeMouse() => Upgrade(TypeOfUpgrade.MouseUpg);
public void UpgradeMonitor() => Upgrade(TypeOfUpgrade.MonitorUpg);
public void UpgradeKeyboard() => Upgrade(TypeOfUpgrade.KeyBoardUpg);
public void UpgradeChair() => Upgrade(TypeOfUpgrade.ChairUpg);
public void UpgradeHeadphone() => Upgrade(TypeOfUpgrade.HeadphoneUpg);
public void UpgradeWebcam() => Upgrade(TypeOfUpgrade.WebcamUpg);
public void UpgradeBed() => Upgrade(TypeOfUpgrade.BedUpg);
public void UpgradePc() => Upgrade(TypeOfUpgrade.PcUpg);

}

