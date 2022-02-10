using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playerxd : MonoBehaviour
{

    public float distanceToCollectable;
    public GameObject explode;
    private GameObject allCollectables;

    private bool isWin=false;
    // Start is called before the first frame update
    void Start()
    {
        allCollectables = GameObject.FindGameObjectWithTag("AllCollectables");
        Gamexd.isTankAlive = true;
    }

    // Update is called once per frame
    void Update()
    {
        goToCollectables();


    }


    private void OnCollisionEnter(Collision collision)
    {
        
        
    }
    public void explodeTank()
    {
        explode.SetActive(true);
        Gamexd.isTankAlive = false;

        StartCoroutine(Gamexd.goSceneName(2, Gamexd.OnlineSceneName));

        // reset the scene
        // kaybettigin icin beklet biraz zaman geçince resetlensin oyun

    }

    private void goToCollectables(){
    
        if (allCollectables.transform.childCount != 0) { 
         Vector3  saveYPosition=  new Vector3(1, 0, 1);

        Vector3 GonnaGoPosition = Vector3.Scale(allCollectables.transform.GetChild(0).position, saveYPosition) - Vector3.forward*distanceToCollectable;

        transform.position = Vector3.Lerp(transform.position ,GonnaGoPosition , Time.deltaTime);
        }
        else{
            Debug.Log("Finish!!!");
            
            
            if(!isWin){
                isWin = true;
                Gamexd.level++;
             StartCoroutine(Gamexd.goSceneName(2f,Gamexd.OnlineSceneName));

            }
            
             

        }

    }

   

}
