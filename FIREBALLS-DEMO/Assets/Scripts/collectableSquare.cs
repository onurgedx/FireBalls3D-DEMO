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
        OnBoomSound();

        EvlatliktanReddet(); 
        setUncollable();// carpma ozelligini kapatiyor
        while (GetComponent<Renderer>().material.color.a>0.1f)
        {

            scaleAugmentation(1.026f);
            // ise yaramasi icin material i opaque den transparent e getirmelisin 
            MakeMoreTransparent(6); 
            yield return null;
        }

        
        Destroy(gameObject);
    }
    private void OnBoomSound()
    {
        transform.parent.parent.gameObject.GetComponent<AudioSource>().Play();
    }
    private void EvlatliktanReddet()
    {
        transform.parent = null;
    }
    private void MakeMoreTransparent(float ScaleAmountEvereyFrame = 6f)
    {
        GetComponent<Renderer>().material.color -= new Color(0, 0, 0, Time.deltaTime * ScaleAmountEvereyFrame);
    }
    private void scaleAugmentation(float AmountAugmentation = 1.026f)
    {
        transform.localScale *= AmountAugmentation;
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
