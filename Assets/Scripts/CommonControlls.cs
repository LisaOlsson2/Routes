using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CommonControlls : MonoBehaviour
{
    readonly KeyCode right = KeyCode.RightArrow;
    readonly KeyCode left = KeyCode.LeftArrow;
    public readonly KeyCode up = KeyCode.UpArrow;
    public readonly KeyCode down = KeyCode.DownArrow;

    public readonly float speed = 4;

    public virtual void Update()
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
