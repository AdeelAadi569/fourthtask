using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class spawnsecscn : MonoBehaviour
{
    public GameObject[] prefabs;
    public Transform pos;
    public GameObject smalcube;
    public  secscnbultmove smalcubeins;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Spawn",2,3);
        //smalcubeins=GameObject.Find("player").GetComponent<secscnmovenem>();

        
    }

    // Update is called once per frame
    void Update()
    {
        if(smalcubeins.isbultcol==true){
           Instantiate(smalcube,new Vector3(5,10,-21),Quaternion.identity);
           Debug.Log("spawn smalcube");
           smalcubeins.isbultcol=false;

        }
    }
    public void Spawn(){
        var rendmspnprefab=Random.Range(0,prefabs.Length);
        Instantiate(prefabs[rendmspnprefab],pos.transform.position,prefabs[rendmspnprefab].transform.rotation);
    }
   
}
