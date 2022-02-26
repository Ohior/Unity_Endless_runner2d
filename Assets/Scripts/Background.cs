using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Background : MonoBehaviour
{
    public GameObject background;
    GameObject game_controller;
    private float window_width;
    float x_speed;
    Runner runner;

    private void Start()
    {
        runner = GameObject.Find("Runner").GetComponent<Runner>();
        game_controller = GameObject.Find("GameController");
        window_width = 24f;
        x_speed = 1.5f;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(x_speed * Time.deltaTime, 0f, 0f);
        if(!runner.runner_alive)
        {
            x_speed = -0.525f;
        }
        if (transform.position.x < (game_controller.transform.position.x - window_width))
            {
                transform.position = new Vector3((game_controller.transform.position.x + window_width), 0, 0);
            }
    }
}
