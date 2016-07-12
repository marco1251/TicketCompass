using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GUIdropdown : MonoBehaviour
{

    //NOT USING THIS SCRIPT ATM

    public Dropdown sectdropdown;
    public int sectionNum = 0;
    //public Navigation nav;

    public GameObject[] sections;

    // Use this for initialization
    void Start()
    {
        //nav = GameObject.Find("Capsule").GetComponent<Navigation>();
        sectdropdown.onValueChanged.AddListener(delegate
        {
            DropdownValueChanged(sectdropdown);
        });
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    void Destroy()
    {
        sectdropdown.onValueChanged.RemoveAllListeners();
    }

    private void DropdownValueChanged(Dropdown target)
    {
        print("Selected" + target.value);

        sectionNum = 0;

        sectionNum = target.value - 1;

    }

    public void SetDropdownIndex(int index)
    {
        sectdropdown.value = index;
    }

}
