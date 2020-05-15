using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision:MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag != gameObject.tag){
            // print("Tienen dif tag");
            PlayerController.instance.AumentarPuntaje();
            
        }else{
            // print("Tienen tag igual");
            PlayerController.instance.DisminuirVidas();
        }
        Destroy(other.gameObject);
    }
}
