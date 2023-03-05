using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// Чекбокс конкретного объекта
/// </summary>
public class ObjectCheckbox : MonoBehaviour
{
    public Toggle ToggleSelect => _toggleSelect;
    public Toggle ToggleDisplay => _toggleDisplay;

    [SerializeField]
    private Toggle _toggleSelect;
    [SerializeField]
    private Toggle _toggleDisplay;

    private ObjectView _sceneObject;

    /// <summary>
    /// Обновление информации об привязанном объекте на сцене
    /// </summary>
    /// <param name="newObject">Новая ссылка на объект сценны</param>
    public void UpdateObjectInfo(ObjectView newObject)
    {
        _sceneObject = newObject;
    }

    private void Start()
    {
        _toggleDisplay.onValueChanged.AddListener(delegate {
            _sceneObject.ChangeDisplayObject(_toggleDisplay.isOn);
        });
    }

    private void OnDestroy()
    {
        _toggleDisplay.onValueChanged.RemoveAllListeners();
    }
}
