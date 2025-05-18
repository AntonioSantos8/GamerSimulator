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
    int mouseLevel = 0, monitorLevel = 0, keyboardLevel = 0, chairLevel = 0, headphoneLevel = 0, webcamLevel = 0, bedLevel = 0, pcLevel = 0;
    int levelMax = 9;
    [SerializeField] GameObject[] mouseGmj, monitorGmj, keyBoardGmj, chairGmj, headphoneGmj, webcamGmj, bedGmj, pcGmj;
    [SerializeField]float[] mouseUpgCost, monitorUpgCost, keyBoardUpgCost, chairUpgCost, headphoneUpgCost, webcamUpgCost, bedUpgCost, pcUpgCost;
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
                if (Money.instance.money >= mouseUpgCost[mouseLevel] && mouseLevel < levelMax)
                {
                    mouseLevel++;
                    mouseGmj[mouseLevel].SetActive(true);
                    mouseGmj[mouseLevel - 1].SetActive(false);
                    Money.instance.money -= mouseUpgCost[mouseLevel];
                }
                break;

            case TypeOfUpgrade.MonitorUpg:
                if (Money.instance.money >= monitorUpgCost[monitorLevel] && monitorLevel < levelMax)
                {
                    monitorLevel++;
                    monitorGmj[monitorLevel].SetActive(true);
                    monitorGmj[monitorLevel - 1].SetActive(false);
                    Money.instance.money -= monitorUpgCost[monitorLevel];
                }
                break;

            case TypeOfUpgrade.KeyBoardUpg:
                if (Money.instance.money >= keyBoardUpgCost[keyboardLevel] && keyboardLevel < levelMax)
                {
                    keyboardLevel++;
                    keyBoardGmj[keyboardLevel].SetActive(true);
                    keyBoardGmj[keyboardLevel - 1].SetActive(false);
                    Money.instance.money -= keyBoardUpgCost[keyboardLevel];
                }
                break;

            case TypeOfUpgrade.ChairUpg:
                if (Money.instance.money >= chairUpgCost[chairLevel] && chairLevel < levelMax)
                {
                    chairLevel++;
                    chairGmj[chairLevel].SetActive(true);
                    chairGmj[chairLevel - 1].SetActive(false);
                    Money.instance.money -= chairUpgCost[chairLevel];
                }
                break;

            case TypeOfUpgrade.HeadphoneUpg:
                if (Money.instance.money >= headphoneUpgCost[headphoneLevel] && headphoneLevel < levelMax)
                {
                    headphoneLevel++;
                    headphoneGmj[headphoneLevel].SetActive(true);
                    headphoneGmj[headphoneLevel - 1].SetActive(false);
                    Money.instance.money -= headphoneUpgCost[headphoneLevel];
                }
                break;

            case TypeOfUpgrade.WebcamUpg:
                if (Money.instance.money >= webcamUpgCost[webcamLevel] && webcamLevel < levelMax)
                {
                    webcamLevel++;
                    webcamGmj[webcamLevel].SetActive(true);
                    webcamGmj[webcamLevel - 1].SetActive(false);
                    Money.instance.money -= webcamUpgCost[webcamLevel];
                }
                break;

            case TypeOfUpgrade.BedUpg:
                if (Money.instance.money >= bedUpgCost[bedLevel] && bedLevel < levelMax)
                {
                    bedLevel++;
                    bedGmj[bedLevel].SetActive(true);
                    bedGmj[bedLevel - 1].SetActive(false);
                    Money.instance.money -= bedUpgCost[bedLevel];
                }
                break;

            case TypeOfUpgrade.PcUpg:
                if (Money.instance.money >= pcUpgCost[pcLevel] && pcLevel < levelMax)
                {
                    pcLevel++;
                    pcGmj[pcLevel].SetActive(true);
                    pcGmj[pcLevel - 1].SetActive(false);
                    Money.instance.money -= pcUpgCost[pcLevel];
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

