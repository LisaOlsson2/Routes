using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;
using UnityEngine.UI;

public class TimeKeeper : MonoBehaviour
{
    readonly float speed = 60;

    public float time;
    public int day;
    bool night;

    Text text;

    GameObject dayLight;

    private void Start()
    {
        text = GetComponent<Text>();
        dayLight = GameObject.Find("DayLight");
    }

    private void Update()
    {
        time += Time.deltaTime * speed;

        int hours = Mathf.FloorToInt(time / 60);
        int mins = Mathf.FloorToInt(time % 60);
        string beforer = "";
        string betweener = ":";

        if (hours < 10)
        {
            beforer += 0;
        }

        if (mins < 10)
        {
            betweener += 0;
        }

        if (hours >= 24)
        {
            day++;
            time = 0;
        }

        if ((hours >= 6 && hours < 18 && night) || ((hours >= 18 || hours < 6) && !night))
        {
            dayLight.SetActive(night);
            night = !night;
        }

        text.text = beforer + hours + betweener + mins;
    }
}
