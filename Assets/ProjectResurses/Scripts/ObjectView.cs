using UnityEngine;

/// <summary>
/// Компонент отображения объекта на сцене
/// </summary>
public class ObjectView : MonoBehaviour
{
    private Renderer _rendererObject;
    private MeshRenderer _meshRendererObject;

    private void Start()
    {
        _rendererObject = GetComponent<Renderer>();
        _meshRendererObject = GetComponent<MeshRenderer>();
    }

    /// <summary>
    /// Изменить отображаемость объекта
    /// </summary>
    /// <param name="isDisplay">Отображать ли объект</param>
    public void ChangeDisplayObject(bool isDisplay)
    {
        _meshRendererObject.enabled = isDisplay;
    }

    /// <summary>
    /// Изменение прозрачность обекта
    /// </summary>
    /// <param name="transparency">Степень прозрачности</param>
    public void ChangingTransparencyObject(float transparency)
    {
        _rendererObject.material.color = new Color(_rendererObject.material.color.r, _rendererObject.material.color.g,
            _rendererObject.material.color.b, transparency);
    }
}
