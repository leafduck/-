using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LoadManager : MonoBehaviour
{
    public string sceneName = "GameStage";
    public Slider slider; // 여기에 슬라이더 오브젝트 할당
    private AsyncOperation operation;

    //private SaveAndLoad theSaveAndLoad;코드를 가져온 거라 이건 이 사람이 구현한 클래스타입 변수같다.나는 아직 구현하지 않은 게임저장 클래스여서 일단 락걸어놓음

    public static LoadManager instance;

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
            Destroy(gameObject);
    }

    void Start()
    {
        StartCoroutine(LoadCoroutine());
    }

    IEnumerator LoadCoroutine()
    {
        operation = SceneManager.LoadSceneAsync(sceneName);
        operation.allowSceneActivation = false;

        float timer = 0f;
        while (!operation.isDone)
        {
            yield return null;

            timer += Time.deltaTime;
            if (operation.progress < 0.9f)
            {
                slider.value = Mathf.Lerp(operation.progress, 1f, timer);
                if (slider.value >= operation.progress)
                    timer = 0f;
            }
            else  
            {
                slider.value = Mathf.Lerp(slider.value, 1f, timer); 
                if (slider.value >= 0.99f)
                    operation.allowSceneActivation = true;
            }
        }

        //theSaveAndLoad = FindObjectOfType<SaveAndLoad>(); // 다음 씬의 📜SaveAndLoad
        //theSaveAndLoad.LoadData();코드를 가져온 거라서 이건 내가 구현을 안한 코드(대충 saveandload클래스의 loaddata를 실행시키는 코드갇다.)
        gameObject.SetActive(false);
    }
}
