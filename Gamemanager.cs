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
    private static Gamemanager _instance;
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
                    _instance = singletonObject.AddComponent<Gamemanager>();
                }
            }

            return _instance;
        }
    }
    public enum Timestate{
    Day,
    Minigame,
    Night
    }
    public Timestate timestate;//낮 시간, 미니게임 시간, 밤 시간을 구분하는 enum형식 객체
    
    public bool isGameOver=false;//죽으면 게임오버
    [HideInInspector]public int count;//         게임 시작 후 흐르는 시간을 기록

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
        Gamestart();
        
    }

    private void Update() {
         if(isGameOver==true){
             return;
         }
            
         
         count+=time.deltatime;
         switch (timestate)
         {   
             case Timestate.Day:
                 if (count >= 300)
                 {
                     timestate = Timestate.Mimigame;
                     count = 0;
                     //+미니게임으로 씬전환하는 함수 호출
                 }
                 break;
             case Timestate.Minigame:
                 if (count >= 60)
                 {
                     timestate = Timestate.Night;
                     count = 0;
                     //+미니게임에서 일반 맵으로 씬전환하고, 개인실에서 깨어남
                 }
                 break;
             case Timestate.Night:
                 if (count >= 120)
                 {
                     timestate = Timestate.Day;
                     count = 0;
                     //+밤이 지나고 아침이 되면 실행할 함수 호출(예) 하루마다 지급해야하는 아이템을 지급하는 함수 등)
                 }
                 break;                 
         }
        
    }
    
    public void Gamestart(){//게임을 새로 시작하고 싶을 때 호출
        count=0;
        isGameOver=false;
        timestate=Timestate.Day;
        //+플레이어 상태 초기화 등
    }
    
}
