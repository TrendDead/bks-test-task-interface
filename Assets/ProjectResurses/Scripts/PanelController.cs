using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// Контроллер панели
/// </summary>
public class PanelController : MonoBehaviour
{
    [SerializeField]
    private Toggle _mainToggleDisplay;
    [SerializeField]
    private Toggle _mainToggleSelect;
    [SerializeField]
    private PanelObjectsSpawner _spawnPanelObjects;

    private void Start()
    {
        _mainToggleSelect.isOn = false;
        _spawnPanelObjects.SpawnCheckboxes();
        _mainToggleDisplay.onValueChanged.AddListener(DisplayObjects);
        _mainToggleSelect.onValueChanged.AddListener(SelectObject);
    }

    private void OnDestroy()
    {
        _mainToggleSelect.onValueChanged.RemoveAllListeners();
    }

    private void SelectObject(bool isSelect)
    {
        foreach (var checkbox in _spawnPanelObjects.Checkboxes)
        {
            checkbox.ToggleSelect.isOn = isSelect;
        }
    }

    private void DisplayObjects(bool isDisplay)
    {
        foreach (var checkbox in _spawnPanelObjects.Checkboxes)
        {
            checkbox.ToggleDisplay.isOn = isDisplay;
        }
    }

    /// <summary>
    /// Изменение прозрачности
    /// </summary>
    /// <param name="transparency">Прозрачность</param>
    public void ChengeTransparency(float transparency)
    {
        foreach (var checkbox in _spawnPanelObjects.Checkboxes)
        {
            if (checkbox.ToggleSelect.isOn)
            {
                checkbox.SceneObject.ChangingTransparencyObject(transparency);
            }
        }
    }
}
