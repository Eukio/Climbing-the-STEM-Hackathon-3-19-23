using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//using UnityEngine.UI;
//            SceneManager.LoadScene("Lvl1");

public class Cloud : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] public List<string> dialogue = new List<string>();
    [SerializeField] public Text text;
    [SerializeField] public GameObject speechBubble;
    [SerializeField] public GameObject interact;
    [SerializeField] Vector3 translatedPosition;
    [SerializeField] GameObject r;
    Player player;
    bool onIPressed;
    int index;
    bool changeIndex;
    bool chat;



    void Start()
    {
        text.text = "";
        speechBubble.SetActive(false);
        player = GameObject.Find("Player").GetComponent<Player>();
        interact.SetActive(false);
        r.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.I))
        {
            onIPressed = true;
        }
        if (Input.GetKeyUp(KeyCode.I))
        {
            onIPressed = false;
        }
        if (index >= dialogue.Count)
        {
            player.transform.position = translatedPosition;
            index = 0;
            chat = false;
            text.text = "";
            speechBubble.SetActive(false);
            interact.SetActive(false);
            StartCoroutine(Notify());
        }
        if (changeIndex)
        {
            onIPressed = false;
            changeIndex = false;
            
            if (index == 0)
                speechBubble.SetActive(true);
            Debug.Log(dialogue[index].ToString());
            text.text = dialogue[index];
            index++;

        }
      
    }
    private void FixedUpdate()
    {
        if (chat & onIPressed)
        {
            interact.SetActive(true);
            changeIndex = true;

        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log(index + " " + dialogue.Count);
        if (collision.gameObject.tag.Equals("Player") && index <= dialogue.Count)
        chat = true;
       
       
    }
    private void OnTriggerExit(Collider other)
    {
        chat = false;
        interact.SetActive(false);

    }

    IEnumerator Notify()
    {
        
        r.SetActive(true);
                yield return new WaitForSeconds(3f);
            r.SetActive(false);

    }
}
