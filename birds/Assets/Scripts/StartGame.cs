using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGame : MonoBehaviour
{
    [SerializeField] string _nextLevelName;
    public void loadGame()
    {
        SceneManager.LoadScene(_nextLevelName);
    } 
}
