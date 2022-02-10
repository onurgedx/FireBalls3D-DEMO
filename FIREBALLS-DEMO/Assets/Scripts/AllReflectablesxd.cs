using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;




public class AllReflectablesxd : MonoBehaviour
{
    
    public GameObject Reflectaclexdin;


    // class yapisi olusturdugum bu  yerde içerideki degerlerin inspectorde gözükmesini istedigim için baþýna [Serializable] ifadesini koyuyorum 
    // [Serializable] ifadesinin çalýþabilmesi için using System; þeklinde import etmem gerekiyor 
       // Seriallizable ettigim bu classý  aþþagýda private ile gösterirken  önine [SerializeField] koymam gerekiyor.
    [Serializable]
    private class ReflectaclesClass
    {
        public int IndexOfCollectable;
        public float DistanceToOne;
        public float SpeedSpin;

        
        
        //public ];

    }
    
    [SerializeField] private ReflectaclesClass[] ReflectaclesInfo;

    // Start is called before the first frame update
    void Awake()
    {
        foreach(ReflectaclesClass rt in ReflectaclesInfo)
        {
            GameObject rtGo =  Instantiate(Reflectaclexdin, this.gameObject.transform);
             
            rtGo.GetComponent<Reflectaclexd>().distanceToOne = rt.DistanceToOne;
            rtGo.GetComponent<Reflectaclexd>().speedSpin = rt.SpeedSpin;
            rtGo.GetComponent<Reflectaclexd>().index_collectable = rt.IndexOfCollectable;
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
