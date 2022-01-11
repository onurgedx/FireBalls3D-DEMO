using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//[ExecuteInEditMode]
public class CollectablesMain : MonoBehaviour
{

    public int collectableCount;
    public GameObject collectablexd;
    public float SpinSpeed = 20f;

    public Material gold;


    private float collectableSizeY;// yuksekligini veriyor 

    private Vector3 startPos;
    private int maxCountOfcollectable;

    // Start is called before the first frame update
    void Start()
    {
       collectableSizeY = collectablexd.GetComponent<BoxCollider>().size.y;

        startPos = transform.position;
        maxCountOfcollectable = transform.childCount;
    }

    // Update is called once per frame
    void Update()
    {
        goDown();
        transform.Rotate(0, Time.deltaTime * SpinSpeed, 0);
        
    }
    
    //inspector de bir sey degisince burasi calisacak
    private void OnValidate()
    {
        createCollectable();


        }

    private void createCollectable(){
        collectableSizeY = collectablexd.GetComponent<BoxCollider>().size.y; 
        Vector3 posNewCollectable = transform.GetChild(transform.childCount- 1).position + collectableSizeY * Vector3.up ;

        
        GameObject go =  Instantiate(collectablexd, posNewCollectable, Quaternion.Euler(0,transform.childCount*90 +transform.rotation.eulerAngles.y, 0), transform);
        
        go.GetComponent<Renderer>().material = transform.childCount%2==0 ? gold: go.GetComponent<Renderer>().sharedMaterial;

    }


    private void goDown()
    {
        transform.position = Vector3.Lerp(transform.position, startPos - collectableSizeY*(maxCountOfcollectable-transform.childCount)*Vector3.up, Time.deltaTime*10);
    }





}
