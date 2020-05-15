using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerMovement: MonoBehaviour
{
    private float minX, maxX; 

    [SerializeField]
    private float speed = 4.0f;

    [HideInInspector]
    private Rigidbody2D body;
    void Start()
    {
        minX = -4.5f; //A LA ALTURA DE LA IMAGEN
        maxX = 4.5f;
        body = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        Bounds();
        Move();

    }
    void Move(){
        if(Input.GetKey(KeyCode.A)){
            body.velocity = new Vector2(-speed,0);
        }   
        else if(Input.GetKey(KeyCode.D)){
            body.velocity = new Vector2(speed,0);
        }else{
            body.velocity = new Vector2();
        }
    }
    void Bounds(){
        if (transform.position.x < minX)
        {
            Vector3 temp = transform.position;
            temp.x = minX;
            transform.position = temp;
        }
        if (transform.position.x > maxX)
        {
            Vector3 temp = transform.position;
            temp.x = maxX;
            transform.position = temp;
        }
    }
}