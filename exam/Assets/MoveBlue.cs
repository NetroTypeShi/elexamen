using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBlue : MonoBehaviour
{
    Vector3 direction;
    public float speed = 0f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        direction = Vector3.zero;

        //Movimiento diferente
        if (Input.GetKey(KeyCode.W))
        {
            direction += Vector3.up;
        }
        if (Input.GetKey(KeyCode.S))
        {
            direction += Vector3.down;
        }
        if (Input.GetKey(KeyCode.A))
        {
            direction += Vector3.left;
        }
        if (Input.GetKey(KeyCode.D))
        {
            direction += Vector3.right;
        }
        gameObject.transform.position += direction * Time.deltaTime * speed;
        direction.Normalize();
    }
}
