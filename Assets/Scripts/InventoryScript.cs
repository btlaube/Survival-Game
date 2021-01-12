using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryScript : MonoBehaviour
{
    public static bool InventoryUp = false;
    public GameObject inventoryUI;

    // Update is called once per frame
    void Update(){
        if(Input.GetKeyDown(KeyCode.E)){
            if (InventoryUp){
                Resume();
            }
            else{
                Pause();
            }
        }
    }

    void Resume(){
        inventoryUI.SetActive(false);
        Time.timeScale = 1f;
        InventoryUp = false;
    }

    void Pause(){
        inventoryUI.SetActive(true);
        Time.timeScale = 0f;
        InventoryUp = true;
    }

}
