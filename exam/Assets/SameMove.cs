using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SameMove : MonoBehaviour
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
        //Movimiento igual
        if (Input.GetKey(KeyCode.UpArrow))
        {
            direction += Vector3.up;
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            direction += Vector3.down;
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            direction += Vector3.left;
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            direction += Vector3.right;
        }
        //Movimiento diferente
        
        gameObject.transform.position += direction * Time.deltaTime * speed;
        direction.Normalize();
    }
}
