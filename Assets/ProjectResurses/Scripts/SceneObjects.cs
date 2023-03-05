using UnityEngine;

/// <summary>
/// Класс хранящий все объекты сцены
/// </summary>
public class SceneObjects : MonoBehaviour
{
    public ObjectView[] Objects { get; private set; }

    private void Awake()
    {
        Objects = GetComponentsInChildren<ObjectView>();
    }
}
