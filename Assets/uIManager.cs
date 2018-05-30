using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class uIManager : MonoBehaviour
{

    public Button[] buttons;
    public Text scoreText; //store our score in text value
    bool gameOver; //when game is over score not updated
    int score;

    // Use this for initialization
    void Start()
    {
        gameOver = false;//when gamover is true game is over when it will false score to be updated
        score = 0;
        InvokeRepeating("Updatescore", 1.0f, 0.5f);
    }


    // Update is called once per frame
    void Update()
    {
        scoreText.text = "Score:" + score; //score is updating to 1,2,3 and so on


    }

    void Updatescore() //increment in our score
    {
        if (gameOver == false)
        {
            score += 1;
        }
    }
    public void gameOverActivated() //when game is over score will not be updated
    {
        gameOver = true;
        foreach (Button button in buttons)
        {
            button.gameObject.SetActive(true);
        }

    }
    
    //load any scene of our game
 public void play()
    {
        SceneManager.LoadScene("Unity 2D Car racing Game");


    }


    public void pause() //this func. take care of pause button.function is called when game is paused
    {
        if (Time.timeScale == 1) //game is running
        {
            Time.timeScale = 0; //get it pause
        }
        else if (Time.timeScale == 0) //game is pause
        {
            Time.timeScale = 1; //get it running
        }
    }

    
    public void Menu()
    {

       SceneManager.LoadScene ("menuScene");
    }
    public void Exit()
    {
        Application.Quit();
    }

}
   
   

