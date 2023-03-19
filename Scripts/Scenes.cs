using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditorInternal;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class Scenes : MonoBehaviour
{
    // Start is called before the first frame update
    Scene activeScene;

    void Start()
    {
        DontDestroyOnLoad(this);


    }

    // Update is called once per frame
    void Update()
    {
         activeScene = SceneManager.GetActiveScene();

       
    }
  
    private void Awake()
    {
        if (GameObject.FindGameObjectsWithTag("Scenes").Length > 1)
            Destroy(GameObject.FindGameObjectsWithTag("Scenes")[1]);
     
    }
    public void ToGame()
    {
        SceneManager.LoadScene("GameScene");

    }
    

}
