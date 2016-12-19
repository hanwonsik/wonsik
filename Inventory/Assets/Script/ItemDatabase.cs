using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ItemDatabase : MonoBehaviour
{
    public List<Item> items = new List<Item>();

    void Start()
    {
        items.Add(new Item("Amulet of Prayers", 0, "An amulet enchanted by prayers", 2, 0, Item.ItemType.Weapon));
        items.Add(new Item("health potion", 1, "A potion that is health potion", 0, 0, Item.ItemType.Consumable));
    }

}
