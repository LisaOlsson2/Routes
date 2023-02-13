using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : CommonControlls
{
    [SerializeField]
    GameObject inventory;

    public override void Update()
    {
        base.Update();

        if (Input.GetKeyDown(KeyCode.Q))
        {
            foreach (Animator animator in FindObjectsOfType<Animator>())
            {
                animator.SetTrigger("Change");
            }
        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            inventory.SetActive(!inventory.activeSelf);
        }

        if (Input.GetKey(up))
        {
            transform.position += Vector3.up * speed * Time.deltaTime;
        }
        if (Input.GetKey(down))
        {
            transform.position += Vector3.down * speed * Time.deltaTime;
        }
    }
}