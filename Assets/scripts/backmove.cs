using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class backmove : MonoBehaviour
{
    public float speed=20;
    Vector3 startpos;
    float repeatwidth;
    // Start is called before the first frame update
    void Start()
    {
        startpos=transform.position;
        repeatwidth=GetComponent<BoxCollider>().size.x/2;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.left*speed*Time.deltaTime);
        if(transform.position.x<startpos.x-repeatwidth){
            transform.position=startpos;
        }
        
    }
}
