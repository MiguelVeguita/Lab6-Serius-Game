using UnityEngine;

[CreateAssetMenu(menuName ="Singletons/MasterManager")]
public class MasterManager : SingletonScriptableObject<MasterManager>
{

    [SerializeField]
    private GameSeting _gameseting;
    public static GameSeting GameSeting { get { return Instance._gameseting; } }

}
