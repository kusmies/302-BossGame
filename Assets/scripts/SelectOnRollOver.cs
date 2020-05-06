using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

[RequireComponent(typeof(Button))]
public class SelectOnRollOver : MonoBehaviour, IPointerEnterHandler
{
    Button bttn;
    // Start is called before the first frame update
     void Start()
    {
        bttn = GetComponent<Button>();
        
    }
  
    public void OnPointerEnter(PointerEventData eventData)
    {
        bttn.Select();
    }
}
