using UnityEngine;

public class LaserControll : MonoBehaviour
{
    [SerializeField] private GameObject laserObj;
    [SerializeField] private Vector2 laserVector;
    private GameObject myLaser;
    private bool active = false;

    public void ChangeLaser ()
    {
        active = !active;

        if (active)
            MatchRay(true);
        else
            Destroy(myLaser);
    }

    private void FixedUpdate()
    {
        if (active)
            MatchRay(false);
    }

    private void MatchRay(bool generate)
    {
        RaycastHit2D[] hits = Physics2D.RaycastAll(transform.position, laserVector, 1000f);

        for (int i = 0; i < hits.Length; i++)
            if (hits[i].collider.CompareTag("Ground") && hits[i].collider.name!= "LaserCenter")
            {
                CreateLaser(hits[i].point, generate);
                break;
            }
    }


    private void CreateLaser (Vector3 endPos, bool generate)
    {
        float distance = Vector2.Distance(transform.position, endPos);
        Vector2 laserPosition = new ((transform.position.x+endPos.x)/2, (transform.position.y + endPos.y)/2);

        if (generate)
            myLaser = Instantiate(laserObj, laserPosition, Quaternion.identity);
        else
            myLaser.transform.position = laserPosition;

        if(laserVector.y!=0)
            myLaser.transform.localScale = new Vector3(myLaser.transform.localScale.x,distance, 1);
        else
            myLaser.transform.localScale = new Vector3(distance, myLaser.transform.localScale.y, 1);
    }
}
