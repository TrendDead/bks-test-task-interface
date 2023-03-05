using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// Компонент генерации панелей объектов на сцене
/// </summary>
public class PanelObjectsSpawner : MonoBehaviour
{
    public List<Toggle> GroupToggleSelect { private set; get; } = new List<Toggle>();
    public List<Toggle> GroupToggleDisplay { private set; get; } = new List<Toggle>();

    [SerializeField]
    private ObjectCheckbox _objectCheckboxPrifab;
    [SerializeField]
    private SceneObjects _sceneObjects;

    private List<ObjectCheckbox> _checkboxes = new List<ObjectCheckbox>();

    /// <summary>
    /// Создание чекбоксов
    /// </summary>
    public void SpawnCheckboxes()
    {
        for (int i = 0; i < _sceneObjects.Objects.Length; i++)
        {
            var checkboxes = Instantiate(_objectCheckboxPrifab, gameObject.transform);
            checkboxes.UpdateObjectInfo(_sceneObjects.Objects[i]);
            GroupToggleSelect.Add(checkboxes.ToggleSelect);
            GroupToggleDisplay.Add(checkboxes.ToggleDisplay);
            _checkboxes.Add(checkboxes);
        }
    }
}
