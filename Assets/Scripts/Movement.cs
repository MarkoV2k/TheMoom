using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    Rigidbody2D body;

    float horizontal;
    float vertical;

    public float runSpeed = 10.0f;

    private Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        body = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        horizontal = Input.GetAxisRaw("Horizontal");
        vertical = Input.GetAxisRaw("Vertical");

        /*anim.SetFloat ("Speed", Mathf.Abs (GetComponent<Rigidbody2D>().velocity.y));
        anim.SetFloat("Speed", Mathf.Abs(GetComponent<Rigidbody2D>().velocity.x));*/
        anim.SetInteger("Horizontal", (int)body.velocity.x);
        anim.SetInteger("Vertical", (int)body.velocity.y);

        //if (GetComponent<Rigidbody2D>().velocity.x > 0)

    }

     

    private void FixedUpdate()
    {
        body.velocity = new Vector2(horizontal * runSpeed, vertical * runSpeed);
        print(body.velocity);
    }
}
