using UnityEngine;

[CreateAssetMenu(fileName = "characterstate", menuName = "test/characterlist", order = 0)]
public class characterstate : ScriptableObject {
    [field: SerializeField]
    public int name//이름
    {
        private set;
    }
    [field: SerializeField]
    public int age;//나이
    {
        private set;
    }
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
    public enum RT{//추리성향
        //....
    }
    public RT rt;

}
