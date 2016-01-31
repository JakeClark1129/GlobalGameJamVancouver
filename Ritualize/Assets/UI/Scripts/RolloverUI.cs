
using UnityEngine;
using UnityEngine.UI;

public class RolloverUI : MonoBehaviour
{
    public GameObject WidgetRoot;
    public Text Caption;
    public float MouseAwaySquared = 1600;

    private RectTransform _RectTransform;

    public void ShowCaption(string caption)
    {
        if (caption.Length < 1)
        {
            WidgetRoot.gameObject.SetActive(false);
            return;
        }

        WidgetRoot.gameObject.SetActive(true);
        Caption.text = caption;
        _RectTransform.anchoredPosition = Input.mousePosition;
    }

    private void Start()
    {
        _RectTransform = WidgetRoot.GetComponent<RectTransform>();
    }

    private void Update()
    {
        Vector3 mouseDiff = new Vector2(Input.mousePosition.x, Input.mousePosition.y) - _RectTransform.anchoredPosition;
        if (mouseDiff.sqrMagnitude > MouseAwaySquared)
        {
            WidgetRoot.gameObject.SetActive(false);
        }
    }
}
