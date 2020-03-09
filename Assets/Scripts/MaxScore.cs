using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;

public class MaxScore : MonoBehaviour
{
  
    
    Text maxScore;
    int highScore;
    string maxScoreIntial;
    string stringHighScore;
    

    void Start()
    {
        
      
        
        maxScore = GetComponent<Text>();         
        
    }

    // Update is called once per frame
    void Update()
    {
        PrintHighScore();
        ReadFile();
    }

    void ReadFile()
    {
        maxScoreIntial = System.IO.File.ReadAllText(@"Assets/DateSaves/Score.txt");
        highScore = int.Parse(maxScoreIntial);

    }
    


    public void AddToMax( int currentScore)
    {
        if (highScore < currentScore) {
            highScore = currentScore;

            stringHighScore = highScore.ToString();
            System.IO.File.WriteAllText(@"Assets /DateSaves/Score.txt", stringHighScore);
        }
    }

    void PrintHighScore()
    {
        maxScore.text = "HighScore is: " + highScore;
    }
        
}
