using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Launcherxd : MonoBehaviour
{



    public GameObject Shellxd;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    private void Launchxd()
    {
        Instantiate(Shellxd, transform.position, transform.rotation,null);
    }


    public void clickLaunch()
    {
        if(Input.GetMouseButtonDown(0))
        {
            Launchxd();
        }
    }
}