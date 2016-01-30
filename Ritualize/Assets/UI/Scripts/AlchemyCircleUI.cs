
using UnityEngine;
using UnityEngine.UI;

public class AlchemyCircleUI : MonoBehaviour
{
    public InventoryUI _InventoryUI;

    private void OnEnable()
    {
        if (_InventoryUI != null)
        {
            _InventoryUI.HandleAlchemyCircleEnabled(this);
        }
    }

    public void HandleButtonClick(Button button)
    {
        Debug.Log("button was clicked: " + button);
    }
}
