using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class JumpTo : MonoBehaviour
{
    
    void Start()
    {
       
    }
    public void LoadScene(string name)
    {
        
        SceneManager.LoadScene(name);
    }

}
