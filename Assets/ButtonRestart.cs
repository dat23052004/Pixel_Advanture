using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class ButtonRestart : MonoBehaviour, IPointerDownHandler
{
    public void OnPointerDown(PointerEventData eventData)
    {
        string CurrentSeneName = SceneManager.GetActiveScene().name;
        SceneManager.LoadScene(CurrentSeneName);
    }
    


}
