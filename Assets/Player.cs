using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] bool Player1 = true;
    KeyCode UP = KeyCode.UpArrow;
    KeyCode DOWN = KeyCode.DownArrow;
    KeyCode W = KeyCode.W;
    KeyCode S = KeyCode.S;

    Rigidbody2D rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        if (Player1)
            rb.velocity = GetMovementAxis(W, S);
        else
            rb.velocity = GetMovementAxis(UP, DOWN);
        
    }

    private Vector2 GetMovementAxis(KeyCode upKey, KeyCode downKey)
    {
        if (Input.GetKey(upKey)) return new Vector2(0, 15);
        else if (Input.GetKey(downKey)) return new Vector2(0, -15);
        else return Vector2.zero;
    }
}
