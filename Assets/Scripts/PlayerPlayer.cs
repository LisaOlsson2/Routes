using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerPlayer : CommonControlls
{
    readonly float jumpForce = 400;
    readonly Vector3 smolScale = new(1, 0.5f, 1);

    Rigidbody2D rb;
    Vector3 normalScale;
    bool grounded;
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        normalScale = transform.localScale;
    }

    protected override void Update()
    {
        base.Update();

        if (Input.GetKeyDown(up) && grounded)
        {
            rb.AddForce(Vector3.up * jumpForce);
            grounded = false;
        }

        if (Input.GetKeyDown(down))
        {
            transform.localScale = smolScale;
            transform.position -= (normalScale - smolScale) / 2;
        }
        if (Input.GetKeyUp(down))
        {
            transform.localScale = normalScale;
            transform.position += (normalScale - smolScale) / 2;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (!grounded)
        {
            grounded = true;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        SceneManager.LoadScene("Game");
    }
}
