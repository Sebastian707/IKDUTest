using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeeklyPlanning : MonoBehaviour
{
    string[] Weekdays = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };

    public float updateInterval = 1.0f;

    IEnumerator UpdateDay()
    {
        for (int day = 0; day < Weekdays.Length; day++)
        {
            if (Weekdays[day] == "Monday")
            {
                Debug.Log("I watched a movie on " + Weekdays[day]);
            }
            else if (Weekdays[day] == "Tuesday")
            {
                Debug.Log("It's " + Weekdays[day] + " I played a video game");
            }
            else if (Weekdays[day] == "Wednesday")
            {
                Debug.Log("It's " + Weekdays[day] + " I dreamt i was a butterfly");
            }
            else if (Weekdays[day] == "Thursday")
            {
                Debug.Log("It's " + Weekdays[day] + " I played Metaphor");
            }
            else if (Weekdays[day] == "Friday")
            {
                Debug.Log("It's " + Weekdays[day] + " I coded for a bit");
            }
            else if (Weekdays[day] == "Saturday")
            {
                Debug.Log("I kicked as in Street Fighter 6 " + Weekdays[day]);
            }
            else
            {
                Debug.Log("It's " + Weekdays[day] + ". And so it's the end of another week");
                day = -1;
            }

            yield return new WaitForSeconds(updateInterval);
        }
    }

    void Start()
    {
        StartCoroutine(UpdateDay());
    }

}