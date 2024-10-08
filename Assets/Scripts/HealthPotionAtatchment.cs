using Fusion;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static GlobalConstants;

public class HealthPotionAtatchment: NetworkBehaviour
{
    public HealthPotion healthPotion;

    public void Start()
    {
        GetComponent<SpriteRenderer>().sprite = healthPotion.itemSprite;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag(GlobalConstants.Tags.Player.ToString()))
        {
            PlayerInventory.AddItem(healthPotion); 
            Runner.Despawn(Object);
        }
    }
}
