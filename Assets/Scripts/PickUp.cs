using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : MonoBehaviour
{
    private Inventory inventory;
    public GameObject item;

    private void Start() {
        inventory = GameObject.FindGameObjectWithTag("Player").GetComponent<Inventory>();
    }

    void OnTriggerEnter2D(Collider2D other) {
        if (other.CompareTag("Player")) {
            for (int i = 0; i < inventory.items.Length; i++) {
                if (inventory.isFull[i] == false) {
                    inventory.isFull[i] = true;
                    Instantiate(item, inventory.items[i].transform, false);
                    Destroy(gameObject);
                    break;
                }
            }
        }
    }
}
