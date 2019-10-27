using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SceneTransition : MonoBehaviour
{
    public GameObject mask;
    public float transitionSpeed = 0.01f;
    Color maskColor;
    bool isTransition = false;
    string currentScene;

    // Start is called before the first frame update
    void Start()
    {
        maskColor = mask.GetComponent<Image>().color;
    }

    // Update is called once per frame
    void Update()
    {
        if (isTransition) 
        {
            maskColor.a += transitionSpeed; 
            mask.GetComponent<Image>().color = maskColor;   
            if (maskColor.a >= 1)    
            {
                isTransition = false;  
                GoToScene(currentScene); 
            }
        }
    }

    public void StartTransition(string scene) 
    {
        mask.SetActive(true); 
        isTransition = true; 
        currentScene = scene;
    }

    public void GoToScene(string scene)
    {
        SceneManager.LoadScene(scene);
    }

    public void ExitGame() 
    {
        Application.Quit();
    }
}
