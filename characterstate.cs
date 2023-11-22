using UnityEngine;

[CreateAssetMenu(fileName = "characterstate", menuName = "test/characterlist", order = 0)]
public class characterstate : ScriptableObject {
    public const int name
    {
        private set;
    }
    public const int age;
    {
        private set;
    }
    public enum Gender{
        male,
        female
    }
    public const Gender gender;
    public enum Personailty{
        stupid,
        suspicious,
        clever

    }
    public const Personailty personailty;

}
