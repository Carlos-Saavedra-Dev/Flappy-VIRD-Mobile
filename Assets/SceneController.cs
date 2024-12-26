using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    public void StartGame()
    {
        Debug.Log("StartGame llamado");

        SceneManager.LoadScene(1);
    }
}
