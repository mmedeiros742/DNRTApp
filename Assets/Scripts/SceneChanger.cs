using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

// Nick, inspired by: https://www.youtube.com/watch?v=NVablfVPek4
public class SceneChanger : MonoBehaviour
{
    public GameObject LoadingScreen;
    private Animator loadingAnimator;
    private bool isLoading = false;
    private float timeElapsed = 0.0f;
    public float timeToTransition = 1.0f; // Min loading time

    void Awake(){
        DontDestroyOnLoad(this.gameObject);
    }

    // Start is called before the first frame update
    void Start()
    {
        if(LoadingScreen != null){
            LoadingScreen.SetActive(false);
            loadingAnimator = LoadingScreen.GetComponent<Animator>();
            DontDestroyOnLoad(LoadingScreen.gameObject);
        }   
    }

    public void LoadScene(string sceneName){
        if(!isLoading)
            StartCoroutine(LoadAsyncScene(sceneName));
    }

    //Loading function as Co-routine
    IEnumerator LoadAsyncScene(string scene){
        isLoading = true;
        timeElapsed = 0;
        AsyncOperation asyncLoad = SceneManager.LoadSceneAsync(scene);
        asyncLoad.allowSceneActivation = false;
        
        if(LoadingScreen != null){
            LoadingScreen.SetActive(true); // Set canvas to on
            loadingAnimator.speed = 1 / timeToTransition;
            loadingAnimator.Play("FadeIn");
        }
        else
            timeToTransition = 0.0f;

        //Wait for async scene to fully load
        while(!asyncLoad.isDone){
            timeElapsed += Time.deltaTime;
            if(timeElapsed >= timeToTransition)
                asyncLoad.allowSceneActivation = true;
            yield return null;
        }

        isLoading = false;

        //Hide canvas and destroy object for scene switching
        if(LoadingScreen != null){
            loadingAnimator.Play("FadeOut");
            loadingAnimator.speed = 1 / timeToTransition;
            yield return new WaitForSeconds(timeToTransition);
            LoadingScreen.SetActive(false);
        }
    }
}
