using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VoitureMouvements : MonoBehaviour
{
    public KeyCode left;
    public KeyCode right;
    public KeyCode down;
    public KeyCode up;
    public float speedMovement = 10;
    public float speedMax = 10;
    public float speedRalenti = 5;
    private Rigidbody2D rb;


    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        if(Input.GetKey(left))
        {
            rb.velocity = new Vector2(-speedMovement, rb.velocity.y);
        }
        if (Input.GetKey(right))
        {
            rb.velocity = new Vector2(speedMovement, rb.velocity.y);
        }
        if (Input.GetKey(down))
        {
            rb.velocity = new Vector2(rb.velocity.x, -speedMovement / 2);
        }
        if (Input.GetKey(up))
        {
            rb.velocity = new Vector2(rb.velocity.x, speedMovement / 2);
        }

    }

    public void Ralentissement()
    {
        speedMovement = speedRalenti;
        StartCoroutine(AccelDelay());
    }

    IEnumerator AccelDelay()
    {
        yield return new WaitForSeconds(2F);
        speedMovement = speedMax;
    }
}
