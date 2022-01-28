using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour
{
    public string SceneName;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void Loadscene()
    {
        SceneManager.LoadScene(SceneName);
    }

    public void Loadscene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }


}
