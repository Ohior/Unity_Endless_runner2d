/**
* @Author:  Aigboje Ohiorenua
* @Date:   2021-09-24 13:10:16
* @Last Modified by:   
* @Last Modified time: 2021-11-19 14:00:05
*
*           ____                      ,
*          /---.'.__             ____//
*               '--.\           /.---'
*          _______  \\         //
*        /.------.\  \|      .'/  ______
*       //  ___  \ \ ||/|\  //  _/_----.\__
*      |/  /.-.\  \ \:|< >|// _/.'..\   '--'
*         //   \'. | \'.|.'/ /_/ /  \\
*        //     \ \_\/" ' ~\-'.-'    \\
*       //       '-._| :H: |'-.__     \\
*      //           (/'==='\)'-._\     ||
*      ||                        \\    \|
*      ||                         \\    '
*      |/                          \\
*                                   ||
*                                   ||
*                                   \\
*/


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObject : MonoBehaviour
{
    public GameObject floor;
    public float floor_second;
    private float floor_time;
    public GameObject rock;
    private float rock_time;
    public float rock_second;
    public GameObject jumpsign;
    public float jumpsign_second;
    private float jumpsign_time;

    Runner runner;

    void Start()
    {
        runner = GameObject.Find("Runner").GetComponent<Runner>();
    }

    // Update is called once per frame
    void Update()
    {
        if(runner.runner_alive)
        {
            spawnFloor();
            spawnRock();
            spawnJumpSign();
        }
    }

    private void spawnFloor()
    {
        var ypointlist = new List<float>{-4.7f, -1f, 2.7f};
        if (Time.time > floor_time) 
        {
            Instantiate(floor, new Vector3((20f+transform.position.x), randomFloat(ypointlist), 0), transform.rotation);
            floor_time = Time.time+floor_second;
        }
    }

    private void spawnRock()
    {
        var ypointlist = new List<float>{-4.0f, -0.7f, 2.0f};
        if (Time.time > rock_time) 
        {
            Instantiate(rock, new Vector3((20f+transform.position.x), randomFloat(ypointlist), 0), transform.rotation);
            rock_time = Time.time+rock_second;
        }
    }

    private void spawnJumpSign()
    {
        var ypointlist = new List<float>{-4f, -3f, -2f, -1f, 0f, 2f, 3f, 4f};
        if (Time.time > jumpsign_time) 
        {
            Instantiate(jumpsign, new Vector3((20f+transform.position.x), randomFloat(ypointlist), 0), transform.rotation);
            jumpsign_time = Time.time+jumpsign_second;
        }
    }

    float randomFloat(List<float> numlist)
    {
        int num = Random.Range(0, numlist.Count);
        return numlist[num];

    }
}
