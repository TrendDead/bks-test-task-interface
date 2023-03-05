using System;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// ������� �������
/// </summary>
public class ObjectCheckbox : MonoBehaviour
{
    public ObjectView SceneObject { get; private set; }
    public Toggle ToggleSelect => _toggleSelect;
    public Toggle ToggleDisplay => _toggleDisplay;

    [SerializeField]
    private Toggle _toggleSelect;
    [SerializeField]
    private Toggle _toggleDisplay;

    /// <summary>
    /// ���������� ���������� �� ����������� ������� �� �����
    /// </summary>
    /// <param name="newObject">����� ������ �� ������ ������</param>
    public void UpdateObjectInfo(ObjectView newObject)
    {
        SceneObject = newObject;
    }

    private void Start()
    {
        _toggleSelect.isOn = false;
        _toggleDisplay.onValueChanged.AddListener(SceneObject.ChangeDisplayObject);
    }

    private void OnDestroy()
    {
        _toggleDisplay.onValueChanged.RemoveAllListeners();
    }
}
