using UnityEngine;

[CreateAssetMenu(fileName = "characterstate", menuName = "test/characterlist", order = 0)]
public class SOcharacterstate : ScriptableObject {
    [field: SerializeField]
    public int reliability;//신뢰도
    {
        get;
    }
    {
        set;
    }
    [field: SerializeField]   // 자동 구현 프로퍼티에 사용하는 serializefield 어트리뷰트이다.
    public int name//이름
    {
        private set;
    }
    public int age;//나이
    public enum Gender{//성별
        Male,
        Female
    }
    public Gender gender;
    public enum Personailty{//성격(정보수용태도에 영향을 준다.) 개임 내에서 조회가 불가능하다.
        Cautious, //조심스러운
        Suspicious, //의심많은
        Clever, //영리한
        Impatient, // 성급한
        Cunning, //교활한
        Reticent //과묵한
        
    }
    public Personailty personailty;
    public enum Tendency{//성향(게임 시작부터 끝까지 영향을 미치는 요소)
        Selfish, //개인주의
        Strange, //괴짜
        Cooperately, //협동적
        Newtral, //중립
        Lead //리더
        
    }
    public Tendency tendency;
    //npc 상태
    public enum Situation{//상태
        Doubtful, //의심중
        Uneasy, //불안한
        Panic,// 공황
        Confidentable,  //자신감있는
        Comportable, //편안한(기본상태)
        Thinking, //생각 중
        Composure, //침착함
        Excitement, //흥분한
        Glad, //기쁜
        Sad, //슬픈
        Zonked, //기운빠진
        Sympathy //동정하는

    }
    public Situation situation;

}
