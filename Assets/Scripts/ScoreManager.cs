using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public Text score_text;
    private float score;
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
            score += 1 * Time.deltaTime;
            score_text.text  = "Score: "+((int)score).ToString();
        }else
        {
            if(score > PlayerPrefs.GetInt("Score"))
            {
                PlayerPrefs.SetInt("Score", (int) score);
            }
        }
    }

    // public static bool WriteToFile(string a_file_name, string a_file_contents)
    // {
    //     var full_path = Path.Combine(Application.persistentDataPath, a_file_name);
    //     try
    //     {
    //         File.WriteAllText(full_path, a_file_contents);
    //         return true;
    //     }
    //     catch (Exception e)
    //     {
    //         Debug.Log($"Failed to Write to {full_path} with exception {e}");
    //     }
    //     return false;
    // }

    // public static bool LoadFromFile(string file_name, out string result)
    // {
    //     var full_path = Path.Combine(Application.persistentDataPath, a_file_name);
    //     try
    //     {
    //         result = File.ReadAllText(full_path);
    //         return true;
    //     }
    //     catch (Exception e)
    //     {
    //         Debug.Log($"Failed to Write to {full_path} with exception {e}");
    //         result = "";
    //     }
    //     return false;
    // }
}
