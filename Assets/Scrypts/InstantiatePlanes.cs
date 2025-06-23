using UnityEngine;
using UnityEngine.UIElements;

public class InstantiatePlanes : MonoBehaviour
{
    public GameObject[] planes;
    private GameObject chosenPlane;
    private int currentIndex = 0;
    
    
    void Start()
    {
        SpawnPlane(currentIndex);
    }
    
    Vector3 spawnPosition = new Vector3(255f,110f,555f);
    Vector3 spawnRotationE = new Vector3(0f,180f,0f);
    private void SpawnPlane(int index) 
    {
        if (chosenPlane != null)
        {
            Destroy(chosenPlane);
        }
        chosenPlane = Instantiate(planes[index], spawnPosition, Quaternion.Euler(spawnRotationE));
    }


    
    // Update is called once per frame
    void Update()
    {
       
    }

    public void NextPlanneInst()
    {
        Destroy(chosenPlane);
        currentIndex++;
        if (currentIndex >= planes.Length) currentIndex = 0;
        chosenPlane = Instantiate(planes[currentIndex], spawnPosition, Quaternion.Euler(spawnRotationE));

    }
    public void PrevPlanneInst()
    {
        Destroy(chosenPlane);
        currentIndex--;
        if (currentIndex < 0) currentIndex = planes.Length - 1;
        chosenPlane = Instantiate(planes[currentIndex], spawnPosition, Quaternion.Euler(spawnRotationE));
    }
}
