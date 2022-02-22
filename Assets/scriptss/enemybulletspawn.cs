using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemybulletspawn : MonoBehaviour
{
    public GameObject prefabenemybullet;
    public Transform pos;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnEnamyBullet",1,4);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void SpawnEnamyBullet(){
        Instantiate(prefabenemybullet,pos.transform.position,transform.rotation);
    }
}
