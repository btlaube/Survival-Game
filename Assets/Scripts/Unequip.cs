using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Unequip : MonoBehaviour
{
    private Inventory inventory;
    public int i;

    private void Start() {
        inventory = GameObject.FindGameObjectWithTag("Player").GetComponent<Inventory>();
    }

    public void UnequipItem(){
        if (inventory.isFull[inventory.items.Length - 1] == false) {
            inventory.isFullEquippedTools[i] = false;
            for (int i = 0; i < inventory.items.Length; i++) {
                if (inventory.isFull[i] == false) {
                    inventory.isFull[i] = true;
                    Instantiate(gameObject.transform.GetChild(0).gameObject, inventory.items[i].transform , false);
                    break;
                }
            }
            foreach (Transform child in transform) {
                GameObject.Destroy(child.gameObject);
            }          
        }      
    }
}
