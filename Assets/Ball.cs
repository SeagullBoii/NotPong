using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class Ball : MonoBehaviour
{
    [HideInInspector] public Rigidbody2D rb;
    [SerializeField] float startSpeed;
    private void Start()
    {
        rb=GetComponent<Rigidbody2D>();
        SetStartSpeed();
    }

    public void SetStartSpeed()
    {

        int randNum = Random.Range(0,2)*2-1;
        float multiplier = Random.Range(0, 2) * 2 - 1 == 1 ? 1 : -1;
        float randYVel = Random.Range(startSpeed, -startSpeed);

        rb.velocity = new Vector2(startSpeed*multiplier, randYVel);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {

        rb.velocity *= 1.05f;
    }
}
