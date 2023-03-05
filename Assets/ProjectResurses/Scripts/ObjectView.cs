using UnityEngine;

/// <summary>
/// ��������� ����������� ������� �� �����
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
    /// �������� �������������� �������
    /// </summary>
    /// <param name="isDisplay">���������� �� ������</param>
    public void ChangeDisplayObject(bool isDisplay)
    {
        _meshRendererObject.enabled = isDisplay;
        //_rendererObject.material.color = new Color(_rendererObject.material.color.r, _rendererObject.material.color.g, _rendererObject.material.color.b, 0f);
    }
}
