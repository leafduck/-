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
    public static Gamemanager instance;
    public int killcount;//킬 카운트
    public int nigritude;//악명(최대 100까지 있다.)


    public bool isGameEnding=false;//죽거나 특정 조건을 충족하면 엔딩
    public bool isGameOver=false;//죽으면 게임오버
    
    private void Awake() {
        if(instance==null){
            instance=this;
        }
        else{Destroy(gameObject);}
    }
    
    private void Start() {
            
    }
    private void Update() {
        if(nigritude>100||nigritude<0){renewalnoto();}//명성범위제한 함수 실행
        
    }
    void renewalnoto()=>nigritude=Mathf.Clamp(nigritude,0,100);//명성범위제한 함수 구현
}
