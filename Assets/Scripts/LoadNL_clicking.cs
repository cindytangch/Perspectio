using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadNL_clicking : MonoBehaviour
{
    public void Clicked(string LevelName)
    {
      SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

    }
}
