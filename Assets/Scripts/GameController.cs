/**
 * @Author: Aigboje Ohiorenua
 * @Date:   2021-09-23 13:47:06
 * @Last Modified by:   Aigboje Ohiorenua
 * @Last Modified time: 2021-10-27 15:08:59
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class GameController : MonoBehaviour
{
    public GameObject game_over_pannel;
    GameObject camera;
    SpawnObject spawn_object;
    Runner runner;
    public float x_speed;
    public float y_speed;
    float seconds;
    int increase_speed_every = 7;
    // Start is called before the first frame update
    void Start()
    {
        runner = GameObject.Find("Runner").GetComponent<Runner>();
        camera = GameObject.Find("Main Camera");
        spawn_object = GameObject.Find("SpawnObjects").GetComponent<SpawnObject>();
    }

    // Update is called once per frame
    void Update()
    {
        moveGame();
        increaseSpeedEvery(increase_speed_every);
        if(!runner.runner_alive)
        {
            x_speed = 0;
            game_over_pannel.SetActive(true);
        }
        if(runner.transform.position.y >= 0){
            camera.transform.position = new Vector3(camera.transform.position.x, runner.transform.position.y, camera.transform.position.z);
        }
    }

    private void moveGame()
    {
        transform.position += new Vector3(x_speed*Time.deltaTime, y_speed*Time.deltaTime, 0);
    }

    public void QuitGame()
    {
        SceneManager.LoadScene(0);
    }


    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    void increaseSpeedEvery(float sec)
    {
        if(Time.time > seconds )
        {
            x_speed += 0.5f;
            seconds = Time.time + sec;
            if (spawn_object.rock_second > 0.1f)
            {
                spawn_object.rock_second = spawn_object.rock_second - 0.3f;
            }
        }
    }
}
