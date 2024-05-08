using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class buttonSceneChange : MonoBehaviour
{
   
   public void GoToStart()
   {
        SceneManager.LoadScene("MainScene");
   }

}
