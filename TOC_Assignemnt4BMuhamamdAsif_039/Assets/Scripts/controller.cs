using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class controller : MonoBehaviour
{
    public void playPenguine()
    {

        SceneManager.LoadScene("Penguins");
    }

    public void playHummingBird()
    {

        SceneManager.LoadScene("FlowerIseland");
    }
}
