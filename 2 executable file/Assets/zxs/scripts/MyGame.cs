using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MyGame : MonoBehaviour
{
    public int score = 0;
    public Text score_text;

    public GameObject canvas;
    public Text canvas_text;
    private int if_canvas_show = 0;
    private int if_canvas_show_once = 0;

    // Start is called before the first frame update
    void Start()
    {
        Application.targetFrameRate = 50;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.T))
        {
            SceneManager.LoadScene("SampleScene");
        }

        if (score == 10)
        {
            if (if_canvas_show_once == 0)
            {
                if_canvas_show = 1;
                canvas.SetActive(true);

                if_canvas_show_once = 1;
            }
        }

        if (score == 10 && Input.GetKeyDown(KeyCode.G))
        {
            if (if_canvas_show == 0)
            {
                if_canvas_show = 1;
                canvas.SetActive(true);
            }
            else
            {
                if_canvas_show = 0;
                canvas.SetActive(false);
            }

        }
    }

    public void AddScore()
    {
        score = score + 1;
        score_text.text = "" + "¡Á " +  score;
    }
}
