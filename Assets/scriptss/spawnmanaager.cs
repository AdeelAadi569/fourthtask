using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnmanaager : MonoBehaviour
{
    public GameObject prefabs;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Spawn",2,2);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Spawn(){
        Instantiate(prefabs,new Vector3(Random.Range(20,-20),3.2f,20),Quaternion.identity);
        Instantiate(prefabs,new Vector3(Random.Range(20,-20),3.2f,20),Quaternion.identity);
        Instantiate(prefabs,new Vector3(Random.Range(20,-20),3.2f,20),Quaternion.identity);
    }
}
