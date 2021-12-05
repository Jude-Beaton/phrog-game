using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemCollector : MonoBehaviour
{

    [SerializeField] private int cherries = 1;

    [SerializeField] private Text cherriesText;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Cherry"))
        {
            Destroy(collision.gameObject);
            cherries++;
            cherriesText.text = "HP: " + cherries * 10;
        }
    }
}
