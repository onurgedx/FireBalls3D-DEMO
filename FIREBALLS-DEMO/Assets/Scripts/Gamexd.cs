using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

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
            // textMeshProUGUI ?eklinde tan?mlar?z text mesh proyu . bu textMeshProUGUI yi kullanabilmek i?in using TMPro; ?eklinde import i?lemi gereklidir.
            GameObject.Find("Level").GetComponent<TextMeshProUGUI>().text = "Level " + level.ToString();
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
        // Slider i?indeki bilgiyi direkt i?lemek i?in:

        //On Value Changed oldugu zaman yani value degeri degi?tigi zamana ?al??t?r?lacak fonksiyonu yazarken value degerini almak i?in degi?ken tipi ile birlikte dynamik parametersi se?iyoruz
        //kendisi direkt value degerini veriyor zaten


        AudioListener.volume = value;
        sliderSoundxd.value = value;
        
    }


    public void OnValidate( )
    {
        Debug.Log("ONVALIDATE");
        // inspectorde bir degisiklik oldugu zaman calisir bu !!!

        
    }



    // deger degistiginde istenilen ?eyi yapmak i?in bir y?ntem buldum
    // property kullan?m?
    // set i?ine yazabiliriz yap?lacak ?eyi 




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
