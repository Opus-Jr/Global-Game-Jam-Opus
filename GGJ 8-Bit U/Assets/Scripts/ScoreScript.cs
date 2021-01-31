using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoreScript : MonoBehaviour
{

    public Text MyscoreText;
    private int ScoreNum;
    private int MaxScore = 25;
    public bool WinCondition = false;

    // Start is called before the first frame update
    void Start()
    {

        ScoreNum = 0;
        MyscoreText.text = "Gold : " + ScoreNum;

    }
   

    private void OnTriggerEnter2D(Collider2D Gold)
    {
        
        if (Gold.tag == "MyGold")
        {
            ScoreNum += 1;
            Destroy(Gold.gameObject);
            MyscoreText.text = "Gold : " + ScoreNum;
        }

        if (Gold.tag == "GoldCrate")
        {
            ScoreNum += 5;
            Destroy(Gold.gameObject);
            MyscoreText.text = "Gold : " + ScoreNum;
        }

        if (ScoreNum >= MaxScore)
        {
            WinCondition = true;
        }

        if (WinCondition == true)
        {
            SceneManager.LoadScene(3);
        }

    }
}
