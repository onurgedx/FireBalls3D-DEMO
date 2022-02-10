using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Gamexd : MonoBehaviour
{



    

    public Slider sliderSoundxd;

    public static bool isTankAlive=true;

    


    // Start is called before the first frame update
    void Start()
    {


        if(OnlineSceneName == "Menu")
        { 
            volumeChange(AudioListener.volume);
            //volumeGameStaticProperty = AudioListener.volume;
        }
        else if(OnlineSceneName == "DenemeTahtasi")
        {
            GameObject.Find("Level").GetComponent<TextMesh>().text = "Level " + level.ToString();
        }


    }

    public static int level
    {
        get
        {
            return PlayerPrefs.GetInt("level");
        }
        set
        {
            PlayerPrefs.SetInt("level", value);
        }

    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(AudioListener.volume);
        
    }

    

    


    public void volumeChange(float value)
    {
        // Slider içindeki bilgiyi direkt iþlemek için:

        //On Value Changed oldugu zaman yani value degeri degiþtigi zamana çalýþtýrýlacak fonksiyonu yazarken value degerini almak için degiþken tipi ile birlikte dynamik parametersi seçiyoruz
        //kendisi direkt value degerini veriyor zaten


        AudioListener.volume = value;
        sliderSoundxd.value = value;
        
    }


    public void OnValidate( )
    {
        Debug.Log("ONVALIDATE");
        // inspectorde bir degisiklik oldugu zaman calisir bu !!!

        
    }



    // deger degistiginde istenilen þeyi yapmak için bir yöntem buldum
    // property kullanýmý
    // set içine yazabiliriz yapýlacak þeyi 




    public void resetScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

    }


    public static IEnumerator goSceneName(float timeCounter =0f,string SName = "Menu")
    {
        
        yield return new WaitForSeconds(timeCounter);
        SceneManager.LoadScene(SName);
    }
    

    public void GoNextScene()
    {

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);


    }    
    public void goMenu()
    {
       StartCoroutine( goSceneName());
    }

    public static string OnlineSceneName
    {
        get
        {
            return SceneManager.GetActiveScene().name;
        }
    }


}
