using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// ��������� ��������� ������� �������� �� �����
/// </summary>
public class PanelObjectsSpawner : MonoBehaviour
{
    /// <summary>
    /// ��� ��������� ��������
    /// </summary>
    public List<ObjectCheckbox> Checkboxes { private set; get; } = new List<ObjectCheckbox>();

    [SerializeField]
    private ObjectCheckbox _objectCheckboxPrifab;
    [SerializeField]
    private SceneObjects _sceneObjects;

    /// <summary>
    /// �������� ���������
    /// </summary>
    public void SpawnCheckboxes()
    {
        for (int i = 0; i < _sceneObjects.Objects.Length; i++)
        {
            var checkbox = Instantiate(_objectCheckboxPrifab, gameObject.transform);
            checkbox.UpdateObjectInfo(_sceneObjects.Objects[i]);
            Checkboxes.Add(checkbox);
        }
    }
}
