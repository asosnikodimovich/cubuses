using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor.Rendering;
using UnityEngine;
using UnityEngine.Rendering;

public class PlayerMovement : MonoBehaviour
{
    public static float speedMultiplier = 15f;
    float maxSpeed = S.speed * speedMultiplier;
    float minSpeed = S.speed;

    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.position += Vector3.up * S.speed * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.position += Vector3.down * S.speed * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.RightArrow) && S.speed < maxSpeed)
        {
            S.speed += S.speed * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.LeftArrow) && S.speed > minSpeed)
        {
            S.speed -= S.speed * Time.deltaTime;
        }

        if (S.speed > minSpeed)
        {
                transform.Rotate(0, 0, S.speed * Time.deltaTime);
        }
    }
}
