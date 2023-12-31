using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Unity.VisualScripting;
using UnityEngine;

public class Coin : MonoBehaviour
{ 
  private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            Debug.Log("Player Collected the coin.");
            GameObject.Find("Canvas").GetComponent<UIManager>().UpdateCoinCount();
            Destroy(this.gameObject);
        }
    }
}