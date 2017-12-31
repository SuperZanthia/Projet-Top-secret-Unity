using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Restart : MonoBehaviour
{
    //redémarre la scène quand on appuie sur R

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        SceneManager.LoadScene("Scene fruit", LoadSceneMode.Single);
        
    }
}
