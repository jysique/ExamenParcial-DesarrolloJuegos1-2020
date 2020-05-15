using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class PlayerController: MonoBehaviour
{
    
    public static PlayerController instance;
    private int puntaje = 0;

    private int vidas  = 4;
    [SerializeField]
    private Text puntajetxt;
    [SerializeField]
    private Text vidastxt;

    [SerializeField]
    private GameObject uno;
    [SerializeField]
    private GameObject dos;
    [SerializeField]
    private GameObject tres;
    [SerializeField]
    private GameObject cuarto;
    [SerializeField]
    private GameObject quinto;

    private GameObject monsterGO;

    private void Awake(){
        if (instance == null)
        {
            instance = this;
        }
    }
    void Start() {

        string monster = PlayerPrefs.GetString("player");
        
        Vector2 position = gameObject.transform.position;//ASUMI ESTO
        // GameObject monsterGO = new GameObject();

        if(monster == "1" ){
            monsterGO = uno;
        }
        if(monster == "2"){
            monsterGO = dos;
        }
        if(monster == "3"){ 
            monsterGO = tres;
        }
        if(monster == "4"){
            monsterGO = cuarto;
        }
        if(monster == "5"){
            monsterGO = quinto;
        }
        Instantiate(monsterGO,position,Quaternion.identity);
    }
    private void Update() {
        puntajetxt.text = "Puntaje: " + puntaje;
        vidastxt.text = "Vidas: " + vidas;
        if (vidas == 0)
        {
            GameOver();
        }
    }
    public void AumentarPuntaje(){
        puntaje+=10;
    }
    public void DisminuirVidas(){
        vidas-=1;
    }

    public void GameOver(){
        SceneManager.LoadScene("GameOver");
    }
}
