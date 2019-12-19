using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    // Start is called before the first frame update
    public void buttonPlay ()
    {
         Debug.Log("play");
        SceneManager.LoadScene("StageOne");
    }

    public void buttonLvl1(){
         Debug.Log("level1");
        SceneManager.LoadScene("StageOne");
    }

    public void buttonLvl2(){
         Debug.Log("level2");
        SceneManager.LoadScene("StageTwo");
    }
    public void buttonLvl3(){
         Debug.Log("level3");
         SceneManager.LoadScene("StageThree");
    }
    public void buttonLvl4(){
         Debug.Log("level4");
         SceneManager.LoadScene("StageFour");
    }
    public void buttonLvl5(){
         Debug.Log("level5");
        SceneManager.LoadScene("StageFive");
    }

    public void buttonQuit(){
        Debug.Log("QUIT!!");
        Application.Quit();
    }


}
