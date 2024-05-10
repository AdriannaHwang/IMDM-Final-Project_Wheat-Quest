// Tutorial for changing scenes
// Documentatin: https://docs.unity3d.com/ScriptReference/SceneManagement.SceneManager.html

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class CollideTrigger : MonoBehaviour
{
    //just testing this out:
    public Rigidbody seed1;
    public Rigidbody seed2;
    public Rigidbody seed3;
    public Rigidbody seed4;
    public Rigidbody seed5;
    public Rigidbody seed6;
    public Button buttonTrigger; //the UI button in beginning scene
    

    // Start is called before the first frame update
    void Start()
    {
       //this makes sure that the seeds don't automatically drop upon entering scene
        seed1.useGravity = false;
        seed2.useGravity = false;
        seed3.useGravity = false;
        seed4.useGravity = false;
        seed5.useGravity = false;
        seed6.useGravity = false;
        
        buttonTrigger.onClick.AddListener(OnButtonClicked);
    }

    // if the button is clicked, the gravity feature is enabled in the seeds' rigidbodies.
    //the collidetrigger function can occur and sceneswitch to the main scene
    void OnButtonClicked()
    {
        seed1.useGravity = true;
        seed2.useGravity = true;
        seed3.useGravity = true;
        seed4.useGravity = true;
        seed5.useGravity = true;
        seed6.useGravity = true;
       
    OnTriggerEnter(seed1.GetComponent<Collider>());
    OnTriggerEnter(seed2.GetComponent<Collider>());
    OnTriggerEnter(seed3.GetComponent<Collider>());
    OnTriggerEnter(seed4.GetComponent<Collider>());
    OnTriggerEnter(seed5.GetComponent<Collider>());
    OnTriggerEnter(seed6.GetComponent<Collider>());
        
    void OnTriggerEnter(Collider other)
    {
        
        // Check if collision is made with the Drop, which is tagged as "Finish"
        // You can change the tag and manually change this accordingly.
        if (other.tag == "CollideTag")
        {
            // Deactivate or destroy the seeds when collision occurs
            seed1.gameObject.SetActive(false);
            seed2.gameObject.SetActive(false);
            seed3.gameObject.SetActive(false);
            seed4.gameObject.SetActive(false);
            seed5.gameObject.SetActive(false);
            seed6.gameObject.SetActive(false);
            
            // Alternatively, you can destroy the seeds
            //Destroy(seed1.gameObject);
            //Destroy(seed2.gameObject);
           // Destroy(seed3.gameObject);
            //Destroy(seed4.gameObject);
            //Destroy(seed5.gameObject);
            //Destroy(seed6.gameObject);
        }
    }

    }


}

