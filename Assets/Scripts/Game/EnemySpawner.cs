
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner: MonoBehaviour
{
    [SerializeField]
    private List<GameObject> enemies;
    private float elapsed;
    void Start()
    {
        
    }

    void Update()
    {
        // Vector2 position = gameObject.transform.position;
        
        elapsed+=Time.deltaTime;
        if(elapsed>=2f){
            elapsed = 0f;
            int index = Random.Range(0,enemies.Count-1);
            float y =gameObject.transform.position.y;
            float x = Random.Range(-4.8f,4.8f); //PARA QUE NO SE SALGA DE LA PANTALLA
            Vector2 pos = new Vector2(x,y);
            Instantiate(enemies[index],pos,Quaternion.identity);
        }
    }
    
}