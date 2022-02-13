using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
public class AllCollectablesxd : MonoBehaviour
{

    public GameObject Collectablesxd;

   

    


    // Start is called before the first frame update
    void Awake()
    {
        //foreach(CollectablesMainClass ctmc in CollectablesList)
        for(int i=0;i<Gamexd.level; i++)
        {
           GameObject ctmcGo =  Instantiate(Collectablesxd, transform.GetChild(transform.childCount - 1).position + Vector3.forward * 30, Quaternion.identity, transform);
           

        
        
        }
       

        
    }
    private void Start()
    {
        GameObject allRef = GameObject.FindGameObjectWithTag("AllReflectacles");
        
        allRef.GetComponent<AllReflectablesxd>().ReflectaclesCreate();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
