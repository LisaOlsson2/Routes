using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bed : MonoBehaviour
{
    TimeKeeper timeKeeper;

    private void Start()
    {
        timeKeeper = FindObjectOfType<TimeKeeper>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        collision.transform.position = new Vector3(transform.position.x - 1.5f, transform.position.y, collision.transform.position.z);
        timeKeeper.day++;
        timeKeeper.time = Random.Range(0f, 24 * 60f);
    }
}
