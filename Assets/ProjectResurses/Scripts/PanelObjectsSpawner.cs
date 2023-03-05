using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// Компонент генерации панелей объектов на сцене
/// </summary>
public class PanelObjectsSpawner : MonoBehaviour
{
    /// <summary>
    /// Все созданные чекбоксы
    /// </summary>
    public List<ObjectCheckbox> Checkboxes { private set; get; } = new List<ObjectCheckbox>();

    [SerializeField]
    private ObjectCheckbox _objectCheckboxPrifab;
    [SerializeField]
    private SceneObjects _sceneObjects;

    /// <summary>
    /// Создание чекбоксов
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
