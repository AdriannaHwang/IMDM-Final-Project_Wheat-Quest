using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChange : MonoBehaviour
{
   public int LevelIndex;

   void Start() 
   {
    
   }

   void OnTriggerEnter(Collider other)
   {
      if (other.gameObject.tag == "ColliderTag")
         SceneManager.LoadScene(LevelIndex);
   }
}