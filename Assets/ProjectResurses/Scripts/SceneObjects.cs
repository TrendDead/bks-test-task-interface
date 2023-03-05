using UnityEngine;

/// <summary>
/// ����� �������� ��� ������� �����
/// </summary>
public class SceneObjects : MonoBehaviour
{
    public ObjectView[] Objects { get; private set; }

    private void Awake()
    {
        Objects = GetComponentsInChildren<ObjectView>();
    }
}
