using UnityEngine;
using System.Collections;

public class Enemy_Logic : EnemyMovement
{
    public GameObject rifle;
    public bool clicked = false;
    public int seconds = 0;
    public bool colliding = false;

    public GUIText scoreText;
    public int score = 0;

    float RectWidth = Screen.width;
    float AlertRectWidth = Screen.width;
    //collision
    void OnTriggerEnter(Collider other)
    {
        rifle.SetActive(true);
        colliding = true;
        audio.Play();

        score += 10;
        UpdateScore();
    }
    //collision out
    void OnTriggerExit()
    {
        rifle.SetActive(false);
        colliding = false;
        seconds = 0;
        audio.Stop();
    }
    //onclick fight starts

    //show enemy menu
    public void OnGUI()
    {
        GUI.Box(new Rect(0, 0, Screen.width, 20), "Health");
        GUI.Box(new Rect(0, 20, RectWidth, 20), "Fuel");
        GUI.Box(new Rect(0, 40, Screen.width, 20), "Amo");
        GUI.Box(new Rect(0, 80, 50, 50), "Gun 1");
        GUI.Box(new Rect(0, 140, 50, 50), "Gun 2");
        GUI.Box(new Rect(0, 200, 50, 50), "Gun 3");

        //if (clicked == true || colliding == true) {
        //	GUI.Box(new Rect(100,100,100,100), seconds.ToString());
        //}
        if (colliding == true)
        {
            GUI.color = Color.red;
            GUI.Box(new Rect(0, 60, AlertRectWidth, 20), "ALERT");
        }
    }
    void Update()
    {
        //Fuel --
        RectWidth = RectWidth - 0.01f;

        //Hitpoints -- logic
        if (colliding == true)
        {
            seconds--;
            AlertRectWidth = AlertRectWidth - 6f;
            //Auto start battle
            if (seconds == -250)
            {

            }
        }
        else if (colliding == false)
        {
            AlertRectWidth = Screen.width;
        }

        //hitpoints end logic

        //Enemy menu loogic
        if (Input.GetMouseButtonDown(1))
        {
            clicked = true;
            print("ENEMY MENU");
        }
    }

    void UpdateScore()
    {
        scoreText.text = "Score: " + score;
    }
}
