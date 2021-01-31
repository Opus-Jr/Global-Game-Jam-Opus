using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerLose : MonoBehaviour
{
    public bool LoseCondition = false;

    private void OnTriggerEnter2D(Collider2D Ai)
    {
        if (Ai.tag == "Ai")
            SceneManager.LoadScene(2);
    }
}
