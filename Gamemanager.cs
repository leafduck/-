using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Gamemanager : MonoBehaviour
{
    
    /*게임 매니저가 갖추어야 할 것
    1.싱글톤 패턴으로 메서드 공유
    2.게임오버 상태를 표현하고, 게임 점수와 ui관리
    전반적으로 게임 시작과 종료를 구현할거다. uimanager에서 정의한 메서드들을 사용할 예정이다.
    씬로드는 따로 구현할 예정이다. 씬로드를 호출한다.
    */ 
    public 
    private static Gamemanager _instance;
    public bool isGameOver=false;//죽으면 게임오버
    private int count;
    {
        set
        {
            if(count==)
        }
    
    }
    public static Gamemanager Instance//외부에서 호출할 때 쓰는 프로퍼티
    {
        get
        {
            // 인스턴스가 없으면 새로 생성
            if (_instance == null)
            {
                // 씬에서 싱글톤 오브젝트를 찾아봅니다.
                _instance = FindObjectOfType<MySingleton>();

                // 씬에 없으면 새로 생성
                if (_instance == null)
                {
                    GameObject singletonObject = new GameObject("Gamemanager");
                    _instance = singletonObject.AddComponent<MySingleton>();
                }
            }

            return _instance;
        }
    }
    private void Awake() {
        if (_instance != null && _instance != this)
        {
            Destroy(this.gameObject);
        }
        else
        {
            // 처음 생성된 인스턴스를 저장
            _instance = this;
            DontDestroyOnLoad(this.gameObject);
        }
    }
    
    private void Start() {
            
    }
    private void Update() {
         count++;
        
    }
    
}
