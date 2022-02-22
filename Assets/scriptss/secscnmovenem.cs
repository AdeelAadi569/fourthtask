using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class secscnmovenem : MonoBehaviour
{
    public float speed;
     private GameObject smalcube;
     public bool isbulletcoll;
    // Start is called before the first frame update
    void Start()
    {
         smalcube=GameObject.FindGameObjectWithTag("smlcub");
         
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.left*Time.deltaTime*speed);
        if(transform.position.x<=-5){
            Destroy(gameObject);
        }
    }
    public void OnCollisionEnter(Collision col){
       // if(col.gameObject.tag=="bullet"){
         //   isbulletcoll=true;
          //  Debug.Log("collided");
           // Destroy(col.gameObject);
         //   Destroy(gameObject);
            //gameObject.transform.localScale=new Vector3(0.2f,0.5f,0.5f);
         
            //Debug.Log("new");

        }
    //}
     
}
