using UnityEngine;
using UnityEngine.SceneManagement;

public class ManosCris : MonoBehaviour
{
    private Animator animator;
    private GameObject text;
    private bool a;
    private float i = 0f;
    // Start is called before the first frame update
    void Start()
    {
        text = GameObject.FindGameObjectWithTag("Instructions");
        text.SetActive(false);
        animator = GetComponent<Animator>();
        
    }

    // Update is called once per frame
    void Update()
    {
        i+=Time.deltaTime;
        Debug.Log(i);
        if (i >= 15)
        {
            Debug.Log("Entro");
            text.SetActive(true);
        }
        OVRInput.Update();
        bool primaryHandTriggerLTouch = OVRInput.Get(OVRInput.Button.PrimaryIndexTrigger, OVRInput.Controller.LTouch);
        bool primaryHandTriggerRTouch = OVRInput.Get(OVRInput.Button.PrimaryIndexTrigger, OVRInput.Controller.RTouch);
        if (primaryHandTriggerRTouch)
        {
            animator.SetInteger("Choose", 1);
            if(!a)
            {
                Invoke("GoToApocalipsis", 4);
                a = true;
            }
            Debug.Log(1);
        }
            
        else if (primaryHandTriggerLTouch)
        {
            animator.SetInteger("Choose", 2);
            Debug.Log(2);
        }
    }

    private void GoToApocalipsis()
    {
        SceneManager.LoadScene("DialogosFuturo");
    }
}
