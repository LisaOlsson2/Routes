using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CommonControlls : MonoBehaviour
{
    readonly KeyCode right = KeyCode.RightArrow;
    readonly KeyCode left = KeyCode.LeftArrow;
    protected readonly KeyCode up = KeyCode.UpArrow;
    protected readonly KeyCode down = KeyCode.DownArrow;

    protected readonly float speed = 4;

    protected virtual void Update()
    {
        if (Input.GetKey(right))
        {
            transform.position += Vector3.right * speed * Time.deltaTime;
        }
        if (Input.GetKey(left))
        {
            transform.position += Vector3.left * speed * Time.deltaTime;
        }
    }
}
