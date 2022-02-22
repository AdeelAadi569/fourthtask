using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class playermovememt : MonoBehaviour
{
    public float speed=20f;
    public GameObject prefab;
    public Text gameover;
    public Button restart,startagain;
    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale=1;
        gameover.enabled=false;
        //restart.enabled=false;
        restart.gameObject.SetActive(false);
        startagain.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey("w")){
            transform.Translate(Vector3.forward*speed*Time.deltaTime);
        }
        if(Input.GetKey("s")){
            transform.Translate(Vector3.back*speed*Time.deltaTime);
        }
        if(Input.GetKey("a")){
            transform.Translate(Vector3.left*speed*Time.deltaTime);
        }
        if(Input.GetKey("d")){
            transform.Translate(Vector3.right*speed*Time.deltaTime);
        }
        if(transform.position.x>=20){
            transform.position=new Vector3(20,transform.position.y,transform.position.z);
        }
        if(transform.position.x<=-20){
            transform.position=new Vector3(-20,transform.position.y,transform.position.z);
        }
        if(Input.GetKeyDown(KeyCode.Space)){
            Instantiate(prefab,new Vector3(transform.position.x,3,transform.position.z+2),Quaternion.identity);
        }
        if(Input.GetKeyDown(KeyCode.Escape)){
            restart.gameObject.SetActive(true);
            Time.timeScale=0;
        }
    }
    public void OnCollisionEnter(Collision col){
       // Destroy(gameObject);
        if(col.transform.tag=="teleport"){
            Debug.Log("Teleport");
            SceneManager.LoadScene("2ndscene");
        }
        if(col.transform.tag=="enm"){
        Destroy(col.gameObject);
        Time.timeScale=0;
        startagain.gameObject.SetActive(true);
        gameover.enabled=true;
        }
       
    }
    public void Restart(){
        Time.timeScale=1;
        restart.gameObject.SetActive(false);
    }
    public void StartAgain(){
       Debug.Log("load new scene");
        SceneManager.LoadScene("instructortask4");
      //  SceneManager.LoadScene(0);
      //  SceneManager.LoadScene("2ndscene");
  
     }
}
