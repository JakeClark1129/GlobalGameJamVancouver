
using UnityEngine;
using UnityEngine.UI;

public class InventorySlot : MonoBehaviour
{
    public Text Caption;
    public Image Icon;

    private InventoryItem _Item;
    public InventoryItem Item
    {
        get { return _Item; }

        set
        {
            _Item = value;

            if (Caption != null)
            {
                if (_Item != null)
                {
                    Caption.text = _Item.Caption;
                }
                else
                {
                    Caption.text = "Empty";
                }
            }

            if (Icon != null)
            {
                if (_Item != null)
                {
                    Icon.overrideSprite = _Item.Icon;
                }
                else
                {
                    Icon.overrideSprite = null;
                }
            }
        }
    }
}
