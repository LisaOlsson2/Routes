using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeKeeper : MonoBehaviour
{
    readonly float speed = 1;
    float time;

    Text text;

    private void Start()
    {
        text = GetComponent<Text>();
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
            time = 0;
        }

        text.text = beforer + hours + betweener + mins;
    }
}
