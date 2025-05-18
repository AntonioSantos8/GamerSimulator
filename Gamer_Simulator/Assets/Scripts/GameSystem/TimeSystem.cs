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
    [SerializeField]float dayDuration = 60f;
    [SerializeField]float nightDuration = 30f;

    public int currentDay = 1;
    public UnityEvent OnDayStart, OnNightStart;

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
                OnDayStart?.Invoke();
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
                print("Day " + currentDay);
               
               
            }
        }
    }
}
