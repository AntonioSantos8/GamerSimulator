using System.Collections;
using UnityEngine;
using UnityEngine.Events;

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
    public UnityEvent onDayStart, OnNightStart;

    void Awake()
    {
        instance = this;
        StartCoroutine(TimeCycle());
    }
    void ChangeDayState(DayState newState)
    {
        currentState = newState;
        switch (currentState)
        {
            case DayState.Day:
             currentDay++;
                onDayStart?.Invoke();
                break;
            case DayState.Night:
                OnNightStart?.Invoke();
                break;
        }
    }
    IEnumerator TimeCycle()
    {
        while (true)
        {
            if (currentState == DayState.Day)
            {
                yield return new WaitForSeconds(dayDuration);
                ChangeDayState(DayState.Night);
            }
            else if (currentState == DayState.Night)
            {
                yield return new WaitForSeconds(nightDuration);
               ChangeDayState(DayState.Day);
               
               
            }
        }
    }
}
