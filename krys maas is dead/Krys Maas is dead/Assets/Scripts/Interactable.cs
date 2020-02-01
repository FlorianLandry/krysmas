using UnityEngine;

public class Interactable : MonoBehaviour
{
    public float radius = 3f;
    bool isFocused = false;
    bool hasInteracted = false;
    Transform player;
    public Transform interactionTransform;
    protected PlayerController pc;

    public virtual void interact()
    {
        //Have to be overwritten
        Debug.Log("INTERACT");
    }

    public void Start()
    {
        pc = GameObject.Find("Joueur").GetComponent<PlayerController>();
    }

    private void Update()
    {
        if (isFocused && !hasInteracted)
        {
            float distance = Vector3.Distance(player.position, interactionTransform.position);
            if(distance <= radius)
            {
                interact();
                hasInteracted = true;
            }
        }
    }

    public void OnFocused(Transform playerTransform)
    {
        isFocused = true;
        player = playerTransform;
        hasInteracted = false;
    }

    public void onDefocused(Transform playerTransform)
    {
        isFocused = false;
        player = null;
        hasInteracted = false;
    }

    private void OnDrawGizmosSelected()
    {
        if (interactionTransform == null)
            interactionTransform = transform;
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireSphere(interactionTransform.position, radius);
    }
}
