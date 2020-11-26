using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum ItemTypeDefinitions { HEALTH, WEALTH, MANA, WEAPON, ARMOR, BUFF, EMPTY };
public enum ItemArmorSubType { None, Head, Chest, Hands, Legs, Boots };

[CreateAssetMenu(fileName ="new Item", menuName ="Spawnable Item/New Pick-up", order = 1)]
public class ItemPickUp_SO : ScriptableObject
{
    public ItemTypeDefinitions itemType = ItemTypeDefinitions.HEALTH;
    public ItemArmorSubType itemArmorSubType = ItemArmorSubType.None;
    public int itemAmount = 0;
}
