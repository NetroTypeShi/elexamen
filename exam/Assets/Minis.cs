using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UIElements;

public class Minis : MonoBehaviour
{
    float rotationSpeed = 0f;
    [SerializeField] float speedRotating = 60f;
    [SerializeField] Color changeColor = Color.magenta;
    bool ready = false;
    
    
  
    
    Color initialColor;
    void Start()
    {
        spawnMinis();
        initialColor = GetComponent<SpriteRenderer>().color;
    }

    // Update is called once per frame
    void Update()
    {
     rotationSpeed = Time.deltaTime * speedRotating;          
     gameObject.transform.Rotate(0, 0, rotationSpeed);
     
        
    }
    void spawnMinis()
    {

      GameObject.FindGameObjectWithTag("MiniB").GetComponent<Transform>().position = new Vector3(Random.Range(8, -8), Random.Range(4.5f, -4.5f), 0);
      GameObject.FindGameObjectWithTag("MiniO").GetComponent<Transform>().position = new Vector3(Random.Range(8, -8), Random.Range(4.5f, -4.5f), 0);
    }
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
       if (gameObject.tag == ("MiniB"))
        {
            if (GameObject.FindGameObjectWithTag("MiniO").GetComponent<Minis>().ready == true)
            {
                spawnMinis();
            }
            if (collision.gameObject.tag== ("Blue"))
            {
              print("touched");
              GameObject.FindGameObjectWithTag("MiniB").GetComponent<SpriteRenderer>().color = changeColor;
              ready = true;
             
            }
            
        }
        if (gameObject.tag == ("MiniO"))
        {
            if (GameObject.FindGameObjectWithTag("MiniB").GetComponent<Minis>().ready == true)
            {
                spawnMinis();
            }
            if (collision.gameObject.tag == ("Orange"))
            {
              GameObject.FindGameObjectWithTag("MiniO").GetComponent<SpriteRenderer>().color = changeColor;
              ready = true;
            }
            
        }  
    }


    private void OnTriggerExit2D(Collider2D collision)
    {
        if (gameObject.tag == ("MiniB"))
        {
            if (collision.gameObject.tag == ("Blue"))
            {
                print("touched");
                GameObject.FindGameObjectWithTag("MiniB").GetComponent<SpriteRenderer>().color = initialColor;
                ready = false;
            }

        }
        if (gameObject.tag == ("MiniO"))
        {
            if (collision.gameObject.tag == ("Orange"))
            {
                GameObject.FindGameObjectWithTag("MiniO").GetComponent<SpriteRenderer>().color = initialColor;
                ready = false;
            }

        }
    }
}
