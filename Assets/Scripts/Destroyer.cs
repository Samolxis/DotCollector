using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Destroyer : MonoBehaviour
{
    Score collected;
    MaxScore mxScore;
    void Start()
    {
        collected = GameObject.FindGameObjectWithTag("Score").GetComponent<Score>();
        mxScore = GameObject.FindGameObjectWithTag("MaxScore").GetComponent<MaxScore>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {

        
        if(collision.gameObject.CompareTag("Collectable"))
        {
            collected.AddToScore();
            ScaleUp();
            Destroy(collision.gameObject);
         }

        if (collision.gameObject.CompareTag("Enemy"))
        {
            mxScore.AddToMax(collected.actualScore);
            SceneManager.LoadScene("MainLevel");
        }
    }

    void ScaleUp()
    {
        transform.localScale = new Vector3(transform.localScale.x+0.005f,transform.localScale.y +0.005f, 0);
    }
 
}
