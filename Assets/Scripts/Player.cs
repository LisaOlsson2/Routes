using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : CommonControlls
{
    [SerializeField]
    GameObject inventory;

    readonly int[] timeScales = { 1, 0 };

    protected override void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            inventory.SetActive(!inventory.activeSelf);
            Time.timeScale = timeScales[(int)Time.timeScale];
        }

        if (Input.GetKeyDown(KeyCode.Q))
        {
            foreach (Animator animator in GetComponentsInChildren<Animator>())
            {
                animator.SetTrigger("Change");
            }
        }

        base.Update();

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