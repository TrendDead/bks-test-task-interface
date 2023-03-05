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
    private PanelObjectsSpawner _spawnPanelObjects;

    private void Start()
    {
        _spawnPanelObjects.SpawnCheckboxes();
        _mainToggleDisplay.onValueChanged.AddListener(delegate
        {
            DisplayObjects(_mainToggleDisplay.isOn);
        });
    }

    private void DisplayObjects(bool isDisplay)
    {
        foreach (var toggle in _spawnPanelObjects.GroupToggleDisplay)
        {
            toggle.isOn = isDisplay;
        }
    }
}
