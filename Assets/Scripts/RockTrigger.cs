using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RockTrigger : MonoBehaviour
{
    [SerializeField] private GameObject rock_particle;
    [SerializeField] private GameObject rock;
    // GameObject rock;
    Runner runner;

    void Start()
    {
        runner = GameObject.Find("Runner").GetComponent<Runner>();
        // rock = GameObject.Find("Rock");
    }
    void OnTriggerStay2D(Collider2D other)
    {
        if(runner.behaviour == "Kick")
        {
            Instantiate(rock_particle, transform.position, Quaternion.identity);
            // GameObject.Find("Runner").GetComponent<Animator>().SetBool("Jump", true);
            // Destroy(this.rock);
            Destroy(transform.parent.gameObject);
            // Destroy(rock);
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        runner.behaviour = "null";
    }
}
