using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class movement : MonoBehaviour
{
    Vector2 var1;
    // Start is called before the first frame update
    void OnMove(InputValue input)
    {
        var1 = input.Get<Vector2>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(var1.x, 0f, var1.y) * Time.deltaTime;
    }
}
