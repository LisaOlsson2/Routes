using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Inventory : MonoBehaviour
{
    readonly Color color = new(1, 143 / 255f, 0);

    static readonly Inventory[,] allSlots = new Inventory[4, 4];
    static Inventory selectedSlot;
    static Inventory emptySlot;
    static Transform thingy;

    Image image;
    Vector2 slotPosition;

    private void Start()
    {
        image = GetComponent<Image>();
        GetComponent<Button>().onClick.AddListener(Clicked);

        if (transform.GetSiblingIndex() == 1)
        {
            thingy = transform.parent.GetChild(0);
            selectedSlot = this;

            int child = transform.GetSiblingIndex();
            for (int i = 0; i < allSlots.GetLength(0); i++)
            {
                for (int i2 = 0; i2 < allSlots.GetLength(1); i2++)
                {
                    allSlots[i, i2] = transform.parent.GetChild(child).GetComponent<Inventory>();
                    allSlots[i, i2].slotPosition = GetPlace(allSlots[i, i2]);
                    
                    child++;

                    if (child == transform.parent.childCount)
                    {
                        emptySlot = allSlots[i, i2];
                    }
                }
            }
        }
    }

    void Clicked()
    {
        if (emptySlot == this && ((selectedSlot.slotPosition.x == slotPosition.x && Mathf.Abs(selectedSlot.slotPosition.y - slotPosition.y) == 1) || (selectedSlot.slotPosition.y == slotPosition.y && Mathf.Abs(selectedSlot.slotPosition.x - slotPosition.x) == 1)))
        {
            emptySlot = selectedSlot;
            emptySlot.image.color = Color.white;
            image.color = color;
        }

        thingy.position = transform.position;
        selectedSlot = this;
    }

    Vector2 GetPlace(Inventory slot)
    {
        for (int i = 0; i < allSlots.GetLength(0); i++)
        {
            for (int i2 = 0; i2 < allSlots.GetLength(1); i2++)
            {
                if (allSlots[i, i2] == slot)
                {
                    return new Vector2(i, i2);
                }
            }
        }
        return Vector2.zero;
    }
}
