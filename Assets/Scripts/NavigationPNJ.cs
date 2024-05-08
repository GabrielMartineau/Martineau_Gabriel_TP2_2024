using UnityEngine;
using UnityEngine.AI;

public class NavigationPNJ : MonoBehaviour
{
    [SerializeField]
    private Transform player;
    private NavMeshAgent agent;

    [SerializeField]
    private InfosJoueur so_infosJoueur;

    [SerializeField]
    private float distanceJoueur;

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }
    void Update()
    {
        if (Vector3.Distance(agent.transform.position, player.position) < distanceJoueur){
            agent.destination = player.position;
            GetComponent<Animator>().SetBool("Course", true);
        }

        else{
            GetComponent<Animator>().SetBool("Course", false);
        }
        
    }

private void OnTriggerEnter(Collider other) {
    Debug.Log("test");
}
    private void OnCollisionEnter(Collision other) {
        Debug.Log("allo");
        if(other.transform.CompareTag("Player")){
            so_infosJoueur.nbVie -= 1;
            Debug.Log("Perdu un point");
            GetComponent<Animator>().SetTrigger("Attaque");
        }
    }
}