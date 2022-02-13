using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShellGoo : MonoBehaviour
{
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += transform.forward*Time.deltaTime*speed;
        
    }

    private void selfVanishGo()
    {

        Destroy(this.gameObject);
    }
    private void afterCollideCollectable(Collision coll)
    {
        
        coll.gameObject.GetComponent<collectableSquare>().beingVanished();
        GetComponent<Collider>().enabled = false;
        transform.GetChild(0).gameObject.SetActive(false);
        Invoke("selfVanishGo", 0.4f);
    }

    private void OnCollisionEnter(Collision coll)
    {
        if(coll.gameObject.CompareTag("collableCircle"))
        {
            Debug.Log("carpti");
            transform.Rotate(0, 180, 0);
            
            gameObject.layer = 0; // carpilir hale getirir

        }
        else if(coll.gameObject.CompareTag("collectableCircle"))
        {

            Debug.Log("collected");
            

            afterCollideCollectable(coll);
        }
        else if(coll.gameObject.CompareTag("Player"))
        {
            Debug.Log("Player has been hit");
            coll.gameObject.GetComponent<Playerxd>().explodeTank();
            Destroy(this.gameObject);

        }


    }
}
