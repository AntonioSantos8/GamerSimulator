using System.Collections;
using UnityEngine;

public enum DayState
{
    Day,
    Night
}

public class TimeSystem : MonoBehaviour
{
    public static TimeSystem instance;

    public DayState currentState = DayState.Day;
    float dayDuration = 60f;
    float nightDuration = 30f;

    public int currentDay = 1;

    public delegate void OnNewDay(int day);
    public static event OnNewDay onNewDay;

    void Start()
    {
        instance = this;
        StartCoroutine(TimeCycle());
    }

    IEnumerator TimeCycle()
    {
        while (true)
        {
            if (currentState == DayState.Day)
            {
                yield return new WaitForSeconds(dayDuration);
                currentState = DayState.Night;
            }
            else if (currentState == DayState.Night)
            {
                yield return new WaitForSeconds(nightDuration);
                currentState = DayState.Day;
                currentDay++;
                onNewDay?.Invoke(currentDay);
            }
        }
    }
}
