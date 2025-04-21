using UnityEngine;


[CreateAssetMenu(menuName = "Manager/GameSeting")]

public class GameSeting : ScriptableObject
{

    [SerializeField]
    private string _gameVersion = "0.0.0";
    public string GameVersion {  get { return _gameVersion; } }
    [SerializeField]
    public string _nicname = "LLAMA KILLER";
    public string NickName
    {
        get
        {
            int value = Random.Range(0, 9999);
            return _nicname + value.ToString();
        }
    }


}
