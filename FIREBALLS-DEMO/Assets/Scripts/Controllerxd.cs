using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controllerxd : MonoBehaviour
{

    public Launcherxd launcher;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Gamexd.isTankAlive)
        { 

            launcher.clickLaunch();

        }
    
    }


}
