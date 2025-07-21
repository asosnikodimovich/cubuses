using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PipesMovement : MonoBehaviour
{

    // Start is called before the first frame update
    void Update()
    {
            transform.Translate(Vector3.left * S.speed * Time.deltaTime);
    }
}
