using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collectableSquare : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private IEnumerator Vanishing()
    {
        transform.parent.parent.gameObject.GetComponent<AudioSource>().Play();

        transform.parent = null;
        setUncollable();// carpma ozelligini kapatiyor
        while (GetComponent<Renderer>().material.color.a>0.1f)
        {
            
            transform.localScale *= 1.026f;
            // ise yaramasi icin material i opaque den transparent e getirmelisin 
            GetComponent<Renderer>().material.color -= new Color(0, 0, 0, Time.deltaTime*6); 
            yield return null;
        }

        
        Destroy(gameObject);
    }
    private void setUncollable()// carpma ozelligini kapatiyor
    {
        GetComponent<Collider>().enabled=false ;

    }

    public void beingVanished()
    {
        StartCoroutine(Vanishing());
    }
}
