using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Equip : MonoBehaviour
{    

    private Inventory inventory;
    public int i;

    private void Start() {
        inventory = GameObject.FindGameObjectWithTag("Player").GetComponent<Inventory>();
    }

    public void EquipItem(){
        if (inventory.isFullEquippedTools[inventory.equippedTools.Length - 1] == false) {
            inventory.isFull[i] = false;
            for (int i = 0; i < inventory.equippedTools.Length; i++) {
                if (inventory.isFullEquippedTools[i] ==  false) {
                    inventory.isFullEquippedTools[i] = true;
                    Instantiate(gameObject.transform.GetChild(0).gameObject, inventory.equippedTools[i].transform, false);
                    break;
                }
            }
            foreach (Transform child in transform) {
                GameObject.Destroy(child.gameObject);
            } 
        }        
    }

}
