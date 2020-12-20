using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    public string URL = "https://github.com/harrymurray881/AssignmentBeta";
   public void Scene1()
    {
        SceneManager.LoadScene("Beta");
    }
       
    public void SourceCode()
    {
        Application.OpenURL(URL);
    }
    
}
