using UnityEngine;
using UnityEngine.InputSystem;

public class BowShoot : MonoBehaviour
{
    public GameObject arrowPrefab;
    public Transform shootPoint;
    public InputActionReference fireButton;
    public float arrowSpeed = 30f;
    public float cooldown = 0.5f;

    float timer;

    void Start()
    {
        fireButton.action.Enable();
    }

    void Update()
    {
        timer += Time.deltaTime;

        if (fireButton.action.WasPressedThisFrame() && timer >= cooldown)
        {
            timer = 0f;
            GameObject arrow = Instantiate(arrowPrefab, shootPoint.position, shootPoint.rotation);
            arrow.GetComponent<Rigidbody>().linearVelocity = shootPoint.forward * arrowSpeed;
        }
    }
}