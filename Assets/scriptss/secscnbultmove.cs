using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class secscnbultmove : MonoBehaviour
{
    public float speed;
    public bool isbultcol;
   
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.right*speed*Time.deltaTime);
        if(transform.position.x>=13){
            Destroy(gameObject);
        }
    }
    public void OnCollisionEnter(Collision col){
       if(col.gameObject.tag=="enm"){
           isbultcol=true;
           Destroy(gameObject);
           Destroy(col.gameObject);
           
          
        }
    }
}
