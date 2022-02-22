using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControll : MonoBehaviour
{
    public float speed;
    private Rigidbody playerrb;
    public bool uptouch=true;
     
    // Start is called before the first frame update
    void Start()
    {
        playerrb=gameObject.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space) && uptouch==true)
        {
            Debug.Log("Pressed speed");
            
            playerrb.AddForce(Vector3.up*speed,ForceMode.Impulse);
        }
        if(transform.position.y>=10){
            uptouch=false;
            Debug.Log("Upper Touch");
            transform.position=new Vector3(transform.position.x,10,transform.position.z);
        }
        uptouch=true;
    }
}
