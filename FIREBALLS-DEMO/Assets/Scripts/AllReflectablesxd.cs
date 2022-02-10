using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;




public class AllReflectablesxd : MonoBehaviour
{
    
    public GameObject Reflectaclexdin;


    // class yapisi olusturdugum bu  yerde i�erideki degerlerin inspectorde g�z�kmesini istedigim i�in ba��na [Serializable] ifadesini koyuyorum 
    // [Serializable] ifadesinin �al��abilmesi i�in using System; �eklinde import etmem gerekiyor 
       // Seriallizable ettigim bu class�  a��ag�da private ile g�sterirken  �nine [SerializeField] koymam gerekiyor.
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
