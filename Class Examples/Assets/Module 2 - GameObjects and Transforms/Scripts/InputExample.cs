using UnityEngine;


public class InputExample : MonoBehaviour
{
[SerializeField]
private bool pressed = false;

    public void Update()
    {
        string keyPressed = Input.inputString;
        switch (keyPressed) {
            case "a":
                transform.position += new Vector3(0.1f, 0, 0);
                break;
            case "d":
                transform.position += new Vector3(-0.1f, 0, 0);
                break;
            case "w":
                transform.position += new Vector3(0, 0.0f, 0.1f);
                break;
            case "s":
                transform.position += new Vector3(0, 0.0f, -0.1f);
                break;
        }

        
    }
}
