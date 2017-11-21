using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GlobalVariables : MonoBehaviour {

    public static int score;
    private string textScore;

    public void Awake()
    {
        textScore = GameObject.Find("TextScore").GetComponent<Text>().text;
        score = 0;
    }

    private void OnGUI()
    {
        GameObject.Find("TextScore").GetComponent<Text>().text = score.ToString();
    }
}
