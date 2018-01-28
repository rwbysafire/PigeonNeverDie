using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestClick : MonoBehaviour
{
    Camera cam;
    Transform home;
    public GameObject BirdSelector;
    public GameObject ItemSelector;
    GameObject depot;
    public int birdselected;
    public int itemselected;
    string[] birdobjectnames = { "pidgeon", "fatpidgeon", "fastpidgeon" };
    // Use this for initialization
    void Start()
    {
        cam = Camera.main;
        home = GameObject.Find("Home").transform;
        BirdSelector = GameObject.Find("BirdImage");
        ItemSelector = GameObject.Find("SupplyImage");
        depot = GameObject.Find("depot");
        transform.GetChild(0).gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
    }

    private void OnMouseUp()
    {
        //var x = Input.mousePosition.x;
        //var y = Input.mousePosition.y;
        //Vector3 route = bird.transform.position - transform.position;
        birdselected = BirdSelector.GetComponent<togglebird>().currentbird;
        itemselected = ItemSelector.GetComponent<togglesupply>().currentitem;
        var go = GameObject.Find(birdobjectnames[birdselected]);
        go.GetComponent<BirdBase>().target = transform;
        go.transform.position = home.position;
        var parcel = Instantiate(depot.GetComponent<itemlist>().AllItems[itemselected], home.position - new Vector3(0, 0.5f, 0), Quaternion.identity);
        parcel.transform.parent = go.transform;
        go.GetComponent<BirdBase>().onquest = true;
        go.GetComponent<BirdBase>().parcel = itemselected;
    }

    private void OnMouseEnter()
    {
        transform.GetChild(0).gameObject.SetActive(true);
    }

    private void OnMouseExit()
    {
        transform.GetChild(0).gameObject.SetActive(false);
    }
}


