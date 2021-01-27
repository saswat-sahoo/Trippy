using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class scene : MonoBehaviour
{
   public void Scene()
    {
        SceneManager.LoadScene("game Over");

    }
    public void Scene1()
    {
        SceneManager.LoadScene("level Complete");

    }
   public void Scene2()
    {
        SceneManager.LoadScene("SampleScene");

    }
}
