using UnityEngine;

[CreateAssetMenu(fileName = "SOcharacterstate", menuName = "test/characterlist", order = 0)]
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
    
}
