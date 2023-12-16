using UnityEngine;

[CreateAssetMenu(fileName = "characterstate", menuName = "test/characterlist", order = 0)]
public class characterstate : ScriptableObject {
    [field: SerializeField]   // 자동 구현 프로퍼티에 사용하는 serializefield 어트리뷰트이다.
    public int name//이름
    {
        private set;
    }
    public int age;//나이
    public enum Gender{//성별
        male,
        female
    }
    public Gender gender;
    public enum Personailty{//성격
        stupid,
        suspicious,
        clever
    }
    public Personailty personailty;
    public enum Tendency{//추리성향
        //....
    }
    public Tendency tendency;
    //npc 상태
    public enum situation{//상태
        //....
    }

}
