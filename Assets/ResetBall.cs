using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetBall : MonoBehaviour
{
    GameObject ballObject;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        ballObject = collision.gameObject;
        Reset();
    }

    private void Reset()
    {
        if (ballObject.TryGetComponent<Ball>(out Ball ballScript))
        {
            ballScript.rb.velocity = Vector2.zero;
            ballObject.transform.position = Vector2.zero;
            ballScript.SetStartSpeed();
        }
    }
}
