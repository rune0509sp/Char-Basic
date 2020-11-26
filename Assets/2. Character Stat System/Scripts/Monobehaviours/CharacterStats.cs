using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterStats : MonoBehaviour
{
    public CharacterStats_SO charcterDefinition;
    public CharacterInventory charInv;
    public GameObject characterWeaponSlot;

    #region Constructors
    public CharacterStats()
    {
        charInv = CharacterInventory.instance;
    }
    #endregion

    #region Initializations
    private void Start()
    {
        if(!charcterDefinition.SetManually)
        {
            charcterDefinition.maxHealth = 100;
            charcterDefinition.currentHealth = 50;

            charcterDefinition.maxMana = 25;
            charcterDefinition.currentMana = 10;

            charcterDefinition.maxWealth = 500;
            charcterDefinition.currentWealth = 0;

            charcterDefinition.baseResistance = 0;
            charcterDefinition.currentResistance = 0;

            charcterDefinition.maxEncumbrance = 50f;
            charcterDefinition.currentEncumbracnce = 0f;

            charcterDefinition.charExperience = 0;
            charcterDefinition.charLevel = 1;
        }
    }
    #endregion

    #region Updates
    private void Update()
    {
       // if(Input.GetMouseButtonDown(2))
       // {
       //     charcterDefinition.saveCharacterData();
       // }
    }
    #endregion

    #region Stat Increasers
    public void ApplyHealth(int healthAmount)
    {
        charcterDefinition.ApplyHealth(healthAmount);
    }

    public void ApplyMana(int manaAmount)
    {
        charcterDefinition.ApplyMana(manaAmount);
    }

    public void GiveWealth(int wealthAmount)
    {
        charcterDefinition.GiveWealth(wealthAmount);
    }
    #endregion

    #region Stat Reducers
    public void TakeDamage(int amount)
    {
        charcterDefinition.TakeDamage(amount);
    }

    public void TakeMana(int amount)
    {
        charcterDefinition.TakeMana(amount);
    }
    #endregion

    #region Weapon and Armor Change
    public void ChangeWeapon(ItemPickUp weaponTakeUp)
    {
        if(!charcterDefinition.UnEquipWeapon(weaponTakeUp, charInv, characterWeaponSlot))
        {
            charcterDefinition.EquipWeapon(weaponTakeUp, charInv, characterWeaponSlot);
        }
    }

    public void ChangeArmor(ItemPickUp armorPickUp)
    {
        if(!charcterDefinition.UnEquipArmor(armorPickUp, charInv))
        {
            charcterDefinition.EquipArmor(armorPickUp, charInv);
        }
    }
    #endregion

    #region Reporters
    public int GetHealth()
    {
        return charcterDefinition.currentHealth;
    }

    public ItemPickUp GetcurrentWeapon()
    {
        return charcterDefinition.weapon;
    }
    #endregion
}
