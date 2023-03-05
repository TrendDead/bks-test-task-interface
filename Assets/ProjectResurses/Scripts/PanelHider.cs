using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// Компонент контролирующий исчезновение панели
/// </summary>
[RequireComponent(typeof(Button))]
public class PanelHider : MonoBehaviour
{
    [SerializeField]
    private GameObject _panel;

    private Button _button;

    private void Awake()
    {
        _button = GetComponent<Button>();
        _button.onClick.AddListener(HidePanel);
    }

    private void OnDestroy()
    {
        _button.onClick.RemoveAllListeners();
    }

    private void HidePanel()
    {
        _panel.SetActive(!_panel.activeSelf);
    }
}
