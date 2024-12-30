using System.Collections;
using UnityEngine;
using UnityEngine.EventSystems;

public class ButtonTouchHold : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    private bool isHold = false;
    private PlayerController PlayerController;

    private void Awake()
    {
        PlayerController = FindObjectOfType<PlayerController>();
    }
    public void OnPointerEnter(PointerEventData eventData)
    {
        isHold = true;
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        StartCoroutine(touchEnd());
        
    }

    private void Update()
    {
        if(isHold == true)
        {
            if(name == "Button Right")
            {
                PlayerController.isPressedButtonRight = true;
            }
            if (name == "Button Left")
            {
                PlayerController.isPressedButtonLeft = true;
            }
            if (name == "Button Run")
            {
                PlayerController.playerRunOn();
            }
        }
    }

    IEnumerator touchEnd()
    {
        yield return new WaitForSeconds(0.05f);
        isHold = false;
        if (name == "Button Right")
        {
            PlayerController.isPressedButtonRight = false;
        }
        if (name == "Button Left")
        {
            PlayerController.isPressedButtonLeft = false;
        }
        if (name == "Button Run")
        {
            PlayerController.playerRunOff();
        }
    }
}
