using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reflectaclexd : MonoBehaviour
{

    public float distanceToOne=7;
    public float speedSpin=10;
    public int index_collectable;
    private GameObject collectableOne;
    // Start is called before the first frame update
    void Start()
    {
        collectableOne = GameObject.FindGameObjectWithTag("AllCollectables").transform.GetChild(index_collectable).gameObject;

       transform.position = collectableOne.transform.position + Vector3.back * distanceToOne;
        
    }

    // Update is called once per frame
    void Update()
    {   RotateAroundCollectables();
        ControlIsOneAlive();
        


    }

    private void RotateAroundCollectables()
    {
        if (collectableOne != null)
            transform.RotateAround(collectableOne.transform.position, Vector3.up, Time.deltaTime * speedSpin);
    }

    private void ControlIsOneAlive()
    {
        if(collectableOne == null )
        {
            Destroy(this.gameObject);
        }
    }


}
