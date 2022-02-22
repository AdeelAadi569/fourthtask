using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnmanager : MonoBehaviour

{
    public GameObject[] prefabs;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnEnemy",2,3);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void SpawnEnemy(){
          var randomspawn=Random.Range(0,prefabs.Length);
          Vector3 pos=new Vector3(18,1f,0);
          Instantiate(prefabs[randomspawn],pos,prefabs[randomspawn].transform.rotation);
    }
}
