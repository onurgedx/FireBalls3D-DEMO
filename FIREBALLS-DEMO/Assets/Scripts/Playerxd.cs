using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playerxd : MonoBehaviour
{

    public GameObject explode;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    private void OnCollisionEnter(Collision collision)
    {
        
        
    }
    public void explodeTank()
    {
        explode.SetActive(true);
        //Gamexd.isTankAlive = false;
        
        // reset the scene
        // kaybettigin icin beklet biraz zaman geçince resetlensin oyun

    }

}
