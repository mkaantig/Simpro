using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class GameOverUI : MonoBehaviour {

    public GameObject ball0;
    public GameObject ball1;
    public GameObject ball2;
    public GameObject ball3;
    public GameObject ball4;
    public GameObject ball5;
    public GameObject ball6;
    public GameObject ball7;
    public GameObject ball8;
    public GameObject ball9;
    public GameObject player;
   

    void Start()
    {
        ball0.SetActive(false);
        ball1.SetActive(false);
        ball2.SetActive(false);
        ball3.SetActive(false);
        ball4.SetActive(false);
        ball5.SetActive(false);
        ball6.SetActive(false);
        ball7.SetActive(false);
        ball8.SetActive(false);
        ball9.SetActive(false);
        player.SetActive(false);
    }

    public void Menu(string sceneName)
    {

        SceneManager.LoadScene(sceneName);
    }

    public void Retry()
    {

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

    }
}
