using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ReloadScene : MonoBehaviour
{
   // public GameObject destroySpawner;
   // public GameObject destroyGround;


    public void Restart()
    {
       // Destroy(destroyGround);
       // Destroy(destroySpawner);
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
     
    }
}
