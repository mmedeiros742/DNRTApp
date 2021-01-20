using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class LoadOnTrigger : MonoBehaviour
{
    private SceneChanger sceneChanger;

    // Start is called before the first frame update
    void Start()
    {
        sceneChanger = GameObject.Find("SceneChanger").GetComponent<SceneChanger>();
    }

    // public void SceneLoader(string sceneName){
    //     sceneChanger.LoadScene(sceneName);
    // }
  public void SceneLoader(int index){
      SceneManager.LoadScene(index);
  }
}
