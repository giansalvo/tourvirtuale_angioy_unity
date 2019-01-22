using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Tmenu : MonoBehaviour
{
    public void MenuReturn()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
        
    }

 }
