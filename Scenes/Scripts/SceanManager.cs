using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class SceanManager : MonoBehaviour
{
    joystickServer js;
    public GameObject ESC;

    public void ChangeFirstScean()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void easy_1()
    {
        SceneManager.LoadScene("난이도하_처음");
    }
    public void easy2()
    {
        SceneManager.LoadScene("난이도하_연결");
    }
    public void easy3()
    {
        SceneManager.LoadScene("난이도하_해제");
    }
    public void hard1()
    {
        SceneManager.LoadScene("난이도상_처음");
    }
    public void hard2()
    {
        SceneManager.LoadScene("난이도상_연결");
    }
    public void hard3()
    {
        SceneManager.LoadScene("난이도상_해제");
    }
    public void hard4()
    {
        SceneManager.LoadScene("난이도상_처음2");
    }
    public void hard5()
    {
        SceneManager.LoadScene("난이도상_연결2");
    }
    public void hard6()
    {
        SceneManager.LoadScene("난이도상_해제2");
    }

    public void ChangeEighthScean()
    {
        SceneManager.LoadScene("outtro");
    }
    public void ChangeTutorial()
    {
        SceneManager.LoadScene("tutorial");
    }
    public void Change_p3downVer()
    {
        SceneManager.LoadScene("04.Simulation_Animation downVer");
    }
    public void ChangeMockup()
    {
        SceneManager.LoadScene("mockup");
    }


    public void Input_Continue()
    {
        ESC.SetActive(false);
    }
    public void Simul_Exit()
    {
        Application.Quit();
    }
    public void Update()
    {
        js = GameObject.FindGameObjectWithTag("server").GetComponent<joystickServer>() as joystickServer;
        if (js.stick=="j")      //ESC버튼으로 메뉴창 끄고켜기
        {   if (ESC.activeSelf)
                ESC.SetActive(false);
        else
            ESC.SetActive(true);
            js.stick = "x";
        }

        
    }

}

