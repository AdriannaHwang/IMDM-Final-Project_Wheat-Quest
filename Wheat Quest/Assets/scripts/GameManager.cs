using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;


public class GameManager : MonoBehaviour
{
    [Header("Timer Componets")]
    [SerializeField] private float gameTime;
    [SerializeField] TextMeshProUGUI timeTextBox;

    // Start is called before the first frame update
    void Start()
    {
        
    }
    public class SceneChange : MonoBehaviour
{
   public void goNextScene()
   {
    SceneManager.LoadScene(3);
   }
}

    // Update is called once per frame
    void Update()
    {
        UpdateGameTimer();
        checkTime();

    }
private void UpdateGameTimer()
    {
      gameTime -= Time.deltaTime;

      var minutes = Mathf.FloorToInt(gameTime/ 60);
      var seconds = Mathf.FloorToInt(gameTime - minutes * 60 );
       string gameTimeClockDisplay = string.Format("{0:0}:{1:00}", minutes, seconds);

       timeTextBox.text = gameTimeClockDisplay;
    }

    public void checkTime()
    {
     if(gameTime <= 0)
     {
        SceneManager.LoadScene("Ending Congrats");
     }
    }
}
