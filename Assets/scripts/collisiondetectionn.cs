using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collisiondetectionn : MonoBehaviour
{
   //public ParticleSystem smoke;
    // Start is called before the first frame update
    void Start()
    {
        //smoke=GetComponent<ParticalSystem>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnCollisionEnter(Collision col){
        
        if(col.gameObject.tag=="player"){
            Debug.Log("Collided");
        Destroy(gameObject);
       // Destroy(col.gameObject);
        Time.timeScale=0;
     //   smoke.Play();
        
        }
    }
}
