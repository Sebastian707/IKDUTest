using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeeklyPlanningCase : MonoBehaviour
{
    string[] Weekdays = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };

    public float updateInterval = 1.0f;

    void Start()
    {
        StartCoroutine(UpdateDay());
    }

    IEnumerator UpdateDay()
    {
        for (int day = 0; day < Weekdays.Length; day++)
        {
            switch (Weekdays[day])
            {
                case "Monday":
                    Debug.Log("I watched a movie on " + Weekdays[day]);
                    break;

                case "Tuesday":
                    Debug.Log("It's " + Weekdays[day] + " I played a video game");
                    break;

                case "Wednesday":
                    Debug.Log("It's " + Weekdays[day] + " I dreamt I was a butterfly");
                    break;

                case "Thursday":
                    Debug.Log("It's " + Weekdays[day] + " I played Metaphor");
                    break;

                case "Friday":
                    Debug.Log("It's " + Weekdays[day] + " I coded for a bit");
                    break;

                case "Saturday":
                    Debug.Log("I kicked ass in Street Fighter 6 on " + Weekdays[day]);
                    break;

                case "Sunday":
                    Debug.Log("It's " + Weekdays[day] + ". And so it's the end of another week");
                    day = -1;
                    break;
            }

            yield return new WaitForSeconds(updateInterval);
        }
    }
}
