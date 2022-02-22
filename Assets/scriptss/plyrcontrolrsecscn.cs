using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class plyrcontrolrsecscn : MonoBehaviour
{
    public Text gameover;
    public Button restart,againstart;
    public float speed;
    private Rigidbody playerrb;
    public bool isground=true;
    public GameObject bullet;
    
    void Awake(){
        Time.timeScale=1;
        againstart.gameObject.SetActive(false);
    }
    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale=1;
        gameover.enabled=false;
        againstart.gameObject.SetActive(false);
        restart.gameObject.SetActive(false);
        playerrb=GetComponent<Rigidbody>();

    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space ) && isground==true){
            
        playerrb.AddForce(Vector3.up*speed,ForceMode.Impulse);
        isground=false;
        }
        if(Input.GetKeyDown(KeyCode.Escape)){
            restart.gameObject.SetActive(true);
            Time.timeScale=0;
        }
        if(Input.GetKeyDown(KeyCode.F)){
           Instantiate(bullet,new Vector3(transform.position.x+1,10f,transform.position.z),transform.rotation);
        }
            
    }
    public void OnCollisionEnter(Collision col){
        isground=true;
        if(col.gameObject.tag=="enm"){
            Debug.Log("eemy collided");
            //Destroy(gameObject);
            Destroy(col.gameObject);
            Time.timeScale=0;
            gameover.enabled=true;
            againstart.gameObject.SetActive(true);
        }
    }
     public void Restart(){
         
      Time.timeScale=1;
      restart.gameObject.SetActive(false);
      gameover.enabled=false;
    }
    public void AgainStart(){
        SceneManager.LoadScene(1);
     Debug.Log("scene start");   
        againstart.gameObject.SetActive(false);
    }
    
}
