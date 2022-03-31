using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Shoot : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI bulletText;
    public GameObject Image;
    static int bullet = 30;
    // Start is called before the first frame update
    void Start()
    {
        bulletText.text = bullet + " bullets";
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseDown()
    {
        bullet = bullet - 1;
        bulletText.text = bullet + " bullets";
        Destroy(Image);
        Destroy(gameObject);
    }
}
