using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;




public class AllReflectablesxd : MonoBehaviour
{
    
    public GameObject Reflectaclexdin;
    public int MaxRequestedSpeed;
    public int MinRequestedSpeed;

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
    
    [SerializeField] private List<ReflectaclesClass> ReflectaclesInfo;

    // Start is called before the first frame update
    void Awake()
    {
        
    }

    private ReflectaclesClass createRefClass(int i)
    {
        
        ReflectaclesClass refClass = new ReflectaclesClass();
                refClass.IndexOfCollectable = i;
                int carpan = UnityEngine.Random.Range(-1f, 1f) > 0 ? 1 : -1;
                refClass.SpeedSpin =UnityEngine.Random.Range(MinRequestedSpeed, MaxRequestedSpeed) *carpan;// UnityEngine. diye basladim cunku System.Random da varmis. Karistirmasin diye
                refClass.DistanceToOne = UnityEngine.Random.Range(5, 7);
            return refClass;
    }

    public void ReflectaclesCreate()
    {

        for(int i=0;i<=Gamexd.level;i++)
        {
            if (i!=0)
            {
               int howManyRefAtOne = UnityEngine.Random.Range(1, 3);
                for(int k=1;k<=howManyRefAtOne;k++)
                {
                    ReflectaclesInfo.Add(createRefClass(i));

                }
                    
                

            }
            


            

        }

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
