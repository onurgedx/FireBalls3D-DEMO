using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Playerxd : MonoBehaviour
{

    public float MoveSpeed = 1;
    public float distanceToCollectable;
    public GameObject explode;
    private GameObject allCollectables;

    private bool isWin=false;

    private Animator cameraShakeAnimator;
    private GameObject bg4damage;


    // Start is called before the first frame update
    void Start()
    {
        allCollectables = GameObject.FindGameObjectWithTag("AllCollectables");
        Gamexd.isTankAlive = true;
        cameraShakeAnimator = Camera.main.gameObject.GetComponent<Animator>();
        bg4damage = GameObject.FindGameObjectWithTag("bg4damage");
    }

    // Update is called once per frame
    void Update()
    {
        goToCollectables();


    }


    
    public void explodeTank()
    {

        TankExplodeEffect();


        setTankUnalive();


        RestartSeceneIn2Min();


        bg4damageActive();
        shakeCamera();
        // reset the scene
        // kaybettigin icin beklet biraz zaman geçince resetlensin oyun

    }

    private void RestartSeceneIn2Min()
    {
        StartCoroutine(Gamexd.goSceneName(2, Gamexd.OnlineSceneName));
    }
    private void TankExplodeEffect()
    {
        explode.SetActive(true);
    }
    private void setTankUnalive()
    {
        Gamexd.isTankAlive = false;

    }
    private void shakeCamera()
    {
        cameraShakeAnimator.SetTrigger("shake");
        

    }

    private void bg4damageActive()
    {bg4damage.GetComponent<Image>().enabled = true;

    }
    private void goToCollectables(){
    
        if (allCollectables.transform.childCount != 0) { 
         Vector3  saveYPosition=  new Vector3(1, 0, 1);

        Vector3 GonnaGoPosition = Vector3.Scale(allCollectables.transform.GetChild(0).position, saveYPosition) - Vector3.forward*distanceToCollectable;

        transform.position = Vector3.Lerp(transform.position ,GonnaGoPosition , Time.deltaTime*MoveSpeed);
        }
        else{
            YouWon();
            
            }

    }

    private void YouWon()
    {
        Debug.Log("Finish!!!");


        if (!isWin)
        {
            isWin = true;
            Gamexd.level++;
            StartCoroutine(Gamexd.goSceneName(2f, Gamexd.OnlineSceneName));

        }

    }
   

}
