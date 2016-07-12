using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Navigation : MonoBehaviour
{

    private NavMeshAgent agent;
    public Dropdown dropdown;
    //public GUIdropdown sectDrop;

    //section A (blue)
    public Transform[] sectionBlue;

    //section B (red)
    public Transform[] sectionRed;


    // Use this for initialization
    void Start()
    {
        //reference to nav mesh
        agent = GetComponent<NavMeshAgent>();

        //dropdown delagate (event)
        dropdown.onValueChanged.AddListener(delegate
        {
            DropdownValueChanged(dropdown);
        });

       // sectDrop = GameObject.Find("Level").GetComponent<GUIdropdown>();

        
    }

    // Update is called once per frame
    void Update()
    {
        

    }

    //test


    //do once
    void Destroy()
    {
        dropdown.onValueChanged.RemoveAllListeners();
    }

    //add code to move here
    private void DropdownValueChanged(Dropdown target)
    {
        int seat = 0;

        print("Selected " + target.value);

        seat = target.value - 1;

        //sectionRed.Length

        agent.SetDestination(sectionRed[seat].transform.position);
    }

    //keep track of dropdown values
    public void SetDropdownIndex(int index)
    {
        dropdown.value = index;
    }
}
