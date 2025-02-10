using UnityEngine;

public class MoveToCheckPoint : MonoBehaviour
{
    private void Start()
    {
        string currentCheckPointLocation = PlayerPrefs.GetString("PlayerPosition", "null");
        if (currentCheckPointLocation != "null")
        {
            string[] locationXYZ = currentCheckPointLocation.Split(",");
            float locationX = float.Parse(locationXYZ[0]);
            float locationY = float.Parse(locationXYZ[1]);
            float locationZ = float.Parse(locationXYZ[2]);

            this.transform.position = new Vector3(locationX, locationY, locationZ); // move to current check point location
        }

    }
}
